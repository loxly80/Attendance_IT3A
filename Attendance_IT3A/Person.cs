using System;
using System.Collections.Generic;
using System.Text;

namespace Attendance_IT3A
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PersonalNumber { get; set; }
        public string ChipId { get; set; }
        public List<Record> Records { get; set; }

        public Person()
        {
            Records = new List<Record>();
        }
    }
}
