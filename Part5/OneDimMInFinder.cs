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
        private const double EPS = 1e-14;
        private const double DELTA = EPS * 0.1;
        private const int MAX_ITER = 40;



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
            Interval interv = swan1(0, 0.01);
            double step = DSK(interv.a, interv.b, 0);
            return startPoint + step * direction;
        }

        public double func(double step)
        {
            return fPars.computeFuncVal((startPoint + step * direction).getCoords());
        }

        private double df(double step)
        {
            return (func(step + 1e-14) - func(step)) / 1e-14;
        }

        private Interval swan2(double startP, double h)
        {
            double prevP;
            double currP;
            if (df(startP) > 0)
            {
                h = -h;
            }
            prevP = startP;
            currP = startP + h;
            while (df(currP) * df(prevP) > 0)
            {
                h *= 2;
                prevP = currP;
                currP += h;
            }
            return new Interval(prevP, currP);
        }

        private Interval swan1(double startP, double h)
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

        private double bolzano(double a, double b, int iter)
        {
            double midP = (a + b) / 2;
            if (((Math.Abs(b - a) < EPS) && (Math.Abs(df(midP)) < EPS)) || (iter == MAX_ITER))
                return (a + b) / 2;
            if (df(midP) > 0)
                b = midP;
            else
                a = midP;
            return bolzano(a, b, ++iter);
        }

        private double dichtomy(double a, double b, int iter)
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

        private double DSK(double x, double h, int iter)
        {
            if ((Math.Abs(df(x)) < EPS) || (iter == MAX_ITER))
            {
                return x;
            }
            Interval afterSwan = swan2(x, h);
            x = (afterSwan.b + afterSwan.a) / 2;
            double d = d_4(afterSwan.a, x, afterSwan.b);
            return func(d) < func(x)
                   ? DSK(d, h / 2, ++iter)
                   : DSK(x, h / 2, ++iter);
        }

        private double d_4(double a, double b, double c)
        {
            return b + ((b - a) * (func(a) - func(c))) /
                   (2 * (func(a) - 2 * func(b) + func(c)));
        }

    }
}
