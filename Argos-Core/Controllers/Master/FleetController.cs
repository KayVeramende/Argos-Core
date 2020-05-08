using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argos.Core.Repository.IRepository.Master;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Argos_Core.Controllers.Master
{
    
    [ApiController]
    [Route("api/fleets")]
    public class FleetController : ControllerBase
    {
        private readonly IFleetRepository _fleetRepository;

        public FleetController(IFleetRepository fleetRepository)
        {
            _fleetRepository = fleetRepository;
        }

        [HttpGet]
        public IActionResult GetFleets() 
        {
            var fleet = _fleetRepository.GetAll();
            return Ok(fleet.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetFleet(Guid id) 
        {
            if (!_fleetRepository.Exist(id)) return NotFound();
            var fleet = _fleetRepository.Get(id);
            return Ok(fleet);
        }

        
    }
}