using System.Collections.Generic;
using System;
using System.Linq;

class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        var pairsList = new List<int>();
        var pairsCount = 0;
        ar.GroupBy(a=>a).ToList().ForEach(g => pairsList.Add(g.Count()));
        foreach (var item in pairsList)
        {
            if (item > 0)
            {
                if (item % 2 == 0)
                {
                    pairsCount += item / 2;
                }
                else
                {
                    pairsCount+= (item-1) / 2;
                    
                }
                }

            }
        return pairsCount;
        }
      
    }


class Solution
{
    public static void Main(string[] args)
    {

        int n = 30;

       var ar =  new List<int>() { 10,10,20,20,20, 30, 30, 30, 30, 30 };

        int result = Result.sockMerchant(n, ar);

        Console.WriteLine(result);

       ;
    }
}
