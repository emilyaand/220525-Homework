using System;

namespace _220524_Classwork
{
    class Program
    {
        public static object Username { get; private set; }

        public static void Main(string[] args)
        {
            Student Ali = new Student          
            {
                Name = "Ali",
                Surname = "Aliyev",
                Username = "Aali",
                Password = "a111",
                Grade 
            };
            Student Mammed = new Student
            {
                Name = "Mammed",
                Surname = "Mammedov",
                Username = "Mmammed",
                Password = "m111"
            };
            Student Qurban = new Student
            {
                Name = "Qurban",
                Surname = "Qurbanov",
                Username = "Qqurban",
                Password = "q111"
            };

            Student[] students = {Ali, Mammed, Qurban};

            Console.WriteLine("Please inter Username and Password: ");
            string studentusername = Console.ReadLine();
            string studentpassword = Console.ReadLine();

            bool flag = false; 
            foreach (Student student in students)
            {
                if (student.Username == studentusername)
                {
                    flag = true;
                    student.GetData();
                }
                if (!flag) Console.WriteLine(Grade);    
            }
        }
    }
}
