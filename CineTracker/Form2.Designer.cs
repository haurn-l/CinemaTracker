namespace CineTracker
{
    partial class Form2
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
            btnGeri = new Button();
            picPoster = new PictureBox();
            lblFilmAdi = new Label();
            lblOzet = new Label();
            btnYildiz = new Button();
            ((System.ComponentModel.ISupportInitialize)picPoster).BeginInit();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Black;
            btnGeri.FlatAppearance.BorderSize = 0;
            btnGeri.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnGeri.ForeColor = SystemColors.HighlightText;
            btnGeri.Location = new Point(35, 29);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 50);
            btnGeri.TabIndex = 0;
            btnGeri.Text = "<-";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // picPoster
            // 
            picPoster.BackColor = Color.WhiteSmoke;
            picPoster.Location = new Point(608, 29);
            picPoster.Name = "picPoster";
            picPoster.Size = new Size(337, 463);
            picPoster.SizeMode = PictureBoxSizeMode.Zoom;
            picPoster.TabIndex = 1;
            picPoster.TabStop = false;
            // 
            // lblFilmAdi
            // 
            lblFilmAdi.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            lblFilmAdi.ForeColor = Color.White;
            lblFilmAdi.Location = new Point(154, 36);
            lblFilmAdi.Name = "lblFilmAdi";
            lblFilmAdi.Size = new Size(448, 80);
            lblFilmAdi.TabIndex = 2;
            lblFilmAdi.Text = "label1";
            // 
            // lblOzet
            // 
            lblOzet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblOzet.ForeColor = Color.Silver;
            lblOzet.Location = new Point(154, 143);
            lblOzet.Name = "lblOzet";
            lblOzet.Size = new Size(402, 309);
            lblOzet.TabIndex = 3;
            lblOzet.Text = "label1";
            // 
            // btnYildiz
            // 
            btnYildiz.AutoSize = true;
            btnYildiz.BackColor = SystemColors.ControlDark;
            btnYildiz.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            btnYildiz.ForeColor = Color.Yellow;
            btnYildiz.Location = new Point(35, 414);
            btnYildiz.Name = "btnYildiz";
            btnYildiz.Size = new Size(68, 68);
            btnYildiz.TabIndex = 4;
            btnYildiz.Text = "⭐";
            btnYildiz.UseVisualStyleBackColor = false;
            btnYildiz.Click += btnYildiz_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(984, 561);
            Controls.Add(btnYildiz);
            Controls.Add(lblOzet);
            Controls.Add(lblFilmAdi);
            Controls.Add(picPoster);
            Controls.Add(btnGeri);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)picPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeri;
        private PictureBox picPoster;
        private Label lblFilmAdi;
        private Label lblOzet;
        private Button btnYildiz;
    }
}