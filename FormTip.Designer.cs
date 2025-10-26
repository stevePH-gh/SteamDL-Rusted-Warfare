namespace SteamDL
{
    partial class frmTip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTip));
            lblTitle = new Label();
            lblTip = new Label();
            btnOaky = new Button();
            btnDownload = new Button();
            lblObviousWarning = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome!";
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTip.Location = new Point(12, 69);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(627, 230);
            lblTip.TabIndex = 1;
            lblTip.Text = resources.GetString("lblTip.Text");
            // 
            // btnOaky
            // 
            btnOaky.Location = new Point(351, 302);
            btnOaky.Name = "btnOaky";
            btnOaky.Size = new Size(294, 29);
            btnOaky.TabIndex = 2;
            btnOaky.Text = "Okay";
            btnOaky.UseVisualStyleBackColor = true;
            btnOaky.Click += btnOaky_Click;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(12, 302);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(294, 29);
            btnDownload.TabIndex = 2;
            btnDownload.Text = "Download SteamCMD";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // lblObviousWarning
            // 
            lblObviousWarning.AutoSize = true;
            lblObviousWarning.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObviousWarning.ForeColor = Color.Red;
            lblObviousWarning.Location = new Point(262, 24);
            lblObviousWarning.Name = "lblObviousWarning";
            lblObviousWarning.Size = new Size(377, 23);
            lblObviousWarning.TabIndex = 1;
            lblObviousWarning.Text = "*INTERNET IS REQUIRED FOR THIS PROGRAM";
            // 
            // frmTip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(657, 343);
            Controls.Add(btnDownload);
            Controls.Add(btnOaky);
            Controls.Add(lblObviousWarning);
            Controls.Add(lblTip);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTip";
            Text = "Important Tip!";
            Load += frmTip_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTip;
        private Button btnOaky;
        private Button btnDownload;
        private Label lblObviousWarning;
    }
}