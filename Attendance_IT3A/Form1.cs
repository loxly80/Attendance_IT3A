using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_IT3A
{
    public partial class Form1 : Form
    {
        List<Person> people;
        List<Record> records;
        SqlRepository SqlRepository = new SqlRepository();

        public Form1()
        {
            InitializeComponent();
            SetButtons(false);
            people = SqlRepository.GetPeople();
            records = new List<Record>();
            foreach (Person person in people)
            {
                records.AddRange(person.Records);
            }
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            lboxAll.Items.Clear();
            lboxPerson.Items.Clear();
            lboxRecord.Items.Clear();
            foreach (Person person in people)
            {
                lboxPerson.Items.Add($"{person.PersonalNumber} - {person.Lastname} {person.Firstname}");
            }
            foreach (Record record in records.OrderByDescending(p => p.DateTime))
            {
                lboxAll.Items.Add($"{record.DateTime.ToString("dd.MM hh:mm")} - {record.Person.Lastname} - {record.Reason}");
            }
        }

        private void lboxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lboxPerson.SelectedIndex;
            if (index >= 0)
            {
                SetButtons(true);
                lboxRecord.Items.Clear();
                foreach (Record record in people[index].Records.OrderByDescending(p => p.DateTime))
                {
                    lboxRecord.Items.Add($"{record.DateTime} - {record.Reason}");
                }
            }
            else
            {
                SetButtons(false);
            }
        }

        private void SetButtons(bool enabled)
        {
            btnDoctorEnd.Enabled = enabled;
            btnDoctorStart.Enabled = enabled;
            btnPauseStart.Enabled = enabled;
            btnPauseEnd.Enabled = enabled;
            btnShiftStart.Enabled = enabled;
            btnShiftStop.Enabled = enabled;
        }

        private void btnShiftStart_Click(object sender, EventArgs e)
        {
            int index = lboxPerson.SelectedIndex;
            if (index >= 0)
            {
                Record newRecord = new Record()
                {
                    DateTime = DateTime.Now,
                    Person = people[index],
                    Reason = RecordReason.StartShift
                };
                records.Add(newRecord);
                people[index].Records.Add(newRecord);
                RefreshGUI();
            }
        }

        private void btnShiftStop_Click(object sender, EventArgs e)
        {

        }

        private void btnPauseStart_Click(object sender, EventArgs e)
        {

        }

        private void btnPauseEnd_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctorStart_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctorEnd_Click(object sender, EventArgs e)
        {

        }
    }
}
