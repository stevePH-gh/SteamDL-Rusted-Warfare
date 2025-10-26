namespace SteamDL
{
    partial class frmDownloadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDownloadForm));
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            lblLink = new Label();
            textBoxLink = new TextBox();
            btnDownload = new Button();
            listBoxDetails = new ListBox();
            progressBar1 = new ProgressBar();
            labelStatus = new Label();
            lblDetails = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.SeaGreen;
            lblTitle.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(425, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Rusted Warfare SteamDL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaGreen;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(555, 62);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Location = new Point(12, 77);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(129, 20);
            lblLink.TabIndex = 2;
            lblLink.Text = "Paste Link to Mod:";
            // 
            // textBoxLink
            // 
            textBoxLink.Location = new Point(12, 100);
            textBoxLink.Name = "textBoxLink";
            textBoxLink.PlaceholderText = "eg: https://steamcommunity.com/sharedfiles/filedetails/?id=0123456789";
            textBoxLink.Size = new Size(555, 27);
            textBoxLink.TabIndex = 3;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.SeaGreen;
            btnDownload.FlatAppearance.BorderColor = Color.Black;
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(12, 263);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(129, 65);
            btnDownload.TabIndex = 4;
            btnDownload.Text = "Download\r\nFile";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // listBoxDetails
            // 
            listBoxDetails.FormattingEnabled = true;
            listBoxDetails.Location = new Point(12, 153);
            listBoxDetails.Name = "listBoxDetails";
            listBoxDetails.Size = new Size(555, 104);
            listBoxDetails.TabIndex = 5;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(147, 291);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(420, 37);
            progressBar1.TabIndex = 6;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Location = new Point(147, 268);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(52, 20);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Status:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(12, 130);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(50, 20);
            lblDetails.TabIndex = 2;
            lblDetails.Text = "Script:";
            // 
            // frmDownloadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(579, 335);
            Controls.Add(labelStatus);
            Controls.Add(progressBar1);
            Controls.Add(listBoxDetails);
            Controls.Add(btnDownload);
            Controls.Add(textBoxLink);
            Controls.Add(lblDetails);
            Controls.Add(lblLink);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDownloadForm";
            Text = "Rusted Warfare SteamDL";
            Load += frmDownloadForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pictureBox1;
        private Label lblLink;
        private TextBox textBoxLink;
        private Button btnDownload;
        private ListBox listBoxDetails;
        private ProgressBar progressBar1;
        private Label labelStatus;
        private Label lblDetails;
    }
}
