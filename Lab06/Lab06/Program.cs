using System;

namespace Lab06
{



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Mammal====================");
           Cat alkeh = new Cat(4,"Hot","blacK");
            alkeh.display();
            Caw c1=new Caw(4, "Hot", "blacK and white");
            c1.display();
            Console.WriteLine("====================================");
            Console.WriteLine("===========Bird====================");
            LoveBirds l1 = new LoveBirds("hot", 2, "many color");
            l1.display();
            canary ca1 = new canary("hot ", 2, "many color");
            Console.WriteLine("====================================");
            Console.WriteLine("===========Reptil====================");
            snake s1 = new snake("cold", 0, "many color");
            s1.display();
            Lizard li1 = new Lizard("cold", 4, "move color");
            li1.display();

        }
    }
}
