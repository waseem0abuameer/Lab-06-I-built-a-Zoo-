using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Lizard : Reptile, IDisplay
    {
        public string BodyColor { get; set; }
        public int hand { get; set; }
        public string blooded { get; set; }

        public Lizard(string BodyColor, int hand, string blooded)
        {
            this.BodyColor = BodyColor;
            this.hand = hand;
            this.blooded = blooded;

        }

        public override void crawling()
        {
            Console.WriteLine("Lizard can be crawling .....");
        }

        public override void Eat()
        {
            Console.WriteLine("Lizard is Eating Rabet and mouse");
        }

        public override void Sleep()
        {
            Console.WriteLine("Lizard is 5houer sleep...");

        }

        public override void Sound()
        {
            Console.WriteLine("Lizard Sound tss tsss.");
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
