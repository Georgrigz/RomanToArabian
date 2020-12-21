using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanToArabian
{
    
    class Program
    {
        public static void ToRoman(string roman, Dictionary<Char,int> RomanDig)
        {
            int res = 0;
            
            for (int i = 0; i < roman.Length; i++)
            {
                if (i == 0 || RomanDig.GetValueOrDefault(roman[i]) <= RomanDig.GetValueOrDefault(roman[i - 1]))
                {
                    res += RomanDig.GetValueOrDefault(roman[i]);
                }
                else
                {
                    res += RomanDig.GetValueOrDefault(roman[i]) - 2 * RomanDig.GetValueOrDefault(roman[i - 1]);
                }

            }
            Console.WriteLine("число "+roman+" равно "+res+"\n");
        }

        static void Main(string[] args)
        {
            Dictionary<Char, int> RomanDig = new Dictionary<Char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            bool flag = true;
            
            while (flag)
            {
                Console.WriteLine("нажмите 0 для выхода или 1 для продолжения\n");
                int caseSwitch = int.Parse(Console.ReadLine());
                switch(caseSwitch)
                {
                    case 1:
                        Console.WriteLine("введите число в римском представлении\n");
                        string roman = Console.ReadLine();
                        roman = roman.ToUpper();
                        ToRoman(roman, RomanDig);
                        break;
                    case 0:
                        flag = false;
                        break;      
                }    
            }
        }
    }
}
