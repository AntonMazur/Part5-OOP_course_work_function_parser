using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    struct Interval
    {
        public double a;
        public double b;

        public Interval(double a, double b)
        {
            if (a > b)
            {
                double temp = a;
                this.a = b;
                this.b = temp;
            }
            else
            {
                this.a = a;
                this.b = b;
            }
        }
    }

    class OneDimMinFinder
    {
        private const double EPS = 1e-7;
        private const double DELTA = EPS * 0.1;
        private const int MAX_ITER = 30;



        private Point startPoint;
        private Point direction;
        private FunctionParser fPars;

        public OneDimMinFinder(Point sPoint, Point dir, FunctionParser fP) : this(fP)
        {
            this.startPoint = sPoint;
            this.direction = dir;
        }

        public OneDimMinFinder(FunctionParser fP)
        {
            this.fPars = fP;
        }

        public OneDimMinFinder setStartPoint(Point sPoint)
        {
            this.startPoint = sPoint;
            return this;
        }

        public OneDimMinFinder setDirection(Point dir)
        {
            this.direction = dir;
            return this;
        }

        public Point findMin()
        {
            Interval interv = swan(0, 0.01);
            double step = dichtomy(interv.a, interv.b, 0);
            return startPoint + step * direction;
        }

        public double func(double step)
        {
            return fPars.computeFuncVal((startPoint + step * direction).getCoords());
        }

        public Interval swan(double startP, double h)
        {
            double prevP;
            double currP;

            // defining function monotony
            if (func(startP) < func(startP + h))
            {
                h = -h;
            }
            // save old argument value
            prevP = startP;
            currP = startP + h;
            // check criteria of search ending
            while (func(currP) < func(prevP))
            {
                h *= 2;
                prevP = currP;
                currP += h;
            }
            // create struct object that keep interval limit points
            return new Interval(prevP - h / 2, currP);
        }

        double dichtomy(double a, double b, int iter)
        {
            double midP = (a + b) / 2;
            if ((iter == MAX_ITER) || (Math.Abs(b - a) < EPS))
            {
                return midP;
            }
            double l = midP - DELTA;
            double m = midP + DELTA;
            double fL = func(l);
            double fM = func(m);
            return func(l) < func(m)
                   ? dichtomy(a, m, ++iter)
                   : dichtomy(l, b, ++iter);
        }

    }
}
