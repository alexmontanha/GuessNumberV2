# GuessNumberV2

## Description
Sample project to demonstrate the use of a simple game state machine.

## Requirements
* .NET 8.0 LTS
* Visual Studio 2022

## How to run
* Open the solution in Visual Studio 2022
* Build the solution
* Run the project
* Follow the instructions on the Window
* Enjoy!

## Specifications and Rules
This is a simple game where the user has to guess a number between 1 and 1000. The user has 10 attempts to guess the number. If the user guesses the number correctly, the game ends and the user wins. If the user does not guess the number correctly after 10 attempts, the game ends and the user loses.
           
### Game Rules
    1) The user has 10 attempts to guess the number.
    2) The user can only enter numbers between 1 and 1000.
    3) The user can only enter numbers.
    4) After 10 attempts, the game ends and the user loses.
    5) If the user guesses the number correctly, the game ends and the user wins.
    6) The user is informed if the guess is too high or too low.
    7) Points are awarded based on the number of attempts.
    8) The user can restart the game at any time.
    9) The user can quit the game at any time.
    10) The points are calculated in the end of the game: (1000 - (Module of Best Guess - Number)) + ((10 - Guesses) * 100)

### Game States Machine
```C#
State.Start // Initial State
State.WaitingForPlayer // Waiting for the player to enter a name
State.Guess // Waiting for the player to enter a guess
State.Win // The player guessed the number correctly
State.Lose // The player did not guess the number correctly
```
