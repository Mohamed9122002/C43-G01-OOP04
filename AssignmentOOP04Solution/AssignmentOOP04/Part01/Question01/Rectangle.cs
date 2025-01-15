using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Part01.Question01
{
     class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        #region Constructor Overloading
        //A parameterless constructor that sets the width and height to 0.
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }
        //A constructor that accepts width and height as integers.
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        //A constructor that accepts a single integer and sets both width and height to that value.
        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        } 
        #endregion
    }
}
