using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    
    public class Departament
    {
        
        public int ID { set; get; }
        [Required]
        [StringLength(50)]
        public string name { set; get; }        

        public virtual ICollection<Municipality> Municipalities { set; get; }
    }
}
