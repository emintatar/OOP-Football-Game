using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    class FootballPlayer
    {
        internal Random rand = new Random();
        protected string fullName;
        protected int jerseyNumber;
        protected int speed;
        protected int durability;
        protected int passing;
        protected int shooting;
        protected int ability;
        protected int stability;
        protected int naturalForm;
        protected int chance;

        public FootballPlayer(string fullName, int jerseyNumber)
        {  
            this.fullName = fullName;
            this.jerseyNumber = jerseyNumber;
            this.speed = rand.Next(50, 100);
            this.durability = rand.Next(50, 100);
            this.passing = rand.Next(50, 100);
            this.shooting = rand.Next(50, 100);
            this.ability = rand.Next(50, 100);
            this.stability = rand.Next(50, 100);
            this.naturalForm = rand.Next(50, 100);
            this.chance = rand.Next(50, 100);
        }

        public FootballPlayer()
        {
            
        }

        public virtual Boolean pass()
        {
            int passScore = Convert.ToInt32((passing * 0.3) + (ability * 0.3) + (stability * 0.1) + (naturalForm * 0.1) + (chance * 0.2));
            
            if (passScore > 60)
            {
                              return true;
            }

            else
            {
                return false;
            }
        }

        public virtual Boolean shoot()
        {
            int shootScore = Convert.ToInt32((ability * 0.3) + (shooting * 0.2) + (stability * 0.1) + (naturalForm * 0.1) + (speed * 0.1) + (chance * 0.2));
            
            if (shootScore > 70) 
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
