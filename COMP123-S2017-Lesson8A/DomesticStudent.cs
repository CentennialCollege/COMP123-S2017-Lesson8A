using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2017_Lesson8A
{
    public class DomesticStudent : Student
    {
        // PUBLIC PROPERTIES

        public string DomesticAddress { get; set; }

        // CONSTRUCTORS ---------------------------

        public DomesticStudent(string name, int age, string studentID)
            :base(name, age, studentID)
        {
            this.DomesticAddress = "Unknown";
        }
        
    }
}