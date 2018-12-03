using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class SwarmAlgorithm: IMininizer
    {
        private FunctionParser fParser;

        private (double, double)[] restrictions;
        private readonly int iterationCount;
        private readonly int particleCount;
        private readonly double localMinWeight;
        private readonly double globalMinWeight;
        private SearchArea searchArea;


        public SwarmAlgorithm((double, double)[] restrictions, 
            int iterationCount, 
            int particleCount, 
            double localMinWeight, 
            double globalMinWeight, 
            FunctionParser fParser)
        {
            this.restrictions = restrictions;
            this.iterationCount = iterationCount;
            this.particleCount = particleCount;
            this.localMinWeight = localMinWeight;
            Particle.localMinWeight = localMinWeight;
            this.globalMinWeight = globalMinWeight;
            this.fParser = fParser;
            Particle.globalMinWeight = globalMinWeight;
            this.searchArea = new SearchArea(restrictions);
            Particle.func = this.func;
        }

        public double func(Point p)
        {
            return fParser.computeFuncVal(p.getCoords());
        }

        public Point findMin()
        {
            var gen = searchArea.generateRandomPoints(particleCount);
            var particles = gen.Select(p => new Particle(p)).ToArray();

            Particle.init(particles);

            for (int i = 0; i < iterationCount; i++)
            {
                foreach (var p in particles)
                {
                    p.iter();
                }
            }

            return Particle.min();
        }

        
    }


    class Particle
    {
        private static Random randomizer = new Random();
        public delegate double funcD(Point p);
        public static funcD func;
        public static double localMinWeight;
        public static double globalMinWeight;

        private static Point globalBestPos;

        private Point currentPos;
        private Point localBestPos;
        private Point speed;

        public Particle(Point startPos)
        {
            this.currentPos = startPos;
            this.localBestPos = startPos;
            this.speed = new Point(startPos.dim);
        }

        public static void init(Particle[] particles)
        {
            globalBestPos = particles.OrderBy(p => func(p.currentPos)).First().currentPos;
        }

        public void iter()
        {
            speed += localMinWeight * randomizer.NextDouble() * (localBestPos - currentPos) +
                globalMinWeight * randomizer.NextDouble() * (globalBestPos - currentPos);

            currentPos += speed;

            var newFVal = func(currentPos);

            globalBestPos = newFVal < func(globalBestPos) ? currentPos : globalBestPos;
            localBestPos = newFVal < func(localBestPos) ? currentPos : localBestPos;
        }

        public static Point min() { return globalBestPos; }


    }
}
