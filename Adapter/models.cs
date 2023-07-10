using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IGraph
    {
        void Point(double x, double y);
    }
    /*Adpaptee*/
    class PolarGraph
    {
        public void Point(double r, double t)
        {
            Console.WriteLine("Polar Coordinate Point: P(" + r + ", " + t + ")");
        }
    }
    //Adapter implement interface that client request
    class PolarGraphAdapter : IGraph
    {
        private readonly PolarGraph polarGraph;
        //pass request vao constructor
        public PolarGraphAdapter(PolarGraph polarGraph)
        {
            this.polarGraph = polarGraph;
        }

        public void Point(double x, double y)
        {
            //Re manipulate param that work with the target method : point
            double r = Math.Sqrt(x * x + y * y);
            double t = Math.Atan2(y, x);
            //call point method as requirement from client 
            polarGraph.Point(r, t);
        }
    }
}
