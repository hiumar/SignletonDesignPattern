using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public sealed class Signleton
    {
       private static int Counter = 0;
       private static Signleton instenace = null;
       private static readonly Object obj = new object();
       public static Signleton GetInstance
        {
            get
            {
                if (instenace == null)
                {
                    lock (obj)
                    {
                        if (instenace == null)
                            instenace = new Signleton();
                    }
                }
                return instenace;
               
            }
        }
       private  Signleton()
        {
            Counter++;
            Console.WriteLine("this is constructor"+Counter.ToString());

        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

  
}
