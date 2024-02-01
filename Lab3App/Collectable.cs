using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public string Description;
        public CollectionBoard Board;
        public Collectable(string Description) {
            this.Description = Description;
        }

        

        public abstract void AddMe(List<Collectable> collectable);

        public virtual void Display() { }
        
    }
}
