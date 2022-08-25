using Internal;
using System;
public class ProgramUI {
    public void Run() {
        string gameSequence = File.ReadAllText("./game-sequence.txt");
        string[] sequenceArr = gameSequence.Split(',');

        int points = 5000;
        int lives = 3;
        // need to keep track of "Vulnerable" bird hunter point val
        int hunterPts = 200;

        // need to keep game running until lives are 0
        // while (lives > 0)
        // {
            foreach (string sequence in sequenceArr)
            {
                switch (sequence)
                {
                    case "InvincibleBirdHunter":
                    // changes text color in console output
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine($"{sequence} detected! Drofsnar has lost a life!");

                        lives--;
                        System.Console.WriteLine($"Remaining lives: {lives}");
                        break;
                    case "VulnerableBirdHunter":
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        System.Console.WriteLine($"{sequence} detected! Drofsnar gains {hunterPts} points!");
                        // adding current "hunterPts" total to Drofsnar point total
                        points += hunterPts;

                        hunterPts = hunterPts * 2;
                        break;
                    default:
                        break;
                }

                if (points == 10000)
                {
                    System.Console.WriteLine("10000 points reached! Life has been added!");
                    lives++;
                }
                
                if (lives == 0)
                {
                    System.Console.WriteLine($"Drofsnar has {lives} lives and wasn't able to complete the quest");
                    // "break" is needed to exit out of loop if this case is met!
                    break;
                }
            }

        // }

        // if (lives > 0)
        // {
        //     System.Console.WriteLine($"Drofsnar won with {lives} lives to spare!");
        //     System.Console.WriteLine($"Final points: {points}");
        // } else {
        // }
    }
}