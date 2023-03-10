using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    class Defender : FootballPlayer
    {
        private int positioning;
        private int head;
        private int bounce;

        public Defender(string fullName, int jerseyNumber)
        {
            this.fullName = fullName;
            this.jerseyNumber = jerseyNumber;
            this.speed = rand.Next(50, 90);
            this.durability = rand.Next(50, 90);
            this.passing = rand.Next(50, 90);
            this.shooting = rand.Next(50, 90);
            this.ability = rand.Next(50, 90);
            this.stability = rand.Next(50, 90);
            this.naturalForm = rand.Next(50, 90);
            this.chance = rand.Next(50, 90);

            this.positioning = rand.Next(50, 90);
            this.head = rand.Next(50, 90);
            this.bounce = rand.Next(50, 90);
        }

        public override Boolean pass()
        {
            int passScore = Convert.ToInt32((passing * 0.3) + (ability * 0.3) + (stability * 0.1) + (naturalForm * 0.1) + (positioning * 0.1) + (chance * 0.2));

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
            int shootScore = Convert.ToInt32((ability * 0.3) + (shooting * 0.2) + (stability * 0.1) + (naturalForm * 0.1) + (head * 0.1) + (bounce * 0.1) + (chance * 0.1));

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
