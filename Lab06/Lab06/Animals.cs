using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public abstract class Animals: IِAnimals
    {
        private string name;

        public abstract void Eat();      

      
        public abstract void Sleep();    

        public abstract void Sound();
        
    }
  
}
