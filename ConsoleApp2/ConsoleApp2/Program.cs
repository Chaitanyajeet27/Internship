using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp2
{
    internal class Program
    {
            //public static void operation(int i , int y )
            //{
            //    Console.WriteLine($"Addition =  {i + y}");
            //    Console.WriteLine($"Difference  {i - y}");
            //    Console.WriteLine($"Product =  {i * y}");
            //    Console.WriteLine($"Division =  {i / y}");
            //}
              
            //public static void operation(double i , double y )
            //{
            //    Console.WriteLine($"Addition =  {i + y}");
            //    Console.WriteLine($"Difference  {i - y}");
            //    Console.WriteLine($"Product =  {i * y}");
            //    Console.WriteLine($"Division =  {i / y}");
            //}
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello, \rWorld!");
            ////String last_name = "Singh";
            ////Console.WriteLine("Chaitanya Jeet " + last_name);
            ////Console.WriteLine("Enter your title Mr or mrs");
            ////String prefix = Console.ReadLine();
            ////Console.WriteLine(prefix+" Chaitanya Jeet "+last_name);
            ////Console.ReadKey(); 
            //Console.WriteLine("Triangle Hypoteneuse calc");
            //Console.WriteLine("Enter the base");
            //Double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the height");
            //Double h = Convert.ToDouble(Console.ReadLine());

            //Double hy = Math.Pow(b,2) + Math.Pow(h,2);

            //Console.WriteLine($"The hypotenuous is {hy:f2}");


            //}



            //<-----------------------------------Day-2------------------------------------->



            //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            //foreach (int i in numbers)
            //{
            //    Console.Write(i);


            //}


            //            Exercise 1: Multi - Dimensional Array Iteration(The Grid)
            //Scenario: You are building a seating chart for a small theater.The theater has 3 rows, and each row has 4 seats.

            //Create a 2D array(int[,]) to represent the theater.

            //Initialize the seats with ticket prices: Row 0 costs $10, Row 1 costs $20, and Row 2 costs $30.

            //Use nested for loops to print out the pricing grid.


            //int[,] seating = { { 10,10,10,10},
            //                   {20,20,20,20 },
            //                   { 30,30,30,30}
            //                                };
            //for(int i = 0; i<3;i++) 
            //{
            //    for(int j = 0; j < 4; j++)
            //    {       
            //        Console.Write(seating[i,j]+ "\t");
            //    }
            //    Console.WriteLine("\n");


            //}


            //METHOD OVERLOADING


            //operation(10.2, 2.3);




            //<---------------------------------------------------Day-3------------------------------------------------------->



            //BASIC OBJECT AND CLASS IMPLEMENTATION

            //Human human = new Human { name ="Chaitanya"};

            // human.Eat();
            // human.Sleep();

            // Human human2 = new Human { name = "Dhruv" };

            // human2.Eat();
            // human2.Sleep();





            //CONSTRUCTOR IMPLEMENTATION

            Students st = new Students("Chaitanya", 20);
            Students st2 = new Students("Dhruv", 22);



            Console.ReadKey();

        }
    }

    //public class Human
    //{
    //    public string? name;

    //    public void Eat()
    //    {
    //        Console.WriteLine($"{name} is eating");

    //    }

    //    public void Sleep()
    //    {
    //        Console.WriteLine($"{name} is sleeping");

    //    }
    //}

    public class Students 
    {
        public string? name;
        public int age;
       public  Students(string name, int age)
        {
            this.name = name;
            this.age = age;

            Data(name, age);

        }

        void Data(string name, int age)
        {
            Console.WriteLine($"Name of the Student : {name } \n Age : {age}");
        }
    }
}
