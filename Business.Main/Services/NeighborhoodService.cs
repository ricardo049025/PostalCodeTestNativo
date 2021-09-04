using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Models;
using Domain.Domain.Interfaces.Services;
using Domain.Domain.Interfaces;
using Infraestructure.Data.Repositories;
using Domain.Domain.Dto;
namespace Business.Main.Services
{
    public class NeighborhoodService : BaseService<Neighborhood>, INeighborhoodsService
    {
        protected INeighborhoodsRepository repository;

        public NeighborhoodService(INeighborhoodsRepository repository):base(repository)
        {
            this.repository = repository;
        }

        public List<PostalCodeDTO> getZipCodesDTO()
        {

            return this.repository.getAllData();
        }
    }
}
