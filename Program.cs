using System.Xml.Schema;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Data.SQLite;
using API.Database;
using API.Models;
using API.Models.Interfaces; 

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // string cs = @"URI=file:C:\source\repos\TAS-360-Feedback\TAS\feedback1.db";
        

            // using var con = new SQLiteConnection(cs);
            // con.Open();

            // string stm = "select SQLITE_VERSION()";

            // using var cmd = new SQLiteCommand(stm, con);
            // string version = cmd.ExecuteScalar().ToString();

            ISeedData saveObj = new SaveData();
            saveObj.SeedData();



            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
