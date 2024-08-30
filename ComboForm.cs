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
    public partial class ComboForm : Form
    {
        public ComboForm()
        {
            InitializeComponent();
        }

        private bool isStarted = false;

        Dictionary<object, object> _dicsrc = new Dictionary<object, object>();
        public Dictionary<object, object> SourceDictionary
        {
            get { return _dicsrc; }
            set  { _dicsrc = value; }
        }

        private int _iselindex = 0;
        public int SelectedIndex
        { 
            get { return _iselindex; }
            set { _iselindex = value; }
        }

        private void ComboForm_Load(object sender, EventArgs e)
        {
            int iwidth = GetMaxComboItemLength();
            int iwidth_def = ComboBoxValues.Width;

            this.Width += iwidth - iwidth_def;

            FillComboBoxValues();
            isStarted = true;
        }

        private int GetMaxComboItemLength()
        {
            int iwdth_cbo = ComboBoxValues.Width;
            if (_dicsrc == null) { return iwdth_cbo; }
            if (_dicsrc.Count == 0) { return iwdth_cbo; }

            Graphics gr = ComboBoxValues.CreateGraphics();
            string smax = string.Empty;
            try
            {
                _dicsrc.ToList().ForEach(x =>
                {
                    int iwdth_tmp = Convert.ToInt32(gr.MeasureString(x.Value.ToString(), ComboBoxValues.Font).Width);
                    iwdth_cbo = iwdth_cbo < iwdth_tmp ? iwdth_tmp : iwdth_cbo;
                });
            }
            catch { }

            if (iwdth_cbo > 900)
            { iwdth_cbo = 900; }

            return iwdth_cbo;
        }

        private void FillComboBoxValues()
        {
            ComboBoxValues.DataSource = new BindingSource(_dicsrc, null);
            ComboBoxValues.ValueMember = "Key";
            ComboBoxValues.DisplayMember = "Value";
            ComboBoxValues.SelectedIndex = _iselindex;
        }

        private void ComboBoxValues_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender == null) { return; }
            if(!(sender is ComboBox cbx)) { return; }
            if(isStarted)
            { _iselindex = cbx.SelectedIndex; }
        }

        private void ComboBoxValues_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e == null) { return; }
            if (sender == null) { return; }
            if (!(sender is ComboBox cbx)) { return; }
            if (cbx != null)
            {
                e.DrawBackground();

                if (e.Index > -1)
                {
                    StringFormat sf = new StringFormat
                    { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };

                    // Set the Brush to ComboBox ForeColor to maintain any ComboBox color settings, assumes Brush is solid
                    Brush brush = new SolidBrush(cbx.ForeColor);
                    // If drawing highlighted selection, change brush
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    { brush = SystemBrushes.HighlightText; }

                    e.Graphics.DrawString(((KeyValuePair<object,object>)cbx.Items[e.Index]).Value.ToString(), cbx.Font, brush, e.Bounds, sf);
                }
            }
        }
    }
}
