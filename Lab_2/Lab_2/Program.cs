using System;

namespace Lab_2
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Типы
            int intNum = 10;
            double doubleNum = 10.78;
            float floatNum = 124.7F;
            long longNum = 1000000000000000L;
            decimal decNum = 123244.1M;
            sbyte sbyteNum = 127;
            short shortNum = 1000;
            byte byteNum = 255;
            uint uintNum = 100000000U;
            ulong ulongNum = 1000000000000000000UL;
            char charVar = 'a';
            bool boolVar = true;
            ushort ushortNum = 10000;

            // Неявное преобразование
            shortNum = byteNum;
            floatNum = uintNum;
            intNum = charVar;
            decNum = intNum;
            decNum = byteNum;

            // Явное преобразвание
            intNum = (int)floatNum;
            floatNum = (float)intNum;
            doubleNum = (double)intNum;
            ulongNum = (ulong)ushortNum;
            doubleNum = (double)shortNum;

            Console.WriteLine($" {intNum} {doubleNum} {floatNum} {longNum} " +
                $"{decNum} {sbyteNum} {shortNum}");

            string input = Console.ReadLine();
            try
            {
                intNum = Convert.ToInt32(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            input = Console.ReadLine();
            try
            {
                doubleNum = Convert.ToDouble(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($" {intNum} {doubleNum} {floatNum} {longNum} " +
                $"{decNum} {sbyteNum} {shortNum}");

            // Упаковка
            object data = intNum;
            // Распаковка
            intNum = data;

            #endregion


            _ = Console.ReadKey();
        }
    }
}
