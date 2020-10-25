using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoYoTestApp.Core.Entities;
using YoYoTestApp.Core.Interfaces;
using YoYoTestApp.Infrastructure.Data;

namespace YoYoTestApp.Infrastructure.Repository
{
    public class ShuttleRepository : IShuttleRepository
    {
        public ShuttleRepository() 
        {
        
        }
        public async Task<IEnumerable<Shuttle>> GetAll()
        {
            JSONReadWrite readWrite = new JSONReadWrite();
            var shuttles = JsonConvert.DeserializeObject<List<Shuttle>>(readWrite.Read("fitnessrating_Beeptest.json"));
            return shuttles;
        }
    }
}
