using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamDL
{
    public partial class frmTip : Form
    {
        public frmTip()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

        }

        private void frmTip_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 0)
            {
                var main = Application.OpenForms[0];
                this.Location = new System.Drawing.Point(main.Right + 10, main.Top);
            }

        }

        private void btnOaky_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";
            try
            {
                // Use this workaround for Windows 7 compatibility
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch
            {
                try
                {
                    // Fallback for very old systems
                    System.Diagnostics.Process.Start("explorer.exe", url);
                }
                catch
                {
                    MessageBox.Show("Unable to open your browser.\nPlease visit:\n" + url,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
