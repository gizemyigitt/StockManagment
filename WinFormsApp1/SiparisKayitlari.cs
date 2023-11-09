using Newtonsoft.Json;
using System.IO;

namespace WinFormsApp1
{

    public partial class SiparisKayitlari : Form
    {
        static string orderpath = "C:\\Users\\gizem\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Json\\OrderJson.JSON";

        public SiparisKayitlari()

        {
            InitializeComponent();

        }

        //Kullan�c� Form Stok Kart sayfas�na y�nlendirilir
        private void buttonList_Click(object sender, EventArgs e)
        {

            FrmStokKart frmStokKart = new FrmStokKart();
            frmStokKart.Show();

        }

        //Kullan�c� Sipari� Giri�i sayfas�na y�nlendirilir
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            SiparisGirisi siparisGirisi = new SiparisGirisi();
            siparisGirisi.Show();
            this.Close();

        }

        //Sipari� Kay�tlar� sayfas� ba�lat�ld���nda datagridview kontrol�ne, Sipari� detaylar�n� i�eren
        //OrderJson dosyas�n�n verileri yazd�r�l�r 
        public void SiparisKayitlari_Load(object sender, EventArgs e)
        {

            string json = File.ReadAllText(orderpath);

            List<Order>? orderJson = JsonConvert.DeserializeObject<List<Order>>(json);

            dataGridView1.Rows.Clear();

            if (orderJson != null)
            {
                dataGridView1.Rows.Clear();

                dataGridView1.Columns.Add("EvrakNo", "EvrakNo");
                dataGridView1.Columns.Add("Tarih", "Tarih");
                dataGridView1.Columns.Add("Toplam", "Toplam");


                foreach (var orderData in orderJson)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells["EvrakNo"].Value = orderData.EvrakNo.ToString();
                    row.Cells["Tarih"].Value = orderData.Tarih.ToString("dd.MM.yy");
                    row.Cells["Toplam"].Value = orderData.Toplam.ToString();

                }

            }
            else { dataGridView1.Rows.Clear(); }

        }

        //Evrak numaras�na �ift t�klama yap�ld���nda Sipari� Giri�i sayfas�na 
        //se�ili Evrak Numaras� i�lenmek �zere Sipari� Giri�i sayfas�na y�nlendirilir
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedEvrakNo = dataGridView1.Rows[e.RowIndex].Cells["EvrakNo"].Value?.ToString();
            if (string.IsNullOrEmpty(selectedEvrakNo))
            {
                return;
            }

            SiparisGirisi siparisGirisi = new SiparisGirisi();
            siparisGirisi.SelectedEvrakNo = selectedEvrakNo;
            siparisGirisi.Show();
            this.Close();
        }


    }
}