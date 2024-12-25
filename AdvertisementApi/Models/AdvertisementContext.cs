﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApi.Models
{
    public class AdvertisementContext : DbContext
    {
        public DbSet<Broadcast> Broadcasts { get; set; }
        public DbSet<AdvertisementOrder> AdvertisementOrders { get; set; }

        public AdvertisementContext(DbContextOptions<AdvertisementContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-VBHFI92; Initial Catalog=AdvertisementDb; TrustServerCertificate=Yes; Integrated Security=True");
    }

}
