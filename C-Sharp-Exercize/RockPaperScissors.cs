using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Exercize
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Create the player object
    //        Player p1 = new Player();

    //        p1.GetPlayerName();
    //        p1.NeedRules();

    //        //Create the Opponent object
    //        Opponent o1 = new Opponent();

    //        //start the game
    //        Game game = new Game();

    //        do
    //        {
    //            string playerDecision = p1.PlayerSelection();
    //            string opponentDecision = o1.OpponentSelection();

    //            Console.WriteLine("You chose {0}", playerDecision);
    //            Console.WriteLine("The Horde of Hamsters chose {0}", opponentDecision);
    //            game.WhoWins(playerDecision, opponentDecision);

    //        } while (game.PlayAgain());
    //    }
    //}


    // Student: Steven Martinez
    //
    // Genesis: I wanted to create a program that utilized multiple classes to operate. This is the first program I've written like this. 
    //
    // Summary: Plays Rock, Paper, Scissors. 
    //

    // create a class called player. This class will house all methods relating to the creation of the player and the 
    // player decisions for rules etc. 
    public class Player
    {
        string playerName;

        // first let's aske the player what his or her name is. We'll use console.readline to store the data in the variable. 
        // we'll also display a short informal greeting to the player. 
        public void GetPlayerName()
        {
            Console.Write("Please enter your name! ");
            playerName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to Rock, Paper, Scissors, {0}!", playerName);
        }

        // I wonder if the player needs to have any rules displayed for him or her. 
        // If the player needs rules displayed then input will refer to the rules posted below. 
        // you'll notice in the final "else" clause that the method refers to itseld to ensure 
        // proper information is input by the user. 

        public void NeedRules()
        {
            Console.WriteLine();
            Console.WriteLine(playerName + ", do you need a refresher on the rules?");
            Console.WriteLine("Press 'y' for yes or 'n' for no");
            Console.WriteLine();

            string rules = Console.ReadLine();

            // no need to display rules if the player already knows them. 
            if (rules == "n")
            {
                Console.WriteLine("Great! Let's play! ");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }

            // I think there is likely a better way to display data like this in the console. I just don't know what that method is yet. 
            // 
            else if (rules == "y")
            {
                Console.WriteLine(playerName + ", when prompted, you will type: ");
                Console.WriteLine();
                Console.WriteLine("'R' for Rock ");
                Console.WriteLine("'P' for Paper ");
                Console.WriteLine("'S' for Scissors ");
                Console.WriteLine();
                Console.WriteLine("Once you've made your selection, our horde of hamsters will make their own decision. ");
                Console.WriteLine();
                Console.WriteLine("Rock beats Scissors ");
                Console.WriteLine("Scissors beat Paper ");
                Console.WriteLine("Paper beats Rock ");
                Console.WriteLine();
                Console.WriteLine("It's just like the circle of life.");
                Console.WriteLine();
                Console.WriteLine("Press any key when ready to continue");
                Console.ReadLine();
            }

            // if the user input is invalid, display a message and rerun the method.
            else
            {
                Console.WriteLine("Please make a valid selection");
                NeedRules();
            }
        }

        // still in the player class, we want to allow the player to make a decision on whether they pick rock, paper or scissors
        public string PlayerSelection()
        {
            Console.WriteLine("Do you choose: ");
            Console.WriteLine();
            Console.WriteLine("The strength of Rock? Press 'r'. ");
            Console.WriteLine("The finesse of Paper? Press 'p'. ");
            Console.WriteLine("The sharpness of Scissors? Press 's'. ");
            Console.WriteLine();


            string playerChose = Console.ReadLine();
            string playerChoice;

            if (playerChose == "r")
            {
                playerChoice = "Rock";
                return playerChoice;
            }

            else if (playerChose == "p")
            {
                playerChoice = "Paper";
                return playerChoice;
            }

            else if (playerChose == "s")
            {
                playerChoice = "Scissors";
                return playerChoice;
            }


            // again the check for valid input and rerun the method if not correct

            else
            {
                Console.WriteLine("Please make a valid selection");
                PlayerSelection();
                return null;
            }
        }
    }

    // making a class for opponent choice. Since the opponent is a horde of robotic hamsters,
    // there's no need to get into too much detail. Basically we're going to grab a random
    // value from the string array called rps
    public class Opponent
    {
        public string OpponentSelection()
        {
            //use random to pull from Rock, Paper, Scissors.
            string[] rps = new string[] { "Rock", "Paper", "Scissors" };
            // create a new instance of the random class
            Random random = new Random();

            // pulls a random value between 0 and the length of rps array
            int index = random.Next(0, rps.Length);

            // returns the value at the index indicated by the random number.
            return rps[index];
        }
    }

    // this class is where we'll create the game. We'll do comparisons and keep score
    public class Game
    {
        //declare variables for keeping score.
        int playerScore = 0;
        int opponentScore = 0;
        int tieScore = 0;

        // whowins method does all comparisons
        public void WhoWins(string playerSelect, string opponentSelect)
        {
            //tie - iterate tiescore to keep track of number of ties
            if (playerSelect == opponentSelect)
            {
                Console.WriteLine("Game is a tie! ");
                tieScore++;
            }
            //hamsters win
            else if (playerSelect == "Rock" && opponentSelect == "Paper")
            {
                Console.WriteLine("The Horde of Hamsters Wins! ");
                opponentScore++;
            }

            else if (playerSelect == "Paper" && opponentSelect == "Scissors")
            {
                Console.WriteLine("The Horde of Hamsters Wins! ");
                opponentScore++;
            }

            else if (playerSelect == "Scissors" && opponentSelect == "Rock")
            {
                Console.WriteLine("The Horde of Hamsters Wins! ");
                opponentScore++;
            }

            //player win - in retrospect every other output besides what's listed above would occur in a 
            // player win condition. Keeping this here for education's sake.
            else if (playerSelect == "Rock" && opponentSelect == "Scissors")
            {
                Console.WriteLine("You Win! ");
                playerScore++;
            }

            else if (playerSelect == "Paper" && opponentSelect == "Rock")
            {
                Console.WriteLine("You Win! ");
                playerScore++;
            }

            else if (playerSelect == "Scissors" && opponentSelect == "Paper")
            {
                Console.WriteLine("You Win! ");
                playerScore++;
            }

            // print the score
            Console.WriteLine("Player Score = {0} ", playerScore);
            Console.WriteLine("Hamster Score = {0} ", opponentScore);
            Console.WriteLine("Tie Score = {0} ", tieScore);
        }

        // finally, does the player want to play again? 
        public bool PlayAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to play again? ");
            Console.WriteLine("Type 'y' for yes or 'n' for no. ");

            string playAgain = Console.ReadLine();

            if (playAgain == "y")
            {
                return true;
            }

            else if (playAgain == "n")
            {
                return false;
            }

            // if input is incorrect, we'll run the method again until proper input is received.
            else
            {
                Console.WriteLine("Please make a valid selection. ");
                PlayAgain();
                return true;
            }
        }
    }
}

