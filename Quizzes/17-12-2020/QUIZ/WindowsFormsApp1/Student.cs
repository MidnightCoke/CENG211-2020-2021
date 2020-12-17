using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Student : Person
    {
        private string age_message;

        public string Study()
        {
            return "I'm Studying.";
        }
        public string ShowAge()
        {
            age_message = "My age is: " + age + " years old";
            return age_message;
        }
    }
}
