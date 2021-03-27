using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonClass
    {
        private static SingletonClass instance;
        private SingletonClass()
        {
            Console.WriteLine("Created");
        }
        public static SingletonClass GetInstance()
        {
            Console.WriteLine("Called");
            if (instance == null)
            {
                instance = new SingletonClass();
            }

            return instance;
        }


    }
}
