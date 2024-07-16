using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuestsForShabat.DAL;
using Microsoft.Extensions.Configuration;

namespace GuestsForShabat
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IConfiguration builder = new ConfigurationBuilder()
 .AddJsonFile("DAL/secrets.json", optional: true) // Add secrets.json
 .Build();
            string result = Seed.InitializeDB(builder["ConnectionString"]);
            if (result == "היה צורך")
            {
                throw new Exception(result);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HostForm(builder["ConnectionString"]));
        }
    }
}
