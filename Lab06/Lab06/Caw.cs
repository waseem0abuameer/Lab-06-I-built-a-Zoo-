using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Caw : Mammal, IDisplay
    {
        public string BodyColor { get ; set; }
        public int hand { get; set; }
        public string blooded { get ; set; }
        public Caw(int hand, string blooded, string BodyColor)
        {
            this.hand = hand;
            this.blooded = blooded;
            this.BodyColor = BodyColor;

        }

        public override void Eat()
        {
            Console.WriteLine("Caw is Eating  grass ");
        }
        public override void Sleep()
        {
            Console.WriteLine("Caw is 6 houer sleep...");
        }

        public override void Sound()
        {
            Console.WriteLine("Caw Sound haa haaa haa");
        }

        public void display()
        {
            Console.WriteLine(hand + " " + blooded + " " + BodyColor);
            Eat();
            Sound();
            Sleep();

        }
    }
}
