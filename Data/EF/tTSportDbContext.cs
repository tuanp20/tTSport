using Data.Configurations;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EF
{
    public class tTSportDbContext : DbContext
    {
        public tTSportDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DMBAIVIETConfiguration());
            modelBuilder.ApplyConfiguration(new DMKHACHHANGConfiguration());
            modelBuilder.ApplyConfiguration(new DMLOAIBAIVIETConfiguration());
            modelBuilder.ApplyConfiguration(new DMLOAIDICHVUConfiguration());
            modelBuilder.ApplyConfiguration(new KETBANConfiguration());
            modelBuilder.ApplyConfiguration(new KHACHHANGDICHVUConfiguration());
            modelBuilder.ApplyConfiguration(new MESSAGEConfiguration());
            modelBuilder.ApplyConfiguration(new MONTHETHAOConfiguration());
            modelBuilder.ApplyConfiguration(new NGUOIDUNGConfiguration());
            modelBuilder.ApplyConfiguration(new TAOGIAIConfiguration());
            modelBuilder.ApplyConfiguration(new THETHAONGUOIDUNGConfiguration());

            //Được dùng để seed Data 
            //modelBuilder.Seed();
        }

        public DbSet<DMBAIVIET> DMBAIVIETs { get; set; }
        public DbSet<DMKHACHHANG> DMKHACHHANGs { get; set; }
        public DbSet<DMLOAIBAIVIET> DMLOAIBAIVIETs { get; set; }
        public DbSet<KETBAN> KETBANs { get; set; }
        public DbSet<KHACHHANGDICHVU> KHACHHANGDICHVUs { get; set; }
        public DbSet<DMLOAIDICHVU> DMLOAIDICHVUs { get; set; }
        public DbSet<MESSAGE> MESSAGEs { get; set; }
        public DbSet<MONTHETHAO> MONTHETHAOs { get; set; }
        public DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public DbSet<TAOGIAI> TAOGIAIs { get; set; }
        public DbSet<THETHAONGUOIDUNG> THETHAONGUOIDUNGs { get; set; }
    }
}
