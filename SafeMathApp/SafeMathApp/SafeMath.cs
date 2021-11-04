namespace SafeMathApp
{
    public static class SafeMath
    {
        public static double SafeSum(double a, double b)
        { 
            double safeA = double.IsNaN(a) ? 0 : a;
            double safeB = double.IsNaN(b) ? 0 : b;

            double sum = safeA + safeB;
            return sum;
        }
    }
}
