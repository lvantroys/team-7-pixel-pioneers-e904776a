using NUnit.Framework;
using levelup;
using System.Drawing;

namespace levelup
{
    public class MockCharacter : Character
    { 
     public new string getName()
     {
        return "MockCharacterName";
     }  
     public Point getPosition()
     {
        return new Point(1,1);
     }

     public int getMaxCount()
     {
        return 23;
     }

    } 
}