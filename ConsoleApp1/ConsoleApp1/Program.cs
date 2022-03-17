using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //var a = "mamed";
            //a = 10;
            //string name = "mamed";

            //dynamic b = "mamed";
            //b = 10;

            //int[] nums = new int[] { 1, 2, 3, 5, 6, 7 };
            //string[] words = new string[] { "mamed", "isabala", "sahin", "mahir", "elovset", "isa", "rasim" };

            //string name = "mamed";

            //char letter = 'a';

            //char[] nameAsArr = new char[] { 'm', 'a', 'm', 'e', 'd' };




            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}


            //int res=0;
            //foreach (var item in nums)
            //{
            //    int power = item * item;
            //    res += power;
            //}

            //Console.WriteLine(res);


            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i] == "mahir")
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int indexer = 0;
            //foreach (string item in words)
            //{
            //    if (item == "mahir")
            //    {
            //        Console.WriteLine(indexer);
            //    }
            //    indexer++;
            //    //Console.WriteLine($"{indexer} - {item}");
            //    //indexer++;
            //}
            #endregion

            #region fibbo
            //Console.WriteLine("Nece fibbo ededi isteyirsiz?");
            //int request = Convert.ToInt32(Console.ReadLine());


            //// c-fb[n]
            //// b-fb[n-1]
            //// a-fb[n-2]

            //int a = 0;
            //int b = 1;
            //int c = 0;

            ////for (int i = 0; i < request; i++)
            ////{
            ////    Console.WriteLine(c);
            ////    a = b;
            ////    b = c;
            ////    c = a + b;
            ////}


            //int i = 0;
            //while (i < request)
            //{
            //    Console.WriteLine(c);
            //    a = b;
            //    b = c;
            //    c = a + b;

            //    i++;
            //}
            #endregion

            int[] nums = new int[] { 12, 18, 72, 21, 32, 43, 55, 63, 71 };

            int temp;
            int loopCount = 0;
            bool swapped = false;

            for (int i = 0; i < nums.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < nums.Length-1; j++)
                {
                    loopCount++;
                    if (nums[j]> nums[j+1])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }


            Console.WriteLine("result:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+" / ");
            }

            Console.WriteLine($"Loop count - {loopCount}");

        }
    }
}
