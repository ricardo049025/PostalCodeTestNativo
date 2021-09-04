using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    
    public class Neighborhood
    {
        
        public int ID { set; get; }

        [StringLength(60)]
        [Required]
        public string name { set; get; }

        public int zipCode { set; get; }

        public int MunicipalityID { set; get; }
        public virtual Municipality Municipality { set; get; }
    }
}
