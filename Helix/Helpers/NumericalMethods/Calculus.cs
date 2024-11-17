namespace Helix.Helpers.NumericalMethods
{
    public static class Calculus
    {
        public static double Integrate(Func<double, double> function, double start, double end, int steps)
        {
            double stepSize = (end - start) / steps;
            double integration = 0.0;

            for (int i = 0; i < steps; i++)
            {
                double x = start + i * stepSize;
                integration += function(x) * stepSize;
            }

            return integration;
        }

        public static double Differentiate(Func<double, double> function, double point, double epsilon = 1e-5)
        {
            return (function(point + epsilon) - function(point - epsilon)) / (2 * epsilon);
        }
    }
}