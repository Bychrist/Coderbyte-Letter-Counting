using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public static string TakeString(string str)
        {
            string letter = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            string[] strArray = str.Split(' ');
            char[] letterArray = letter.ToCharArray();
            List<int> getList = new List<int>();
            int counter = 0;
            foreach (var item in strArray)
            {
                foreach (char leta in letterArray)
                {
                     counter = counter +  item.Count(f => (f == leta));
                }

                getList.Add(counter);
                counter = 0;
            }

            int maxValue = getList.Max();
            int indexme = getList.IndexOf(maxValue);

            return strArray[indexme];
           
        }
        static void Main(string[] args)
        {
            string check = "I am Hello apple tommmy";
            var result = TakeString(check);
            Console.WriteLine(result);
        }
    }
}
