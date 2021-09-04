using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    
    public class Municipality
    {
    
        public int ID { set; get; }
        [Required]
        [StringLength(50)]
        public string name { set; get; }                
        [Required]
        public int DepartamentID { set; get; }

        
        public virtual Departament Departament { set; get; }   
        public virtual ICollection<Neighborhood> Neighborhoods { set; get; }
    }
}
