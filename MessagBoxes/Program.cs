using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace MessagBoxes
{
    internal class Program
    {
        static void Main()
        {
            FirstTask(); // первое задание
            //ThirdTask(); // третье задание
        }

        /* ЗАДАНИЕ 1:
         * Разработайте приложение, которое использует унаследованный код. 
         * Вам необходимо использовать функцию MessageBox из Windows API. 
         * Отобразите с помощью MessageBox информацию о вас. Данные должны быть показаны в нескольких MessageBox.   
         */

        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, int options);

        static void FirstTask()
        {
            string name = "Филипп";
            string age = "19";
            string location = "Ставрополь";

            MessageBox(IntPtr.Zero, $"Имя: {name}", "Информация обо мне", 0);
            MessageBox(IntPtr.Zero, $"Возраст: {age}", "Информация обо мне", 0);
            MessageBox(IntPtr.Zero, $"Место жительства: {location}", "Информация обо мне", 0);
        }


        /* ЗАДАНИЕ 3:
         * Разработайте приложение, которое использует унаследованный код. 
         * Вам необходимо использовать функции Beep и MessageBeep из Windows API. 
         * С помощью импортированных функций сгенерируйте набор звуковых сигналов через определенные промежутки времени.   
         */

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        static void ThirdTask()
        {
            int[] frequencies = { 784, 784, 932, 1047, 784, 784, 699, 740, 784, 784, 932, 1047, 784, 784, 699, 740, 932, 784, 587, 932, 784, 554, 932, 784, 523, 466, 523 };
            int[] durations = { 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 1200, 150, 150, 1200, 150, 150, 1200, 150, 150 };
            int[] timeouts = { 300, 300, 150, 150, 300, 300, 150, 150, 300, 300, 150, 150, 300, 300, 150, 150, 0, 0, 75, 0, 0, 75, 0, 150, 0, 0 };

            for (int i = 0; i < frequencies.Length; i++)
            {
                Beep(frequencies[i], durations[i]);
                Thread.Sleep(timeouts[i]);
            }
        }
    }
}
