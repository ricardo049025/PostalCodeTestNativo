using Domain.Domain.Dto;
using Domain.Domain.Interfaces.Services;
using Domain.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNativo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostalCodeController : ControllerBase
    {
        
        private readonly ILogger<PostalCodeController> _logger;
        private readonly INeighborhoodsService service;
        public PostalCodeController(ILogger<PostalCodeController> logger, INeighborhoodsService service)
        {
            _logger = logger;
            this.service = service;
        }

        [HttpGet]
        [Route("getCodigos")]
        public IEnumerable<PostalCodeDTO> Get()
        {
            List<PostalCodeDTO> dto = this.service.getZipCodesDTO();

            return dto;
            
        }
    }
}
