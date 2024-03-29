using System;
using System.Text;

namespace FinalWork
{
    public class HelperMethods // Вспомогательный класс, хранящий вспомогательные методы.
    {
        HelperDataArrayTests dataArray = new HelperDataArrayTests();

        public  void ArrayPrint(string[] Array) // метод выполняющий отображение массива в терминале.
        {
            Console.WriteLine("[" + String.Join(", ", Array) + "]"); // склейка значений, для аналогичного вывода результата в условиях задания.
        }

        public  string[] ArrayCheck(string[] ArrayCheck) // Метод получения нового массива, по текущему, использовая только значения, где количество символов 3 и меньше.
        {
            
            int SizeArray = 0;
            for(int i = 0; i < ArrayCheck.Length; i++) // цикл вычисляющий нужный размер для нового массива
            {
                if (ArrayCheck[i].Length <= 5)
                {
                     SizeArray++;                 
                }
            }
            if (SizeArray == 0) // В случаях когда ни одно значения не подходит под условия, создаётся пустой пассив.
            {
                string[] ArrayItog = new string[1];
                return ArrayItog;
            }
            else // по предыдущему циклу создаётся массив, а так же заполняется значениями, которые выполняют условия.
            {
                string[] ArrayItog = new string[SizeArray];
                int d = 0;
                for (int i = 0; i < ArrayCheck.Length; i++)
                {
                    if (ArrayCheck[i].Length <= 5)
                    {
                       ArrayItog[d] = ArrayCheck[i]; // склейка значений, для аналогичного вывода результата в условиях задания.
                       d++;       
                    }
                }
                return ArrayItog;
            }
            
        }
        

        public  int CheckOUT(int Number, int Size) // Проверяет входные данные для методов.
        {
            int Number0 = -0;
            Number0 = Convert.ToInt32(Console.ReadLine());
            if (Number0 < 1 || Number0 > Size)
            {
                Console.WriteLine($"Выберите один вариант 1-{Size}");
                Number0 = CheckOUT(Number0,Size);
            }
            return Number0;
        }

        public string[] ArrayTest() // Выводит примеры массивов из условия задания и предлагает выбрать один.
        {
            Console.WriteLine("Варианты массивов:");
            Console.Write("1. ");
            ArrayPrint(dataArray.ArrayTestExample(1));
            Console.Write("2. ");
            ArrayPrint(dataArray.ArrayTestExample(2));
            Console.Write("3. ");
            ArrayPrint(dataArray.ArrayTestExample(3));
            int ArrayNumber = CheckOUT(2,3);
            return dataArray.ArrayTestExample(ArrayNumber);
        }

        public  string[] CreatArray() // Создание пользовательского массива.
        {
            Console.WriteLine("Введите количество элементов в массиве:");
            int Length = 0;
            for(;Length < 2;)
            {
                Length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Значение количества элементов в массиве, должно быть больше 1");
            }
            
            string[] ArrayItog = new string[Length];
            
            for (int i = 0; i < Length;)
            {
                Console.WriteLine($"Введите {i+1} значение");
                
                    
                string? ReadConsole = Console.ReadLine();
                    
                if (ReadConsole != "")
                {
                    ArrayItog[i] = "“" + ReadConsole + "”";
                    i++;
                    }
                else
                {
                    Console.WriteLine("Введите значние отличное от NULL");
                }
                
                
            }
            
            return ArrayItog;
        }
    }
}