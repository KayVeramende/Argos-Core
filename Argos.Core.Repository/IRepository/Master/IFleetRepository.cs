using Argos.Core.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace Argos.Core.Repository.IRepository.Master
{
    public interface IFleetRepository
    {
        Guid Add(Fleet fleet);
        IEnumerable<Fleet> GetAll();
        void Get(Guid id);
    }
}
