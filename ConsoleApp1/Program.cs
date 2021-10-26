using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Signleton signleton = Signleton.GetInstance;
            signleton.PrintDetails("This is first signleton object");
           

            Signleton developer = Signleton.GetInstance;
            developer.PrintDetails("developer");
            Console.ReadLine();
        }
    }
}
