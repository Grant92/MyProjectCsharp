using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Fighter
    {
        private string name;

        /// <summary>
        /// Is fighter id Dark side or Light side?
        /// </summary>
        private string allegiance;

        private int hp;

        private int maxHp;

        /// <summary>
        /// How much force fighter can use
        /// </summary>
        private int force;

        /// <summary>
        /// Demage when using force attack
        /// </summary>
        private int forceDmg;

        /// <summary>
        /// Defence against force attacks
        /// </summary>
        private int defenceForce;

        /// <summary>
        /// Demage when using base attack
        /// </summary>
        private int baseDmg;

        /// <summary>
        /// Defence against base attacks
        /// </summary>
        private int baseDefence;

        private Dice dice;

        public Fighter(string name, string allegiance, int hp, int force, int forceDmg, int defenceForce, int baseDmg, int baseDefence, Dice dice)
        {
            this.name = name;
            this.allegiance = allegiance;
            this.hp = hp;
            this.maxHp = hp;
            this.force = force;
            this.forceDmg = forceDmg;
            this.defenceForce = defenceForce;
            this.baseDmg = baseDmg;
            this.baseDefence = baseDefence;
            this.dice = dice;
        }
        public override string ToString()
        {
            return name;             
        }
        public bool Alive()
        {
            return (hp > 0);                
        }
        public string LifeBar()
        {
            string s = "|";
            int full = 100;
            double hpNum = Math.Round(((double)hp / maxHp) * full);
            if ((hpNum == 0) && (Alive()))
                hpNum = 1;
            for (int i = 0; i < hpNum; i++)
                s += "█";
            s = s.PadRight(full + 1);
            s += "|";
            return s;
        }
    }


}
