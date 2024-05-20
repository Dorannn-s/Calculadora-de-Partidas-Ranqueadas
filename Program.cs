using System;
using System.Collections;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int wins = 200;
            int losses = 100;
            int winBalance = wins - losses;
            int balanceCategory;
            string ranking;
            int level = 10;
            string username = "Unknown";


            
            if (winBalance <= 10)
            {
                balanceCategory = 1;
            }
            else if (winBalance >= 11 && winBalance <= 20)
            {
                balanceCategory = 2;
            }
            else if (winBalance >= 21 && winBalance <= 50)
            {
                balanceCategory = 3;
            }
            else if (winBalance >= 51 && winBalance <= 80)
            {
                balanceCategory = 4;
            }
            else if (winBalance >= 81 && winBalance <= 90)
            {
                balanceCategory = 5;
            }
            else if (winBalance >= 91 && winBalance <= 100)
            {
                balanceCategory = 6;
            }
            else if (winBalance >= 101)
            {
                balanceCategory = 7;
            }
            else
            {
                balanceCategory = default; //Undefined
            }

                switch (balanceCategory)
                {
                    case 1:
                        ranking = "Iron Ranking";
                        Console.WriteLine(username + " is currently at " + ranking);
                        break;
                    case 2:
                        ranking = "Bronze Ranking";
                         Console.WriteLine(username + " is currently at " + ranking);

                        break;
                    case 3:
                        ranking = "Silver Ranking";
                        Console.WriteLine(username + " is currently at " + ranking);
                        break;
                    case 4:
                        ranking = "Gold Ranking";
                        Console.WriteLine(username + " is currently at " + ranking);
                        break;
                    case 5:
                        ranking = "Diamond Ranking";
                         Console.WriteLine(username + " is currently at " + ranking);
                        break;
                    case 6:
                        ranking = "Legends Ranking";
                        Console.WriteLine(username + " is currently at " + ranking);
                        break;
                    case 7:
                        ranking = "Immortals Ranking";
                        Console.WriteLine(username + " is currently at " + ranking);
                        break;
                    default:
                        ranking = "Rank indefinido";
                        Console.WriteLine(username + " doesn't have a ranking.");
                        break;
                }

            Console.WriteLine(username + " is at " + ranking  + " with a " + winBalance + " win balance while in level " + level + "." );
        }
    }
}
