using System;
using Sytem.Collections.Generic;

namespace MyApplication {
    public class GuessTheNumber
    {
    int secretNumber = 42;
    int userNumber;

    Console.WriteLine("Guess the number I'm thinking between 1 and 100");
    while (userNumber != secretNumber)
    {
        Console.WriteLine("Enter your guess:");
        userGuess = int.Parse(Console.ReadLine());

    if (userGuess<secretNumber)
    {
        Console.WriteLine("Too Low! Try again!");
    }
    else if(userGuess>secretNumber)
    {
        Console.WriteLine("Too High! Try again");
    }
    }
    }
}
