using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebApplication.Dao;
using WebApplication.Model;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateDatabase();
            CreateHostBuilder(args).Build().Run();
            
            
        }
        public static void CreateDatabase()
        {
            using (JdrContext context = new JdrContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.ApplyOptionChange();
                //context.Database.
                Object obj = new Objet();
                
                
                context.SaveChanges();
                //var jdrWithName = context.JdrTable.First();
                //Console.WriteLine(jdrWithName.Nom);
                //context.JdrTable.Remove(jdrWithName);
                /*
              context.JdrTable.Add(new Jdr
              {
                  Id = 1,
                  Nom = "nom",
                  IdMenber = 1
              });
              */
              context.SaveChanges();
            }
            
                
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });

      
    }
}