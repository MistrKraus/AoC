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
                int[] maxCalories = new int[3] { 0, 0, 0 };

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
        /// Duplicit priorities sum
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

        /// <summary>
        /// Day 3 Part 2
        /// Group priorities sum
        /// </summary>
        public static void Day3_2()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input3.txt");
                string line;
                string[] group = new string[3];
                int priority;
                int groupCounter = 0;
                int sum = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    group[groupCounter++] = line;

                    if (groupCounter < 3)
                    {
                        continue;
                    }

                    groupCounter = 0;

                    foreach (char letter in group[0])
                    {
                        if (!group[1].Contains(letter))
                        {
                            continue;
                        }

                        if (!group[2].Contains(letter))
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

                        break;
                    }
                }

                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Day 4 Part 1
        /// Total overlaps
        /// </summary>
        public static void Day4_1()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input4.txt");
                string line;
                string[] sections = new string[2];
                string[] section = new string[2];

                int s1_low;
                int s1_high;
                int s2_low;
                int s2_high;

                int overlapCount = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    sections = line.Split(',');

                    section = sections[0].Split('-');
                    s1_low = Int32.Parse(section[0]);
                    s1_high = Int32.Parse(section[1]);

                    section = sections[1].Split('-');
                    s2_low = Int32.Parse(section[0]);
                    s2_high = Int32.Parse(section[1]);

                    if ((s1_low <= s2_low && s1_high >= s2_high) || (s2_low <= s1_low && s2_high >= s1_high))
                    {
                        overlapCount++;
                    }
                }

                Console.WriteLine(overlapCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Day 4 Part 2
        /// Partial overlaps
        /// </summary>
        public static void Day4_2()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input4.txt");
                string line;
                string[] sections = new string[2];
                string[] section = new string[2];

                int s1_low;
                int s1_high;
                int s2_low;
                int s2_high;

                int overlapCount = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    sections = line.Split(',');

                    section = sections[0].Split('-');
                    s1_low = Int32.Parse(section[0]);
                    s1_high = Int32.Parse(section[1]);

                    section = sections[1].Split('-');
                    s2_low = Int32.Parse(section[0]);
                    s2_high = Int32.Parse(section[1]);

                    if ((s1_high >= s2_low && s1_high <= s2_high) || (s1_low >= s2_low && s1_low <= s2_high) ||
                        (s2_high >= s1_low && s2_high <= s1_high) || (s2_low >= s1_low && s2_low <= s1_high))
                    {
                        overlapCount++;
                    }
                }

                Console.WriteLine(overlapCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Day 5 Part 1
        /// Top items
        /// </summary>
        public static void Day5_1()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input5.txt");
                string line;
                List<string> storageLines = new List<string>();

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length == 0)
                    {
                        break;
                    }

                    storageLines.Add(line);
                }

                string num = storageLines[storageLines.Count - 1].Substring(storageLines[storageLines.Count - 1].LastIndexOf("   "));
                int storageSize = int.Parse(num);
                int itemId;
                string item;
                Stack<string>[] stack = new Stack<string>[storageSize];

                for (int i = 0; i < storageSize; i++)
                {
                    stack[i] = new Stack<string>();
                }
                
                for (int i = storageLines.Count - 2; i > -1; i--)
                {
                    while (true)
                    {
                        Console.WriteLine(storageLines[i]);
                        
                        itemId = storageLines[i].LastIndexOf("[") + 1;
                        item = storageLines[i].Substring(itemId, storageLines[i].LastIndexOf("]") - itemId);
                        stack[storageLines[i].LastIndexOf("[") / 4].Push(item);
                        storageLines[i] = storageLines[i].Substring(0, storageLines[i].LastIndexOf("]") - 2);

                        if (storageLines[i].LastIndexOf("[") == -1)
                        {
                            break;
                        }
                    }
                }

                string[] move;

                while ((line = sr.ReadLine()) != null)
                {
                    move = line.Split(' ');

                    for (int i = 0; i < int.Parse(move[1]); i++)
                    {
                        stack[int.Parse(move[5]) - 1].Push(stack[int.Parse(move[3]) - 1].Pop());
                    }
                }

                for (int i = 0; i < stack.Length; i ++)
                {
                    Console.Write(stack[i].Peek());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Day 5 Part 1
        /// Top items
        /// </summary>
        public static void Day5_2()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input5.txt");
                string line;
                List<string> storageLines = new List<string>();

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length == 0)
                    {
                        break;
                    }

                    storageLines.Add(line);
                }

                string num = storageLines[storageLines.Count - 1].Substring(storageLines[storageLines.Count - 1].LastIndexOf("   "));
                int storageSize = int.Parse(num);
                int itemId;
                string item;
                Stack<string>[] stack = new Stack<string>[storageSize];

                for (int i = 0; i < storageSize; i++)
                {
                    stack[i] = new Stack<string>();
                }

                for (int i = storageLines.Count - 2; i > -1; i--)
                {
                    while (true)
                    {
                        Console.WriteLine(storageLines[i]);

                        itemId = storageLines[i].LastIndexOf("[") + 1;
                        item = storageLines[i].Substring(itemId, storageLines[i].LastIndexOf("]") - itemId);
                        stack[storageLines[i].LastIndexOf("[") / 4].Push(item);
                        storageLines[i] = storageLines[i].Substring(0, storageLines[i].LastIndexOf("]") - 2);

                        if (storageLines[i].LastIndexOf("[") == -1)
                        {
                            break;
                        }
                    }
                }

                string[] move;
                Stack<string> load = new Stack<string>();

                while ((line = sr.ReadLine()) != null)
                {
                    move = line.Split(' ');
                    load.Clear();

                    for (int i = 0; i < int.Parse(move[1]); i++)
                    {
                        load.Push(stack[int.Parse(move[3]) - 1].Pop());
                    }

                    for (int i = 0; i < int.Parse(move[1]); i++)
                    {
                        stack[int.Parse(move[5]) - 1].Push(load.Pop());
                    }
                }

                for (int i = 0; i < stack.Length; i++)
                {
                    Console.Write(stack[i].Peek());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
