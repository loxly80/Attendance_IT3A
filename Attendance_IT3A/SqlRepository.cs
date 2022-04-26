using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Attendance_IT3A
{
    public class SqlRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Attendance_IT3A; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private List<Person> TempPeople()
        {
            List<Person> people = new List<Person>();
            Person person1 = new Person()
            {
                Id = 1,
                ChipId = "123456789",
                Firstname = "John",
                Lastname = "Doe",
                PersonalNumber = "0001011111"                
            };
            Person person2 = new Person()
            {
                Id = 2,
                ChipId = "234567891",
                Firstname = "Pepa",
                Lastname = "Zdepa",
                PersonalNumber = "9007193123"
            };
            people.Add(person1);
            people.Add(person2);
            return people;
        }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();            
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using(SqlCommand sqlCommand = new SqlCommand("select * from Person",sqlConnection))
                {
                    using(SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            people.Add(new Person()
                            {
                                Id = Convert.ToInt32(dataReader["IdPerson"]),
                                Firstname = dataReader["FirstName"].ToString(),
                                Lastname = dataReader["LastName"].ToString(),
                                PersonalNumber = dataReader["PersonalNumber"].ToString(),
                                ChipId = dataReader["ChipId"].ToString()
                            });
                        }
                    }
                }
                sqlConnection.Close();
            }
            var records = GetRecords();

            return people;
        }

        private List<Record> GetRecords()
        {
            List<Record> records = new List<Record>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("select * from Record", sqlConnection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            records.Add(new Record()
                            {
                                Id = Convert.ToInt32(dataReader["IdPerson"]),
                                DateTime = Convert.ToDateTime(dataReader["FirstName"].ToString()),
                                Reason = (RecordReason)Convert.ToInt32(dataReader["LastName"].ToString()),
                                Guid = Guid.Parse(dataReader["PersonalNumber"].ToString())                                
                            });
                        }
                    }
                }
                sqlConnection.Close();
            }
            return records;
        }


    }
}
