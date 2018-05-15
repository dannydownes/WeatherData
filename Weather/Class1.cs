using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Weather
{
    class JaggedArray
    {
        // Reads the files and adds them to their respective arrays
        public static string[] Months = File.ReadAllLines(@"../../Data/Month.txt");
        public static string[] Years = File.ReadAllLines(@"../../Data/Year.txt");
        public static string[] AF = File.ReadAllLines(@"../../Data/WS1_AF.txt");
        public static string[] Rain = File.ReadAllLines(@"../../Data/WS1_Rain.txt");
        public static string[] Sun = File.ReadAllLines(@"../../Data/WS1_Sun.txt");
        public static string[] TMax = File.ReadAllLines(@"../../Data/WS1_TMax.txt");
        public static string[] TMin = File.ReadAllLines(@"../../Data/WS1_TMin.txt");

        // Used for converting the string arrays to relevant arrays 
        public static float[] MonthsFloat = new float[Months.Length];
        public static float[] YearsFloat = new float[Years.Length];
        public static float[] AFFloat = new float[AF.Length];
        public static float[] RainFloat = new float[Rain.Length];
        public static float[] SunFloat = new float[Sun.Length];
        public static float[] TMaxFloat = new float[TMax.Length];
        public static float[] TMinFloat = new float[TMin.Length];

        // Initializes the jagged array
        public static float[][] AllData = new float[Years.Length-1][];

        // Length variable
        public static int length = Years.Length - 1;

        public static void BuildJA()
        {
            for (int i = 0; i < length; i++)
            {
                MonthsFloat[i] = Convert.ToSingle(DateTime.ParseExact(Months[i], "MMMM", CultureInfo.InvariantCulture).Month);
                YearsFloat[i] = float.Parse(Years[i]);
                AFFloat[i] = float.Parse(AF[i]);
                RainFloat[i] = float.Parse(Rain[i]);
                SunFloat[i] = float.Parse(Sun[i]);
                TMaxFloat[i] = float.Parse(TMax[i]);
                TMinFloat[i] = float.Parse(TMin[i]);
            }

            for (int i = 0; i < length; i++)
            {
                AllData[i][0] = MonthsFloat[i];
                AllData[i][1] = YearsFloat[i];
                AllData[i][2] = AFFloat[i];
                AllData[i][3] = RainFloat[i];
                AllData[i][4] = SunFloat[i];
                AllData[i][5] = TMaxFloat[i];
                AllData[i][6] = TMinFloat[i];
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0, -15}" + "{1, -10}" + "{2, -10}" + "{3, -10}" + "{4, -10}" + "{5, -10}" + "{6, -10}", AllData[i][0], AllData[i][1], AllData[i][2], AllData[i][3], AllData[i][4], AllData[i][5], AllData[i][6]);
            }
        }
    }
}
