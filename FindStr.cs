using System;

namespace training_code_C_sharp
{
    static class FindStr
    {
        static public string str = "";
        static public string find_str = "";
        static int find_str_count = 0;
        static int count_str = 0;

        static public void ResetCount_str()
        {
            count_str = 0;
        }
        static public void Find()
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (find_str[0] == str[i])
                {
                    for (int j = 0; j < find_str.Length; j++)
                    {
                        if (find_str[j] == str[i])
                        {
                            find_str_count++;
                            if (i < str.Length - 1)
                            {
                                i++;
                            }
                            if (find_str_count == find_str.Length)
                            {
                                count_str++;
                                find_str_count = 0;
                            }
                        }
                        else
                        {
                            find_str_count = 0;
                            break;
                        }
                    }
                }
            }
        }

        static public void PrintResult()
        {
            Console.WriteLine($"{find_str} = {count_str}");
        }
    }
}
