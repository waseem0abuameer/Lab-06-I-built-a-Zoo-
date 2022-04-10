using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public abstract class Mammal : Animals
    {
      
   

        public virtual void Brain ()
        {
            Console.WriteLine("Mammal is more clever ...");
        }       
    }
}
