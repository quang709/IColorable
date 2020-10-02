using System;
using System.Collections.Generic;
using System.Text;

namespace interface_IColorable
{
    public class Shape : IColorable
    {
        private string color = "green";
        private bool filled = true;

        public Shape()
        {
        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public bool isFilled()
        {
            return filled;
        }

        public void setFilled(bool filled)
        {
            this.filled = filled;
        }

        public override string ToString()
        {
            return "A Shape with color of "
                    + getColor()
                    + " and "
                    + (isFilled() ? "filled" : "not filled");
        }
        public virtual void HowToColor() { }
        public virtual string Name()
        {
            return "";
        }

        internal bool GetArea()
        {
            throw new NotImplementedException();
        }
    }
}