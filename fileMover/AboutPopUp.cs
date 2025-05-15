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
using System.Windows.Forms.Design;

namespace fileMover
{
    public partial class AboutPopUp : Form
    {
        public AboutPopUp()
        {
            InitializeComponent();
        }

        private void AboutLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo browserprocess = new ProcessStartInfo();
            browserprocess.FileName = sourceLink.Text;
            browserprocess.UseShellExecute = true;

            System.Diagnostics.Process.Start(browserprocess);
        }

        private void WzautomationurlLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo browserprocess = new ProcessStartInfo();
            browserprocess.FileName = wzautomationurl.Text;
            browserprocess.UseShellExecute = true;

            System.Diagnostics.Process.Start(browserprocess);
        }
    }
}
