using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        Board board;

        public void NewGame()
        {
            GenerateBoard();
            PlaceShips();
            RunGame();
            DetermineWinner();
        }
        private void GenerateBoard()
        {
            board = new Board();
        }
        private void PlaceShips()
        {
            
        }

        private void RunGame()
        {

        }

        private void DetermineWinner()
        {

        }
    }
}
