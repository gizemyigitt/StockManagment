using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Web.UI;
using System.IO;
using System.Security.Cryptography;
using System.DirectoryServices.ActiveDirectory;

namespace WinFormsApp1
{
    public partial class FrmStokKart : Form
    {
        static string path = "C:\\Users\\gizem\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Json\\StockJson.JSON";

        //Stock json dosyası adına açılacak liste için getData fonksiyonunu yazarak tekrarın önüne geçmeye çalıştım.
        public List<Stock> getData()
        {

            string json = File.ReadAllText(path);
            List<Stock>? stockJson = JsonConvert.DeserializeObject<List<Stock>>(json);

            return stockJson;
        }

        public FrmStokKart()
        {
            InitializeComponent();
        }
        //Form yüklendiğinde Stock Json dosyasındaki veriler okunup, listbox a eklenmesi
        private void FrmStokKart_Load_1(object sender, EventArgs e)
        {

            var stockJson = getData();

            if (stockJson != null)
            {
                var orderList = stockJson.ToList();
                listBox1.Items.Clear();

                foreach (var stock in orderList)
                {
                    listBox1.Items.Add(stock.StokAdi);
                }
            }

        }

        //Bilgileri kaydetmek istediğimizde gerekli kontrollerin yapıldığı
        // ve Stock json dosyasına verilerin eklendiği kontol
        private void button1_Click_1(object sender, EventArgs e)
        {
            var stockJson = getData();

            int stokKodu = Convert.ToInt32(txtStokKodu.Text);
            string stokAdi = txtStokAdi.Text;
            double birimFiyat = Convert.ToDouble(DropDownBirimFiyat.Value);

            if (!string.IsNullOrEmpty(stokAdi) && !string.IsNullOrEmpty(Convert.ToString(birimFiyat)))
            {

                Stock newStock = new Stock
                {
                    StokKodu = stokKodu,
                    StokAdi = stokAdi,
                    BirimFiyat = birimFiyat
                };


                //stockJson koleksiyonunda stokKodu ile eşleşen veriyi filtreledim ve
                //bu stok öğesinin StokAdi ve BirimFiyat alanlarını güncelledim
                if (stockJson.Any(s => s.StokKodu == stokKodu) && stockJson != null)
                {
                    Stock existingStock = stockJson.First(s => s.StokKodu == stokKodu);

                    existingStock.StokAdi = stokAdi;
                    existingStock.BirimFiyat = birimFiyat;

                    File.WriteAllText(path, JsonConvert.SerializeObject(stockJson));


                    listBox1.Items.Clear();
                    foreach (var stock in stockJson)
                    {
                        listBox1.Items.Add(stock.StokAdi);
                    }

                }
                //Yeni eklenecek verinin güncel veriler arasında olup olmadığını inceledim 
                // ve veri tekrarının önüne geçmeye çalıştım
                if (!stockJson.Any(s => s.StokKodu == newStock.StokKodu) && newStock != null && stockJson != null)
                {

                    stockJson.Add(newStock);

                    File.WriteAllText(path, JsonConvert.SerializeObject(stockJson));

                    listBox1.Items.Add(newStock.StokAdi);
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti");
                }
            }

        }

        //Listbox da seçilen Stok Adı değerine göre Stock json dosyasından ilgili
        //verileri çağırdım ve boşlukları doldurdum.
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stockJson = getData();

            if (stockJson != null && stockJson.Count > 0)
            {
                int index = 0;
                foreach (int item in listBox1.SelectedIndices)
                {

                    index = item;

                    if (index < stockJson.Count)
                    {
                        Stock selectedStock = stockJson[index];

                        txtStokAdi.Text = selectedStock.StokAdi;
                        txtStokKodu.Text = Convert.ToString(selectedStock.StokKodu);
                        DropDownBirimFiyat.Value = Convert.ToInt32(selectedStock.BirimFiyat);
                    }
                }
            }
        }

        //Son üç kontrol Stock nesnesine vereceğim değerleri alan
        //labelların boş geçilmemesine dair yaptığım kontrollerdir
         private void txtStokKodu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStokKodu.Text))
            {
                MessageBox.Show("Bu alan boş bırakılamaz.");
            }
        }

       

        private void txtStokAdi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStokAdi.Text))
            {
                MessageBox.Show("Bu alan boş bırakılamaz.");
            }
        }

        private void DropDownBirimFiyat_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(DropDownBirimFiyat.Value)))
            {

                MessageBox.Show("Bu alan boş bırakılamaz.");
            }
        }
    }
}
