using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoYoTestApp.Application.Dtos;
using YoYoTestApp.Core.Entities;

namespace YoYoTestApp.Application.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Shuttle, ShuttleDto>();
                //.ForMember(dest => dest.AccumulatedShuttleDistance,
                //    opt => opt.MapFrom(src => Convert.ToInt32(src.AccumulatedShuttleDistance)))
                //.ForMember(dest => dest.SpeedLevel,
                //    opt => opt.MapFrom(src => Convert.ToInt32(src.SpeedLevel)))
                //.ForMember(dest => dest.ShuttleNo,
                //    opt => opt.MapFrom(src => Convert.ToInt32(src.ShuttleNo)))
                //.ForMember(dest => dest.Speed,
                //    opt => opt.MapFrom(src => Convert.ToInt32(src.Speed)))
                //.ForMember(dest => dest.LevelTime,
                //    opt => opt.MapFrom(src => Convert.ToDouble(src.LevelTime)))
                //.ForMember(dest => dest.CommulativeTime,
                //    opt => opt.MapFrom(src => Convert.ToString(src.CommulativeTime)))
                //.ForMember(dest => dest.StartTime,
                //    opt => opt.MapFrom(src => Convert.ToString(src.StartTime)))
                //.ForMember(dest => dest.ApproxVo2Max,
                //    opt => opt.MapFrom(src => Convert.ToDouble(src.ApproxVo2Max)));
        }
    }
}
