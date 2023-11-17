using System.Drawing;

namespace levelup 
{
    public class GameMap 
    {
        public int numPositions = 100;
        public Position [,] positions;

        public GameMap()
        {
           positions = new Position [10,10];
        }
        public Position [,] GetPositions()
        {
            return positions;
        }
        public Position calculatePosition(Position startingPosition, GameController.DIRECTION direction)
        {
            Position newPosition = new Position(1,1);
            if(isPositionValid(newPosition.getCoordinates()) == true)
            {
                return newPosition;
            }
            else
            {
                return startingPosition;
            }
        }

         public bool isPositionValid(Point positionCoordinates)
        {        
            return false;
        }
    }
}