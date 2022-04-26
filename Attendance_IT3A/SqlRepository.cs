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
            var records = GetRecords(people);

            return people;
        }

        private List<Record> GetRecords(Dictionary<int,Person> people)
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
                            var record = new Record()
                            {
                                Id = Convert.ToInt32(dataReader["IdRecord"]),
                                DateTime = Convert.ToDateTime(dataReader["DateTime"].ToString()),
                                Reason = (RecordReason)Convert.ToInt32(dataReader["Reason"].ToString()),
                                Guid = Guid.Parse(dataReader["Guid"].ToString()),
                                Person = people[Convert.ToInt32(dataReader["IdPerson"])]
                            };
                            record.Person?.Records.Add(record);
                            records.Add(record);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return records;
        }

        public void SavePerson()
        {
        }

        public void SaveRecord(Record record)
        {
            if (record.Id == 0)
            {
                InsertRecord(record);
            }
            else
            {
                UpdateRecord(record);
            }
        }

        private void UpdateRecord(Record record)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = $"update Record set Reason=@Reason,DateTime=@DateTime,IdPerson=@IdPerson where IdRecord={record.Id}";
                    sqlCommand.Parameters.AddWithValue("Reason", record.Reason);
                    sqlCommand.Parameters.AddWithValue("DateTime", record.DateTime);
                    sqlCommand.Parameters.AddWithValue("IdPerson", record.Id);
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

        private void InsertRecord(Record record)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = "insert into Record(Reason,DateTime,Guid,IdPerson) values(@Reason,@DateTime,@Guid,@IdPerson);";
                    sqlCommand.CommandText += " select top 1 IdRecord from Record where Guid=@Guid";
                    sqlCommand.Parameters.AddWithValue("Reason",record.Reason);
                    sqlCommand.Parameters.AddWithValue("DateTime", record.DateTime);
                    sqlCommand.Parameters.AddWithValue("Guid", record.Guid);
                    sqlCommand.Parameters.AddWithValue("IdPerson", record.Person.Id);
                    record.Id =  Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
                sqlConnection.Close();
            }
        }
    }
}
