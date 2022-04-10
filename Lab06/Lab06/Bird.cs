using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public abstract class Bird : Animals
    {
        public  void Fly()
        {
            Console.WriteLine("Bird can by fly ");
        }
    }
}
