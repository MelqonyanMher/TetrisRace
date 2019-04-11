using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;

namespace MyRace

{
    public class Point
    {
        public static Random rd = new Random();
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set
            {
                if (value > 0 && value < WindowWidth)
                    x = value;
                else if (value < 0) x = WindowWidth - 1;
                else if (value > WindowWidth - 1) x = 0;
            }

        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value > 0 && value < WindowHeight)
                    y = value;
                else if (value < 0) y = WindowHeight - 1;
                else if (value > WindowHeight - 1) y = 0;
            }

        }


        public Point(int x = 15, int y = 12)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return X + "\t" + Y;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }
    }
}
