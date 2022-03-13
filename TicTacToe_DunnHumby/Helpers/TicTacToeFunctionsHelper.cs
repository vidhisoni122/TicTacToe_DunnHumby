using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_DunnHumby.Helpers
{
    public static class TicTacToeFunctionsHelper
    {
        public static int CheckWin(this char[] arr)  
        {
            if(arr.Length < 9)
            {
                return -1;
            }

            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }

        public static void DisplayOutPut(this char[] arr)
        {
            Console.WriteLine("  {0}    {1}    {2}", arr[1].ToResult(), arr[2].ToResult(), arr[3].ToResult());
            Console.WriteLine("  {0}    {1}    {2}", arr[4].ToResult(), arr[5].ToResult(), arr[6].ToResult());
            Console.WriteLine("  {0}    {1}    {2}", arr[7].ToResult(), arr[8].ToResult(), arr[9].ToResult());
        }

        private static char ToResult(this char c)
        {
            if (c == 'O' || c == 'X')
            {
                return c;
            }
            else
            {
                return '-';
            }
        }
    }
}
