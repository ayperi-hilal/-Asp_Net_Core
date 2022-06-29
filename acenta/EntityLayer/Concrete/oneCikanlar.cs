using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class oneCikanlar
    {
        [Key]
        public int ID { get; set; }
        public string Post1Baslıgı { get; set; }
        public string Post1Aciklama { get; set; }
        public string Post1Image { get; set; }
        public bool Post1Durum { get; set; }
    }
}
