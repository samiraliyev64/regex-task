using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    public class Rectangle:Figure
    {
        private int _side1;
        public int Side1 
        {
            get 
            {
                return _side1;
            } 
            
            set 
            {
                if (value > 0)
                {
                    _side1 = value;
                }
            } 
        }

        private int _side2;
        public int Side2
        {
            get
            {
                return _side2;
            }

            set
            {
                if(value > 0)
                {
                    _side2 = value;
                }
               
            }
        }

        public override void CalcArea()
        {
            int sahe = _side1 * _side2;
            Console.WriteLine($"duzbucaqlinin sahesi : {sahe}");
        }
    }
}
