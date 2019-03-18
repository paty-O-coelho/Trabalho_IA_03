using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_IA_03.AGClass
{
   public static class Utils
    {

        public static List <int>RandomNubers(int start, int end)
        {

            List<int> numbers = new List<int>();

            for (int i= start; i<end; i++)
            {
                numbers.Add(i);
            }

            //embaralhar a lista
            for (int i=0; i<numbers.Count; i++)
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
