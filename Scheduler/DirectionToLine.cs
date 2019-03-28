using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    //Line1 = North & South
    //Line2 = East & West
    //Line3 = East & West
    //Line4 = East & West

    public static class DirectionToLine
    {
        public static readonly List<string> NorthSouthLine = new List<string> { "Line1" };
        public static readonly List<string> EastWestLine = new List<string> { "Line2", "Line3", "Line4" };

        public enum Direction
        {
            North,
            South,
            East,
            West
        }

        public static List<string> ConvertToLines(Direction testDirection)
        {
            switch (testDirection)
            {
                case Direction.North:
                case Direction.South:
                    return NorthSouthLine;
                case Direction.East:
                case Direction.West:
                    return EastWestLine;
                default:
                    throw new Exception($"Unknown Directon {testDirection}");
            }
        }
    }
}
