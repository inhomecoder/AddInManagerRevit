
namespace AddInManager
{
    partial class FormEnable
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
            this.TableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.CheckBoxEnabled = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanelMain
            // 
            this.TableLayoutPanelMain.ColumnCount = 2;
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelMain.Controls.Add(this.ButtonApply, 0, 2);
            this.TableLayoutPanelMain.Controls.Add(this.ButtonCancel, 1, 2);
            this.TableLayoutPanelMain.Controls.Add(this.CheckBoxEnabled, 0, 0);
            this.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            this.TableLayoutPanelMain.RowCount = 3;
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.TableLayoutPanelMain.Size = new System.Drawing.Size(450, 165);
            this.TableLayoutPanelMain.TabIndex = 0;
            // 
            // ButtonApply
            // 
            this.ButtonApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonApply.Location = new System.Drawing.Point(8, 63);
            this.ButtonApply.Margin = new System.Windows.Forms.Padding(8);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(209, 94);
            this.ButtonApply.TabIndex = 1;
            this.ButtonApply.Text = "&Apply";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCancel.Location = new System.Drawing.Point(233, 63);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(8);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(209, 94);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "&Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // CheckBoxEnabled
            // 
            this.CheckBoxEnabled.AutoSize = true;
            this.CheckBoxEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TableLayoutPanelMain.SetColumnSpan(this.CheckBoxEnabled, 2);
            this.CheckBoxEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxEnabled.Location = new System.Drawing.Point(3, 3);
            this.CheckBoxEnabled.Name = "CheckBoxEnabled";
            this.CheckBoxEnabled.Size = new System.Drawing.Size(444, 44);
            this.CheckBoxEnabled.TabIndex = 2;
            this.CheckBoxEnabled.Text = "Add-In";
            this.CheckBoxEnabled.UseVisualStyleBackColor = true;
            this.CheckBoxEnabled.CheckedChanged += new System.EventHandler(this.CheckBoxEnabled_CheckedChanged);
            // 
            // FormEnable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(450, 165);
            this.ControlBox = false;
            this.Controls.Add(this.TableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEnable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Do Nothing";
            this.Load += new System.EventHandler(this.FormEnable_Load);
            this.TableLayoutPanelMain.ResumeLayout(false);
            this.TableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMain;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.CheckBox CheckBoxEnabled;
    }
}