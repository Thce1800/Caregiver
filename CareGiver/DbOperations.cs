using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;

namespace CareGiver
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
        public List<Child> GetChildren(int id)
        {
            Child child;
            List<Child> children = new List<Child>();
            using (var conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT child.person_id, child.firstname FROM ((child_caregiver  INNER JOIN child ON child_caregiver.child_id = child.person_id)  INNER JOIN caregiver ON child_caregiver.caregiver_id = caregiver.person_id) WHERE caregiver.person_id = @person_id";
                    cmd.Parameters.AddWithValue("person_id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            child = new Child()
                            {
                                Id = reader.GetInt32(0),
                                Firstname = reader.GetString(1),
                            };
                            children.Add(child);


                        };

                    }
                }


                return children;
            }

        }
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
        public List<Date> Dates(int id)
        {
            List<Date> dates = new List<Date>();
            Date d;
            using (var conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM schedule WHERE person_id = @person_id ORDER BY date_id ASC";
                    cmd.Parameters.AddWithValue("person_id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            d = new Date()
                            {
                                date_id = reader.GetDateTime(1),
                                weekday = reader.GetString(2),
                            };
                            dates.Add(d);


                        }

                    }
                }


                return dates;
            }
        }
        public Child GetChildById(int id)
        {
            Child c = new Child();
            using (var conn = new
                NpgsqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM child WHERE person_id = @person_id";

                    cmd.Parameters.AddWithValue("person_id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            c.Id = reader.GetInt32(0);
                            c.Firstname = reader.GetString(3);

                        }
                    }
                }
                return c;
            }
        }



        public void UpdateSchedule(int id, DateTime date, int att, string weekday)
        {
            using (var conn = new
            NpgsqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE schedule SET (date_id, nonattendance_id) = " +
                                      "(@date_id, @nonattendance_id) WHERE person_id = @person_id and weekday = @weekday";
                    cmd.Parameters.AddWithValue("person_id", id);
                    cmd.Parameters.AddWithValue("date_id", date);
                    cmd.Parameters.AddWithValue("nonattendance_id", att);
                    cmd.Parameters.AddWithValue("weekday", weekday);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int UpdateNonAttendance(int personId, string typeId)
        {
            using (var conn = new
            NpgsqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
            {
                int nonAttId = 0;
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO non_attendance VALUES (default, @type_id, @person_id) RETURNING nonattendance_id";

                    cmd.Parameters.AddWithValue("person_id", personId);
                    cmd.Parameters.AddWithValue("type_id", typeId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nonAttId = reader.GetInt32(0);
                        }
                        return nonAttId;

                    }
                }
            }
        }
    }
}
