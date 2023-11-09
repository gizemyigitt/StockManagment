using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bu sınıf Stok verilerinin propertylerini içermektedir
namespace WinFormsApp1
{
    public class Stock
    {
        public string StokAdi { get; set; }
        public int StokKodu { get; set; }
        public double BirimFiyat { get; set; }

    }
}
