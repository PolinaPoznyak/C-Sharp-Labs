using System;
using System.Text;

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
            intNum = (int)data;
            dynamic attention = 10;
            attention = "hello";
            Console.WriteLine(attention);
            
            int? i = 10; // или Nullable<int> i

            if(i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
            else
            {
                Console.WriteLine("No value");
            }
            #endregion
            #region Строки
            string str1 = "word";
            string str2 = "word 111";
            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str2.Contains(str1));
            Console.WriteLine(string.Concat(str1, str2));
            str1 = string.Copy(str2);
            Console.WriteLine(str1);
            Console.WriteLine(str1.Substring(2));
            var words = str2.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(str1.Insert(1,"inserted"));
            Console.WriteLine(str2.Remove(4));
            Console.WriteLine("{0} {1}", str1, str2);
            Console.WriteLine($"{str1} {str2}");
            string emptyStr = null;
            if (string.IsNullOrEmpty(emptyStr))
            {
                Console.WriteLine("This str is empty");
            }
            var newStr = new StringBuilder("hello ", 255);
            newStr.Remove(2, 1);
            newStr.Insert(0, "hi ");
            newStr.Append("bye");
            Console.WriteLine(newStr);
            #endregion
            #region Массивы
            int[,] array = new int [3,3];
            var rnd = new Random();
            var rowSize = array.GetUpperBound(0) + 1;
            var collumnSize = array.Length / rowSize;
            for (int rowIdx = 0; rowIdx < rowSize; rowIdx++)
            {
                for (int collumnIdx = 0; collumnIdx < collumnSize; collumnIdx++)
                {
                    array[rowIdx, collumnIdx] = rnd.Next(10);
                    Console.Write($"{array[rowIdx, collumnIdx]} ");
                }
                Console.WriteLine();
            }
            #endregion

            _ = Console.ReadKey();
        }
    }
}
