using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Loading_bar
    {
        public void ShowLoadingBar(int totalSteps, int delayMilliseconds)
        {
            

            for (int i = 0; i <= totalSteps; i++)
            {
                int percentage = (i * 100) / totalSteps;
                int lines = (i * 40) / totalSteps; // Increase the number of lines for a larger bar

                Console.Write($"\t\t\t\t\t\t\t\t\t\t{new string('█', lines)}{new string(' ', 40 - lines)} {percentage}%");

                Thread.Sleep(delayMilliseconds);
                Console.SetCursorPosition(0, Console.CursorTop);
            }

            Console.WriteLine();
        }

        public static void choose()
        {

        }
    }
}
