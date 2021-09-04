using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Models;
using Domain.Domain.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Domain.Domain.Dto;

namespace Infraestructure.Data.Repositories
{
    public class NeighborhoodsRepository : BaseRepository<Neighborhood>, INeighborhoodsRepository
    {
        protected NativoContext context;
        public NeighborhoodsRepository(NativoContext context):base(context)
        {
            this.context = context;
        }


        public List<PostalCodeDTO> getAllData()
        {
            List<PostalCodeDTO> data = this.context.Neighborhoods
                        .Include(e => e.Municipality)                        
                        .Select(s => new PostalCodeDTO
                        {
                            departament = s.Municipality.Departament.name,
                            municipality = s.Municipality.name,
                            zipCode = s.zipCode.ToString(),
                            neighborhood = s.name,
                            id = s.ID
                        }).ToList();

            return data;
        }

    }
}
