namespace SafeMathApp
{
    public static class SafeMath
    {
        public static double SafeAdd(double a, double b)
        { 
            double safeA = double.IsNaN(a) ? 0 : a;
            double safeB = double.IsNaN(b) ? 0 : b;

            double sum = safeA + safeB;
            return sum;
        }
    }
}
