using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class Matrix
    {
        private double[,] matrix;

        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
        }

        public Matrix(Point p, bool isVertical)
        {
            if (isVertical)
            {
                matrix = new double[p.dim, 1];
                double[] pCoords = p.getCoords();

                for (int i = 0; i < p.dim; i++)
                {
                    matrix[i, 0] = pCoords[i];
                }
            }
            else
            {
                matrix = new double[1, p.dim];
                double[] pCoords = p.getCoords();

                for (int i = 0; i < p.dim; i++)
                {
                    matrix[0, i] = pCoords[i];
                }
            }
            
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            double[,] matr1 = m1.matrix;
            double[,] matr2 = m2.matrix;

            double resEl;
            double[,] resMatrix = new double[matr1.GetLength(0), matr2.GetLength(1)];

            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                {
                    resEl = 0;

                    for (int k = 0; k < matr1.GetLength(1); k++)
                    {
                        resEl += matr1[i, k] * matr2[k, j];
                    }
                    resMatrix[i, j] = resEl;
                }
            }

            return new Matrix(resMatrix);
        }

        public static Matrix operator +(Matrix m, double val)
        {
            double[,] oldM = m.matrix;
            double[,] newM = new double[m.matrix.GetLength(0), m.matrix.GetLength(1)];

            for (int i = 0; i < newM.GetLength(0); i++)
            {
                for (int j = 0; j < newM.GetLength(1); j++)
                {
                    newM[i, j] = oldM[i, j] + val;
                }
            }

            return new Matrix(newM);
        }

        public static Matrix operator -(Matrix m, double val)
        {
            double[,] oldM = m.matrix;
            double[,] newM = new double[m.matrix.GetLength(0), m.matrix.GetLength(1)];

            for (int i = 0; i < newM.GetLength(0); i++)
            {
                for (int j = 0; j < newM.GetLength(1); j++)
                {
                    newM[i, j] = oldM[i, j] - val;
                }
            }

            return new Matrix(newM);
        }

        public static Point operator *(Matrix m, Point p)
        {
            double[,] matr = m.matrix;
            double[] vect = p.getCoords();

            double[] res = new double[matr.GetLength(0)];

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < vect.Length; j++)
                {
                    res[i] += matr[i, j] * vect[j];
                }
            }

            return new Point(res);
        }




    }
}
