using System;
using System.Text;

namespace FinalWork
{
    public class HelperMethods // Вспомогательный класс, хранящий вспомогательные методы.
    {
        HelperDataArrayTests dataArray = new HelperDataArrayTests();

        public void ArrayPrint(string[] Array) // метод выполняющий отображение массива в терминале.
        {
            Console.WriteLine("[" + String.Join(", ", Array) + "]"); // склейка значений, для аналогичного вывода результата в условиях задания.
        }

        public string[] ArrayCheck(string[] ArrayCheck) // Метод получения нового массива, по текущему, использовая только значения, где количество символов 3 и меньше.
        {
            
            
            int SizeArray = 0;
            for(int i = 0; i < ArrayCheck.Length; i++) // цикл вычисляющий нужный размер для нового массива
            {
                if (ArrayCheck[i].Length <= 3)
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
                    if (ArrayCheck[i].Length <= 3)
                    {
                       ArrayItog[d] = "“" + ArrayCheck[i] + "”"; // склейка значений, для аналогичного вывода результата в условиях задания.
                       d++;       
                    }
                }
                return ArrayItog;
            }
            
        }
        public int CheckCondition(int i){
            int Number2 = -0;
            if (i == 1)
            {
                Console.WriteLine("Выберите вариант 1 или 2");
                Number2 = Convert.ToInt32(Console.ReadLine());
                if (Number2 != 1 & Number2 != 2)
                {
                    Thread.Sleep(400);
                    CheckCondition(1);
                }
                return Number2;
            }
            if (i == 2)
            {
                Console.WriteLine("Выберите один из предложенных вариантов");
                Number2 = Convert.ToInt32(Console.ReadLine());
                if (Number2 != 1 && Number2 != 2 && Number2 != 3)
                {
                    Thread.Sleep(400);
                    CheckCondition(2);
                }
                return Number2;
            }
            return Number2;
        }

        public int CheckOUT(int Number, int Size)
        {
            int Number0 = -0;
            Console.WriteLine("Выберите один из предложенных вариантов");
            Number0 = Convert.ToInt32(Console.ReadLine());
            if (Number0 < 1 || Number0 > Size)
            {
                Console.WriteLine($"Выберите один вариант 1-{Size}");
                CheckOUT(Number0,Size);
            }
            return Number0;
        }

        public string[] ArrayTest()
        {
            Console.WriteLine("Варианты массивов:");
            Console.Write("1. ");
            ArrayPrint(dataArray.ArrayTest(1));
            Console.Write("2. ");
            ArrayPrint(dataArray.ArrayTest(2));
            Console.Write("3. ");
            ArrayPrint(dataArray.ArrayTest(3));
            //int ArrayNumber = CheckCondition(2);
            int ArrayNumber = CheckOUT(2,3);
            return dataArray.ArrayTest(ArrayNumber);
        }

        public string[] CreatArray()
        {
            Console.WriteLine("Введите количество элементов в массиве:");
            int Length = 0;
            for(;Length < 2;)
            {
                Length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Значение количества элементов в массиве, должно быть больше 1");
            }
            //Length = Convert.ToInt32(Console.ReadLine());
            string[] Array = new string[Length];
            string ReadConsole;
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"Введите {i+1} значение");
                for(;;)
                {
                    #pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                    ReadConsole = Console.ReadLine();
                    #pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                    if (ReadConsole != "")
                    {
                        #pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
                        Array[i] = ReadConsole;
                        #pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите значние отличное от NULL");
                    }
                }
                
            }
            
            return Array;
        }
    }
}