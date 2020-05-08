using Argos.Core.Data;
using Argos.Core.Model.Master;
using Argos.Core.Repository.IRepository.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Argos.Core.Repository.Master
{
    public class FleetRepository : IFleetRepository
    {
        private readonly ArgosDbContext _context;


        public FleetRepository(ArgosDbContext context)
        {
            _context = context;
        }

        public Guid Add(Fleet fleet)
        {
            _context.Add(fleet);
            return fleet.Id;
        }

        public bool Exist(Guid id)
        {
            return _context.Fleets.Any(x => x.Id.Equals(id));
        }

        public Fleet Get(Guid id)
        {
            return _context.Fleets.Find(id);
        }

        public IEnumerable<Fleet> GetAll()
        {
            return _context.Fleets.ToList();
        }
    }
}
