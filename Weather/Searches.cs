using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Weather
{
    public class Searches
    {
        public static void LinearSearch(float Input, float[][] Search, int index)
        {
            // Iterates through every value in the array
            for (int i = 0; i < Search.Length; i++)
            {
                // Matches the value in the array to the inputted string
                if (Input == Search[i][index])
                {
                    Console.WriteLine("{0, -12}|" + "{1, -10}|" + "{2, -14}|" + "{3, -14}|" + "{4, -14}|" + "{5, -14}|" + "{6, -14}|" + "{7, -14}|" + "{8, -14}|" + "{9, -14}|" + "{10, -14}|" + "{11, -14}", CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(JaggedArray.AllData[i][12])), JaggedArray.AllData[i][1], JaggedArray.AllData[i][2], JaggedArray.AllData[i][3], JaggedArray.AllData[i][4], JaggedArray.AllData[i][5], JaggedArray.AllData[i][6], JaggedArray.AllData[i][7], JaggedArray.AllData[i][8], JaggedArray.AllData[i][9], JaggedArray.AllData[i][10], JaggedArray.AllData[i][11]);
                }
            }
        }
    }
}
