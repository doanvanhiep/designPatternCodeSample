using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass s1 = SingletonClass.GetInstance();
            SingletonClass s2 = SingletonClass.GetInstance();
            Console.ReadKey();
            
        }
    }
}
