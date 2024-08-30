using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddInManager
{
    public static class AuxProcs
    {
        private const string _sEXEPATH = @"C:\Program Files\Autodesk\Revit {0}\Revit.exe";
        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static bool IsRevitOpen(string srvtversion)
        {
            if (string.IsNullOrWhiteSpace(srvtversion)) { return false; }

            System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcesses()
                .Where(x => x.ProcessName.ToUpper().Contains("REVIT")).ToArray();
            foreach (System.Diagnostics.Process proc in procs)
            {
                string sttl = proc.MainWindowTitle;
                if (sttl.ToUpper().Contains($"AUTODESK REVIT {srvtversion}")) { return true; }
            }

            return false;
        }

        public static bool IsRevitVersionInstalled(int irvtversion, out string srealpath)
        {
            srealpath = string.Empty;
            IEnumerable<string> ienudrives = DriveInfo.GetDrives().Where(x => x.DriveType == DriveType.Fixed).Select(x => x.Name);
            string spath = string.Format(_sEXEPATH, irvtversion);
            string sdrive = Path.GetPathRoot(spath);
            foreach(string sdrivetmp in ienudrives)
            {
                string spathtmp = spath.Replace(sdrive, sdrivetmp);
                if (File.Exists(spathtmp)) { srealpath = spathtmp; return true; }
            }
            return false;
        }

        public static Encoding GetEncoding(string sfilename)
        {
            byte[] bom = new byte[4];
            using (FileStream file = new FileStream(sfilename, FileMode.Open, FileAccess.Read))
            { file.Read(bom, 0, 4); }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) { return Encoding.UTF7; }
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) { return Encoding.UTF8; }
            if (bom[0] == 0xff && bom[1] == 0xfe && bom[2] == 0 && bom[3] == 0) { return Encoding.UTF32; }//UTF-32LE
            if (bom[0] == 0xff && bom[1] == 0xfe) { return Encoding.Unicode; } //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) { return Encoding.BigEndianUnicode; } //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) { return new UTF32Encoding(true, true); } //UTF-32BE

            return Encoding.ASCII;
        }

        public static void RestartAs()
        {
            string sexeName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(sexeName)
            { Verb = "runas", Arguments = "restart" };
            System.Diagnostics.Process.Start(startInfo);
            Application.Exit();
        }

        #region REGYSTRY
        public static Dictionary<string, string> FindInRegistry(string sxmlpath)
        {
            string sdirpath = Path.GetDirectoryName(sxmlpath);
            string sfile = Path.GetFileNameWithoutExtension(sxmlpath);
            string sfield = string.Empty;
            if (sdirpath.ToUpper().Contains(@"ADDINS\DH")) { sfield = "Readme"; }
            else { sfield = "InstallLocation"; }
            sdirpath = sdirpath.ToUpper();
            List<string> lstdefpaths = new List<string>
            {
                @"Software\Microsoft\Windows\CurrentVersion\Uninstall",
                @"Software\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\"
            };

            Dictionary<string, string> dic = new Dictionary<string, string>();
            try
            {
                foreach (string sdefpath in lstdefpaths)
                {
                    using (Microsoft.Win32.RegistryKey rootKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(sdefpath))
                    {
                        string[] subSubKeyNames = rootKey.GetSubKeyNames();
                        foreach (string currSubKey in subSubKeyNames)
                        {
                            string sval, suninst, svers, sfieldcontent;
                            sval = suninst = svers = sfieldcontent = string.Empty;
                            Microsoft.Win32.RegistryKey subSubKey = rootKey.OpenSubKey(currSubKey);
                            object o = subSubKey.GetValue(sfield);
                            if (o == null)
                            { o = subSubKey.GetValue("UninstallPath"); }
                            sfieldcontent = o == null ? string.Empty : o.ToString();
                            object o1 = subSubKey.GetValue("DisplayName");
                            sval = o1 == null ? string.Empty : o1.ToString();

                            if (sfieldcontent.ToUpper().Contains(sdirpath) || sval.Equals(sfile, StringComparison.OrdinalIgnoreCase))
                            {
                                object o2 = subSubKey.GetValue("UninstallString");
                                object o3 = subSubKey.GetValue("DisplayVersion");
                                if (o2 != null && o3 != null)
                                {
                                    suninst = o2.ToString();
                                    if (!suninst.ToUpper().Contains("MSIEXEC.EXE") && suninst.Contains("{") && suninst.Contains("}"))
                                    {
                                        string stmp = suninst.Substring(0, suninst.IndexOf("}") + 1);
                                        stmp = stmp.Substring(stmp.IndexOf("{"));
                                        suninst = $"msiexec.exe /i{stmp}";
                                    }

                                    svers = o3.ToString();
                                    if (!dic.ContainsKey($"{sval} {svers}"))
                                    { dic.Add($"{sval} {svers}", suninst.Trim()); }
                                }
                            }
                        }
                    }
                }
            }
            catch { }

            return dic;
        }

        public static Dictionary<string, bool> GetAddInStateFromRegistry(string srvtversion)
        {
            Dictionary<string, bool> dic = new Dictionary<string, bool>();
            string sdef = @"Software\Autodesk\Revit\{0}\CodeSigning";
            string sdefpath = string.Format(sdef, srvtversion);
            try
            {
                using (Microsoft.Win32.RegistryKey rootKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(sdefpath))
                {
                    string[] valueNames = rootKey.GetValueNames();
                    foreach (string currSubKey in valueNames)
                    {
                        string svalue = rootKey.GetValue(currSubKey).ToString();
                        if (int.TryParse(svalue, out int i))
                        {
                            string skey = currSubKey.ToUpper();
                            if (!dic.ContainsKey(skey))
                            { dic.Add(skey, Convert.ToBoolean(i)); }
                        }
                    }
                }
            }
            catch { }

            return dic;
        }

        public static void SetRegistryValue(string srvtversion, string skey, bool isvalue)
        {
            string sdef = @"Software\Autodesk\Revit\{0}\CodeSigning";
            string sdefpath = string.Format(sdef, srvtversion);
            try
            {
                using (Microsoft.Win32.RegistryKey rootKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(sdefpath, true))
                {
                    string[] valueNames = rootKey.GetValueNames();
                    foreach (string currSubKey in valueNames)
                    {
                        if (currSubKey.Equals(skey, StringComparison.OrdinalIgnoreCase))
                        {
                            rootKey.SetValue(currSubKey, isvalue ? 1 : 0);
                            break;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Cannot change Registry. Error: {exc.Message}.{Environment.NewLine}Please, consult Your administrator: ID {skey}."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RemoveRegistryValue(string srvtversion, string skey)
        {
            string sdef = @"Software\Autodesk\Revit\{0}\CodeSigning";
            string sdefpath = string.Format(sdef, srvtversion);
            try
            {
                using (Microsoft.Win32.RegistryKey rootKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(sdefpath, true))
                {
                    string[] valueNames = rootKey.GetValueNames();
                    foreach (string currSubKey in valueNames)
                    {
                        if (currSubKey.Equals(skey, StringComparison.OrdinalIgnoreCase))
                        {
                            rootKey.DeleteValue(currSubKey);
                            break;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Cannot change Registry. Error: {exc.Message}.{Environment.NewLine}Please, consult Your administrator: ID {skey}."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }

    public class GridViewSort : System.Collections.IComparer
    {
        private IDictionary<string, SortOrder> _dic = null;
        public GridViewSort(IDictionary<string, SortOrder> diccols )
        {
            _dic = diccols;
        }

        public int Compare(object x, object y)
        {
            if(_dic == null || _dic.Count == 0) { return 0; }
            if (!(x is DataGridViewRow row_x)) { return 0; }
            if (!(y is DataGridViewRow row_y)) { return 0; }

            foreach (KeyValuePair<string, SortOrder> kvp in _dic)
            {
                if (!row_x.DataGridView.Columns.Contains(kvp.Key)) { return 0; }

                int icomp = row_x.Cells[kvp.Key].Value.ToString().CompareTo(row_y.Cells[kvp.Key].Value.ToString());
                if(icomp != 0) { return icomp * (kvp.Value == SortOrder.Ascending ? 1 : -1); }
            }

            return 0;
        }
    }
}
