using System.Collections.Generic;

namespace Trabalho_IA_03.AGClass
{
    public static class Utils
    {
        /// <summary>
        /// Embaralhar a lista.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static List<int> RandomNubers(int start, int end)
        {
            List<int> numbers = new List<int>();

            for (int i = start; i < end; i++)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                int a = ConfigurationGA.random.Next(numbers.Count);
                int temp = numbers[i];
                numbers[i] = numbers[a];
                numbers[a] = temp;
            }
            return numbers.GetRange(0, end);
        }
    }
}
