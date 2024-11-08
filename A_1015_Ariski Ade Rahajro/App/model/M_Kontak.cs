using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_1015_Ariski_Ade_Rahajro.App.model
{
    public class Kontak
    { 
        [Key]
        public int kontak_id { get; set; }
        [Required]
        public string nama { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string no_hp { get; set; }
    }
}
