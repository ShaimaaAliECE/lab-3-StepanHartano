using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        private int Value
        {
            get;
            set;
        }

        public Coin(string desc, int score, int value) : base(desc, score) { this.Value = value; }
            
        public override void AddMe(List<Collectable> collectable) { 
            base.AddMe(collectable);
            UpdateTotalValue(); 
        }

        public override void Display() { Console.WriteLine("Coin " + this.Description + " is displayed"); }
        public void UpdateTotalValue()
        {
            int currValue = Board.TotalValue += this.Value;
            Console.WriteLine("Total Value is updated to: " + currValue);
        }
    }
}
