namespace WinFormsApp1
{
    partial class FrmStokKart
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
            components = new System.ComponentModel.Container();
            stockBindingSource = new BindingSource(components);
            label1 = new Label();
            txtStokKodu = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtStokAdi = new TextBox();
            button1 = new Button();
            label4 = new Label();
            DropDownBirimFiyat = new NumericUpDown();
            panel1 = new Panel();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)stockBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DropDownBirimFiyat).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // stockBindingSource
            // 
            stockBindingSource.DataSource = typeof(Stock);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 51);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Stok Kodu";
            // 
            // txtStokKodu
            // 
            txtStokKodu.Location = new Point(41, 74);
            txtStokKodu.Name = "txtStokKodu";
            txtStokKodu.Size = new Size(149, 27);
            txtStokKodu.TabIndex = 3;
            txtStokKodu.Validating += txtStokKodu_Validating;
            
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 2);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 4;
            label2.Text = "Stok Kart Bilgileri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 122);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "Stok Adı";
            // 
            // txtStokAdi
            // 
            txtStokAdi.Location = new Point(40, 145);
            txtStokAdi.Name = "txtStokAdi";
            txtStokAdi.Size = new Size(150, 27);
            txtStokAdi.TabIndex = 6;
            txtStokAdi.Validating += txtStokAdi_Validating;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(41, 275);
            button1.Name = "button1";
            button1.Size = new Size(149, 53);
            button1.TabIndex = 5;
            button1.Text = "Bilgileri Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 191);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 7;
            label4.Text = "Birim Fiyat";
            // 
            // DropDownBirimFiyat
            // 
            DropDownBirimFiyat.Location = new Point(40, 225);
            DropDownBirimFiyat.Name = "DropDownBirimFiyat";
            DropDownBirimFiyat.Size = new Size(150, 27);
            DropDownBirimFiyat.TabIndex = 8;
            DropDownBirimFiyat.Validating += DropDownBirimFiyat_Validating;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(DropDownBirimFiyat);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtStokAdi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtStokKodu);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(368, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 364);
            panel1.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(82, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(213, 364);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FrmStokKart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "FrmStokKart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmStokKart";
            Load += FrmStokKart_Load_1;
            ((System.ComponentModel.ISupportInitialize)stockBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DropDownBirimFiyat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource stockBindingSource;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtStokKodu;
        private Label label2;
        private Label label3;
        private TextBox txtStokAdi;
        private Button button1;
        private Label label4;
        private NumericUpDown DropDownBirimFiyat;
        private Panel panel1;
        private ListBox listBox1;
    }
}