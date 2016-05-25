using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2.Models
{
    public class GameTModel
    {
       

        public char[] Board { get; set; } = new char[10];
        public char Player { get; set; }
        public int Turn { get; set; } = 2;
        public string Result { get; set; }
        public bool Win = false;


        public void PlayerTurn()
        {
            if (Turn % 2 == 0)
            {
                Player = 'X'; // player one 
            }
            else if (Turn % 2 == 1)
            {
                Player = 'O'; //player two 
            }
        }
        public void PlayLogic(int userInput)
        {
            PlayerTurn();
            Board[userInput] = Player;
            Turn++;
            CheckWin(Player);
        }


        public void CheckWin(char player)
        {

            if ((Board[1] == player && Board[2] == player && Board[3] == player) || (Board[4] == player && Board[5] == player && Board[6] == player)
              || (Board[7] == player && Board[8] == player && Board[9] == player) // Rows 
               || (Board[1] == player && Board[4] == player && Board[7] == player) || (Board[2] == player && Board[5] == player && Board[8] == player)
              || (Board[3] == player && Board[6] == player && Board[9] == player) // column
             || (Board[1] == player && Board[5] == player && Board[9] == player) || (Board[3] == player && Board[5] == player && Board[7] == player)) // cross line 
            {
                Result = $"Player  {Player} Win";
                Win = true;

            }
            else
            {
                Result = "Tie";
            }
        }
    }
}
