using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain.Dto;
using Domain.Entities.Models;

namespace Domain.Domain.Interfaces.Services
{
    public interface INeighborhoodsService : IBaseService<Neighborhood>
    {
        List<PostalCodeDTO> getZipCodesDTO();
    }
}
