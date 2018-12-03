using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class GeneticAlgorithm: IMininizer
    {
        private static Random randomizer = new Random();

        private (double, double)[] restrictions;
        private int individualsCount;
        private double crossoverProbability;
        private double mutationProbability;
        private double mutationStep;
        private int iterationCount;
        private static double truncationCoef = 0.4;
        private FunctionParser fParser;
        private SearchArea searchArea;

        public Point best;

        public GeneticAlgorithm((double, double)[] restrictions, 
            int individualsCount, 
            int iterationCount,
            double crossoverProbability, 
            double mutationProbability, 
            double mutationStep,
            FunctionParser fParser)
        {
            this.restrictions = restrictions;
            this.individualsCount = individualsCount;
            this.crossoverProbability = crossoverProbability;
            this.mutationProbability = mutationProbability;
            this.mutationStep = mutationStep;
            this.iterationCount = iterationCount;
            this.fParser = fParser;
            this.best = new Point(restrictions.Count());
            this.searchArea = new SearchArea(restrictions);

        }

        public Point findMin()
        {
            var gen = searchArea.generateRandomPoints(individualsCount);

            for (int i = 0; i < iterationCount; i++)
            {
                gen = crossover(gen);
                mutation(gen);
                gen = selectStrongest(gen);

                best = func(gen[0]) < func(best) ? gen[0] : best;
            }

            return best;
        }

        private double func(Point p)
        {
            return fParser.computeFuncVal(p.unsafeGetCoords());
        }


        private Point[] crossover(Point[] oldGen)
        {
            var newGen = new Point[individualsCount];
            (Point, Point) childs;

            for (int i = 0; i < individualsCount - 1; i += 2)
            {
                childs = crossOperator(getPairOfDifferentPoints(oldGen));
                newGen[i] = childs.Item1;
                newGen[i + 1] = childs.Item2;
            }

            return newGen;
        }

        private void mutation(Point[] gen)
        {
            for (int i = 0; i < gen.Length; i++)
            {
                var point = gen[i];
                var pointCoords = point.getCoords();

                for (int j = 0; j < pointCoords.Length; j++)
                {
                    if (randomizer.NextDouble() < mutationProbability)
                    {
                        point.setCoord(j, pointCoords[j] + (randomizer.NextDouble() - 0.5) * 2 * mutationStep);
                    }
                }

            }
        }

        private Point[] selectStrongest(Point[] points)
        {
            var resultSize = (int)(points.Length * (1 - truncationCoef));

            return points
                .Where(p => searchArea.isBelong(p))
                .OrderBy(p => fParser.computeFuncVal(p.getCoords()))
                .Take(resultSize)
                .ToArray();
        }

        private (Point, Point) getPairOfDifferentPoints(Point[] points)
        {
            int rand1 = (int)Math.Round(randomizer.NextDouble() * (points.Length - 1));
            int rand2 = rand1;

            while (rand1 == rand2)
            {
                rand2 = (int)Math.Round(randomizer.NextDouble() * (points.Length - 1)); 
            }

            return (points[rand1], points[rand2]);
        }

        private (Point, Point) crossOperator((Point, Point) parents)
        {
            var dim = parents.Item1.dim;

            var fChild = new Point(dim);
            var sChild = new Point(dim);

            var fParentCoords = parents.Item1.getCoords();
            var sParentCoords = parents.Item2.getCoords();

            for (int i = 0; i < dim; i++)
            {
                if (randomizer.NextDouble() < crossoverProbability)
                {
                    fChild.setCoord(i, sParentCoords[i]);
                    sChild.setCoord(i, fParentCoords[i]);
                }
            }

            return (fChild, sChild);
        }
    }
}
