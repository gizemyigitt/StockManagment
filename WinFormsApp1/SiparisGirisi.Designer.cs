namespace WinFormsApp1
{
    partial class SiparisGirisi
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
            panel1 = new Panel();
            label1 = new Label();
            lblTarih = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblEvrakNo = new Label();
            buttonAddRow = new Button();
            txtEvrakNo = new TextBox();
            panel2 = new Panel();
            panel5 = new Panel();
            lblToplam = new Label();
            txtToplam = new TextBox();
            panel4 = new Panel();
            buttonRegister = new Button();
            textBox3 = new TextBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            Sira = new DataGridViewTextBoxColumn();
            StokAdi = new DataGridViewTextBoxColumn();
            StokKodu = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            AraToplam = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTarih);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(lblEvrakNo);
            panel1.Controls.Add(buttonAddRow);
            panel1.Controls.Add(txtEvrakNo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 117);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 1);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 7;
            label1.Text = "Sipariş Temel Bilgileri";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(11, 77);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(43, 20);
            lblTarih.TabIndex = 6;
            lblTarih.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(105, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // lblEvrakNo
            // 
            lblEvrakNo.AutoSize = true;
            lblEvrakNo.BackColor = SystemColors.Control;
            lblEvrakNo.Location = new Point(11, 37);
            lblEvrakNo.Name = "lblEvrakNo";
            lblEvrakNo.Size = new Size(71, 20);
            lblEvrakNo.TabIndex = 4;
            lblEvrakNo.Text = "Evrak No:";
            // 
            // buttonAddRow
            // 
            buttonAddRow.BackColor = SystemColors.ActiveBorder;
            buttonAddRow.Location = new Point(593, 70);
            buttonAddRow.Name = "buttonAddRow";
            buttonAddRow.Size = new Size(165, 35);
            buttonAddRow.TabIndex = 3;
            buttonAddRow.Text = "Yeni Satır Ekle";
            buttonAddRow.UseVisualStyleBackColor = false;
            buttonAddRow.Click += buttonAddRow_Click;
            // 
            // txtEvrakNo
            // 
            txtEvrakNo.BackColor = SystemColors.HighlightText;
            txtEvrakNo.BorderStyle = BorderStyle.FixedSingle;
            txtEvrakNo.Location = new Point(105, 37);
            txtEvrakNo.Name = "txtEvrakNo";
            txtEvrakNo.Size = new Size(250, 27);
            txtEvrakNo.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(textBox3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 385);
            panel2.Name = "panel2";
            panel2.Size = new Size(793, 119);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblToplam);
            panel5.Controls.Add(txtToplam);
            panel5.Location = new Point(12, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(371, 78);
            panel5.TabIndex = 6;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.BackColor = SystemColors.Control;
            lblToplam.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplam.ForeColor = Color.Black;
            lblToplam.Location = new Point(12, 28);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(100, 20);
            lblToplam.TabIndex = 4;
            lblToplam.Text = "Toplam Fiyat:";
            // 
            // txtToplam
            // 
            txtToplam.BackColor = SystemColors.HighlightText;
            txtToplam.BorderStyle = BorderStyle.None;
            txtToplam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtToplam.ForeColor = Color.Firebrick;
            txtToplam.Location = new Point(118, 21);
            txtToplam.Name = "txtToplam";
            txtToplam.Size = new Size(83, 27);
            txtToplam.TabIndex = 3;
            txtToplam.Text = "0,00";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(buttonRegister);
            panel4.Location = new Point(411, 29);
            panel4.Name = "panel4";
            panel4.Size = new Size(371, 78);
            panel4.TabIndex = 5;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = SystemColors.ActiveBorder;
            buttonRegister.Location = new Point(3, 3);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(359, 70);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Sipariş Bilgilerini Kaydet";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 20);
            textBox3.TabIndex = 4;
            textBox3.Text = "Sipariş Toplam Bilgileri";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(793, 268);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Sira, StokAdi, StokKodu, BirimFiyat, Miktar, AraToplam });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(793, 268);
            dataGridView1.TabIndex = 0;
            dataGridView1.EditModeChanged += buttonAddRow_Click;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            dataGridView1.KeyDown += SiparisGirisi_KeyDown;
            // 
            // Sira
            // 
            Sira.HeaderText = "Sıra";
            Sira.MinimumWidth = 6;
            Sira.Name = "Sira";
            Sira.Width = 125;
            // 
            // StokAdi
            // 
            StokAdi.HeaderText = "Stok Adı";
            StokAdi.MinimumWidth = 6;
            StokAdi.Name = "StokAdi";
            StokAdi.Width = 125;
            // 
            // StokKodu
            // 
            StokKodu.HeaderText = "Stok Kodu";
            StokKodu.MinimumWidth = 6;
            StokKodu.Name = "StokKodu";
            StokKodu.Width = 125;
            // 
            // BirimFiyat
            // 
            BirimFiyat.HeaderText = "Birim Fiyat";
            BirimFiyat.MinimumWidth = 6;
            BirimFiyat.Name = "BirimFiyat";
            BirimFiyat.Width = 125;
            // 
            // Miktar
            // 
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 6;
            Miktar.Name = "Miktar";
            Miktar.Width = 125;
            // 
            // AraToplam
            // 
            AraToplam.HeaderText = "Ara Toplam";
            AraToplam.MinimumWidth = 6;
            AraToplam.Name = "AraToplam";
            AraToplam.Width = 125;
            // 
            // SiparisGirisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 504);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SiparisGirisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Girişi";
            Load += SiparisGirisi_Load_1;
            KeyDown += SiparisGirisi_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtEvrakNo;
        private TextBox textBox3;
        private TextBox txtToplam;
        private Panel panel5;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Label lblEvrakNo;
        private Button buttonAddRow;
        private Label lblToplam;
        private Button buttonRegister;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Sira;
        private DataGridViewTextBoxColumn StokAdi;
        private DataGridViewTextBoxColumn StokKodu;
        private DataGridViewTextBoxColumn BirimFiyat;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn AraToplam;
        private Label lblTarih;
        private Label label1;
    }
}