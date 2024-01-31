using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : Displayable
    {
        public String Description;
        public CollectionBoard Board;
        
        public virtual void AddMe(List<Collectable> Collectables)
        {
            Collectables.Add(this);
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
        }

        public virtual void Display()
        {
        }
    }
}
