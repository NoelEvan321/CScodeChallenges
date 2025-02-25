﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges2
{
    internal class FibSequence
    {
        static void Main(string[] args)
        {
            /*Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
             1,2,3,5,8,13,21,34,55,89,and so on
            
             By Considering the terms in the fib seq whose values do not exceed four million,find the sum of the even-valued terms*/
            bool exit = false;
            List<int> fibSeq = new List<int>() { 1, 2 };
            int startNbr = 1;
            int fibNbr = startNbr;
            do
            {

                if (fibNbr <= 4_000_000)
                {
                    fibNbr = fibSeq[fibSeq.Count - 1] + fibSeq[fibSeq.Count - 2];
                    fibSeq.Add(fibNbr);
                    Console.WriteLine(fibSeq[fibSeq.Count - 1]);
                }
                else
                {
                    exit = true;
                }
            } while (!exit);
            var fibSeqEvens = fibSeq.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(fibSeqEvens.Sum());
        }
    }
}
