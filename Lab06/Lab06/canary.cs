using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public  class canary : Bird, IDisplay
    {
        public string BodyColor { get; set; }
        public int hand { get; set; }
        public string blooded { get; set; }

        public canary(string BodyColor, int hand, string blooded)
        {
            this.BodyColor = BodyColor;
            this.hand = hand;
            this.blooded = blooded;

        }


        public override void Eat()
        {
            Console.WriteLine("canary is Eating .....");
        }

        public override void Sleep()
        {
            Console.WriteLine("canary is 5houer sleep...");

        }

        public override void Sound()
        {
            Console.WriteLine("canary Sound ....");
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
