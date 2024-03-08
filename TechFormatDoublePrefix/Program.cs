#region FileHeader
/*
Project:     TechFormatDoublePrefix
Filename:    Program.cs
Last write:  08/03/2024 4:23:13 PM
Creation:    08/03/2024 3:16:27 PM

© Public Domain
Written by E.H. Terwiel
Utrecht, the Netherlands
*/
#endregion FileHeader


namespace TechFormatDoublePrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
                           //5.000563466587678545345434
            double input = 5.000563466587678545345434 * Math.Pow(10, -9);
            string units = "m";
            const string pref = "YZEPTGMk mμnpfazy";
            char prefix = ' ';
            double f;
            double value = 0;

            var g = Math.Log10(Math.Abs(input)) / 3;
            prefix = pref[8 - (int)Math.Floor(g)];
            value = Math.Pow(10, (g - Math.Floor(g)) * 3) * Math.Sign(input);

            Console.WriteLine($"{value:N3} {prefix}{units}");
        }

    }
}
