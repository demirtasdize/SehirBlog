using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSınavı.Class
{
    public class Sehir
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Resim { get; set; }
        public string Tarihi { get; set; }
        public string GezilecekYer { get; set; }
        public string DigerBilgiler { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }

        public virtual ICollection<Mekan> Sehirmekan { get; set; }
        public virtual ICollection<Yorum> Sehiryorum { get; set; }
    }
}
