using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYoTestApp.Application.Dtos;

namespace YoYoTestApp.Web.ViewModels
{
    public class YoYoTestViewModel
    {
        public List<ShuttleDto> Shuttles { get; set; }
        public int MaxValue { get; set; }
    }
}
