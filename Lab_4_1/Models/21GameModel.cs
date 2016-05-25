using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_1.Models
{
   public class _21GameModel
    {
        public bool ComputerWin = false;
        public int CurrentNumber { get; set; }

        public int UserInput { get; set; }

        public int UserInputLogic()
        {
            CurrentNumber += UserInput;
            return CurrentNumber;

        }

        public int ResponseLogic()
        {
            Random rand = new Random();
            int response = rand.Next(1, 3);
            if (CurrentNumber == 19)
            {
                response = 2;
            }
            else if (CurrentNumber == 20)
            {
                response = 1;
            }
            if (CurrentNumber + response == 21)
            {
                ComputerWin = true;
            }

            CurrentNumber += response;
            return CurrentNumber;
        }

        public bool WinLogic()
        {
            if (CurrentNumber >= 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
