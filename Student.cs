using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220524_Classwork
{
    class Student
    {
        public string Name;
        public string Surname;
        public string Username;
        public string Password;

        public void GetData()
        {
            Console.WriteLine($"username = {Username}, password = {Password}");
        }
    }
}
