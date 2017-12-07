using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Part5
{
    struct KeyVals
    {
        public int iter;
        public Point prevPoint;
        public Point currPoint;
        public Point currDirection;
        public Point prevDirection;
        public Point currGrad;
        public Point prevGrad;
        public bool isDirectionPersist;


        

        public KeyVals(int dimesionality)
        {
            iter = 0;
            prevPoint = new Point(dimesionality);
            currPoint = new Point(dimesionality);
            isDirectionPersist = false;
            currDirection = null;
            prevDirection = null;
            currGrad = null;
            prevGrad = null;
        }
        public KeyVals(double[] startPointCoords)
        {
            iter = 0;
            prevPoint = new Point(startPointCoords);
            currPoint = new Point(startPointCoords);
            isDirectionPersist = false;
            currDirection = null;
            prevDirection = null;
            currGrad = null;
            prevGrad = null;
        }
        public KeyVals(double[] startPointCoords, double[] startDirecCoords) : this(startPointCoords)
        {
            isDirectionPersist = true;
            currDirection = new Point(startDirecCoords);
        }
    }


    class MinFinder
    {
        private double EPS;
        private int MAX_ITER;


        private FunctionParser fPars;
        private KeyVals kVals;
        private DataTable dt;

        public MinFinder(
            string func, 
            double[] startPoint, 
            double[] startDirection, 
            DataTable dt, double EPS, 
            int maxIter
            ) : this(func, dt, EPS, maxIter)
        {
            kVals = new KeyVals(startPoint, startDirection);
        }

        public MinFinder(
            string func, 
            double[] startPoint, 
            DataTable dt, double EPS, 
            int maxIter
            ) : this(func, dt, EPS, maxIter)
        {
            kVals = new KeyVals(startPoint);
        }

        public MinFinder(string func, DataTable dt, double EPS, int maxIter)
        {
            this.EPS = EPS;
            this.MAX_ITER = maxIter;
            this.dt = dt;
            fPars = new FunctionParser(func);
            kVals = new KeyVals(fPars.getDimensionality());
        }

        public Point findMin()
        {
            initDTPaulaMeth();
            return M_Paula();
        }

        public double func(Point point)
        {
            return fPars.computeFuncVal(point.getCoords());
        }

        private double df(Point point, Point direction)
        {
            Point.normalize(direction);
            return (func(point + 1e-12 * direction) - func(point)) / 1e-12;
        }

        public Point grad(Point point)
        {
            double[] gradCoords = new double[point.dim];
            Point tempDir = new Point(point.dim);
            for (int i = 0; i < point.dim; i++)
            {
                tempDir.setCoord(i - 1, 0);
                tempDir.setCoord(i, 1);
                gradCoords[i] = df(point, tempDir);
            }
            return new Point(gradCoords);
        }

        private Point M_PolakaRibiere()
        {
            double fVal = func(kVals.currPoint);
            kVals.currGrad = grad(kVals.currPoint);
            kVals.currDirection = -kVals.currGrad;

            if (kVals.iter % kVals.currPoint.dim != 0)
            {
                kVals.currDirection +=
                    computePolRib_beta(kVals.currGrad, kVals.prevGrad) * kVals.prevDirection;
            }

            kVals.currPoint = new OneDimMinFinder(kVals.currPoint, kVals.currDirection, fPars).findMin();

            kVals.prevGrad = kVals.currGrad;
            kVals.prevDirection = kVals.currDirection;
            kVals.iter++;

            addKeyValsToTable(
                kVals.iter,
                kVals.currPoint.ToString(),
                kVals.currGrad.ToString(),
                kVals.currDirection.ToString());

            return (Point.norm(kVals.currGrad) > EPS && kVals.iter < MAX_ITER) ? M_PolakaRibiere() : kVals.currPoint;

        }

        private Point M_Paula()
        {
            OneDimMinFinder mF = new OneDimMinFinder(fPars);
            int dim = fPars.getDimensionality();
            Point[] directions = initStartDirsCGD(dim);

            do
            {
                kVals.prevPoint = kVals.currPoint;

                for (int i = 0; i < dim; i++)
                {
                    kVals.currPoint = mF.setStartPoint(kVals.currPoint).setDirection(directions[i]).findMin();
                }


                Point newDir = kVals.currPoint - kVals.prevPoint;
                
                mPaulaAddDirection(directions, newDir);
                kVals.currPoint = mF
                    .setStartPoint(kVals.currPoint)
                    .setDirection(newDir)
                    .findMin();

                kVals.iter++;

                addKeyValsToTable(
                    kVals.iter,
                    kVals.currPoint.ToString(),
                    newDir.ToString());
                
            } while (kVals.iter < dim);

            return kVals.currPoint;
        }

        private void mPaulaAddDirection(Point[] directions, Point dir)
        {
            for (int i = 0; i < directions.Length - 1; i++)
            {
                directions[i] = directions[i + 1];
            }
            directions[directions.Length - 1] = dir;
        }

        private Point[] initStartDirsCGD(int dim)
        {
            Point[] initDirections = new Point[dim];
            for (int i = 0; i < dim; i++)
            {
                Point p = new Point(dim);
                p.setCoord(i, 1);
                initDirections[i] = p;
            }
            return initDirections;
        }


        private double computePolRib_beta(Point currG, Point prevG)
        {
            return (((currG - prevG) * currG)/(prevG * prevG));
        }


        private void initDTConjGrad()
        {  
            dt.Columns.AddRange(new DataColumn[] 
            {
                new DataColumn("Iteration", Type.GetType("System.Int32")),
                new DataColumn("Current point", Type.GetType("System.String")),
                new DataColumn("Current gradient", Type.GetType("System.String")),
                new DataColumn("Current direction", Type.GetType("System.String"))
            });
        }

        private void initDTPaulaMeth()
        {
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Iteration", Type.GetType("System.Int32")),
                new DataColumn("Current point", Type.GetType("System.String")),
                new DataColumn("Current direction", Type.GetType("System.String")),
            });
        }


        private void addKeyValsToTable(int iter, string currP, string currG, string currD)
        {
            DataRow dR = dt.NewRow();
            dR.SetField(0, iter);
            dR.SetField(1, currP);
            dR.SetField(2, currG);
            dR.SetField(3, currD);
            dt.Rows.Add(dR);
        }

        private void addKeyValsToTable(int iter, string currP, string currD)
        {
            DataRow dR = dt.NewRow();
            dR.SetField(0, iter);
            dR.SetField(1, currP);
            dR.SetField(2, currD);
            dt.Rows.Add(dR);
        }
    }
}
