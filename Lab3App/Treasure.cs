using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {

        private int Score
        {
            get; 
            set; 
        }

        public Treasure(string desc, int score) : base(desc) { this.Score = score; }

        public override void AddMe(List<Collectable> collectable)
        {
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            UpdateTotalScore();
        }

        public void UpdateTotalScore() {
            //Console.WriteLine($"Score: {Score}");
            int currScore = Board.TotalScore += this.Score;
            Console.WriteLine("Total Score is updated to: " + currScore);
        }



    }
}
