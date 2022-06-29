using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class altHakkinda
    {
        [Key]
        public int ID { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
    }
}
