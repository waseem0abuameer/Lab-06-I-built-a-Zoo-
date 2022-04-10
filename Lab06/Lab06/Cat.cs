using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class Cat : Mammal, IDisplay
    {
        public int hand { get ; set; }
        public string blooded { get; set; }
        public string BodyColor { get ; set; }
        public Cat(int hand ,string blooded ,string BodyColor)
        {
           this.hand = hand;
            this.blooded = blooded;
            this.BodyColor = BodyColor;

        }

        


        public override void Eat()
        {
            Console.WriteLine("Cat is Eating  Meet and dray Food");
        }
        public  string Eat1()
        {
           return("Cat is Eating  Meet and dray Food");
        }
        public override void Sleep()
        {
            Console.WriteLine("Cat is 5houer sleep...");
        }

        public override void Sound()
        {
            Console.WriteLine("Cat Sound meo meooo");
        }

        public void display()
        {
            Console.WriteLine(hand + " "+ blooded+" "+ BodyColor);
            Eat();
            Sound();
            Sleep();

        }

    }
}
