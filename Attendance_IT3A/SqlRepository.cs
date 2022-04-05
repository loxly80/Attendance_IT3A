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

                sqlConnection.Close();
            }

            return people;
        }
    }
}
