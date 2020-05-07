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

        public void Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fleet> GetAll()
        {
            return _context.Fleets.ToList();
        }
    }
}
