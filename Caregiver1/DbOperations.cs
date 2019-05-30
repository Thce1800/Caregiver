using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;

namespace Caregiver1
{
    class DbOperations
    {

        public List<Caregiver> GetAllCaregivers()
        {
            Caregiver cg;
            List<Caregiver> caregivers = new List<Caregiver>();

            string stmt = "SELECT * FROM caregiver";

            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);

            conn.Open();

            var cmd = new NpgsqlCommand(stmt, conn);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cg = new Caregiver()
                {
                    Id = reader.GetInt32(0),
                    Firstname = reader.GetString(2),
                    Lastname = reader.GetString(3),
                };
                caregivers.Add(cg);


            }
            conn.Close();

            return caregivers;

        }



    }
}
