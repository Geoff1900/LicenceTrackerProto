using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LicenceTrackerProto.Models;

namespace LicenceTrackerProto.Services
{
    public class LicenceService : ILicenceService
    {
        public Task<IEnumerable<Licence>> GetLicencesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
