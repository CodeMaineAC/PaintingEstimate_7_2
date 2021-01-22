using System;

namespace PaintingEstimate_7_2
{
    class PaintingEstimate
    {
        static void Main(string[] args)
        {
            UI();
        }

        public static double ComputeCost(int length, int width)
        {
            const int HEIGHT = 9;
            const double  COST_PER_SQFT = 6.00;

            int area = length * HEIGHT * 2 + width * HEIGHT * 2;
            double cost = area * COST_PER_SQFT;

            return cost;

            // Write your ComputeCost method here.
        }

        public static void UI()
        {
            string uiLength, uiWidth;
            double cost;

            Console.Write("Enter length of the room in feet >> ");
            uiLength = Console.ReadLine();

            Console.Write("Enter width of room in feet >> ");
            uiWidth = Console.ReadLine();

            cost = ComputeCost(Convert.ToInt32(uiLength), Convert.ToInt32(uiWidth));
            Console.WriteLine("Cost of job for {0} X {1} foot room" +
                " is {2:C}", uiLength, uiWidth, cost );
        }
    }
}
