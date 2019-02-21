using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LicenceTrackerProto.Models;


namespace LicenceTrackerProto.Services
{
    public class FakeLicenceService : ILicenceService
    {


        public Task<IEnumerable<Licence>> GetLicencesAsync()
        {
            var item1 = new Licence() { ID = Guid.NewGuid(), User = "Geoff", LicenceKey = "VS_123" };
            var item2 = new Licence() { ID = Guid.NewGuid(), User = "Geoff", LicenceKey = "VS_123" };
            var items = new List<Licence>() { item1, item2 };

            /*  Need to explicitly specify <IEnumerable<Licence>> on the Task.FromResult 
             *  This satisfies the complier and the the method signature. 
             *  Otherwise the complier complains it can't covert a List to an IEnumerable.
             *  Thanks https://stackoverflow.com/questions/37439166/how-to-mock-a-method-returning-taskienumerablet-with-tasklistt/37439472
             *
             */
            return Task.FromResult<IEnumerable<Licence>>(items);

        }
        public Task<bool> AddNewLicence(Licence licence)
        {
            return Task.FromResult(true);
        }
    }
}