// output for this program will be determined by the player playing the game. 

//Please enter your name! Amanda

//Welcome to Rock, Paper, Scissors, Amanda!

//Amanda, do you need a refresher on the rules?
//Press 'y' for yes or 'n' for no

//y
//Amanda, when prompted, you will type:

//'R' for Rock
//'P' for Paper
//'S' for Scissors

//Once you've made your selection, our horde of hamsters will make their own decision.

//Rock beats Scissors
//Scissors beat Paper
//Paper beats Rock

//It's just like the circle of life.

//Press any key when ready to continue

//Do you choose:

//The strength of Rock? Press 'r'.
//The finesse of Paper? Press 'p'.
//The sharpness of Scissors? Press 's'.

//r
//You chose Rock
//The Horde of Hamsters chose Rock
//Game is a tie!
//Player Score = 0
//Hamster Score = 0
//Tie Score = 1

//Do you want to play again?
//Type 'y' for yes or 'n' for no.
//y
//Do you choose:

//The strength of Rock? Press 'r'.
//The finesse of Paper? Press 'p'.
//The sharpness of Scissors? Press 's'.

//s
//You chose Scissors
//The Horde of Hamsters chose Paper
//You Win!
//Player Score = 1
//Hamster Score = 0
//Tie Score = 1

//Do you want to play again?
//Type 'y' for yes or 'n' for no.
//n
//Press any key to continue . . .


