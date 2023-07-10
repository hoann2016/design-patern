using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridege
{
    interface Color
    {
        string GetColor();
    }

    class Blue : Color
    {
        public string GetColor()
        {
            return "Blue";
        }
    }

    class Red : Color
    {
        public string GetColor()
        {
            return "Red";
        }
    }

    abstract class Shape
    {
        public Color color { get; set; }

        public string GetColor()
        {
            return color.GetColor();
        }
    }

    class Square : Shape
    {

    }

    class Circle : Shape
    {

    }
}
