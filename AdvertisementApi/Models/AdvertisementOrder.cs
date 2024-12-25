using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApi.Models
{
    public class AdvertisementOrder
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string BroadcastCode { get; set; }
        public string AdvertisementName { get; set; }
        public int Duration { get; set; }
        public decimal Cost { get; set; }
    }
}
