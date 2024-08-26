using practice_oop;

namespace practiceoop
{
    class Summary : Calculation
    {
        public int A { get; set; }
        public int B { get; set; }

        // Constructor to initialize A and B
        public Summary(int a, int b)
        {
            A = a;
            B = b;
        }

        // Method to get the sum using the inherited sum method
        public int GetSum()
        {
            return sum(A, B);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Summary with values for a and b
            Summary summary = new Summary(3, 2);

            // Get the sum using the Summary class
            int result = summary.GetSum();
            Console.WriteLine(result);
        }
    }
}
