using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Dto
{
    public class PostalCodeDTO
    {
        public int id { get; set; }
        public string departament { set; get; }
        public string municipality { set; get; }
        public string zipCode { set; get; }
        public string neighborhood { set; get; }
    }
}
