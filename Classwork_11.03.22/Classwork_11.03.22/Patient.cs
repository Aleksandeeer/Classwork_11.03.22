using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classwork_11._03._22
{
    public class Patient
    {
        private string name;
        private string surname;
        private string diagnosis;
        private string gender;
        private string history;
        private Image photo;
        private DateTime date;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value;}
        }
        public Image Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string History
        {
            get { return history; }
            set { history = value; }
        }
    }
}
