namespace KediGercekleri
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
            dgvGercekler = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dgvMovies = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGercekler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            SuspendLayout();
            // 
            // dgvGercekler
            // 
            dgvGercekler.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvGercekler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvGercekler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGercekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGercekler.Location = new Point(14, 47);
            dgvGercekler.Margin = new Padding(5, 6, 5, 6);
            dgvGercekler.Name = "dgvGercekler";
            dgvGercekler.RowTemplate.Height = 25;
            dgvGercekler.Size = new Size(809, 186);
            dgvGercekler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 1;
            label1.Text = "Kedi Gerçekleri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 239);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 3;
            label2.Text = "IMDB 100";
            // 
            // dgvMovies
            // 
            dgvMovies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(14, 275);
            dgvMovies.Margin = new Padding(5, 6, 5, 6);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.RowTemplate.Height = 25;
            dgvMovies.Size = new Size(809, 295);
            dgvMovies.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 587);
            Controls.Add(label2);
            Controls.Add(dgvMovies);
            Controls.Add(label1);
            Controls.Add(dgvGercekler);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Kedi Gerçekleri";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGercekler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGercekler;
        private Label label1;
        private Label label2;
        private DataGridView dgvMovies;
    }
}