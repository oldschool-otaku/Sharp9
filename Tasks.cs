using System;
using System.Collections.Generic;

namespace Sharp9
{
    public static class Tasks
    {
        //TODO: по возможности оптимизировать
        public static int GetDigits(out List<int> numbers)
        {
            //ссылка на лист
            numbers = new List<int>();
            
            
            Console.WriteLine("Needed numbers: ");
            //нам же нужно деление на 9? поэтому 9 и прибавляем
            for (int i = 108; i <= 999; i += 9)
            {
                int withoutMiddle = i / 100 * 10 + i % 10; //тут мы убираем из числа цифру посередине
                if (i / 9 != withoutMiddle) continue; //ежели не делится то начинаем заново
                //вот это ежели оно делится на 9 
                numbers.Add(i); 
                Console.WriteLine(i);
            }
            
            Console.WriteLine();
            Console.WriteLine("Amount of needed numbers:");
            
            return numbers.Count;
        }
    }
}