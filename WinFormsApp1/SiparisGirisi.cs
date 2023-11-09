using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{

    public partial class SiparisGirisi : Form
    {
        static string path = "C:\\Users\\gizem\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Json\\StockJson.JSON";
        static string orderpath = "C:\\Users\\gizem\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Json\\OrderJson.JSON";
       
        public string SelectedEvrakNo { get; set; }
       
        public SiparisGirisi()
        {
            InitializeComponent();

        }
        public List<Stock> getStockData()
        {

            string json = File.ReadAllText(path);
            List<Stock>? stockJson = JsonConvert.DeserializeObject<List<Stock>>(json);

            return stockJson;
        }
        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            //dataGridView1.AllowUserToAddRows = true;
            dataGridView1.Rows.Add();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // var orderJson = getOrderData();
            var stockJson = getStockData();

            object item = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            int b = Convert.ToInt32(item);

            List<Stock> filteredItems = stockJson
                            .Where(item1 => item1.StokKodu % 100 == b).ToList();
            foreach (var item2 in filteredItems)
            {

                dataGridView1.Rows[e.RowIndex].Cells[2].Value = item2.StokKodu.ToString();
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = item2.StokAdi.ToString();
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = item2.BirimFiyat.ToString();


            }

        }
        //Json Dosyasına verileri kaydettiğimiz fonksiyon
        private void SaveDataToJSON(string jsonFilePath, List<Order> orders)
        {
            string json = JsonConvert.SerializeObject(orders, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }
        //Json Dosyasından verileri okuduğumuz fonksiyon
        private List<Order> LoadDataFromJSON(string jsonFilePath)
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(json);
                return orders;
            }
            return new List<Order>();
        }
        // verileri kaydetme butonu ile doldurulan bütün boşlukların değerini OrderJson dosyasına ekledim
        private void buttonRegister_Click(object sender, EventArgs e)
        {

            string evrakNo = txtEvrakNo.Text;
            DateTime tarih = dateTimePicker1.Value.Date;
            double toplam = Convert.ToDouble(txtToplam.Text);
           
            //Boşluklardan gelen veriler için yeni bir Order nesnesi oluşturdum
            Order newOrder = new Order
            {
                EvrakNo = evrakNo,
                Tarih = tarih,
                Toplam = toplam,
                OrderDatas = new List<OrderData>()
            };

            //Datagridview içindeki verileri foreach döngüsü yardımıyla OrderDatas listesine ekledim
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    OrderData orderdata = new OrderData
                    {
                        StokAdi = row.Cells["StokAdi"].Value.ToString(),
                        StokKodu = Convert.ToInt32(row.Cells["StokKodu"].Value),
                        BirimFiyat = Convert.ToDouble(row.Cells["BirimFiyat"].Value),
                        Miktar = Convert.ToDouble(row.Cells["Miktar"].Value),
                        AraToplam = Convert.ToDouble(row.Cells["AraToplam"].Value)
                    };
                    newOrder.OrderDatas.Add(orderdata);
                }
                else
                {
                    MessageBox.Show("Boş Satır Kalmamalıdır!");
                    return; 
                }
            }


            List<Order> orders = LoadDataFromJSON(orderpath);

            // Aynı EvrakNo'ya sahip bir nesneyi buldum
            Order existingOrder = orders.FirstOrDefault(order => order.EvrakNo == evrakNo);

            if (existingOrder != null)
            {
                // Eğer aynı EvrakNo'ya sahip bir nesne varsa, propertylerini güncelledim
                existingOrder.Tarih = newOrder.Tarih;
                existingOrder.OrderDatas = newOrder.OrderDatas;
            }
            else
            {
                // Aynı EvrakNo'ya sahip bir nesne yoksa, yeni nesneyi orders listesine ekledim
                orders.Add(newOrder);
            }

            // Değişiklikleri JSON dosyasına kaydettim
            SaveDataToJSON(orderpath, orders);

            SiparisKayitlari siparisKayitlari = new SiparisKayitlari();
            siparisKayitlari.Show();

            this.Close();

        }
        //SiparisKAyitlari Sayfasından gelen seçilmiş evrak numarasıyla; ilgili Evrak Numarası, Tarih ve
        // sipariş bilgileri OrderJson dosyasından getirilir.
        private void SiparisGirisi_Load_1(object sender, EventArgs e)
        {
           
            if (SelectedEvrakNo != null)
            {
                string orderJson = File.ReadAllText(orderpath);

                
                List<Order> OrderList = JsonConvert.DeserializeObject<List<Order>>(orderJson);

                // Seçilen EvrakNo'ya ait veriyi buldum
                Order selectedOrder = OrderList.FirstOrDefault(s => s.EvrakNo == SelectedEvrakNo);

                if (selectedOrder != null)
                {
                    txtEvrakNo.Text = selectedOrder.EvrakNo;
                    dateTimePicker1.Value = selectedOrder.Tarih;
                    txtToplam.Text = selectedOrder.Toplam.ToString();
                    //datagridview1 içindeki her bir satır için değerleri yerine yerleştirdim
                    foreach (OrderData orderData in selectedOrder.OrderDatas)
                    {
                        int rowIndex = dataGridView1.Rows.Add();
                        dataGridView1.Rows[rowIndex].Cells["StokAdi"].Value = orderData.StokAdi;
                        dataGridView1.Rows[rowIndex].Cells["StokKodu"].Value = orderData.StokKodu;
                        dataGridView1.Rows[rowIndex].Cells["BirimFiyat"].Value = orderData.BirimFiyat;
                        dataGridView1.Rows[rowIndex].Cells["Miktar"].Value = orderData.Miktar;
                        dataGridView1.Rows[rowIndex].Cells["AraToplam"].Value = orderData.AraToplam;
                    }
                }
            }
        }
        //Her satır için sıra değerini numeric şekilde artıran kontrol
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }
        //Enter tuşu ile hücreler arası geçiş yapmamızı sağlayan kontrol
        private void SiparisGirisi_KeyDown(object sender, KeyEventArgs e)
        {


            dataGridView1.AllowUserToAddRows = false;
            if (e.KeyCode == Keys.Enter)
            {
                int col = dataGridView1.CurrentCell.ColumnIndex;
                int row = dataGridView1.CurrentCell.RowIndex;
                if (col < dataGridView1.Columns.Count - 1)
                {              
                    dataGridView1.Focus();
                    SendKeys.Send("{right}");
                }
                else if (col == dataGridView1.Columns.Count - 1)
                {
                    e.Handled = true;
                }
            }

        }
        //Her satır sonunda birim fiyat ve miktar değerlerinin çarpımı ve Toplam Fiyat bilgisinin 
        // yazıldığı kontrol
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            txtToplam.Text = "0";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[dataGridView1.Columns["AraToplam"].Index].Value = (Convert.ToDouble(row.Cells[dataGridView1.Columns["Miktar"].Index].Value)) * (Convert.ToDouble(row.Cells[dataGridView1.Columns["BirimFiyat"].Index].Value));

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                txtToplam.Text = Convert.ToString(double.Parse(txtToplam.Text) + double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()));
            }

        }


    }
}
