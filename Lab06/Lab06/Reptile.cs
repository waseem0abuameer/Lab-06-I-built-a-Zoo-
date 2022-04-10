using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{

   public abstract class Reptile : Animals
    {
        string length { get; set; }
       public abstract void crawling();
    }
}
