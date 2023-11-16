using System.Drawing;

namespace levelup
{
    public class Position
    {
        
        public Point PositionSet(int xPosition, int yPosition)
        {
            Point coordinates = new Point(xPosition, yPosition);
            return coordinates;
        }
    }
}