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
    }
}
