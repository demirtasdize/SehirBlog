using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSınavı.Class
{
    public class Yorum
    {
        public int ID { get; set; }
        public int SehirID { get; set; }
        public DateTime Tarih { get; set; }
        public string YorumMetni { get; set; }

        public virtual Sehir Yorumsehir { get; set; }
    }
}
