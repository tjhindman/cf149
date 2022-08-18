/*
    1. Print every letter of the word "Supercalifragilisticexpialidocious" to the console, one at a time.

    2. Next, do the same, except only print the letter if it's an 'i'. If it's any other letter, print "Not an i".

    Bonus: After that, print the number of letters in the word (do this with code, not by counting manually and hard-coding the number).
    Another Bonus: In part 2, also determine if the letter is 'L'. If it is, print 'L'.
*/

string longString = "Supercalifragilisticexpialidocious";

int letterCount = 0;

foreach (char letter in longString)
{
    if (letter == 'i' || letter == 'l')
    {
        System.Console.WriteLine(letter);
    }
    else
    {
        System.Console.WriteLine("Not an i or l");
    }

    letterCount++;
}

System.Console.WriteLine(longString.Length);