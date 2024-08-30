using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddInManager
{
    public partial class FormEnable : Form
    {
        public FormEnable()
        {
            InitializeComponent();
        }

        public string AddInName 
        {
            get { return CheckBoxEnabled.Text; }
            set { CheckBoxEnabled.Text = value; }
        }

        private string _sguid = string.Empty;
        public string GUIDText { get => _sguid; set => _sguid = value; }

        public bool PromptLoad
        {
            get => CheckBoxEnabled.Checked;
            //set => CheckBoxEnabled.Checked = value;
        }

        private void SetTitle()
        {
            Text = CheckBoxEnabled.Checked ? "Prompt Again" : "Do Nothing";
        }

        private FormStart frmparent = null;

        private void FormEnable_Load(object sender, EventArgs e)
        {
            frmparent = this.Owner as FormStart;
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CheckBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            SetTitle();
        }
    }
}
