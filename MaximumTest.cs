namespace MaximumGenericMethod
{
    internal class MaximumTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Maximum of 3, 4 and 5 is {Maximum(3, 4, 5)}\n");
            Console.WriteLine($"Maximum of 6.6, 8.8 and 7.7 is {Maximum(6.6, 8.8, 7.7)}\n");
            Console.WriteLine($"Maximum of pear, apple and orange is {Maximum("pear", "apple", "orange")}\n");        
        }

        // Generic function determines the largest of the IComparable<T> objects
        private static T Maximum<T>(T x, T y, T z) where T : IComparable<T>
        {
            var max = x; // Assume that x is initially the largest

            // Compare y with max
            if (y.CompareTo(max) > 0)
            {
                max = y; // y is the largest so far
            }

            // Compare z to max
            if (z.CompareTo(max) > 0)
            {
                max = z; // y is the largest so far
            }

            return max;
        }
    }
}