using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Xml;
using System.Drawing;
using System.Security.Principal;
using System.Text;
//https://product.hubspot.com/blog/git-and-github-tutorial-for-beginners
//https://www.geeksforgeeks.org/working-on-git-for-gui/
namespace AddInManager
{    
    public partial class FormStart : Form
    {
        public const int _RVTYEAR = 2021;
        public const string _REVITALL = "<all>";
        public const string _COMP = "<computer>";
        public const string _DISABLED = ".disabled";
        public const string _REVITVERS = "Autodesk Revit {0}";
        public const string _EXEPATH = @"C:\Program Files\Autodesk\Revit {0}\Revit.exe";

        public const string _INIAPITXT = "\r\n[API]";
        public const string _INIDISABLETXT = "\r\nDisableUserAddinsAndMacros={0}";
        public const string _INIFILETXT = "\r\n[Recent File List]";

        public const string _REVITINIFILE = @"C:\Users\{0}\AppData\Roaming\Autodesk\Revit\Autodesk Revit {1}\Revit.ini";

        private IEnumerable<string> _ienupaths = new List<string>
            {
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Autodesk", "Revit", "Addins"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Autodesk", "ApplicationPlugins"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Autodesk", "Revit"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Autodesk", "ApplicationPlugins"),
            };

        private bool isStarted = false;
        public FormStart()
        {
            InitializeComponent();
            FillCboScope();
            //!!!!!!!!!!!!!
            isStarted = true;
            FillCboVersion();

            FillGridView();

            BtnAdmin.Enabled = !AuxProcs.IsAdministrator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(sender == null) { return; }
            if(!(sender is FormStart frm)) { return; }

            Point pt = Cursor.Position;
            Screen scr = Screen.FromPoint(pt);

            int ix_scr = scr.WorkingArea.Width / 2;
            int iy_scr = scr.WorkingArea.Height / 2;

            if(pt.X > scr.WorkingArea.Width)
            { ix_scr += scr.WorkingArea.Width; }
            if (pt.Y > scr.WorkingArea.Height)
            { iy_scr += scr.WorkingArea.Height; }

            int w = frm.Width / 2;
            int h = frm.Height / 2;

            frm.Location = new Point(ix_scr - w, iy_scr - h);
        }

        private void FillCboScope()
        {
            cboScope.Items.Add(_REVITALL);
            cboScope.Items.Add(_COMP);
            cboScope.Items.Add(Environment.UserName);
            cboScope.SelectedIndex = 0;
        }

        private void FillCboVersion()
        {
            CboVersion.Items.Add(_REVITALL);
            CboVersion.SelectedIndex = 0;
        }

