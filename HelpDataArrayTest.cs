using System;
using System.Text;

namespace FinalWork
{
    public class HelperDataArrayTests //Вспомогательный класс, хранящий метод содержащий тестовые массивы для проверки из условий задания.
    {
        public  string[] ArrayTest(int Number)
        {
            string[] Data = ["1", "2"];

            if (Number == 1)
            {

                Data = ["“Hello”", "“2”", "“world”", "“:-)”"];
            }
            if (Number == 2)
            {

                Data = ["“1234”", "“1567”", "“-2”", "“computer science”"];
            }
            if (Number == 3)
            {

                Data = ["“Russia”", "“Denmark”", "“Kazan”"];
            }
            if (Number != 1 & Number != 2 & Number != 3)
            {
                Console.WriteLine("Повторите выбор варианта 1-3");
                Environment.Exit(0);
            }

            return Data;
        }
    }
}