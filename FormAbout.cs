using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddInManager
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            PictureBoxDH.Image = Properties.Resources.dh_logo.ToBitmap();
            PictureBoxSantec.Image = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location).ToBitmap();

            LinkLabel.Link llStantec = new LinkLabel.Link
            {
                LinkData = "http://www.stantec.com/"
            };
            linkLabelStantec.Links.Add(llStantec);

            LinkLabel.Link llDH = new LinkLabel.Link
            {
                LinkData ="mailto:dh51600@heinekamp.com"  // "https://www.heinekamp.com"
            };
            linkLabelDH.Links.Add(llDH);

            LinkLabel.Link llBoost = new LinkLabel.Link
            {
                LinkData = "https://boostyourbim.wordpress.com/"
            };
            linkLabelBoost.Links.Add(llBoost);
        }

        private void linkLabelBoost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabelDH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
