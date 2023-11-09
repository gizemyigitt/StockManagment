using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bu sınıf Sipariş verileri ve ilgili diğer propertyleri içermektedir
namespace WinFormsApp1
{
    public class Order
    {
        public string EvrakNo {  get; set; }
        public DateTime Tarih {  get; set; }
        public double Toplam {  get; set; }
        public List<OrderData> OrderDatas { get; set; } 

    }
}
