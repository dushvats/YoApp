using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoYoTestApp.Application.Dtos;
using YoYoTestApp.Application.Interfaces;
using YoYoTestApp.Application.Mapper;
using YoYoTestApp.Core.Entities;
using YoYoTestApp.Core.Interfaces;

namespace YoYoTestApp.Application.Services
{
    public class ShuttleService : IShuttleService
    {
        private readonly IShuttleRepository _shuttleRepository;
        private readonly IMapper _mapper;
        public ShuttleService(IShuttleRepository shuttleRepository, IMapper mapper)
        {
            _shuttleRepository = shuttleRepository;
            _mapper = mapper;
        }
        public async Task<List<ShuttleDto>> GetAllShuttles()
        {
            var shuttles = await _shuttleRepository.GetAll();
            var shuttleDtos = _mapper.Map<List<Shuttle>, List<ShuttleDto>>(shuttles.ToList());
            return shuttleDtos.OrderBy(x => x.StartTime).ToList();
        }
        public async Task<int> MaxValueForTimer()
        {
            int maxValue = 15;
            var shuttles = GetAllShuttles().Result;
            var lastStartTime = shuttles.LastOrDefault().StartTime;
            maxValue = lastStartTime.HasValue ? Convert.ToInt32(lastStartTime.Value.TotalSeconds) : 0;
            return maxValue;
        }

    }
}
