using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatAccsesLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
             Server=192.168.1.203;Database=dbTrv;User ID=cogurcu;Password=deneme;Trusted_Connection=False
             */
            optionsBuilder.UseSqlServer("Server=192.168.1.203;Database=dbTrv2;User ID=cogurcu;Password=deneme;Trusted_Connection=False");
        }

        public DbSet<about> abouts { get; set; }
        public DbSet<about2> about2s { get; set; }
        public DbSet<altHakkinda> altHakkindas { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<oneCikanlar> oneCikanlars { get; set; }
        public DbSet<onecikanlar2> onecikanlar2s { get; set; }
        public DbSet<referanslar> referanslars { get; set; }
        public DbSet<reshberler> reshberlers { get; set; }
        public DbSet<yeniHaberler> yeniHaberlers { get; set; }
    }
}