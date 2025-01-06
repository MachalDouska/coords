using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coords
{
    public class Coord : IEquatable<Coord>, IComparable<Coord>
    {
        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }
​
        public int X { get; set; } 
        public int Y { get; set; } 
        public double Size { get { return Math.Sqrt(X * X + Y * Y); } }
        public double Magnitude { get { return (X * X + Y * Y); } }

        public static bool operator +(Coord x,  Coord y)
        {

        }

        public bool Equals(Coord? other) {
            if(other == null)
        }

        public int CompareTo(Coord? other) {
            if (other.X == null || this.X == null || other.Y == null || this.Y == null)
        }
    }
}
