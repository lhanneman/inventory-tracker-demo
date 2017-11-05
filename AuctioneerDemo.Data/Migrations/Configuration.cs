namespace AuctioneerDemo.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AuctioneerDemo.Entities;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<AuctioneerDemo.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AuctioneerDemo.Data.ApplicationDbContext context)
        {
            var equipment = new List<Equipment>
            {
                new Equipment() { Year = 1999, Make = "Rayco", Model = "RG50", Description = "[no description]"},
                new Equipment() { Year = 2006, Make = "International", Model = "4300", Description = "[no description]"},
                new Equipment() { Year = 2009, Make = "International", Model = "4300", Description = "[no description]"},
                new Equipment() { Year = 2014, Make = "John Deere", Model = "7000", Description = "[no description]"},
            };

            equipment.ForEach(e => context.Equipment.Add(e));
            context.SaveChanges();
        }
    }
}
