using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Part01.Question03
{
     class Complex
    {
        #region Properties
        public int Real { get; set; }
        public int Img { get; set; } 
        #endregion


        #region Operator Overloading
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Img = (left?.Img ?? 0) + (right?.Img ?? 0)
            };
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Img = (left?.Img ?? 0) - (right?.Img ?? 0)
            };
        }
        #endregion
        #region Method
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
        #endregion
    }
}
