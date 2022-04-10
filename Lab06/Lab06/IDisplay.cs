using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal interface IDisplay
    {
        public string BodyColor { get; set; }
        public int hand { set; get; }
        public string blooded { set; get; }
        public void display();
    }
}
