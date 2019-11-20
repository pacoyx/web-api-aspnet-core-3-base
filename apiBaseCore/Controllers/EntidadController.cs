using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;

namespace apiBaseCore.Controllers
{
    [Route("api/entidad")]
    [ApiController]
    public class EntidadController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public EntidadController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet, Authorize(Roles = "Manager")]
        public IActionResult GetAllEntidades()
        {
            try
            {
                var entidads = _repository.Entidad.GetAllEntidades();
                _logger.LogInfo($"Retorno todas las entidades de la BD.");

                var entidadsResult = _mapper.Map<IEnumerable<EntidadDto>>(entidads);
                return Ok(entidadsResult);

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllEntidades action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}