using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class referanslar
    {
        [Key]
        public int ID { get; set; }
        public string müsteri { get; set; }
        public string yorumu { get; set; }
        public string ımageURL { get; set; }
        public bool durum { get; set; }
    }
}
