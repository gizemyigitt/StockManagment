using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bu sınıfta Sipariş propertylerini içermektedir
namespace WinFormsApp1
{
    public class OrderData
    {
        public string StokAdi { get; set; }
        public int StokKodu { get; set; }
        public double BirimFiyat { get; set; }
        public double Miktar { get; set; }
        public double AraToplam { get; set; }
    }
}
