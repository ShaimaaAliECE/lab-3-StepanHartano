using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand : Tool
    {
        public MagicWand(string desc) : base(desc) { }

        public override void DoAction() { base.DoAction(); }

        public override void Display()
        {
            Console.WriteLine("MagicWand " + this.Description + " is displayed");
        }

    }
}


