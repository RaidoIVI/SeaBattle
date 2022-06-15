//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace SeaBattle
{
    public class Rulls
    {
        private const int _sizeGameBoardX = 10;
        private const int _sizeGameBoardY = 10;
        private const int _collisionRadius = 1;
        private const int _shipTypeNumber = 4;



        public int GetShipNumber(int numberOfType)
        {
            if (numberOfType <= _shipTypeNumber && numberOfType > 0)
            {
                return numberOfType;
            }
            return 0;

        }

        public int GetShipLeght(int numberOfType)
        {
            if (numberOfType <= _shipTypeNumber && numberOfType > 0)
            {
                return _shipTypeNumber - numberOfType + 1;
            }
            return 0;
        }

        public int GetShipTypeNumber()
        {
            return _shipTypeNumber;
        }
        public int GetCollisionRadius()
        {
            return _collisionRadius;
        }
        public int GetSizeGameBoardX()
        {
            return _sizeGameBoardX;
        }
        public int GetSizeGameBoardY()
        {
            return _sizeGameBoardY;
        }
    }
}
