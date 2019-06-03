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

        public List<Child> GetChildren()
        {
            Child child;
            List<Child> children = new List<Child>();
            string stmt = "SELECT child.person_id, child.firstname FROM ((child_caregiver  INNER JOIN child ON child_caregiver.child_id = child.person_id)  INNER JOIN caregiver ON child_caregiver.caregiver_id = caregiver.person_id) WHERE caregiver.person_id = 4011";
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);

            conn.Open();

            var cmd = new NpgsqlCommand(stmt, conn);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                child = new Child()
                {
                    Id = reader.GetInt32(0),
                    Firstname = reader.GetString(1),
                };
                children.Add(child);


            }
            conn.Close();

            return children;
        }

        //METOD SOM HÄMTAR SCHEMA MED PERSON-ID
        //Skickar in personens id som parameter

        public List<Schedule> GetChildsSchedule(int id)
        {
            List<Schedule> schemor = new List<Schedule>();
            Schedule s;
            using (var conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM schedule WHERE person_id = @person_id ORDER BY date_id ASC"; //LIMIT 7? 
                    cmd.Parameters.AddWithValue("person_id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            s = new Schedule()
                            {
                                date_id = reader.GetDateTime(1),
                                weekday = reader.GetString(2),
                                breakfast = reader.GetBoolean(3),
                                attendance = reader.GetBoolean(9)
                            };
                            schemor.Add(s);


                        }

                    }
                }


                return schemor;
            }
        }
    }
}
