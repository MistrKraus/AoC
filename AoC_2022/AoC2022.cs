using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC.AoC_2022
{
    class AoC2022
    {
        /// <summary>
        /// Day 1 Part 1
        /// Maximum total calories carried
        /// </summary>
        public static void Day1_1()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input1.txt");
                string line;
                int maxCalories = 0;
                int totalCalories = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    if (Int16.TryParse(line, out short calories))
                    {
                        totalCalories += calories;

                        continue;
                    }

                    maxCalories = Math.Max(maxCalories, totalCalories);
                    totalCalories = 0;
                }

                maxCalories = Math.Max(maxCalories, totalCalories);

                sr.Close();
                Console.WriteLine(maxCalories);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// Day 1 Part 2
        /// Maximum total calories carried
        /// </summary>
        public static void Day1_2()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input1.txt");
                string line;
                int minCalories;
                int minCaloriesId = 0;
                int totalCalories = 0;
                int total3Calories = 0;
                int[] maxCalories = new int[3] { 0, 0, 0};

                while ((line = sr.ReadLine()) != null)
                {
                    if (Int32.TryParse(line, out int calories))
                    {
                        totalCalories += calories;

                        continue;
                    }

                    minCalories = maxCalories[0];
                    minCaloriesId = 0;
                    for (int i = 1; i < 3; i++)
                    {
                        if (maxCalories[i] < minCalories)
                        {
                            minCalories = maxCalories[i];
                            minCaloriesId = i;
                        }
                    }

                    maxCalories[minCaloriesId] = Math.Max(maxCalories[minCaloriesId], totalCalories);

                    totalCalories = 0;
                }

                sr.Close();

                // Console.WriteLine();

                for (int i = 0; i < 3; i++)
                {
                    // if (maxCalories[i] < totalCalories)
                    // {
                    //     maxCalories[i] = totalCalories;
                    //     totalCalories = 0;
                    // }
                    // 
                    Console.WriteLine(maxCalories[i]);
                    total3Calories += maxCalories[i];
                }

                Console.WriteLine(total3Calories);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Day 2 Part 1
        /// Exact item
        /// </summary>
        public static void Day2_1()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input2.txt");
                string line;

                Dictionary<string, int> scoreTable = new Dictionary<string, int>
                {
                    {"A X", 3 + 1},      // Rock:    A, X    1
                    {"A Y", 6 + 2},      // Paper:   B, Y    2
                    {"A Z", 0 + 3},      // Scissors:C, Z    3

                    {"B X", 0 + 1},      // Lost:            0
                    {"B Y", 3 + 2},      // Draw:            3
                    {"B Z", 6 + 3},      // Win:             6

                    {"C X", 6 + 1},
                    {"C Y", 0 + 2},
                    {"C Z", 3 + 3}
                };

                int score = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    score += scoreTable[line];
                }

                Console.WriteLine(score);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Day 2 Part 1
        /// Exact outcome
        /// </summary>
        public static void Day2_2()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input2.txt");
                string line;

                Dictionary<string, int> scoreTable = new Dictionary<string, int>
                {
                    {"A X", 0 + 3 },      // Rock:    A, X    1
                    {"A Y", 3 + 1 },      // Paper:   B, Y    2
                    {"A Z", 6 + 2 },      // Scissors:C, Z    3

                    {"B X", 0 + 1 },      // Lost     X       0
                    {"B Y", 3 + 2 },      // Draw:    Y       3
                    {"B Z", 6 + 3 },      // Win:     Z       6

                    {"C X", 0 + 2 },
                    {"C Y", 3 + 3 },
                    {"C Z", 6 + 1 }
                };

                int score = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    score += scoreTable[line];
                }

                Console.WriteLine(score);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Day 3 Part 1
        /// Priorities sum
        /// </summary>
        public static void Day3_1()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input3.txt");
                string line;
                string[] splittedLine = new string[2];
                int priority;
                int sum = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    splittedLine[0] = line.Substring(0, line.Length / 2);
                    splittedLine[1] = line.Substring(line.Length / 2);

                    foreach (char letter in splittedLine[0])
                    {
                        if (!splittedLine[1].Contains(letter))
                        {
                            continue;
                        }

                        if (letter > 96)
                        {
                            priority = letter - 96;
                        }
                        else
                        {
                            priority = letter - 38;
                        }

                        sum += priority;

                        //foreach (char let in line)
                        //{
                        //    if (letter == let)
                        //    {
                        //        sum += priority;
                        //    }
                        //}

                        break;
                    }
                }

                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
