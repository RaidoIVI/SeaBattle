using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal class RandomBoard
    {
        public Board Boards { get; }

        public RandomBoard (Rulls rulls)
        {
            Ship ship;
            Boards = new Board(rulls.GetSizeGameBoardX(), rulls.GetSizeGameBoardY());
            for (int i = rulls.GetShipTypeNumber(); i > 0 ; i--)
            {
                for (int j = rulls.GetShipNumber (i); j > 0 ; j--)
                {
                    do
                    {                        
                        ship = GetRandomShip(rulls, rulls.GetShipLeght(i));
                    }
                    while (!SetRandomShip(Boards, ship, rulls));
                }
            }
            
        }

        private Ship GetRandomShip (Rulls rulls, int shipLenght)
        {
            var rnd = new Random();
            var shipLocate = rnd.Next(11) % 2 == 0 ? ShipLocate.Vertical : ShipLocate.Horizontal   ;
            Ship ship = new Ship ( rnd.Next(rulls.GetSizeGameBoardX()) , rnd.Next(rulls.GetSizeGameBoardY()) , shipLenght , shipLocate);
            return ship;
        }
        private bool SetRandomShip(Board board, Ship ship, Rulls rulls)
        {
            return board.ShipAdd(ship, rulls);
        }
    }
}
