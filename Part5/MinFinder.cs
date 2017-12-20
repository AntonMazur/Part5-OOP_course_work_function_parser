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
            return M_Pirson_3();
        }

        public double func(Point point)
        {
            return fPars.computeFuncVal(point.getCoords());
        }

        private double df(Point point, Point direction)
        {
            return (func(point + 1e-14 * direction) - func(point)) / 1e-14;
        }

        public double df_2(Point point, int df1_dimNum, int df2_dimNum)
        {
            Point df1Direc = new Point(point.dim);
            df1Direc.setCoord(df1_dimNum, 1);
            Point df2Direc = new Point(point.dim);
            df2Direc.setCoord(df2_dimNum, 1);

            return (df(point, df1Direc) - df(point + 1e-12 * df2Direc, df1Direc)) / 1e-12;
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

        public Matrix getHessianMatr(Point point)
        {
            int dim = point.dim;
            double[,] hesArr = new double[dim, dim];
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    hesArr[i, j] = df_2(point, i, j);
                    hesArr[j, i] = hesArr[i, j];
                }
            }

            return new Matrix(hesArr);
        }

        public Matrix getIdentityMatr(int dim)
        {
            double[,] identityArr = new double[dim, dim];
            for (int i = 0; i < dim; i++)
            {
                identityArr[i, i] = 1;
            }

            return new Matrix(identityArr);
        }

        private Point M_Pirson_3()
        {
            OneDimMinFinder minFinder = new OneDimMinFinder(fPars);
            Matrix a = null;

            do
            {
                // preservarion previous gradient's value
                kVals.prevGrad = kVals.currGrad;
                // calculation new gradient's value
                kVals.currGrad = grad(kVals.currPoint);
                if (kVals.iter % kVals.currPoint.dim != 0)
                {
                    // calculation new matrix of quasi-Newtonian's directions 
                    a = calculateMatrixPirs3(kVals, a);
                    // calculation new direction for one-dimensionality's search 
                    kVals.currDirection = -(a * kVals.currGrad);
                }
                else{
                    // initializing with identity matrix
                    a = getIdentityMatr(kVals.currPoint.dim);
                    // calculation new direction for one-dimensionality's search 
                    kVals.currDirection = -kVals.currGrad;
                }
                //preservation of previous point
                kVals.prevPoint = kVals.currPoint;
                // one-dimensionality's search
                kVals.currPoint = minFinder.setStartPoint(kVals.currPoint).setDirection(kVals.currDirection).findMin();
                kVals.iter++;
                addKeyValsToTable(
                    kVals.iter,
                    kVals.currPoint.ToString(),
                    kVals.currDirection.ToString());

            } while (kVals.iter != MAX_ITER && Point.norm(kVals.prevPoint - kVals.currPoint) > EPS);

            return kVals.currPoint;

        }

        private Matrix calculateMatrixPirs3(KeyVals kvals, Matrix a)
        {
            Point gamma = kvals.currGrad - kvals.prevGrad;
            Point diff = kvals.currPoint - kvals.prevPoint;
            Point s = a * diff;
            return a + ((diff - s) * s) / (s * diff);
        }

        private Point M_ConjagateGrads()
        {

            /**
             * kVals - объект структуры, который хранит ключевые значения,
             * используемые в методе, в данном случае это текущая точка,
             * градиент на текущей и на прошлой итерациях,
             * направление на текущей и на прошлой итерациях
             * и уже сделанное количество итераций
             */

            //вычисление значения функции в текущей точке
            double fVal = func(kVals.currPoint);
            //вычисление градиента в текущей точке
            kVals.currGrad = grad(kVals.currPoint);
            //нахождение направления одномерного поиска из текущей точки
            kVals.currDirection = -kVals.currGrad;

            //добавление в направление поиска ещё одного члена: коэффициент beta * направление поиска на предыдущем шаге
            //если текущий шаг не кратен количеству переменных в функции
            if (kVals.iter % kVals.currPoint.dim != 0)
            {
                kVals.currDirection +=
                    computeFletReeves_beta(kVals.currGrad, kVals.prevGrad) * kVals.prevDirection;
            }

            //вычисление результата однгомерного поиска по заданному направлению
            kVals.currPoint = new OneDimMinFinder(kVals.currPoint, kVals.currDirection, fPars).findMin();

            //сохранение значения градиента(т.к. при вычислении beta используются градиенты на текущей и предыдущей итерации)
            kVals.prevGrad = kVals.currGrad;
            //сохранение направления
            kVals.prevDirection = kVals.currDirection;
            kVals.iter++;

            // не имеет никакого отношщения к алгоритму, сохранение значения ключевых переменных для последующего вывода
            /*addKeyValsToTable(
                kVals.iter,
                kVals.currPoint.ToString(),
                kVals.currGrad.ToString(),
                kVals.currDirection.ToString());*/

            //проверка условий окончания поиска, в случае их не выполнения –
            //рекурсивный вызов этого метода со значениями полученными на текущей итерации
            return (Point.norm(kVals.currGrad) > EPS && kVals.iter < MAX_ITER) ? M_ConjagateGrads() : kVals.currPoint;

        }

        /*private Point M_MacCormack()
        {
            do
            {
                Matrix m;
                int dim = kVals.currPoint.dim
                if (kVals.iter % dim != 0)
                {

                }
                else
                {
                    m = getIdentityMatr(dim);
                    kVals.currGrad = grad(kVals.currPoint);
                    kVals.currDirection = -kVals.currGrad;
                }

                kVals.prevPoint = kVals.currPoint;
                kVals.currPoint = new OneDimMinFinder(fPars)
                    .setStartPoint(kVals.currPoint)
                    .setDirection(kVals.currDirection)
                    .findMin();
            }
            while ((kVals.iter < MAX_ITER) && (Point.norm(kVals.currGrad) > EPS));
        }

        private Matrix compMacCormackMatrix(Matrix prevM, KeyVals kVals)
        {

        }*/

        private Point M_Paula1()
        {

            //создание объекта для одномерного поиска
            OneDimMinFinder mF = new OneDimMinFinder(fPars);
            // получение количетсва переменных и создание одномерного масива орт по каждому из измерений 
            //(для dim = 2, directions = {{1,0}, {0,1}}
            int dim = fPars.getDimensionality();
            Point[] directions = initStartDirsCGD(dim, dim);

            do
            {
                //сохранение значения в текущей точке(далее будет использовано для нахождения нового направления поиска)
                kVals.prevPoint = kVals.currPoint;

                // одномерный последовательный поиск по массиву направлений
                for (int i = 0; i < dim; i++)
                {
                    kVals.currPoint = mF.setStartPoint(kVals.currPoint).setDirection(directions[i]).findMin();
                }

                // нахождение нового направления поиска
                Point newDir = kVals.currPoint - kVals.prevPoint;
                
                // добавление нового направления в матрицу поисковых векторов
                mPaula1AddDirection(directions, newDir);
                kVals.currPoint = mF
                    .setStartPoint(kVals.currPoint)
                    .setDirection(newDir)
                    .findMin();

                kVals.iter++;

                // никак не относится к алгоритму
                addKeyValsToTable(
                    kVals.iter,
                    kVals.currPoint.ToString(),
                    newDir.ToString());
                
            } while (kVals.iter < dim);

            return kVals.currPoint;
        }

        // метод для сдвига всех направлений вправо на 1 и добавления нового направления на место последнего
        private void mPaula1AddDirection(Point[] directions, Point dir)
        {
            for (int i = 0; i < directions.Length - 1; i++)
            {
                directions[i] = directions[i + 1];
            }
            directions[directions.Length - 1] = dir;
        }

        private Point[] initStartDirsCGD(int dim, int dirsCount)
        {
            Point[] initDirections = new Point[dirsCount];
            for (int i = 0; i < dirsCount; i++)
            {
                Point p = new Point(dim);
                p.setCoord(i, 1);
                initDirections[i] = p;
            }
            return initDirections;
        }

        private Point M_Paula2()
        {

            //создание объекта для одномерного поиска
            OneDimMinFinder mF = new OneDimMinFinder(fPars);
            // получение количетсва переменных и создание одномерного масива орт по каждому из измерений 
            //(для dim = 2, directions = {{1,0}, {0,1}}
            int dim = fPars.getDimensionality();
            Point[] directions = initStartDirsCGD(dim, dim + 1);
            directions[dim] = directions[0];

            do
            {
                kVals.currPoint = mF.setStartPoint(kVals.currPoint).setDirection(directions[0]).findMin();
                //сохранение значения в текущей точке(далее будет использовано для нахождения нового направления поиска)
                kVals.prevPoint = kVals.currPoint;

                // одномерный последовательный поиск по массиву направлений
                for (int i = 1; i <= dim; i++)
                {
                    kVals.currPoint = mF.setStartPoint(kVals.currPoint).setDirection(directions[i]).findMin();
                }

                // нахождение нового направления поиска
                Point newDir = kVals.currPoint - kVals.prevPoint;

                // добавление нового направления в матрицу поисковых векторов
                mPaula1AddDirection(directions, newDir);
                directions[0] = newDir;
                kVals.currPoint = mF
                    .setStartPoint(kVals.currPoint)
                    .setDirection(newDir)
                    .findMin();

                kVals.iter++;

                // никак не относится к алгоритму
                addKeyValsToTable(
                    kVals.iter,
                    kVals.currPoint.ToString(),
                    newDir.ToString());

            } while (kVals.iter < dim);

            return kVals.currPoint;
        }


        private double computePolRib_beta(Point currG, Point prevG)
        {
            return (((currG - prevG) * currG)/(prevG * prevG));
        }

	   private double computeFletReeves_beta(Point currG, Point prevG)
        {
            return (currG * currG)/(prevG * prevG);
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
