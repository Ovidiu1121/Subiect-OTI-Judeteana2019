using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subiect_OTI_judeteana2019.data;
using Microsoft.Extensions.Configuration;
using Subiect_OTI_judeteana2019.model;

namespace Subiect_OTI_judeteana2019.repository
{
    public class ImprumutRepository
    {
        private string connectionString;
        private DataAcces dataAcces;

        public ImprumutRepository()
        {
            this.dataAcces = new DataAcces();
            this.connectionString =GetConnection();

        }

        public List<Imprumut> getAllImprumuturi()
        {
            string sql = "select * from imprumuturi";

            return this.dataAcces.LoadData<Imprumut, dynamic>(sql, new { }, connectionString);
        }

        public string GetConnection()
        {
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration=new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            string connectionStringIs = configuration.GetConnectionString("Default");
            return connectionStringIs;
        }

    }
}
