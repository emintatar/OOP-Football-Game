using System;
using System.Collections.Generic;
using System.Threading;

namespace FootballGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FootballPlayer> team = new List<FootballPlayer>();
            team.Add(new FootballPlayer("Manuel Neuer", 1));

            team.Add(new Defender("Virgil van Dijk", 2));
            team.Add(new Defender("Andrew Robertson", 3));
            team.Add(new Defender("João Cancelo", 4));
            team.Add(new Defender("Trent Alexander-Arnold", 5));

            team.Add(new Midfielder("Fabinho", 6));
            team.Add(new Midfielder("Georginio Wijnaldum", 7));
            team.Add(new Midfielder("Mohamed Salah", 8));
            team.Add(new Midfielder("Sadio Mané", 9));

            team.Add(new Striker("Roberto Firmino", 10));
            team.Add(new Striker("Cristiano Ronaldo", 11));

            Random rand = new Random();

            int jerseyNumber = rand.Next(1, 12);
            int passCheck = 12;
            Boolean shootState = true;
            
            for (int i = 1; i <= 3; i++)
            {
                while (passCheck == jerseyNumber)
                {
                    jerseyNumber = rand.Next(1, 12);
                }

                passCheck = jerseyNumber;

                if (!team[jerseyNumber - 1].pass())
                {
                    Console.WriteLine("Player number " + jerseyNumber + " pass failed!");
                    shootState = false;
                    break;
                }

                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Ball with " + "player number " + jerseyNumber);
                }
            }

            if (shootState == true)
            {
                if (team[jerseyNumber - 1].shoot()) 
                {
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Player number " + jerseyNumber + " Goallllll!!!!");
                }

                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Player number " + jerseyNumber + " shoot failed!");
                }
            }
        }
    }
}