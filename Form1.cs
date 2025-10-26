using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamDL
{
    public partial class frmDownloadForm : Form
    {
        public frmDownloadForm()
        {
            InitializeComponent();
        }
        private void frmDownloadForm_Load(object sender, EventArgs e)
        {
            var tip = new frmTip();
            tip.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            string link = textBoxLink.Text.Trim();
            string pattern = @"id=(\d+)";
            Match match = Regex.Match(link, pattern);

            if (!match.Success)
            {
                MessageBox.Show("Invalid Steam Link\n\t\t\t\t", "Error");
                return;
            }

            string modId = match.Groups[1].Value;
            string appId = "647960";

            string downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string steamDlRoot = Path.Combine(downloadsFolder, "SteamDL");
            Directory.CreateDirectory(steamDlRoot);

            try
            {
                labelStatus.Text = "Starting Download";
                progressBar1.Value = 0;
                listBoxDetails.Items.Clear();

                string steamCmdPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    "steamcmd",
                    "steamcmd.exe"
                );

                string args = $"+login anonymous +workshop_download_item {appId} {modId} validate +quit";

                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = steamCmdPath,
                    Arguments = args,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                string output = "";
                string modTitle = $"Mod {modId}";

                using (var process = new System.Diagnostics.Process { StartInfo = psi })
                {
                    process.OutputDataReceived += (s, ev) =>
                    {
                        if (!string.IsNullOrEmpty(ev.Data))
                        {
                            output += ev.Data + Environment.NewLine;

                            if (ev.Data.Contains("Downloading item"))
                            {
                                var matchTitle = Regex.Match(ev.Data, @"\d+\s*:\s*(.+)$");
                                if (matchTitle.Success)
                                {
                                    string possibleTitle = matchTitle.Groups[1].Value.Trim();
                                    if (!string.IsNullOrWhiteSpace(possibleTitle))
                                        modTitle = possibleTitle;
                                }
                            }

                            this.Invoke((Action)(() =>
                            {
                                listBoxDetails.Items.Add(ev.Data);
                                listBoxDetails.TopIndex = listBoxDetails.Items.Count - 1;

                                if (
                                    !ev.Data.Contains("type 'quit' to exit", StringComparison.OrdinalIgnoreCase) &&
                                    !ev.Data.Contains("Steam Console Client", StringComparison.OrdinalIgnoreCase) &&
                                    !ev.Data.Contains("Redirecting stderr", StringComparison.OrdinalIgnoreCase) &&
                                    !ev.Data.Contains("Loading Steam API", StringComparison.OrdinalIgnoreCase)
                                )
                                {
                                    labelStatus.Text = ev.Data;
                                }

                                if (ev.Data.Contains("Connecting anonymously", StringComparison.OrdinalIgnoreCase))
                                {
                                    progressBar1.Style = ProgressBarStyle.Continuous;
                                    progressBar1.Value = 10;
                                }
                                else if (ev.Data.Contains("Waiting for client config", StringComparison.OrdinalIgnoreCase))
                                {
                                    progressBar1.Value = 25;
                                }
                                else if (ev.Data.Contains("Waiting for user info", StringComparison.OrdinalIgnoreCase))
                                {
                                    progressBar1.Value = 40;
                                }
                                else if (ev.Data.Contains("Downloading item", StringComparison.OrdinalIgnoreCase))
                                {
                                    progressBar1.Style = ProgressBarStyle.Marquee;
                                }
                                else if (ev.Data.Contains("Success. Downloaded", StringComparison.OrdinalIgnoreCase))
                                {
                                    progressBar1.Style = ProgressBarStyle.Continuous;
                                    progressBar1.Value = 100;
                                }
                            }));
                        }
                    };




                    process.Start();
                    process.BeginOutputReadLine();
                    await process.WaitForExitAsync();
                }

                string modFolder = Path.Combine(
                    Path.GetDirectoryName(steamCmdPath),
                    "steamapps", "workshop", "content", appId, modId
                );

                if (Directory.Exists(modFolder))
                {
                    string modSaveFolder = Path.Combine(steamDlRoot, modId);
                    Directory.CreateDirectory(modSaveFolder);

                    string zipPath = Path.Combine(modSaveFolder, $"{modId}.zip");

                    if (File.Exists(zipPath))
                        File.Delete(zipPath);

                    ZipFile.CreateFromDirectory(modFolder, zipPath, CompressionLevel.Optimal, false);

                    try { Directory.Delete(modFolder, true); } catch { }

                    progressBar1.Style = ProgressBarStyle.Blocks;
                    progressBar1.Value = 100;
                    labelStatus.Text = "Download complete";

                    MessageBox.Show($"Saved as:\n{zipPath}\n\t\t\t\t", "Downloaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Ooops... Error\nMod folder not found after download.\t\t\t\t", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ooops... Error\n{ex.Message}\t\t\t\t", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
