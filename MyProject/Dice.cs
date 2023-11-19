using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Dice
    {
        private Random random;

        private int sideNum;

        public Dice()
        {
            sideNum = 20;
            random = new Random();
        }

        public Dice(int sideNum)
        {
            this.sideNum = sideNum;
            random = new Random();
        }
        
        public int ReturnSideNum()
        { 
            return sideNum;
        }

        public int Roll()
        {
            return random.Next(1, sideNum + 1);
        }
    }
}
