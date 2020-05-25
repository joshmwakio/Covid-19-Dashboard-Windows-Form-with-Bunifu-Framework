namespace Covid19_Analytica
{
    partial class ToastControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToastControl));
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toastBunifuLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bunifuShadowPanel1.Controls.Add(this.toastBunifuLabel);
            this.bunifuShadowPanel1.Controls.Add(this.pictureBox1);
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 4;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(364, 98);
            this.bunifuShadowPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Covid19_Analytica.Properties.Resources._45__1_;
            this.pictureBox1.Location = new System.Drawing.Point(31, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toastBunifuLabel
            // 
            this.toastBunifuLabel.AutoEllipsis = false;
            this.toastBunifuLabel.CursorType = null;
            this.toastBunifuLabel.Font = new System.Drawing.Font("Montserrat Alternates", 11.25F);
            this.toastBunifuLabel.ForeColor = System.Drawing.Color.White;
            this.toastBunifuLabel.Location = new System.Drawing.Point(119, 35);
            this.toastBunifuLabel.Name = "toastBunifuLabel";
            this.toastBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toastBunifuLabel.Size = new System.Drawing.Size(174, 27);
            this.toastBunifuLabel.TabIndex = 8;
            this.toastBunifuLabel.Text = "Fetching Covid-19 Data";
            this.toastBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.toastBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ToastControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Name = "ToastControl";
            this.Size = new System.Drawing.Size(370, 104);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel toastBunifuLabel;
    }
}
