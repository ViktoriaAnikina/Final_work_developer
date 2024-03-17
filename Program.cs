﻿using System;
using System.Text;

namespace FinalWork
{
    public class Array // Основной класс программы
    {
        
        public static void Main() //Основной метод программы.
        {
            HelperDataArrayTests dataArray = new HelperDataArrayTests();
            HelperMethods helpMethods = new HelperMethods();

            string[] ArrayTest;

            Console.Write("Выберите вариант начальных данных, где ");
            Console.WriteLine("1 - Выбор из придложенных варианов, 2 - ввод массива чисел через консоль: ");
            //int NumberCondition = helpMethods.CheckCondition(1);
            int NumberCondition = helpMethods.CheckOUT(1,2);
            if (NumberCondition == 1)
            {
                ArrayTest = helpMethods.ArrayTest();
            }
            else
            {
                ArrayTest = helpMethods.CreatArray();
            }

            
            // string[] ArrayTest = ["1","2"]; // Вариант для использования своего массива.
            //string[] ArrayTest = dataArray.ArrayTest(1); // В параметре выбрать один из 3 вариантов предложенных для проверки.
            string[] ArrayItog = helpMethods.ArrayCheck(ArrayTest);  //Получения массива с выполнением условий задания.
            Console.Write("[" + String.Join(", ", ArrayTest) + "] → "); // склейка с добавлением начального массива в вывод.
            helpMethods.ArrayPrint(ArrayItog); // Печать полученного массива в терминал.
        }
    }
}