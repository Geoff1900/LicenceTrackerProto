using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LicenceTrackerProto.Data;
using LicenceTrackerProto.Models;
using Microsoft.EntityFrameworkCore;

namespace LicenceTrackerProto.Services
{
    public class LicenceService : ILicenceService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public LicenceService(ApplicationDbContext applicationContext)
        {
            _applicationDbContext = applicationContext;
        }
        public async Task<IEnumerable<Licence>> GetLicencesAsync()
        {
            return await _applicationDbContext.items.ToListAsync();
        }
    }
}
