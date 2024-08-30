namespace AddInManager
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.linkLabelStantec = new System.Windows.Forms.LinkLabel();
            this.linkLabelBoost = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelDH = new System.Windows.Forms.LinkLabel();
            this.labelAltered = new System.Windows.Forms.Label();
            this.PictureBoxDH = new System.Windows.Forms.PictureBox();
            this.PictureBoxSantec = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSantec)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelStantec
            // 
            this.linkLabelStantec.AutoSize = true;
            this.linkLabelStantec.Location = new System.Drawing.Point(230, 120);
            this.linkLabelStantec.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabelStantec.Name = "linkLabelStantec";
            this.linkLabelStantec.Size = new System.Drawing.Size(79, 25);
            this.linkLabelStantec.TabIndex = 0;
            this.linkLabelStantec.TabStop = true;
            this.linkLabelStantec.Text = "Stantec";
            this.linkLabelStantec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSite_LinkClicked);
            // 
            // linkLabelBoost
            // 
            this.linkLabelBoost.AutoSize = true;
            this.linkLabelBoost.Location = new System.Drawing.Point(230, 72);
            this.linkLabelBoost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabelBoost.Name = "linkLabelBoost";
            this.linkLabelBoost.Size = new System.Drawing.Size(148, 25);
            this.linkLabelBoost.TabIndex = 1;
            this.linkLabelBoost.TabStop = true;
            this.linkLabelBoost.Text = "Boost Your BIM";
            this.linkLabelBoost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBoost_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Revit Add-In Manager";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 230);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Developed By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "For";
            // 
            // linkLabelDH
            // 
            this.linkLabelDH.AutoSize = true;
            this.linkLabelDH.Location = new System.Drawing.Point(230, 168);
            this.linkLabelDH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabelDH.Name = "linkLabelDH";
            this.linkLabelDH.Size = new System.Drawing.Size(99, 25);
            this.linkLabelDH.TabIndex = 6;
            this.linkLabelDH.TabStop = true;
            this.linkLabelDH.Text = "DHGMBH";
            this.linkLabelDH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDH_LinkClicked);
            // 
            // labelAltered
            // 
            this.labelAltered.AutoSize = true;
            this.labelAltered.Location = new System.Drawing.Point(93, 168);
            this.labelAltered.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAltered.Name = "labelAltered";
            this.labelAltered.Size = new System.Drawing.Size(125, 25);
            this.labelAltered.TabIndex = 7;
            this.labelAltered.Text = "Amended By";
            // 
            // PictureBoxDH
            // 
            this.PictureBoxDH.Location = new System.Drawing.Point(350, 161);
            this.PictureBoxDH.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxDH.Name = "PictureBoxDH";
            this.PictureBoxDH.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxDH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxDH.TabIndex = 10;
            this.PictureBoxDH.TabStop = false;
            // 
            // PictureBoxSantec
            // 
            this.PictureBoxSantec.Location = new System.Drawing.Point(351, 111);
            this.PictureBoxSantec.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxSantec.Name = "PictureBoxSantec";
            this.PictureBoxSantec.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxSantec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxSantec.TabIndex = 11;
            this.PictureBoxSantec.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 481);
            this.Controls.Add(this.PictureBoxSantec);
            this.Controls.Add(this.PictureBoxDH);
            this.Controls.Add(this.labelAltered);
            this.Controls.Add(this.linkLabelDH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelBoost);
            this.Controls.Add(this.linkLabelStantec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSantec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelStantec;
        private System.Windows.Forms.LinkLabel linkLabelBoost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelDH;
        private System.Windows.Forms.Label labelAltered;
        private System.Windows.Forms.PictureBox PictureBoxDH;
        private System.Windows.Forms.PictureBox PictureBoxSantec;
    }
}