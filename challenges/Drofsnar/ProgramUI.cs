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
                    case "Bird":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine("It's a bird! 10 points added!");

                        points += 10;
                        System.Console.WriteLine($"Point total: {points}");
                        break;
                    case "EveningGrosbeak":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine($"{sequence} detected! 1000 points added!");

                        points += 1000;
                        System.Console.WriteLine($"Point total: {points}");
                        break;
                    case "GreaterPrairieChicken":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine($"{sequence} detected! 2000 points added!");

                        points += 2000;
                        System.Console.WriteLine($"Point total: {points}");
                        break;
                    case "IcelandGull":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine($"{sequence} detected! 3000 points added!");

                        points += 3000;
                        System.Console.WriteLine($"Point total: {points}");
                        break;
                    case "CrestedIbis":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine($"{sequence} detected! 100 points added!");

                        points += 100;
                        System.Console.WriteLine($"Point total: {points}");
                        break;
                    case "GreatKiskudee":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine($"{sequence} detected! 300 points added!");

                        points += 300;
                        System.Console.WriteLine($"Point total: {points}");
                        break;
                    case "RedCrossbill":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine($"{sequence} detected! 500 points added!");

                        points += 500;
                        System.Console.WriteLine($"Point total: {points}");
                        break;
                    case "Red-neckedPhalarope":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine($"{sequence} detected! 700 points added!");

                        points += 700;
                        System.Console.WriteLine($"Point total: {points}");
                        break;
                    case "Orange-belliedParrot":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        System.Console.WriteLine($"{sequence} detected! 5000 points added!");

                        points += 5000;
                        System.Console.WriteLine($"Point total: {points}");
                        break;
                    default:
                        break;
                }

                if (points > 10000 && points < 12000)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("10000 points reached! Life has been added!");
                    lives++;
                }
                
                if (lives == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine($"Drofsnar has {lives} lives and wasn't able to complete the quest");
                    // "break" is needed to exit out of loop if this case is met!
                    break;
                }
            }

        // }

        if (lives > 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine($"Drofsnar won with {lives} lives to spare!");
            System.Console.WriteLine($"Final points: {points}");
        }
    }
}