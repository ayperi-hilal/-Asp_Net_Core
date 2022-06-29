using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class reshberler
    {
        [Key]
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Aciklama { get; set; }
        public string ImageURl { get; set; }
        public string twitterURL { get; set; }
        public string InstURL { get; set; }
        public bool durum { get; set; }
    }
}
