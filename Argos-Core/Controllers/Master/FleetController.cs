using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argos.Core.Repository.IRepository.Master;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Argos_Core.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class FleetController : ControllerBase
    {
        private readonly IFleetRepository _fleetRepository;

        public FleetController(IFleetRepository fleetRepository)
        {
            _fleetRepository = fleetRepository;
        }

        public IActionResult GetFleets() 
        {
            var fleet = _fleetRepository.GetAll();
            return new JsonResult(fleet.ToList());
        }
    }
}