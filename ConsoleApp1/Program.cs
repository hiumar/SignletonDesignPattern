using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is used for multi threading
            //inviournment
            Parallel.Invoke(() => GetDeveloper(), () => GetStudent());
          
        }

        private static void GetDeveloper()
        {
            Signleton developer = Signleton.GetInstance;
            developer.PrintDetails("developer");
            Console.ReadLine();
        }

        private static void GetStudent()
        {
            Signleton signleton = Signleton.GetInstance;
            signleton.PrintDetails("This is student object class");
        }
    }
}
