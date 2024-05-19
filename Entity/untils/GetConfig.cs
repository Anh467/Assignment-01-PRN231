using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.untils
{
    internal class GetConfig
    {
        public static string GetConnectionString()
        {
            IConfiguration configuration= new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            if(configuration == null ) throw new ArgumentNullException(nameof(configuration));
            
            return configuration?.GetConnectionString("MSSQL");
        }

        public (string , string) GetAdminCredential()
        {
            IConfiguration configuration= new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) 
                .AddJsonFile("appsettings.json")
                .Build();
            string account = configuration["admin:account"];
            string pasword = configuration["admin:password"];
            return (account, pasword);  
        }
    }
}
