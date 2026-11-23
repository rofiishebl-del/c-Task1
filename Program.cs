using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please , Enter your name:");
            string name;
            name=Console.ReadLine();
            Console.Write("Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your salary : ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Enter your gender (M / F) :");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Enter total sales : ");
            int totalsales = int.Parse(Console.ReadLine());
            Console.Write("Enter number of days : ");
            int NDay= int.Parse(Console.ReadLine());
            float average =( (float)totalsales / NDay);
            Console.WriteLine("================= Employee's information ===============");
            Console.WriteLine($"Name is : {name}");
            Console.WriteLine($"Age is : {age}"); 
            Console.WriteLine($"Salary is : {salary}");
            Console.WriteLine($"Gender is : {gender}");
            Console.WriteLine($"Daily sales average : {average}");



        }
    }
}

