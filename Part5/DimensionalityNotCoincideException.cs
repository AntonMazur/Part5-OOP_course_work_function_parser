using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class DimensionalityNotCoincideException : Microsoft.CSharp.RuntimeBinder.RuntimeBinderException
    {

        public DimensionalityNotCoincideException() : this(null, null, "") { }


        public DimensionalityNotCoincideException(string msg) : this(null, null, msg) { }


        public DimensionalityNotCoincideException(Point p1, Point p2) : this(p1, p2, "") { }


        public DimensionalityNotCoincideException(Point p1, Point p2, string msg)
            : base("Dimesion not coincide:\n dim 1-st point: " +
                  p1 == null ? "unknown " : p1.dim +
                  "dim 1-st point: " +
                  p2 == null ? "unknown " : p2.dim +
                  msg) { }
    }
}
