using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int ID { get; set; }
        public string sehir { get; set; }
        public string KonaklamaSuresi { get; set; }
        public double fiyat { get; set; }
        public string resimURL { get; set; }
        public string aciklama { get; set; }
        public int kapasite { get; set; }
        public bool durum { get; set; }
    
    }
}
