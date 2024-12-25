using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApi.Models
{
    public static class SeedData
    {
        public static void SeedDatabase(AdvertisementContext context)
        {
            context.Database.Migrate();
            if (context.Broadcasts.Count() == 0 && context.AdvertisementOrders.Count() == 0)
            {
                // Исходные данные для таблицы "Регистрация передач"
                var broadcasts = new List<Broadcast>
                {
                    new Broadcast { BroadcastCode = "BC001", AdvertisementName = "Реклама 1", PricePerUnitTime = 100m },
                    new Broadcast { BroadcastCode = "BC002", AdvertisementName = "Реклама 2", PricePerUnitTime = 150m },
                    new Broadcast { BroadcastCode = "BC003", AdvertisementName = "Реклама 3", PricePerUnitTime = 200m },
                    new Broadcast { BroadcastCode = "BC004", AdvertisementName = "Реклама 4", PricePerUnitTime = 250m },
                    new Broadcast { BroadcastCode = "BC005", AdvertisementName = "Реклама 5", PricePerUnitTime = 300m },
                    new Broadcast { BroadcastCode = "BC006", AdvertisementName = "Реклама 6", PricePerUnitTime = 350m },
                    new Broadcast { BroadcastCode = "BC007", AdvertisementName = "Реклама 7", PricePerUnitTime = 400m }
                };

                context.Broadcasts.AddRange(broadcasts);
                context.SaveChanges();

                // Исходные данные для таблицы "Регистрация заказов на рекламу"
                var advertisementOrders = new List<AdvertisementOrder>
                {
                    new AdvertisementOrder { Company = "Фирма 1", BroadcastCode = "BC001", AdvertisementName = "Реклама 1", Duration = 30, Cost = 3000m },
                    new AdvertisementOrder { Company = "Фирма 2", BroadcastCode = "BC002", AdvertisementName = "Реклама 2", Duration = 45, Cost = 6750m },
                    new AdvertisementOrder { Company = "Фирма 3", BroadcastCode = "BC003", AdvertisementName = "Реклама 3", Duration = 60, Cost = 12000m },
                    new AdvertisementOrder { Company = "Фирма 4", BroadcastCode = "BC004", AdvertisementName = "Реклама 4", Duration = 90, Cost = 22500m },
                    new AdvertisementOrder { Company = "Фирма 5", BroadcastCode = "BC005", AdvertisementName = "Реклама 5", Duration = 120, Cost = 36000m },
                    new AdvertisementOrder { Company = "Фирма 6", BroadcastCode = "BC006", AdvertisementName = "Реклама 6", Duration = 150, Cost = 52500m },
                    new AdvertisementOrder { Company = "Фирма 7", BroadcastCode = "BC007", AdvertisementName = "Реклама 7", Duration = 180, Cost = 72000m },
                    new AdvertisementOrder { Company = "Фирма 8", BroadcastCode = "BC001", AdvertisementName = "Реклама 1", Duration = 210, Cost = 21000m },
                    new AdvertisementOrder { Company = "Фирма 9", BroadcastCode = "BC002", AdvertisementName = "Реклама 2", Duration = 240, Cost = 36000m },
                    new AdvertisementOrder { Company = "Фирма 10", BroadcastCode = "BC003", AdvertisementName = "Реклама 3", Duration = 270, Cost = 54000m },
                    new AdvertisementOrder { Company = "Фирма 11", BroadcastCode = "BC004", AdvertisementName = "Реклама 4", Duration = 300, Cost = 75000m },
                    new AdvertisementOrder { Company = "Фирма 12", BroadcastCode = "BC005", AdvertisementName = "Реклама 5", Duration = 330, Cost = 99000m },
                    new AdvertisementOrder { Company = "Фирма 13", BroadcastCode = "BC006", AdvertisementName = "Реклама 6", Duration = 360, Cost = 126000m },
                    new AdvertisementOrder { Company = "Фирма 14", BroadcastCode = "BC007", AdvertisementName = "Реклама 7", Duration = 390, Cost = 156000m },
                    new AdvertisementOrder { Company = "Фирма 15", BroadcastCode = "BC001", AdvertisementName = "Реклама 1", Duration = 420, Cost = 42000m }
                };

                context.AdvertisementOrders.AddRange(advertisementOrders);
                context.SaveChanges();
            }
        }
    }
}
