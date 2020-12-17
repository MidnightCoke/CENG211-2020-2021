using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    class Person
    {
        protected int age;
        public string Greet()
        {
            return "Hello\n";
        }
        public int SetAge(int n)
        {
            return age = n;
        }
    }
}