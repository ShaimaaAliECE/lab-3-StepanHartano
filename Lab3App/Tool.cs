using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Tool : Collectable
    {
        public Tool(string Descripton) : base(Descripton) { }

        public abstract void DoAction();

        public override void AddMe(List<Collectable> collectable) {
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            DoAction();
        }

        
    }
}
