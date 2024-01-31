using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond : Treasure
    {
        public Diamond(String Desciption, int score)
        {
            this.Description = Desciption;
            this.Score = score;
        }

        public override void Display()
        {
            Console.WriteLine("Diamond " + Description + " is displayed");
        }
    }
}
