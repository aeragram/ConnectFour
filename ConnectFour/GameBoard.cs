using System;
using System.Collections.Generic;
using System.Linq;


namespace ConnectFour
{
    public class GameBoard
    {
        // game board array
        public byte[,] grid = new byte[6, 7];
        public byte winner = 0;

        Dictionary<char, byte> colNumber = new Dictionary<char, byte>()
        { { 'A', 0 }, { 'B', 1 }, { 'C', 2 }, { 'D', 3 }, { 'E', 4 }, { 'F', 5 }, { 'G', 6} };

        Dictionary<string, byte> plrNumber = new Dictionary<string, byte>()
        { { "Red", 1 }, { "Yellow", 2 }};
        
        // try to insert token
        public bool InsertToken(string token)
        {
            byte collumnNumber;

            if (!plrNumber.ContainsKey((token.Substring(2))))
            {
                Console.WriteLine("Błędnie wprowadzone oznaczenie gracza !");
                return false;
            }

            if (colNumber.ContainsKey(token.First()))
            {
                collumnNumber = colNumber[ token.First() ];
                if ( grid[5,collumnNumber] != 0)
                {
                    Console.WriteLine("Błędny ruch, kolumna jest już pełna !");
                    return false;
                }
                InsertTokenNow(collumnNumber, plrNumber[token.Substring(2)]);
            }
            else
            {
                Console.WriteLine("Błędne oznaczenie kolumny !");
                return false;
            }

            return true;
        }

        // insert token into 'grid' array
        private void InsertTokenNow(byte collumnNr, byte playerNr)
        {
            byte row = 0;

            do
            {
                if (grid[row, collumnNr] == 0)
                {
                    grid[row, collumnNr] = playerNr;
                    IsWinner();
                    break;
                }
                else
                {
                    row++;
                }
            } while (true);
        }

        // check if player wins
        private void IsWinner()
        {
            
        }

       

    }
}