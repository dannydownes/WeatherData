using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Weather
{ 
    public class JaggedArray
    {
        // Reads the files and adds them to their respective arrays
        public static string[] Months = File.ReadAllLines(@"../../Data/Month.txt");
        public static string[] Years = File.ReadAllLines(@"../../Data/Year.txt");
        public static string[] AF = File.ReadAllLines(@"../../Data/WS1_AF.txt");
        public static string[] Rain = File.ReadAllLines(@"../../Data/WS1_Rain.txt");
        public static string[] Sun = File.ReadAllLines(@"../../Data/WS1_Sun.txt");
        public static string[] TMax = File.ReadAllLines(@"../../Data/WS1_TMax.txt");
        public static string[] TMin = File.ReadAllLines(@"../../Data/WS1_TMin.txt");
        public static string[] AF2 = File.ReadAllLines(@"../../Data/WS2_AF.txt");
        public static string[] Rain2 = File.ReadAllLines(@"../../Data/WS2_Rain.txt");
        public static string[] Sun2 = File.ReadAllLines(@"../../Data/WS2_Sun.txt");
        public static string[] TMax2 = File.ReadAllLines(@"../../Data/WS2_TMax.txt");
        public static string[] TMin2 = File.ReadAllLines(@"../../Data/WS2_TMin.txt");

        // Used for converting the string arrays to relevant arrays 
        public static float[] MonthsFloat = new float[Months.Length];
        public static float[] YearsFloat = new float[Years.Length];
        public static float[] AFFloat = new float[AF.Length];
        public static float[] RainFloat = new float[Rain.Length];
        public static float[] SunFloat = new float[Sun.Length];
        public static float[] TMaxFloat = new float[TMax.Length];
        public static float[] TMinFloat = new float[TMin.Length];
        public static float[] MYFloat = new float[Months.Length];
        public static float[] AF2Float = new float[AF2.Length];
        public static float[] Rain2Float = new float[Rain2.Length];
        public static float[] Sun2Float = new float[Sun2.Length];
        public static float[] TMax2Float = new float[TMax2.Length];
        public static float[] TMin2Float = new float[TMin2.Length];

        // Initializes the jagged array
        public static float[][] AllData = new float[Years.Length][];

        // Length variable
        public static int length = Years.Length;

        public static void BuildJA()
        {
            // converts every value to float type
            for (int i = 0; i < length; i++)
            {
                MonthsFloat[i] = Convert.ToSingle(DateTime.ParseExact(Months[i], "MMMM", CultureInfo.InvariantCulture).Month);
                YearsFloat[i] = float.Parse(Years[i]);
                AFFloat[i] = float.Parse(AF[i]);
                RainFloat[i] = float.Parse(Rain[i]);
                SunFloat[i] = float.Parse(Sun[i]);
                TMaxFloat[i] = float.Parse(TMax[i]);
                TMinFloat[i] = float.Parse(TMin[i]);
                AF2Float[i] = float.Parse(AF2[i]);
                Rain2Float[i] = float.Parse(Rain2[i]);
                Sun2Float[i] = float.Parse(Sun2[i]);
                TMax2Float[i] = float.Parse(TMax2[i]);
                TMin2Float[i] = float.Parse(TMin2[i]);

                //anything below 12 doesnt work because december would be 1.2 which would add more than 1 year
                MYFloat[i] = Convert.ToSingle(YearsFloat[i] + (MonthsFloat[i]/12));
            }

            // Populates the columns with data from each singular array in float type
            for (int i = 0; i < length; i++)
            {
                AllData[i] = new float[]
                {
                    MYFloat[i],               
                    YearsFloat[i],
                    AFFloat[i],
                    RainFloat[i],
                    SunFloat[i],
                    TMaxFloat[i],
                    TMinFloat[i],
                    AF2Float[i],
                    Rain2Float[i],
                    Sun2Float[i],
                    TMax2Float[i],
                    TMin2Float[i],                  
                    MonthsFloat[i]
                };
            }
        }

        // Responisble for printing the jagged array whenever displaying the data is requested
        public static void PrintJA()
        { 
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0, -12}|" + "{1, -10}|" + "{2, -14}|" + "{3, -14}|" + "{4, -14}|" + "{5, -14}|" + "{6, -14}|" + "{7, -14}|" + "{8, -14}|" + "{9, -14}|" + "{10, -14}|" + "{11, -14}", CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(JaggedArray.AllData[i][12])), JaggedArray.AllData[i][1], JaggedArray.AllData[i][2], JaggedArray.AllData[i][3], JaggedArray.AllData[i][4], JaggedArray.AllData[i][5], JaggedArray.AllData[i][6], JaggedArray.AllData[i][7], JaggedArray.AllData[i][8], JaggedArray.AllData[i][9], JaggedArray.AllData[i][10], JaggedArray.AllData[i][11]);
            }
        }
    }
}
