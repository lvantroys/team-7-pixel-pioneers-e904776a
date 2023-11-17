using System.Drawing;

namespace levelup
{
    public class Position
    {
        internal Point coordinates;
       // private int yPosition;
    

        public Position(int xPosition, int yPosition)
        {
            coordinates = new Point(xPosition,yPosition);
        }

        public Point getCoordinates(){
            return coordinates;
        }
    }
}