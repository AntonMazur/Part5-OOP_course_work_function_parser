using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class Point : ICloneable
    {
        private double[] coords;
        public readonly int dim;


        public double[] getCoords()
        {
            return (double[])coords.Clone();
        }       


        public Point(int dim)
        {
            this.dim = dim;
            coords = new double[dim];
            zeroInit();
        }


        public Point(params double[] args)
        {
            coords = args;
            dim = args.Count();
        }

        public void setCoord(int coordInd, double val)
        {
            if ((coordInd >= 0) && (coordInd < dim))
            {
                coords[coordInd] = val;
            }
            
        }


        public static Point operator +(Point p1, Point p2)
        {
            if (p1.dim != p2.dim)
            {
                throw new DimensionalityNotCoincideException(p1, p2);
            }

            double[] newCoords = new double[p1.dim];
            for (int i = 0; i < p1.dim; i++)
            {
                newCoords[i] = p1.coords[i] + p2.coords[i];
            }
            return new Point(newCoords);
        }

        public static Point operator -(Point p)
        {
            double[] newCoords = new double[p.dim];
            for (int i = 0; i < p.dim; i++)
            {
                newCoords[i] = -p.coords[i];
            }

            return new Point(newCoords);
        }

        public static Point operator -(Point p1, Point p2)
        {
            if (p1.dim != p2.dim)
            {
                throw new DimensionalityNotCoincideException(p1, p2);
            }

            double[] newCoords = new double[p1.dim];
            for (int i = 0; i < p1.dim; i++)
            {
                newCoords[i] = p1.coords[i] - p2.coords[i];
            }
            return new Point(newCoords);
        }


        public static double operator /(Point p1, Point p2)
        {
            if (p1.dim != p2.dim)
            {
                throw new DimensionalityNotCoincideException();
            }
            return norm(p1)/norm(p2);
        }


        public static Point operator /(Point p1, double val)
        {
            double[] newCoords = p1.getCoords();
            for (int i = 0; i < p1.dim; i++)
            {
                newCoords[i] /= val;
            }
            return new Point(newCoords);
        }


        public static Point operator *(double val, Point p1)
        {
            double[] newCoords = p1.getCoords();
            for (int i = 0; i < p1.dim; i++)
            {
                newCoords[i] *= val;
            }
            return new Point(newCoords);
        }


        public static double operator *(Point p1, Point p2)
        {
            double scalMult = 0;
            for (int i = 0; i < p1.dim; i++)
            {
                scalMult += p1.coords[i] * p2.coords[i];
            }
            return scalMult;
        }


        public static double norm(Point p1)
        {
            return Math.Sqrt(p1.coords.Sum(x => x * x));
        }

        public Object Clone()
        {
            return new Point(getCoords());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (double coord in coords)
                sb.Append(Math.Round(coord, 7) + "; ");
            sb.Remove(sb.Length - 2, 2);
            sb.Append("]");
            return sb.ToString();
        }


        public void zeroInit()
        {
            for (int i = 0; i < dim; i++)
            {
                coords[i] = 0;
            }
        }

        public static Point normalize(Point direction)
        {
            return direction / Point.norm(direction);
        }

    }
}
