using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class about2
    {
        [Key]
        public int ID { get; set; }

        public string balik1 { get; set; }
        public string balik2 { get; set; }
        public string aciklama { get; set; }
        public string resimURL { get; set; }
    }
}
