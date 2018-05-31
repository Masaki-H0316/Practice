using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            bool b = Anagram(str1, str2);
            Console.WriteLine(b);
            
            Console.ReadLine();
        }
        
        /// <summary>
        /// FizzBuzz
        /// </summary>
        private void FizzBuzz()
        {
            int n = 1;

            for (int i = 0; i < 100; i++)
            {
                if (n % 3 == 0 && n % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (n % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (n % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine("{0}", n);
                }

                n++;
            }
        }

        /// <summary>
        /// アナグラム判定
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        private static bool Anagram(string word1, string word2)
        {
            char[] c1 = new char[word1.Length];
            char[] c2 = new char[word2.Length];

            // 配列にセット
            for (int i = 0; i < word1.Length; i++)
            {
                c1[i] = word1[i];
            }
            
            // 並び変え
            StringComparer cmp = StringComparer.OrdinalIgnoreCase;
            Array.Sort(c1, cmp);

            // 配列にセット
            for (int i = 0; i < word2.Length; i++)
            {
                c2[i] = word2[i];
            }
            
            // 並び変え
            Array.Sort(c2, cmp);

            // 全く同じ並びになっているはずなのでそのまま比較
            for (int i = 0; i < word1.Length; i++)
            {
                if (c1[i] != c2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
