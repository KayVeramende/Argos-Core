using System;
using System.Collections.Generic;
using System.Linq;
using Argos.Core.Model.Master;
using Argos.Core.Repository.IRepository.Master;
using Argos_Core.View;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Argos_Core.Controllers.Master
{
    
    [ApiController]
    [Route("api/fleets")]
    public class FleetController : ControllerBase
    {
        private readonly IFleetRepository _fleetRepository;
        private readonly IMapper _mapper;

        public FleetController(IFleetRepository fleetRepository, 
            IMapper mapper)
        {
            _fleetRepository = fleetRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<FleetViewModel>> GetFleets() 
        {
            var fleet = _fleetRepository.GetAll();
            return Ok(_mapper.Map<IEnumerable<FleetViewModel>>(fleet));
        }

        [HttpGet("{id}")]
        public IActionResult GetFleet(Guid id) 
        {
            if (!_fleetRepository.Exist(id)) return NotFound();
            var fleet = _fleetRepository.Get(id);
            return Ok(_mapper.Map<FleetViewModel>(fleet));
        }

        
    }
}