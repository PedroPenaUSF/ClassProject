
using System;
    
namespace Wicksy_Business
{ 
 class Program
{
    static void Main(string[] args)
    {
        int candlesNeededToSell = Convert.ToInt32(Console.ReadLine());
        int friendGroups = Convert.ToInt32(Console.ReadLine());
        int[] friendsInGroup = new int[friendGroups];
        int candlesSold = 0;
        int magnitude = 0;
        

        for (int i = 0; i < friendGroups; i++)
        {
           friendsInGroup[i] = Convert.ToInt32(Console.ReadLine());
        }

        int previousGroupTotal = friendsInGroup[0];

        for(int j = 0; j < friendGroups; j++)
        {
                
                if (j == 0)
               {
                    candlesSold += friendsInGroup[j];
                    magnitude += 1;
               }
               else
               {
                 
                 candlesSold += (previousGroupTotal) * friendsInGroup[j];
                 magnitude += 1;
                 previousGroupTotal = (previousGroupTotal) * friendsInGroup[j];
               }

               if (candlesSold >= candlesNeededToSell)
               {
                   break;
               }
                
        }

            if (candlesSold >= candlesNeededToSell)
            {
                Console.WriteLine(magnitude);
            }
            else
            {
                Console.WriteLine("We need " + (candlesNeededToSell - candlesSold) + " more friends!!!");
            }

        }
}

}

