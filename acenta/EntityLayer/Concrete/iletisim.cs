using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class iletisim
    {
        [Key]
        public int ID { get; set; }
        public string aciklama { get; set; }
        public string mail { get; set; }
        public string adres { get; set; }
        public string telNo { get; set; }
        public string Harita { get; set; }
        public bool durum { get; set; }
    }
}
