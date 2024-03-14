using System;
using System.Text;

namespace FinalWork
{
    public class Array
    {
        
        public static void Main()
        {
            HelperDataArrayTests dataArray = new HelperDataArrayTests();
            HelperMethods helpMethods = new HelperMethods();

            string[] ArrayTest = dataArray.ArrayTest(1);
            helpMethods.ArrayPrint(ArrayTest);
        }
    }
}