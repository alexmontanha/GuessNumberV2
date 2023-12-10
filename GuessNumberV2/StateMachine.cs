using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberV2
{
    public class StateMachine
    {
        public enum State
        {
            Start,
            WaitingForPlayer,
            Guess,
            Win,
            Lose,
        }

        public State CurrentState { get; set; } = State.WaitingForPlayer;
        public string Message { get; set; } = "Welcome to the Guessing Game!";
        public int Guesses { get; set; } = 0;
        public int Guess { get; set; } = 0;
        public int Number { get; set; } = 0;
        public int Points { get; set; } = 0;
        public string Player { get; set; } = "";
        public Delegate? OnStart { get; set; }
        public Delegate? OnGuess { get; set; }
        public Delegate? OnWin { get; set; }
        public Delegate? OnLose { get; set; }

        public void Start(string player)
        {
            CurrentState = State.Guess;
            Message = "Welcome to the Guessing Game!";
            Guesses = 0;
            Guess = 0;
            Number = 0;
            Points = 0;
            Player = player;
            OnStart?.DynamicInvoke();
        }

        public void Update(string input)
        {
            switch (CurrentState)
            {
                case State.WaitingForPlayer:
                    Start(input);
                    break;
                case State.Guess:
                    if (int.TryParse(input, out int guess))
                    {
                        GuessNumber(guess);
                    }
                    else
                    {
                        Message = "Invalid input. Please enter a number between 1 and 1000.";
                    }
                    break;
                case State.Win:
                    Start(Player);
                    break;
                case State.Lose:
                    Start(Player);
                    break;
                default:
                    break;
            }
        }

        public void GuessNumber(int guess)
        {
            if (CurrentState != State.Guess)
            {
                throw new Exception("Invalid state");
            }
            Guess = guess;
            Guesses++;
            if (Guesses == 1)
            {
                Number = new Random().Next(1, 1000);
            }

            if (Guess == Number)
            {
                CurrentState = State.Win;
                Points = GetPoints();
                Message = $"Congratulations {Player}! You guessed the number in {Guesses} guesses and scored {Points} points!";
                OnWin?.DynamicInvoke();
            }
            else if (Guesses == 10)
            {
                CurrentState = State.Lose;
                Points = GetPoints();
                Message = $"Sorry {Player}! You did not guess the number in 10 guesses. You scored {Points} points.";
                OnLose?.DynamicInvoke();
            }
            else if (Guess < Number)
            {
                CurrentState = State.Guess;
                Message = $"Sorry {Player}! Your guess is too low. Try again.";
                OnGuess?.DynamicInvoke();
            }
            else if (Guess > Number)
            {
                CurrentState = State.Guess;
                Message = $"Sorry {Player}! Your guess is too high. Try again.";
                OnGuess?.DynamicInvoke();
            }
        }

        private int GetPoints()
        {
            return 1000 - Math.Abs(Guess - Number) + 100 * (10 - Guesses);
        }

    }
}
