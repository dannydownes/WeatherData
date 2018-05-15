using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Weather
{
    public class Sorts
    {
        public static void QuickSortAscending(float[][] data, int left, int right, int index)
        {
            int i, j;
            float pivot;
            float[] temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2][index];

            // Compares each number to the pivot and moves it to the correct side
            while (i <= j)
            {
                while ((data[i][index] < pivot) && (i < right))
                    i++;

                while ((pivot < data[j][index]) && (j > left))
                    j--;

                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            }

            // Calls itself to sort the numbers either side
            if (left < j)
            {
                QuickSortAscending(data, left, j, index);
            }

            if (i < right)
            {
                QuickSortAscending(data, i, right, index);
            }
        }

        public static void QuickSortDescending(float[][] data, int left, int right, int index)
        {
            int i, j;
            float pivot;
            float[] temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2][index];

            // Compares each number to the pivot and moves it to the correct side
            while (i <= j)
            {
                while ((data[i][index] > pivot) && (i < right))
                    i++;

                while ((pivot > data[j][index]) && (j > left))
                    j--;

                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            }

            // Calls itself to sort the numbers either side
            if (left < j)
            {
                QuickSortDescending(data, left, j, index);
            }

            if (i < right)
            {
                QuickSortDescending(data, i, right, index);
            }
        }

        public static void PrintData(int index)
        {
            // Variables used for averages
            float Median = 0;
            float Mean = 0;
            int size = JaggedArray.Years.Length;
            int mid = (size - 1/2) / 2;

            // Finds the median
            if (size % 2 == 0)
            {
                Median = ((JaggedArray.AllData[mid][index] + JaggedArray.AllData[mid - 1][index]) / 2);
            }
            else
            {
                Median = JaggedArray.AllData[mid][index];
            }
            // End of median

            // Finds the mean
            for (int i = 0; i < size; i++)
            {
                Mean += JaggedArray.AllData[i][index]; 
            }
            Mean = Mean / size;
            // End of mean

            // Responsible for printing the data
            Console.WriteLine("\n\t\tMonth       |Year      |Air Frost |Avg Rain  |Avg Sun   |Temp Max  |Temp Min");
            Console.WriteLine("\t\t____________|__________|__________|__________|__________|__________|________");
            Console.WriteLine("Minimum:\t{0, -12}|" + "{1, -10}|" + "{2, -10}|" + "{3, -10}|" + "{4, -10}|" + "{5, -10}|" + "{6, -10}", CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(JaggedArray.AllData[0][12])), JaggedArray.AllData[0][1], JaggedArray.AllData[0][2], JaggedArray.AllData[0][3], JaggedArray.AllData[0][4], JaggedArray.AllData[0][5], JaggedArray.AllData[0][6]);
            Console.WriteLine("Maximum:\t{0, -12}|" + "{1, -10}|" + "{2, -10}|" + "{3, -10}|" + "{4, -10}|" + "{5, -10}|" + "{6, -10}", CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(JaggedArray.AllData[JaggedArray.Years.Length - 1][12])), JaggedArray.AllData[JaggedArray.Years.Length - 1][1], JaggedArray.AllData[JaggedArray.Years.Length - 1][2], JaggedArray.AllData[JaggedArray.Years.Length - 1][3], JaggedArray.AllData[JaggedArray.Years.Length - 1][4], JaggedArray.AllData[JaggedArray.Years.Length - 1][5], JaggedArray.AllData[JaggedArray.Years.Length - 1][6]);
            Console.WriteLine("\nMedian:\t\t{0}", (Median).ToString("0.0"));
            Console.WriteLine("Mean:\t\t{0}", (Mean).ToString("0.0"));
        }
    }
}
