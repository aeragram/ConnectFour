using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista wrzucanych tokenow
            List<string> tokenList = new List<string>() { "A_Red", "B_Yellow", "F_Red", "G_Yellow", "D_Red" };

            GameBoard gameBoard = new GameBoard();

            //wrzucamy kolejne tokeny do planszy
            for (int i = 0; i < tokenList.Count; i++)
            {
                gameBoard.InsertToken(tokenList[i]);
            }

        }
    }
}
