using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoYoTestApp.Application.Dtos
{
    public class ShuttleDto
    {
        public int AccumulatedShuttleDistance { get; set; }
        public int SpeedLevel { get; set; }
        public int ShuttleNo { get; set; }
        public float Speed { get; set; }
        public float LevelTime { get; set; }
        public TimeSpan? CommulativeTime { get; set; }
        public TimeSpan? StartTime { get; set; }
        public float ApproxVo2Max { get; set; }
    }
}
