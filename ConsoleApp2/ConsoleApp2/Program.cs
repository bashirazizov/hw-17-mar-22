using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mamed = { 756, 12, 54, 134, 6, 75, 21 };

            Bubble(mamed);

            for (int i = 0; i < mamed.Length; i++)
            {
                Console.WriteLine(mamed[i]);
            }
        }

        static void Bubble(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }

        static double CalculateArea(double raidus)
        {
            return 3 * raidus * raidus;
        }

        static int CalculateArea(int width, int height)
        {
            return width * height;
        }

        static int CalculateArea(int top, int bottom, int side)
        {
            return 2 * (top * bottom + top * side + bottom * side);
        }


    }
}
