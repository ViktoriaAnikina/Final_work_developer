using System;
using System.Text;

namespace FinalWork
{
    public class HelperMethods // Вспомогательный класс, хранящий вспомогательные методы.
    {
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
    }
}