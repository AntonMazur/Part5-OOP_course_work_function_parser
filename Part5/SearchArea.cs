using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class SearchArea
    {
        private static Random randomizer = new Random();

        private (double, double)[] restrictions;
        private int dimensionality;

        public SearchArea((double, double)[] restrictions)
        {
            this.restrictions = restrictions;
            this.dimensionality = restrictions.Count();
        }

        public Point[] generateRandomPoints(int count)
        {
            Point[] points = new Point[count];
            
            for (int i = 0; i < count; i++)
            {

                double[] pointCoords = new double[dimensionality];
                for (int j = 0; j < dimensionality; j++)
                {
                    pointCoords[j] = random(restrictions[j]);
                }

                points[i] = new Point(pointCoords);
            }

            return points;
        }

        public Point[] generateEvenDistributionPoints(int count)
        {
            var evenDistr = new Point[count];

            throw new NotImplementedException();
        }

        public bool isBelong(Point p)
        {
            var coords = p.getCoords();

            for (int i = 0; i < coords.Length; i++)
            {
                if (restrictions[i].Item1 > coords[i] || restrictions[i].Item2 < coords[i]) return false;
            }

            return true;
        }

        private static double random((double, double) range)
        {
            return range.Item1 + randomizer.NextDouble() * (range.Item2 - range.Item1);
        }
    }
}
