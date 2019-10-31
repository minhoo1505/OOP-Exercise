using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRectangle
{
    class Rectangle
    {
        private float Length;
        private float Width;

        public Rectangle()
        {
            Length = 1.0f;
            Width = 1.0f;
        }
        public Rectangle(float Length, float Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public float getLength()
        {
            return Length;
        }
        public void setLength(float newLength)
        {
            Length = newLength;
        }
        public float getWidth()
        {
            return Width;
        }
        public void setWidth(float newWidth)
        {
            Width = newWidth;
        }
        public double getArea()
        {
            return Length * Width;
        }
        public double getPerimater()
        {
            return (Width + Length) * 2;
        }
        public override string ToString()
        {
            return string.Format("The rectangle has a Length is: {0}  \nWidth is: {1} \nAre is: {2} \nPerimeter is: {3}", getLength(), getWidth(), getArea(), getPerimater());
        }
    }
}