using LicenceTrackerProto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicenceTrackerProto.Services
{
    public interface ILicenceService
    {
        Task<IEnumerable<Licence>> GetLicencesAsync();

        Task<bool> AddNewLicence(Licence licence);
    }
}
