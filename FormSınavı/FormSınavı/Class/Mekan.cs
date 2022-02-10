using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSınavı.Class
{
    public class Mekan
    {
        public int ID { get; set; }
        public int SehirID { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public string Aciklama { get; set; }

        public virtual Sehir Mekansehir { get; set; }
    }
}
