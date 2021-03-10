using System;
using System.Collections.Generic;


namespace training_code_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string user_str = Console.ReadLine();
            FindStr.str = user_str;
            CountWords.str = user_str;

            CountWords.CountWorlds();
            CountWords.PrintWorlds();
            foreach (var item in CountWords.arr_str)
            {
                FindStr.find_str = item;
                FindStr.Find();
                FindStr.PrintResult();
                FindStr.ResetCount_str();
            }
        }
    }
}
