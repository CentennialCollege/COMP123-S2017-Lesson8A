using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson8A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("-------------");
            Console.WriteLine();

            Person person = new Person("Tom", 25);
            person.Talks();

            Student student = new Student("John", 19, "123456789A");
            student.Studies();
            student.Talks();

            DomesticStudent domestic = new DomesticStudent("Mary", 21, "123456788B");
            domestic.Talks();
        }
    }
}
