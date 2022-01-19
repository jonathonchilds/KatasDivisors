using System.Collections.Generic;


namespace KatasDivisors
{
    class Program
    {
        public static int[] Divisors(int n)
        {
            List<int> divisors = new List<int>();

            for (int i = 2; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    divisors.Add(i);
                }
            }
            if (divisors.Count < 1)
            {
                return null;
            }
            else
            {
                return divisors.ToArray();
            }
        }
    }
}


// using System.Collections.Generic;
// public class Kata
// {
//   public static int[] Divisors(int n)
//         {
//             List<int> divisors = new List<int>();

//             for (int i = 2; i < n - 1; i++)
//             {
//                 if (n % i == 0)
//                 {
//                     divisors.Add(i);

//                 }
//             }
//             if (divisors.ToArray().Length < 1)
//             {
//                 return null;
//             }
//             else
//             {
//                 return divisors.ToArray();
//             }

//         }
// }