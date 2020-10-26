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

            CreateMap<Shuttle, ShuttleDto>()
                .ForMember(dest => dest.AccumulatedShuttleDistance,
                    opt => opt.MapFrom<AccumulatedShuttleDistanceResolver>())
                .ForMember(dest => dest.SpeedLevel,
                    opt => opt.MapFrom<SpeedLevelResolver>())
                .ForMember(dest => dest.ShuttleNo,
                    opt => opt.MapFrom<ShuttleNoResolver>())
                .ForMember(dest => dest.Speed,
                    opt => opt.MapFrom<SpeedResolver>())
                .ForMember(dest => dest.LevelTime,
                    opt => opt.MapFrom<LevelTimeResolver>())
                .ForMember(dest => dest.CommulativeTime,
                    opt => opt.MapFrom<CommulativeTimeResolver>())
                .ForMember(dest => dest.StartTime,
                    opt => opt.MapFrom<StartTimeResolver>())
                .ForMember(dest => dest.ApproxVo2Max,
                    opt => opt.MapFrom<ApproxVo2MaxResolver>());
        }

    }
    public class AccumulatedShuttleDistanceResolver : IValueResolver<Shuttle, ShuttleDto, int>
    {
        public int Resolve(Shuttle source, ShuttleDto dest, int member, ResolutionContext context)
        {
            if (source != null && !string.IsNullOrEmpty(source.AccumulatedShuttleDistance))
            {
                return Convert.ToInt32(source.AccumulatedShuttleDistance);
            }
            return 0;
        }
    }

    public class SpeedLevelResolver : IValueResolver<Shuttle, ShuttleDto, int>
    {
        public int Resolve(Shuttle source, ShuttleDto dest, int member, ResolutionContext context)
        {
            if (source != null && !string.IsNullOrEmpty(source.SpeedLevel))
            {
                return Convert.ToInt32(source.SpeedLevel);
            }
            return 0;
        }
    }

    public class ShuttleNoResolver : IValueResolver<Shuttle, ShuttleDto, int>
    {
        public int Resolve(Shuttle source, ShuttleDto dest, int member, ResolutionContext context)
        {
            if (source != null && !string.IsNullOrEmpty(source.ShuttleNo))
            {
                return Convert.ToInt32(source.ShuttleNo);
            }
            return 0;
        }
    }

    public class SpeedResolver : IValueResolver<Shuttle, ShuttleDto, float>
    {
        public float Resolve(Shuttle source, ShuttleDto dest, float member, ResolutionContext context)
        {
            float a;
            if (float.TryParse(source.LevelTime, out a))
                return float.Parse(source.Speed);
            else
                return 0;
        }
    }

    public class LevelTimeResolver : IValueResolver<Shuttle, ShuttleDto, float>
    {
        public float Resolve(Shuttle source, ShuttleDto dest, float member, ResolutionContext context)
        {
            if (source != null && !string.IsNullOrEmpty(source.LevelTime))
            {
                float a;
                if (float.TryParse(source.LevelTime, out a))
                    return float.Parse(source.LevelTime);
                else
                    return 0;
            }
            return 0;
        }
    }

    public class ApproxVo2MaxResolver : IValueResolver<Shuttle, ShuttleDto, float>
    {
        public float Resolve(Shuttle source, ShuttleDto dest, float member, ResolutionContext context)
        {
            if (source != null && !string.IsNullOrEmpty(source.ApproxVo2Max))
            {
                float a;
                if (float.TryParse(source.ApproxVo2Max, out a))
                    return float.Parse(source.ApproxVo2Max);
                else
                    return 0;
            }
            return 0;
        }
    }

    public class CommulativeTimeResolver : IValueResolver<Shuttle, ShuttleDto, TimeSpan?>
    {
        public TimeSpan? Resolve(Shuttle source, ShuttleDto dest, TimeSpan? member, ResolutionContext context)
        {
            TimeSpan? retVal;

            if (source != null && !string.IsNullOrEmpty(source.CommulativeTime))
            {
                TimeSpan interval;
                if (TimeSpan.TryParseExact(source.CommulativeTime, @"mm\:ss", null, out interval))
                {
                    retVal = interval;
                }
                else
                {
                    retVal = new TimeSpan(0, 0, 0, 0);
                }
            }
            else 
            {
                retVal = new TimeSpan(0, 0, 0, 0);
            }

            return retVal;
        }
    }

    public class StartTimeResolver : IValueResolver<Shuttle, ShuttleDto, TimeSpan?>
    {
        public TimeSpan? Resolve(Shuttle source, ShuttleDto dest, TimeSpan? member, ResolutionContext context)
        {
            TimeSpan? retVal;

            if (source != null && !string.IsNullOrEmpty(source.StartTime))
            {
                TimeSpan interval;
                if (TimeSpan.TryParseExact(source.StartTime, @"mm\:ss", null, out interval))
                {
                    retVal = interval;
                }
                else
                {
                    retVal = new TimeSpan(0, 0, 0, 0);
                }
            }
            else
            {
                retVal = new TimeSpan(0, 0, 0, 0);
            }

            return retVal;
        }
    }
}
