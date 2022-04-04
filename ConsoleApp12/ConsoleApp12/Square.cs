using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    public class Square:Figure
    {
        private int _side;
        public int Side
        {
            get
            {
                return _side;
            }

            set
            {
                if (value > 0)
                {
                    _side = value;
                }
            }
        }
        public override void CalcArea()
        {
            int sahe = _side * _side;
            Console.WriteLine($"kvadratin sahesi : {sahe}");

        }
    }
}