        private void FillGridView()
        {
            DataGridViewAddIns.Rows.Clear();
            IList<string> ilstpaths = _ienupaths.ToList();

            string suser = GetComboBoxItemAsText(cboScope);
            if(!suser.Equals(_REVITALL))
            {
                if(suser.Equals(_COMP))
                { ilstpaths = ilstpaths.Where(x => !x.ToUpper().Contains(Environment.UserName.ToUpper())).ToList(); }
                else
                { ilstpaths = ilstpaths.Where(x => x.ToUpper().Contains(Environment.UserName.ToUpper())).ToList(); }
            }

            IList<string> ilstfiles = new List<string>();
            foreach (string spath in ilstpaths)
            {
                if (Directory.Exists(spath))
                {
                    try
                    {
                        string[] foo = Directory.GetFiles(spath, "*.addin", SearchOption.AllDirectories);
                        string[] foo_d = Directory.GetFiles(spath, "*.addin" + _DISABLED, SearchOption.AllDirectories);

                        foreach (string f in foo)
                        { ilstfiles.Add(f); }
                        foreach (string f in foo_d)
                        { ilstfiles.Add(f); }
                    }
                    catch { }
                }
            }

            List<string> lstversions = new List<string>();

            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("^[0-9]+$");
            foreach (string file in ilstfiles)
            {
                string[] split = file.Split('\\');
                string sversion = string.Empty;
                bool isuser = false;
                foreach (string s in split)
                {
                    if (reg.IsMatch(s)) { sversion = s; }
                    if (s.Equals(Environment.UserName, StringComparison.OrdinalIgnoreCase)) { isuser = true; }
                }

                string sname = string.Empty;
                string svendor = string.Empty;
                bool isxml = false;
                try
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.LoadXml(File.ReadAllText(file)); //xmldoc.Load(file) causes error sometimes
                    if (xmldoc != null)
                    {
                        XmlNode xmlnd = xmldoc.DocumentElement.GetElementsByTagName("Name").OfType<XmlNode>().FirstOrDefault();
                        if (xmlnd == null)
                        {
                            xmlnd = xmldoc.DocumentElement.GetElementsByTagName("Text").OfType<XmlNode>().FirstOrDefault();
                            if (xmlnd != null)
                            { sname = xmlnd.InnerText.Trim(); }
                        }
                        else
                        { sname = xmlnd.InnerText.Replace("Application", string.Empty).Trim(); isxml = true; }

                        XmlNode xmlndvendor = xmldoc.DocumentElement.GetElementsByTagName("VendorDescription").OfType<XmlNode>().FirstOrDefault();
                        if (xmlndvendor != null)
                        { svendor = xmlndvendor.InnerText.Trim(); }
                    }
                }
                catch { }

                if (!isxml)
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string thisLine = string.Empty;
                        while (thisLine != null)
                        {
                            thisLine = sr.ReadLine();
                            if (thisLine == null) { break; }

                            if (thisLine.Contains("<Name>") && thisLine.Contains("</Name>"))
                            {
                                sname = thisLine.Replace("<Name>", "").Replace("</Name>", "").Trim();
                                if (sname.StartsWith("Application", StringComparison.OrdinalIgnoreCase))
                                { sname = sname.Substring("Application".Length).Trim(); }
                                break;
                            }

                            if (thisLine.Contains("<Text>") && thisLine.Contains("</Text>"))
                            {
                                sname = thisLine.Replace("<Text>", "").Replace("</Text>", "");
                                break;
                            }
                        }
                    }
                    sname = sname.TrimStart(' ').TrimEnd(' ');
                }

                bool isenabled = !file.EndsWith(_DISABLED, StringComparison.OrdinalIgnoreCase);
                string stxt = GetComboBoxItemAsText(CboVersion);
                if (stxt.Equals(sversion) || stxt.Equals(_REVITALL))
                {
                    DataGridViewAddIns.Rows.Add(new object[] { sname, isuser, isenabled, sversion, file });

                    if (!string.IsNullOrWhiteSpace(svendor))
                    {
                        DataGridViewAddIns.Rows[DataGridViewAddIns.Rows.Count - 1].Cells["AddinName"].ToolTipText = svendor;
                    }
                }//user, enabled

                if (!lstversions.Contains(sversion) && !sversion.Equals(_REVITALL))
                { lstversions.Add(sversion); }
            }

            lstversions.Sort();
            foreach (string version in lstversions)
            {
                if (!CboVersion.Items.Contains(version))
                { CboVersion.Items.Add(version); }
            }

            Dictionary<string, SortOrder> dic = new Dictionary<string, SortOrder> { { "AddinName", SortOrder.Ascending }, { "Version", SortOrder.Ascending } };
            GridViewSort sort = new GridViewSort(dic);
            DataGridViewAddIns.Sort(sort);
            foreach(KeyValuePair<string,SortOrder> kvp in dic)
            {
                if(DataGridViewAddIns.Columns.Contains(kvp.Key))
                {
                    DataGridViewAddIns.Columns[kvp.Key].HeaderCell.SortGlyphDirection =
                        kvp.Value == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
                }
            }
                
            SetIconFromRevit(CboVersion.Text);
            SetBtnEnDisGlobal(CboVersion.Text);
        }

        private string GetComboBoxItemAsText(ComboBox cbo)
        {
            if (cbo == null || cbo.Items.Count == 0) { return string.Empty; }
            if(cbo.SelectedItem == null) { return string.Empty; }

            return cbo.SelectedItem.ToString();
        }

        private void SetIconFromRevit(string sversion)
        {
            if (!sversion.Equals(_REVITALL))
            {
                Icon ico = null;
                try
                {
                    if (AuxProcs.IsRevitVersionInstalled(Convert.ToInt32(sversion), out string srealpath))
                    {
                        ico = Icon.ExtractAssociatedIcon(srealpath);
                    }
                }
                catch { }
                if (ico == null)
                { PictureBoxRevitIco.Image = Properties.Resources.fileunknown; }
                else
                { PictureBoxRevitIco.Image = ico.ToBitmap(); }
            }
            else
            { PictureBoxRevitIco.Image = null; }
        }

        private void SetBtnEnDisGlobal(string sversion)
        {
            if (sversion.Equals(_REVITALL))
            { BtnEnDisGlobal.Enabled = true; }
            else
            {
                if (int.TryParse(sversion, out int ivers))
                { BtnEnDisGlobal.Enabled = ivers >= _RVTYEAR; }
            }
        }

        private void BtnEnDisGlobal_Click(object sender, EventArgs e)
        {
            List<int> lstvers = new List<int>();
            string stxt = GetComboBoxItemAsText(CboVersion);
            if (stxt.Equals(_REVITALL))
            {
                IEnumerable<int> ienu = CboVersion.Items.OfType<string>().Where(x => !x.Equals(_REVITALL)).Select(x => Convert.ToInt32(x))
                    .Where( x => x >= _RVTYEAR);

                lstvers.AddRange(ienu);
            }
            else
            {
                if(int.TryParse(stxt, out int ivers))
                {
                    if (ivers >= 2023)
                    { lstvers.Add(ivers); }
                }
            }

            if (lstvers.Count > 0)
            {
                Dictionary<object, object> dic = new Dictionary<object, object> { { 1, "Disable" }, { 0, "Enable" } };
                using(ComboForm cbofrm = new ComboForm { SourceDictionary = dic, Text = "Completely enable/disable add-ins in this version"})
                {
                    if (cbofrm.ShowDialog(this) == DialogResult.OK)
                    {
                        string skey = dic.ToList()[cbofrm.SelectedIndex].Key.ToString();
                        string stext = string.Format(_INIDISABLETXT, skey);
                        foreach (int ivers in lstvers)
                        {
                            bool isrevitopen = AuxProcs.IsRevitOpen(ivers.ToString());
                            if (isrevitopen)
                            {
                                MessageBox.Show($"Revit {ivers} is open.{Environment.NewLine} No changes possible"
                                , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                string spath = string.Format(_REVITINIFILE, Environment.UserName, ivers);
                                if (File.Exists(spath))
                                {
                                    Encoding enc = AuxProcs.GetEncoding(spath);
                                    string scontent = File.ReadAllText(spath);
                                    if (scontent.Contains(_INIAPITXT))
                                    {
                                        List<string> lstlines = scontent.Split(new string[] { Environment.NewLine }
                                            , StringSplitOptions.RemoveEmptyEntries).ToList();

                                        int iindex = lstlines.IndexOf(_INIAPITXT.Replace(Environment.NewLine, string.Empty));
                                        if (iindex > -1 && lstlines.Count > iindex + 1)
                                        {
                                            lstlines[iindex + 1] = stext.Replace(Environment.NewLine, string.Empty);
                                            scontent = string.Join(Environment.NewLine, lstlines);
                                        }
                                    }
                                    else
                                    {
                                        scontent = scontent.Replace(_INIFILETXT, _INIAPITXT + stext + _INIFILETXT);
                                    }

                                    File.WriteAllText(spath, scontent, enc);
                                    System.Threading.Thread.Sleep(500);
                                }
                                else
                                {
                                    MessageBox.Show($"Cannot find {spath}"
                                    , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($"Version {stxt} cannot be set globally"
                , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEnDis_Click(object sender, EventArgs e)
        {
            string readonlyfiles = "";
            foreach (DataGridViewRow row in DataGridViewAddIns.SelectedRows)
            {
                string filename = row.Cells["AddinPath"].Value.ToString();
                string version = row.Cells["Version"].Value.ToString();

                bool isrevitopen = AuxProcs.IsRevitOpen(version);

                if (isrevitopen)
                {
                    readonlyfiles += filename + $" (Revit {version} is open)" + Environment.NewLine;
                }
                else
                {
                    if (File.Exists(filename))
                    {
                        FileInfo fi = new FileInfo(filename);
                        if (fi.IsReadOnly)
                        {
                            readonlyfiles += filename + " (is readonly)" + Environment.NewLine;
                        }
                        else
                        {
                            try
                            {
                                if (filename.EndsWith(_DISABLED))
                                {
                                    string nodis = filename.Replace(_DISABLED, "");
                                    File.Copy(filename, nodis);
                                    File.Delete(filename);
                                }
                                else
                                {
                                    File.Copy(filename, filename + _DISABLED);
                                    File.Delete(filename);
                                }
                            }
                            catch
                            {
                                readonlyfiles += $"{filename} (general error){Environment.NewLine}";
                            }
                        }
                    }
                    else
                    { readonlyfiles += $"{filename} (not found){Environment.NewLine}"; }
                }
            }

            if (readonlyfiles != "")
            {
                MessageBox.Show($"Cannot rename following files.{Environment.NewLine}{readonlyfiles}"
                    , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FillGridView();
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewAddIns.Rows)
            { row.Selected = true; }
        }

        private void BtnInvert_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewAddIns.Rows)
            { row.Selected = !row.Selected; }
        }

        private void BtnSelEnabled_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewAddIns.Rows)
            {
                if (bool.TryParse(row.Cells["IsEnabled"].Value.ToString(), out bool b))
                { row.Selected = b; }
                else
                { row.Selected = false; }
            }
        }

        private void BtnSelDis_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewAddIns.Rows)
            {
                if (bool.TryParse(row.Cells["IsEnabled"].Value.ToString(), out bool b))
                { row.Selected = !b; }
                else
                { row.Selected = true; }
            }
        }

        private void Cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isStarted)
            { FillGridView(); }
        }

        private void Cbo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e == null) { return; }
            if(sender == null) { return; }
            if(!(sender is ComboBox cbo)) { return; }
            if (e.Button != MouseButtons.Right)
            {
                if (e.Location.X < cbo.Width - SystemInformation.VerticalScrollBarWidth)
                { cbo.Cursor = Cursors.Default; }
                else
                { cbo.Cursor = Cursors.Hand; }
            }
        }

        private void ButtonRevitVersions_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 2015; i < 2029; i++)
            {
                if(AuxProcs.IsRevitVersionInstalled(i, out string spath))
                { sb.AppendLine(spath); }
            }

            if(sb.Length > 0)
            {
                MessageBox.Show($"Found:{Environment.NewLine}{sb}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Revit (full version) found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            if (!AuxProcs.IsAdministrator())
            { AuxProcs.RestartAs(); }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            using (FormAbout form = new FormAbout())
            { form.ShowDialog(this); }
        }

        private void DataGridViewAddIns_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sender == null) { return; }
            if (!(sender is DataGridView dgv)) { return; }
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    dgv.CurrentCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
            }
        }

        private void DataGridViewAddIns_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sender == null) { return; }
            if (!(sender is DataGridView dgv)) { return; }
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    if (dgv.SelectedRows.OfType<DataGridViewRow>().Select(x => x.Index).Contains(e.RowIndex))
                    {
                        ContextMenuStripDGV.Show(Cursor.Position);
                    }
                }
            }
        }

        private void DataGridViewAddIns_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e == null) { return; }
            if (sender == null) { return; }
            if (!(sender is DataGridView dgv)) { return; }

            SortOrder sort = dgv.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;
            dgv.Columns.OfType<DataGridViewColumn>().ToList().ForEach(x =>
            {
                if (x.HeaderCell.SortGlyphDirection != SortOrder.None)
                { x.HeaderCell.SortGlyphDirection = SortOrder.None; }
            });

            Dictionary<string, SortOrder> dic = new Dictionary<string, SortOrder>
            { { dgv.Columns[e.ColumnIndex].Name
                , sort == SortOrder.None || sort == SortOrder.Descending ? SortOrder.Ascending : SortOrder.Descending }};
            GridViewSort gvsort = new GridViewSort(dic);
            DataGridViewAddIns.Sort(gvsort);
            switch (sort)
            {
                case SortOrder.None:
                case SortOrder.Ascending:
                    dgv.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                    break;
                case SortOrder.Descending:
                    dgv.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                    break;
            }
        }

        private void ToolStripMenuItemEnabledInRevit_Click(object sender, EventArgs e)
        {
            if (sender == null) { return; }
            if (!(sender is ToolStripMenuItem mitm)) { return; }
            if (!(mitm.GetCurrentParent() is ContextMenuStrip cstrip)) { return; }

            Point pt = DataGridViewAddIns.PointToClient(new Point(cstrip.Left, cstrip.Top));
            DataGridView.HitTestInfo hifo = DataGridViewAddIns.HitTest(pt.X, pt.Y);
            if (hifo.RowIndex > -1)
            {
                object opath = DataGridViewAddIns.Rows[hifo.RowIndex].Cells["AddInPath"].Value;
                string spath = (opath ?? opath.ToString()) as string;

                if (File.Exists(spath))
                {
                    string scontent = File.ReadAllText(spath);
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.LoadXml(scontent);

                    string sxmltxt = string.Empty;
                    try
                    {
                        sxmltxt = xmldoc.GetElementsByTagName("AddInId").OfType<XmlNode>().First().InnerText.ToUpper();
                    }
                    catch { }

                    if(string.IsNullOrWhiteSpace(sxmltxt))
                    {
                        try
                        {
                            sxmltxt = xmldoc.GetElementsByTagName("ClientId").OfType<XmlNode>().First().InnerText.ToUpper();
                        }
                        catch { }
                    }

                    object oversion = DataGridViewAddIns.Rows[hifo.RowIndex].Cells["Version"].Value;
                    string sversion = (oversion ?? oversion.ToString()) as string;
                    Dictionary<string, bool> dic_addins = AuxProcs.GetAddInStateFromRegistry(string.Format(_REVITVERS, sversion));
                    if(dic_addins.ContainsKey(sxmltxt))
                    {
                        string saddin = DataGridViewAddIns.Rows[hifo.RowIndex].Cells["AddinName"].Value.ToString();
                        using(FormEnable frm = new FormEnable { AddInName = saddin, GUIDText = sxmltxt})
                        {
                            if(frm.ShowDialog(this) == DialogResult.OK)
                            {
                                if (frm.PromptLoad)
                                { AuxProcs.RemoveRegistryValue(string.Format(_REVITVERS, sversion), sxmltxt); }
                                //SetRegistryValue(string.Format(_REVITVERS, sversion), sxmltxt, frm.PromptLoad);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Add-In is not listed as \"Prompt on Start\" within Revit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ToolStripMenuItemShowContent_Click(object sender, EventArgs e)
        {
            if (sender == null) { return; }
            if (!(sender is ToolStripMenuItem mitm)) { return; }
            if (!(mitm.GetCurrentParent() is ContextMenuStrip cstrip)) { return; }

            Point pt = DataGridViewAddIns.PointToClient(new Point(cstrip.Left, cstrip.Top));
            DataGridView.HitTestInfo hifo = DataGridViewAddIns.HitTest(pt.X, pt.Y);
            if (hifo.RowIndex > -1)
            {
                object opath = DataGridViewAddIns.Rows[hifo.RowIndex].Cells["AddInPath"].Value;
                string spath = (string)(opath ?? opath.ToString());

                if (File.Exists(spath))
                {
                    string scontent = File.ReadAllText(spath);

                    AddInForm adfrm = new AddInForm
                    {
                        AddInContent = scontent,
                        AddInPath = spath,
                        Top = this.Top,
                        Left = this.Left,
                        Width = this.Width,
                        Height = this.Height
                    };
                    adfrm.Show(this);
                }
                else
                {
                    MessageBox.Show($"Cannot find {spath}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ToolStripMenuItemUninstall_Click(object sender, EventArgs e)
        {
            if (sender == null) { return; }
            if (!(sender is ToolStripMenuItem mitm)) { return; }
            if (!(mitm.GetCurrentParent() is ContextMenuStrip cstrip)) { return; }

            Point pt = DataGridViewAddIns.PointToClient(new Point(cstrip.Left, cstrip.Top));
            DataGridView.HitTestInfo hifo = DataGridViewAddIns.HitTest(pt.X, pt.Y);
            if (hifo.RowIndex > -1)
            {
                object opath = DataGridViewAddIns.Rows[hifo.RowIndex].Cells["AddInPath"].Value;
                string spath = (string)(opath ?? opath.ToString());
                if (File.Exists(spath))
                {
                    string scontent = File.ReadAllText(spath);
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.LoadXml(scontent); //this way to prevent load xml from file error

                    string sxmltpath = string.Empty;
                    try
                    {
                        sxmltpath = xmldoc.GetElementsByTagName("Assembly").OfType<XmlNode>().First().InnerText.ToUpper();
                        sxmltpath = sxmltpath.Replace("\"", string.Empty).Replace("'", string.Empty);
                    }
                    catch { }

                    if (!Path.IsPathRooted(sxmltpath))
                    {
                        if (sxmltpath.StartsWith(".. /") || sxmltpath.StartsWith(@".\"))
                        {
                            if (sxmltpath.StartsWith(".. /"))
                            {
                                int ict = System.Text.RegularExpressions.Regex.Matches(sxmltpath, ".. /").Count;
                                if (ict > 0)
                                {
                                    while (sxmltpath.StartsWith(@"\"))
                                    {
                                        sxmltpath = sxmltpath.Substring(1); // @"\ " should be deleted
                                    }
                                    spath = string.Join(@"\", spath.Split('\\').Reverse().Skip(ict + 1).Reverse()); // +1 == file.addin
                                }
                            }
                            else
                            {
                                sxmltpath = sxmltpath.Replace(@".\", string.Empty);
                                spath = Path.GetDirectoryName(spath);
                            }
                            //string sdots = string.Empty;
                            //for (int i = 0; i < sxmltpath.Length; i++)
                            //{
                            //    if (!sxmltpath[i].Equals('.'))
                            //    {
                            //        sdots = new string('.', i);
                            //        break;
                            //    }
                            //}
                            //if (!string.IsNullOrWhiteSpace(sdots))
                            //{
                            //    sxmltpath = sxmltpath.Substring(sdots.Length).Trim();
                            //    while (sxmltpath.StartsWith(@"\"))
                            //    {
                            //        sxmltpath = sxmltpath.Substring(1); // @"\ " should be deleted
                            //    }
                            //    int iup = sdots.Length / 2;
                            //    spath = string.Join(@"\", spath.Split('\\').Reverse().Skip(iup + 1).Reverse()); // +1 == file.addin
                            //}
                            sxmltpath = Path.Combine(spath, sxmltpath).Replace("/", @"\");
                        }
                        else
                        { sxmltpath = Path.Combine(Path.GetDirectoryName(spath), sxmltpath).Replace("/", @"\"); }
                    }
 
                    if(File.Exists(sxmltpath))
                    {
                        Dictionary<string, string> dic = AuxProcs.FindInRegistry(sxmltpath);
                        if (dic.Count == 0)
                        {
                            System.Diagnostics.Process proc = new System.Diagnostics.Process();
                            proc.StartInfo.Verb = "runas";
                            proc.StartInfo.FileName = "appwiz.cpl";
                            proc.Start();
                            proc.WaitForExit();
                        }
                        else
                        {
                            string sexec = string.Empty;
                            if (dic.Count == 1)
                            { sexec = dic.AsEnumerable().First().Value; }
                            else
                            {
                                bool isok = false;
                                using (ComboForm cbfrm = new ComboForm
                                {
                                    SourceDictionary = dic.ToDictionary(x => x.Key as object, y => y.Key as object)
                                        , Text = "Choose Version"
                                })
                                {
                                    if (cbfrm.ShowDialog(this) == DialogResult.OK)
                                    { sexec = dic.ToList()[cbfrm.SelectedIndex].Value; isok = true; }
                                }

                                if (!isok) { return; }
                            }

                            if(sexec.ToUpper().Contains("MSIEXEC"))
                            {
                                string sarg = $"-Command \"Start-Process cmd -Verb RunAs -ArgumentList {{/c {sexec}}}\""; //msiexec
                                System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo
                                {
                                    Verb = "runas",
                                    FileName = "powershell.exe",
                                    Arguments = sarg,
                                    RedirectStandardOutput = false,
                                    UseShellExecute = true,
                                    CreateNoWindow = true
                                };

                                System.Diagnostics.Process proccmd = System.Diagnostics.Process.Start(processInfo);
                                proccmd.WaitForExit();
                            }
                            else
                            {
                                MessageBox.Show("Uninstal parameter not found"
                                    , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        //System.Reflection.Assembly ass = null;
                        //try
                        //{ ass = System.Reflection.Assembly.LoadFile(sxmltpath); }
                        //catch { }
                        //if (ass != null)
                        //{
                        //string sguid = ass.GetType().GUID.ToString("B");
                        //System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo
                        //{
                        //    Verb = "runas",
                        //    FileName = "powershell.exe",
                        //    Arguments = $"-Command \"Start-Process cmd -Verb RunAs -ArgumentList {{/c msiexec.exe /x {sguid}}}\"",
                        //    RedirectStandardOutput = false,
                        //    UseShellExecute = true,
                        //    CreateNoWindow = true
                        //};
                    }
                    else
                    {
                        MessageBox.Show($"Cannot find {sxmltpath}.{Environment.NewLine} Delete manually, please"
                            , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ToolStripMenuItemGoToFolder_Click(object sender, EventArgs e)
        {
            if (sender == null) { return; }
            if (!(sender is ToolStripMenuItem mitm)) { return; }
            if (!(mitm.GetCurrentParent() is ContextMenuStrip cstrip)) { return; }

            Point pt = DataGridViewAddIns.PointToClient(new Point(cstrip.Left, cstrip.Top));
            DataGridView.HitTestInfo hifo = DataGridViewAddIns.HitTest(pt.X, pt.Y);
            if (hifo.RowIndex > -1)
            {
                object opath = DataGridViewAddIns.Rows[hifo.RowIndex].Cells["AddInPath"].Value;
                string spath = (string)(opath ?? opath.ToString());

                if (File.Exists(spath))
                {
                    string cmd = "explorer.exe";
                    string arg = "/select, " + spath;
                    System.Diagnostics.Process.Start(cmd, arg);
                }
            }
        }

    }
}
