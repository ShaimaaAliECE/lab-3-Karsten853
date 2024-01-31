using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        public int Score;

        public override void AddMe(List<Collectable> Collectables)
        {
            Collectables.Add(this);
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            UpdateTotalScore();
        }

        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }
    }
}
