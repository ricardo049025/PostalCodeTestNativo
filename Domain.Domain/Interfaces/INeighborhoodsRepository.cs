using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain.Dto;
using Domain.Domain.Interfaces;
using Domain.Entities.Models;
namespace Domain.Domain.Interfaces
{
    public interface INeighborhoodsRepository : IBaseRepository<Neighborhood>
    {
        List<PostalCodeDTO> getAllData();

    }
}
