using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AddInManager
{
    public partial class AddInForm : Form
    {
        public AddInForm()
        {
            InitializeComponent();
        }

        private string _scontent = string.Empty;
        public string AddInContent { get => _scontent; set => _scontent = value; }

        private string _spath = string.Empty;
        public string AddInPath { get => _spath; set => _spath = value; }

        private void AddInForm_Load(object sender, EventArgs e)
        {
            Text += " " + _spath;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(_scontent);
            StringBuilder sb = new StringBuilder();
            using (System.IO.StringWriter swr = new System.IO.StringWriter(sb))
            {
                using (XmlTextWriter writer = new XmlTextWriter(new System.IO.StringWriter(sb)))
                {
                    writer.Formatting = Formatting.Indented;
                    doc.Save(writer);

                    TextBoxContent.Text = swr.ToString();
                }
            }

            if (doc != null)
            {
                XmlNodeList xnList = doc.SelectNodes("/RevitAddIns/AddIn/Assembly");
                if(xnList.Count > 0)
                {
                    string sasspath = xnList.OfType<XmlNode>().First().InnerText.Trim();

                    if (sasspath.StartsWith("\"")) { sasspath = sasspath.Substring(1); }
                    if (sasspath.EndsWith("\"")) { sasspath = sasspath.Substring(0, sasspath.Length - 2); }
                    sasspath = sasspath.Trim();

                    if (!System.IO.Path.IsPathRooted(sasspath))
                    {
                        if (sasspath.StartsWith(".")) { sasspath.TrimStart(new char[] { '.' }).Trim(); }
                        sasspath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(_spath), sasspath);
                    }

                    if (sasspath.Contains("/")) { sasspath = sasspath.Replace("/", "\\"); }

                    if (System.IO.File.Exists(sasspath))
                    {
                        string sfolderpath = System.IO.Path.GetDirectoryName(sasspath);
                        string[] arrfiles = System.IO.Directory.GetFiles(sfolderpath, "*.*", System.IO.SearchOption.AllDirectories);
                        ListBoxFiles.Items.AddRange(arrfiles); 
                    }
                    else
                    { ListBoxFiles.Items.Add("NOTHING FOUND"); }
                }
            }
        }
    }
}
