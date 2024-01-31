using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        public int value;

        public Coin(String Description, int score, int value)
        {
            this.Description = Description;
            this.Score = score;
            this.value = value;
        }

        public override void AddMe(List<Collectable> Collectables)
        {
            Collectables.Add(this);
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            UpdateTotalScore();
            UpdateTotalValue();
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += value;
            Console.WriteLine("Total Value is updated to : " + Board.TotalValue);
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }
    }
}
