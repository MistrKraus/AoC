using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC.AoC_2022
{
    class Day6
    {
        /// <summary>
        /// Day 6 Part 1
        /// Char count
        /// </summary>
        public static void Day6_1()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input6.txt");
                string potentionalMarker = string.Empty;
                int counter = 0;

                for (int i = 0; i < 4; i++)
                {
                    potentionalMarker += Char.ToString((char)sr.Read());
                    counter++;
                }

                string s;
                while ((s = Char.ToString((char)sr.Read())) != null)
                {
                    if (ContainsUniqueChars(potentionalMarker))
                    {
                        break;
                    }

                    counter++;
                    potentionalMarker = potentionalMarker.Substring(1);
                    potentionalMarker += s;
                }

                Console.WriteLine(counter);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Day 6 Part 2
        /// Char count
        /// </summary>
        public static void Day6_2()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\PetrKraus\\Programovani\\C#\\AoC\\AoC_2022\\Resources\\input6.txt");
                string potentionalMarker = string.Empty;
                int counter = 0;

                for (int i = 0; i < 14; i++)
                {
                    potentionalMarker += Char.ToString((char)sr.Read());
                    counter++;
                }

                string s;
                while ((s = Char.ToString((char)sr.Read())) != null)
                {
                    if (ContainsUniqueChars(potentionalMarker))
                    {
                        break;
                    }

                    counter++;
                    potentionalMarker = potentionalMarker.Substring(1);
                    potentionalMarker += s;
                }

                Console.WriteLine(counter);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Test if given string contains unique characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static bool ContainsUniqueChars(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
