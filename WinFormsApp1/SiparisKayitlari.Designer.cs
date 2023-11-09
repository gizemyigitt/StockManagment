namespace WinFormsApp1
{
    partial class SiparisKayitlari
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
            dataGridView1 = new DataGridView();
            buttonList = new Button();
            buttonOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "datagridview1";
            dataGridView1.AccessibleRole = AccessibleRole.Row;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(429, 377);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // buttonList
            // 
            buttonList.BackColor = Color.FromArgb(255, 255, 128);
            buttonList.Location = new Point(288, 12);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(153, 29);
            buttonList.TabIndex = 2;
            buttonList.Text = "Stok Kart Liste";
            buttonList.UseVisualStyleBackColor = false;
            buttonList.Click += buttonList_Click;
            // 
            // buttonOrder
            // 
            buttonOrder.BackColor = Color.Coral;
            buttonOrder.Location = new Point(12, 12);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(171, 29);
            buttonOrder.TabIndex = 3;
            buttonOrder.Text = "Yeni Sipariş Ekle";
            buttonOrder.UseVisualStyleBackColor = false;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // SiparisKayitlari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 453);
            Controls.Add(buttonOrder);
            Controls.Add(buttonList);
            Controls.Add(dataGridView1);
            Name = "SiparisKayitlari";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Kayıtları";
            Load += SiparisKayitlari_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button buttonList;
        private Button buttonOrder;
    }
}