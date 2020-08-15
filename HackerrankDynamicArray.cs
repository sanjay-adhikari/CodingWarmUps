using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerrankDynamicArray.cs
{
    class Program
    {
        //It is hard to understand but easy to solve. 
    
        public static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            List<int> result = new List<int>(); //return result of lastanswers


            //Setup
            #region Setup - understanding

            // 1. Create a list, seqList, of  empty sequences, where each sequence is indexed from 0 to N-1 . 
                                          // The elements within each of the N sequences also use 0-indexing.
            // 2. Create an integer lastAnswer and initialize to 0

            #endregion

            // i.e. seqList = List of 'n' lists of int

            List<List<int>> seqList = new List<List<int>>(); 
            int lastAnswer = 0; //create an integer lastAnswer and initialize to 0

            for (int i = 0; i < n; i++) 
                seqList.Add(new List<int>());


            // Query
            #region Query Understanding

            // there are 2 Types of Queries- 1 & 2
            // if query starts with 1, then it is Query 1 AND if query starts with 2, then it is Query 2 
            // list<int> of input has format of [1 x y] or [2 x y] in one list inside the queries (because queries hold the list of list of integers)
            // further breakdown:
            // e.g if current query inside queries is [1 0 2]
            //                     then 1 means it is of query 1
            //                     x = 0
            //                     y = 2

            #endregion


            foreach (var query in queries)
            {
                var x = query[1]; // get index 1 element...ie if 1 0 2, index[1] holds the value = 0
                int y = query.Last(); // or query[2] e.g. 2 1 3

                int index = (x ^ lastAnswer) % n; // ^ means X-OR AND index = (x X-OR lastAnswer) % N

                var queryType = query.First();

                if (queryType == 1) //query 1 
                {
                    seqList[index].Add(y); //Append integer y to sequence seqList. y means the last value...2 is last value from 1 0 2
                }

                else //query 2 
                {
                    int size = seqList[index].Count;
                    lastAnswer = seqList[index][y % size]; //lastAnswer = find the value of element  in y % size of seq

                    result.Add(lastAnswer);
                }
            }
        
            return result;
        }
        static void Main(string[] args)
        {
            int n = 2;
            List<List<int>> inp = new List<List<int>>();

            var a = new List<int> { 1, 0, 5 };
            var b = new List<int> { 1, 1, 7 };
            var c = new List<int> { 1, 0, 3 };
            var d = new List<int> { 2, 1, 0 };
            var e = new List<int> { 2, 1, 1 };

            inp.Add(a);
            inp.Add(b);
            inp.Add(c);
            inp.Add(d);
            inp.Add(e);

            var result = DynamicArray(n, inp);

            foreach (var l in result)
                Console.Write("{0} \t", l);

            Console.ReadKey();

        }
    }
}
