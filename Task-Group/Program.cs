using System;
using Task_Group.Models;

namespace Task_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Kamil Quliyev", "P224", 24);

            Console.WriteLine(stu1);
        }
    }
}
