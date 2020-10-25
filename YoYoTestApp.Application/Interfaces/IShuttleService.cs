using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoYoTestApp.Application.Dtos;

namespace YoYoTestApp.Application.Interfaces
{
    public interface IShuttleService
    {
        Task<List<ShuttleDto>> GetAllShuttles();
        Task<int> MaxValueForTimer();
    }
}
