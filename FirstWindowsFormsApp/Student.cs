using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindowsFormsApp
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SectionName { get; set; }
        private byte _age;
        public byte Age
        {
            get
            {
                _age = Convert.ToByte(DateTime.Now.Year - DateOfBirth.Year);
                return _age;
            }
        }

        public bool doesEnrolledElective { get; set; }
        public List<string> EnrolledElectiveLectures { get; set; } = new List<string>();

        public override string ToString()
        {
            return this.Name + " " + this.Surname.ToUpper() + " " + Age + ", Enrolled Electives " + this.EnrolledElectiveLectures.Count; 
        }
    }
}
