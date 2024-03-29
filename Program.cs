﻿using System;
using System.Text;

namespace FinalWork
{
    public class Program // Основной класс программы
    {
        
        public static void Main() //Основной метод программы.
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16"); // Смена кодировки, исправлена ошибка, когда при вводе русского текста в тело массива оно не обробатовалось.(воспроизводилось только на Visual Studio Code, на версии Community нет)

            HelperDataArrayTests dataArray = new HelperDataArrayTests();
            HelperMethods helpMethods = new HelperMethods();

            string[] ArrayTest;

            Console.Write("Выберите вариант начальных данных, где ");
            Console.WriteLine("1 - Выбор из предложенных варианов, 2 - ввод массива чисел через консоль: ");
            int NumberCondition = helpMethods.CheckOUT(1,2); // Метод обрабатывающий варианты выбора, исключающий неверные.
            if (NumberCondition == 1)
            {
                ArrayTest = helpMethods.ArrayTest(); 
            }
            else
            {
                ArrayTest = helpMethods.CreatArray();
            }

            string[] ArrayItog = helpMethods.ArrayCheck(ArrayTest);  //Получения массива с выполнением условий задания.
            Console.Write("[" + String.Join(", ", ArrayTest) + "] → "); // склейка с добавлением начального массива в вывод.
            helpMethods.ArrayPrint(ArrayItog); // Печать полученного массива в терминал.
        }
    }
}