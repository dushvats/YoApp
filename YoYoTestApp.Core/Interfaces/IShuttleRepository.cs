using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoYoTestApp.Core.Entities;

namespace YoYoTestApp.Core.Interfaces
{
    public interface IShuttleRepository
    {
        Task<IEnumerable<Shuttle>> GetAll();  
    }
}
