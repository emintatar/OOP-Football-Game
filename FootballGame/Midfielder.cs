using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    class Midfielder : FootballPlayer
    {
        private int longBall;
        private int firstTouch;
        private int productivity;
        private int dribbling;
        private int specialAbility;

        public Midfielder(string fullName, int jerseyNumber)
        {
            this.fullName = fullName;
            this.jerseyNumber = jerseyNumber;
            this.speed = rand.Next(60, 100);
            this.durability = rand.Next(60, 100);
            this.passing = rand.Next(60, 100);
            this.shooting = rand.Next(60, 100);
            this.ability = rand.Next(60, 100);
            this.stability = rand.Next(60, 100);
            this.naturalForm = rand.Next(60, 100);
            this.chance = rand.Next(60, 100);

            this.longBall = rand.Next(60, 100);
            this.firstTouch = rand.Next(60, 100);
            this.productivity = rand.Next(60, 100);
            this.dribbling = rand.Next(60, 100);
            this.specialAbility = rand.Next(60, 100);
        }

        public override Boolean pass()
        {
            int passScore = Convert.ToInt32((passing * 0.3) + (ability * 0.2) + (specialAbility * 0.2) + (stability * 0.1) + (naturalForm * 0.1) + (longBall * 0.1) + (dribbling * 0.1) + (chance * 0.1));

            if (passScore > 60)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public override Boolean shoot()
        {
            int shootScore = Convert.ToInt32((ability * 0.3) + (specialAbility * 0.2) + (shooting * 0.2) + (firstTouch * 0.1) + (stability * 0.1) + (naturalForm * 0.1) + (chance * 0.1));

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
