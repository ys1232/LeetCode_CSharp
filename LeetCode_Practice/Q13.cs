using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    class Q13
    {
        public class Solution
        {
            public int RomanToInt(string s)
            {
                Dictionary<string, int> RomanNumerals_Lkup = new Dictionary<string, int> ();
                    
            }

            public string IntToRoman(int num)
            {
                int _num = num;
                int count = 0;
                string Roman_numerals = "";
                Roman_Symbol[] Roman_Symbol_arry = new Roman_Symbol[7];
                Roman_Symbol_arry[0] = new Roman_Symbol() { Current_Roman_Symbol = "M", Fivth_Roman_Symbol = "U", Tenth_Roman_Symbol = "U", integer_num = 1000 };
                Roman_Symbol_arry[1] = new Roman_Symbol() { Current_Roman_Symbol = "C", Fivth_Roman_Symbol = "D", Tenth_Roman_Symbol = "M", integer_num = 100 };
                Roman_Symbol_arry[2] = new Roman_Symbol() { Current_Roman_Symbol = "X", Fivth_Roman_Symbol = "L", Tenth_Roman_Symbol = "C", integer_num = 10 };
                Roman_Symbol_arry[3] = new Roman_Symbol() { Current_Roman_Symbol = "I", Fivth_Roman_Symbol = "V", Tenth_Roman_Symbol = "X", integer_num = 1 };


                for (int i = 0; i < 4; i++)
                {
                    count = _num / Roman_Symbol_arry[i].integer_num;
                    _num = _num % Roman_Symbol_arry[i].integer_num;
                    Roman_numerals = Roman_numerals + Roman_Symbol.Get_Roman_Symbols(count, Roman_Symbol_arry[i]);
                }

                return Roman_numerals;
            }


            public void Test_Case()
            {
                Console.WriteLine("98:" + IntToRoman(98));
                Console.WriteLine("99:" + IntToRoman(99));
                Console.WriteLine("58:" + IntToRoman(58));
                Console.WriteLine("21:" + IntToRoman(21));
                Console.WriteLine("39:" + IntToRoman(39));
                Console.WriteLine("3499:" + IntToRoman(3499));
                Console.WriteLine("3999:" + IntToRoman(3999));

                Console.ReadLine();
            }


            public class Roman_Symbol
            {
                public string Current_Roman_Symbol { get; set; }

                public string Fivth_Roman_Symbol { get; set; }

                public string Tenth_Roman_Symbol { get; set; }

                public int integer_num { get; set; }

                public static string Get_Roman_Symbols(int Cnt, Roman_Symbol Roman_Symbol_Unit)
                {
                    if (Cnt == 0)
                        return "";
                    else if (Cnt < 4)
                        return Dup_Symbol(Cnt, Roman_Symbol_Unit.Current_Roman_Symbol);
                    else if (Cnt == 4)
                        return Roman_Symbol_Unit.Current_Roman_Symbol + Roman_Symbol_Unit.Fivth_Roman_Symbol;
                    else if (Cnt == 5)
                        return Roman_Symbol_Unit.Fivth_Roman_Symbol;
                    else if (Cnt < 9)
                        return Roman_Symbol_Unit.Fivth_Roman_Symbol + Dup_Symbol(Cnt - 5, Roman_Symbol_Unit.Current_Roman_Symbol);
                    else if (Cnt == 9)
                        return Roman_Symbol_Unit.Current_Roman_Symbol + Roman_Symbol_Unit.Tenth_Roman_Symbol;
                    else
                        return "error";

                }

                public static string Dup_Symbol(int Cnt, string Symbol)
                {
                    string _Symbol = "";
                    for (int i = 0; i < Cnt; i++)
                    {
                        _Symbol = _Symbol + Symbol;
                    }
                    return _Symbol;
                }

            }
        }


    }
}
