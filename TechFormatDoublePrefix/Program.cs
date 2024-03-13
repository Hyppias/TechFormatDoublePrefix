#region FileHeader
/*
Project:     TechFormatDoublePrefix
Filename:    Program.cs
Last write:  08/03/2024 4:23:13 PM
Creation:    08/03/2024 3:16:27 PM

By nitrateag
https://stackoverflow.com/questions/26209217/how-to-code-metric-prefix-kilo-mega-giga-etc-and-do-calculation-on-them
Adapted by E.H. Terwiel, the Netherlands
*/
#endregion FileHeader

namespace TechFormatDoublePrefix
{
    internal class Program
    {


        static void Main(string[] args)
        {                          //5.000563466587678545345434

            double value = -1223.2343456; // -12.345 mm -> -0.0123456 m

            int i = 1;
            int j = -1;
            for (int n = -18; n < 16; n += 3)
            {
                Convert(value, "g");
            }
        }

        public static void Convert(double value, string parameter)
        {

            if (parameter[0] == 'g')
            {
                value *= 1000;
            }

            const string pref = "yzafpnμm kMGTPEZY";            

            int log10 = (int)Math.Log10(Math.Abs(value));
            if (log10 < -27)
            {
                Console.WriteLine("0.000");
            }

            if (log10 % -3 < 0)
            {
                log10 -= 3;
            }

            int log1000 = Math.Max(-8, Math.Min(log10 / 3, 8));
            Console.WriteLine($"{(double)value / Math.Pow(10, log1000 * 3)} {pref[log1000 + 8]}{parameter}");
        }
    }

}
