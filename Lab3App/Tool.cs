using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Tool : Collectable
    {
        public override void AddMe(List<Collectable> Collectables)
        {
            Collectables.Add(this);
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            DoAction();
        }

        public virtual void DoAction()
        {
        }
    }
}
