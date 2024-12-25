using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApi.Models
{
    public class Broadcast
    {
        public int Id { get; set; }
        public string BroadcastCode { get; set; }
        public string AdvertisementName { get; set; }
        public decimal PricePerUnitTime { get; set; }
    }
}
