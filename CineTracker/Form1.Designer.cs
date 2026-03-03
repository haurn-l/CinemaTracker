namespace CineTracker
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            txtFilmArama = new TextBox();
            btnAra = new Button();
            dgvTop10 = new DataGridView();
            colFilmAdi = new DataGridViewTextBoxColumn();
            colYil = new DataGridViewTextBoxColumn();
            colImdb = new DataGridViewTextBoxColumn();
            dgvEditor = new DataGridView();
            colFilmAdiEd = new DataGridViewTextBoxColumn();
            colYilEd = new DataGridViewTextBoxColumn();
            colImdbEd = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTop10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEditor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(138, 0, 196);
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(430, 54);
            label1.TabIndex = 0;
            label1.Text = "HARUN SİNEVAZYON";
            // 
            // txtFilmArama
            // 
            txtFilmArama.Font = new Font("Segoe UI", 14F);
            txtFilmArama.Location = new Point(667, 93);
            txtFilmArama.Name = "txtFilmArama";
            txtFilmArama.Size = new Size(168, 32);
            txtFilmArama.TabIndex = 1;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.Gray;
            btnAra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAra.ForeColor = Color.Chartreuse;
            btnAra.Location = new Point(841, 93);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(88, 32);
            btnAra.TabIndex = 2;
            btnAra.Text = "BUL 🔍";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // dgvTop10
            // 
            dgvTop10.AllowUserToAddRows = false;
            dgvTop10.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 55, 55);
            dgvTop10.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTop10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTop10.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTop10.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTop10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTop10.Columns.AddRange(new DataGridViewColumn[] { colFilmAdi, colYil, colImdb });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTop10.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTop10.EnableHeadersVisualStyles = false;
            dgvTop10.Location = new Point(50, 220);
            dgvTop10.Name = "dgvTop10";
            dgvTop10.ReadOnly = true;
            dgvTop10.RowHeadersVisible = false;
            dgvTop10.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTop10.Size = new Size(382, 242);
            dgvTop10.TabIndex = 3;
            dgvTop10.CellDoubleClick += dgvTop10_CellDoubleClick;
            // 
            // colFilmAdi
            // 
            colFilmAdi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFilmAdi.HeaderText = "Film Adı";
            colFilmAdi.Name = "colFilmAdi";
            colFilmAdi.ReadOnly = true;
            // 
            // colYil
            // 
            colYil.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colYil.HeaderText = "Yıl";
            colYil.Name = "colYil";
            colYil.ReadOnly = true;
            colYil.Width = 45;
            // 
            // colImdb
            // 
            colImdb.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colImdb.HeaderText = "IMDb";
            colImdb.Name = "colImdb";
            colImdb.ReadOnly = true;
            colImdb.Width = 61;
            // 
            // dgvEditor
            // 
            dgvEditor.AllowUserToAddRows = false;
            dgvEditor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(55, 55, 55);
            dgvEditor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEditor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditor.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEditor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvEditor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditor.Columns.AddRange(new DataGridViewColumn[] { colFilmAdiEd, colYilEd, colImdbEd });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvEditor.DefaultCellStyle = dataGridViewCellStyle6;
            dgvEditor.Location = new Point(530, 220);
            dgvEditor.Name = "dgvEditor";
            dgvEditor.ReadOnly = true;
            dgvEditor.RowHeadersVisible = false;
            dgvEditor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEditor.Size = new Size(382, 242);
            dgvEditor.TabIndex = 4;
            dgvEditor.CellDoubleClick += dgvEditor_CellDoubleClick;
            // 
            // colFilmAdiEd
            // 
            colFilmAdiEd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFilmAdiEd.HeaderText = "Film Adı";
            colFilmAdiEd.Name = "colFilmAdiEd";
            colFilmAdiEd.ReadOnly = true;
            // 
            // colYilEd
            // 
            colYilEd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colYilEd.HeaderText = "Yıl";
            colYilEd.Name = "colYilEd";
            colYilEd.ReadOnly = true;
            colYilEd.Width = 45;
            // 
            // colImdbEd
            // 
            colImdbEd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colImdbEd.HeaderText = "IMDb";
            colImdbEd.Name = "colImdbEd";
            colImdbEd.ReadOnly = true;
            colImdbEd.Width = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(157, 189);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 5;
            label2.Text = "🏆 IMDb Top 10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(609, 189);
            label3.Name = "label3";
            label3.Size = new Size(210, 28);
            label3.TabIndex = 6;
            label3.Text = "⭐ Editörün Seçimleri";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(984, 561);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvEditor);
            Controls.Add(dgvTop10);
            Controls.Add(btnAra);
            Controls.Add(txtFilmArama);
            Controls.Add(label1);
            Name = "Form1";
            Text = "HarunSinevazyon - Ana Merkez";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTop10).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEditor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFilmArama;
        private Button btnAra;
        private DataGridView dgvTop10;
        private DataGridView dgvEditor;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn colFilmAdi;
        private DataGridViewTextBoxColumn colYil;
        private DataGridViewTextBoxColumn colImdb;
        private DataGridViewTextBoxColumn colFilmAdiEd;
        private DataGridViewTextBoxColumn colYilEd;
        private DataGridViewTextBoxColumn colImdbEd;
    }
}
