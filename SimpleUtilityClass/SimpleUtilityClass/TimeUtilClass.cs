using System;

namespace SimpleUtilityClass
{
    // Static classes can only
    // contain static members
    static class TimeUtilClass
    {
       
        public static void PrintTime()
            => Console.WriteLine(Now.ToShortTimeString());

        public static void PrintDate()
            => Console.WriteLine(Today.ToShortDateString());

    }
}
