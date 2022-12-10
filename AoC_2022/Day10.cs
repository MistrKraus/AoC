using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC.AoC_2022
{
    class Day10
    {/// <summary>
     /// Day 10 Part 1
     /// </summary>
        public static void Day10_1()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input10.txt");
                string line;
                int tickCount = 0;
                int value = 1;
                int sum = 0;
                int ticksToProcess = 0;
                int add;

                int intValStart = 5;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("n"))
                    {
                        ticksToProcess = 1;
                        add = 0;
                    }
                    else
                    {
                        ticksToProcess = 2;
                        add = int.Parse(line.Substring(intValStart));
                    }

                    for (int i = 0; i < ticksToProcess; i++)
                    {
                        tickCount++;

                        if (tickCount == 20 || (tickCount > 20 && (tickCount - 20) % 40 == 0))
                        {
                            sum += value * tickCount;
                        }
                    }

                    value += add;
                }

                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Day 10 Part 2
        /// </summary>
        public static void Day10_2()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input10.txt");
                string line;
                int tickCount = 0;
                int registerValue = 1;
                int ticksToProcess = 0;
                int pixel;
                int add;

                int intValStart = 5;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("n"))
                    {
                        ticksToProcess = 1;
                        add = 0;
                    }
                    else
                    {
                        ticksToProcess = 2;
                        add = int.Parse(line.Substring(intValStart));
                    }

                    for (int i = 0; i < ticksToProcess; i++)
                    {
                        pixel = tickCount % 40;
                        tickCount++;

                        if (pixel >= registerValue - 1 && pixel <= registerValue + 1)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(".");
                        }

                        if (pixel == 39)
                        {
                            Console.WriteLine();
                        }

                    }

                    registerValue += add;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
