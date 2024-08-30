
namespace AddInManager
{
    partial class AddInForm
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
            this.TextBoxContent = new System.Windows.Forms.TextBox();
            this.TabControlAddIn = new System.Windows.Forms.TabControl();
            this.TabPageContent = new System.Windows.Forms.TabPage();
            this.TabPageFiles = new System.Windows.Forms.TabPage();
            this.ListBoxFiles = new System.Windows.Forms.ListBox();
            this.TabControlAddIn.SuspendLayout();
            this.TabPageContent.SuspendLayout();
            this.TabPageFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxContent
            // 
            this.TextBoxContent.AcceptsReturn = true;
            this.TextBoxContent.AcceptsTab = true;
            this.TextBoxContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxContent.Location = new System.Drawing.Point(3, 3);
            this.TextBoxContent.Multiline = true;
            this.TextBoxContent.Name = "TextBoxContent";
            this.TextBoxContent.ReadOnly = true;
            this.TextBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxContent.Size = new System.Drawing.Size(786, 411);
            this.TextBoxContent.TabIndex = 0;
            // 
            // TabControlAddIn
            // 
            this.TabControlAddIn.Controls.Add(this.TabPageContent);
            this.TabControlAddIn.Controls.Add(this.TabPageFiles);
            this.TabControlAddIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlAddIn.Location = new System.Drawing.Point(0, 0);
            this.TabControlAddIn.Margin = new System.Windows.Forms.Padding(0);
            this.TabControlAddIn.Name = "TabControlAddIn";
            this.TabControlAddIn.SelectedIndex = 0;
            this.TabControlAddIn.Size = new System.Drawing.Size(800, 450);
            this.TabControlAddIn.TabIndex = 1;
            // 
            // TabPageContent
            // 
            this.TabPageContent.Controls.Add(this.TextBoxContent);
            this.TabPageContent.Location = new System.Drawing.Point(4, 29);
            this.TabPageContent.Name = "TabPageContent";
            this.TabPageContent.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageContent.Size = new System.Drawing.Size(792, 417);
            this.TabPageContent.TabIndex = 0;
            this.TabPageContent.Text = "Add-In Content";
            this.TabPageContent.UseVisualStyleBackColor = true;
            // 
            // TabPageFiles
            // 
            this.TabPageFiles.Controls.Add(this.ListBoxFiles);
            this.TabPageFiles.Location = new System.Drawing.Point(4, 29);
            this.TabPageFiles.Name = "TabPageFiles";
            this.TabPageFiles.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageFiles.Size = new System.Drawing.Size(792, 417);
            this.TabPageFiles.TabIndex = 1;
            this.TabPageFiles.Text = "Add-In Files";
            this.TabPageFiles.UseVisualStyleBackColor = true;
            // 
            // ListBoxFiles
            // 
            this.ListBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxFiles.FormattingEnabled = true;
            this.ListBoxFiles.ItemHeight = 20;
            this.ListBoxFiles.Location = new System.Drawing.Point(3, 3);
            this.ListBoxFiles.Name = "ListBoxFiles";
            this.ListBoxFiles.Size = new System.Drawing.Size(786, 411);
            this.ListBoxFiles.TabIndex = 0;
            // 
            // AddInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControlAddIn);
            this.Name = "AddInForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddIn:";
            this.Load += new System.EventHandler(this.AddInForm_Load);
            this.TabControlAddIn.ResumeLayout(false);
            this.TabPageContent.ResumeLayout(false);
            this.TabPageContent.PerformLayout();
            this.TabPageFiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxContent;
        private System.Windows.Forms.TabControl TabControlAddIn;
        private System.Windows.Forms.TabPage TabPageContent;
        private System.Windows.Forms.TabPage TabPageFiles;
        private System.Windows.Forms.ListBox ListBoxFiles;
    }
}