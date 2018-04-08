using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the staircase function below.
     */
    static void staircase(int n) {
        for(int outerloop=n;outerloop>0;outerloop--){
            for(int innerloop=1;innerloop<=n;innerloop++){
                if(innerloop>=outerloop){
                    Console.Write("#");
                }
                else{
                Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
