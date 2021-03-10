using System;
using System.Collections.Generic;

namespace training_code_C_sharp
{
    static class CountWords
    {
        static public string str = "";
        static public HashSet<string> arr_str = new HashSet<string>();
        static bool switcher = false;
        static string temp_str = "";

        static public void CountWorlds()
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    temp_str += str[i];
                    switcher = true;
                }
                else
                {
                    if (switcher)
                    {
                        arr_str.Add(temp_str);
                        temp_str = "";
                        switcher = false;
                    }
                }
            }
        }
        static public void PrintWorlds()
        {
            int i = 0;
            foreach (var item in arr_str)
            {
                Console.WriteLine($"arr_str[{i++}] = {item}");
            }
        }
    }
}
