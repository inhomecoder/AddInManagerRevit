namespace AddInManager
{
    partial class ComboForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ComboBoxValues = new System.Windows.Forms.ComboBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ToolTipFrm = new System.Windows.Forms.ToolTip(this.components);
            this.TableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanelMain
            // 
            this.TableLayoutPanelMain.ColumnCount = 4;
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelMain.Controls.Add(this.ButtonOK, 1, 1);
            this.TableLayoutPanelMain.Controls.Add(this.ComboBoxValues, 0, 0);
            this.TableLayoutPanelMain.Controls.Add(this.ButtonCancel, 2, 1);
            this.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            this.TableLayoutPanelMain.RowCount = 2;
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelMain.Size = new System.Drawing.Size(416, 86);
            this.TableLayoutPanelMain.TabIndex = 0;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonOK.Location = new System.Drawing.Point(118, 54);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(10, 3, 10, 6);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(80, 26);
            this.ButtonOK.TabIndex = 0;
            this.ButtonOK.Text = "OK";
            this.ToolTipFrm.SetToolTip(this.ButtonOK, "OK");
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // ComboBoxValues
            // 
            this.ComboBoxValues.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxValues.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TableLayoutPanelMain.SetColumnSpan(this.ComboBoxValues, 4);
            this.ComboBoxValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxValues.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxValues.FormattingEnabled = true;
            this.ComboBoxValues.Location = new System.Drawing.Point(3, 3);
            this.ComboBoxValues.Name = "ComboBoxValues";
            this.ComboBoxValues.Size = new System.Drawing.Size(410, 39);
            this.ComboBoxValues.TabIndex = 1;
            this.ComboBoxValues.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxValues_DrawItem);
            this.ComboBoxValues.SelectedValueChanged += new System.EventHandler(this.ComboBoxValues_SelectedValueChanged);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCancel.Location = new System.Drawing.Point(218, 54);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 6);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(80, 26);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "&Cancel";
            this.ToolTipFrm.SetToolTip(this.ButtonCancel, "Cancel");
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ComboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 86);
            this.ControlBox = false;
            this.Controls.Add(this.TableLayoutPanelMain);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComboForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Version";
            this.Load += new System.EventHandler(this.ComboForm_Load);
            this.TableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMain;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.ComboBox ComboBoxValues;
        private System.Windows.Forms.ToolTip ToolTipFrm;
        private System.Windows.Forms.Button ButtonCancel;
    }
}