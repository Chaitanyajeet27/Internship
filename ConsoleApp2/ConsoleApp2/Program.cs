namespace ConsoleApp2
{
    internal class Program
    {
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


            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            foreach (int i in numbers)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
