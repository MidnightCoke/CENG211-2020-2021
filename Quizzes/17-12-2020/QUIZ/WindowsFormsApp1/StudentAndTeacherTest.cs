using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class StudentAndTeacherTest
    {
         void Main()
        {

            Person my_Person = new Person();
            my_Person.Greet();

            Student my_Student = new Student();
            my_Student.SetAge(21);
            my_Student.Greet();
            my_Student.ShowAge();

            Teacher my_Teacher = new Teacher();
            my_Teacher.SetAge(30);
            my_Teacher.Greet();
            my_Teacher.Explain();


        }
    }
}
