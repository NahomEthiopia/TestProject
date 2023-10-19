// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Windows;


namespace Leetcode3sum
{
    public class program
    {
        // herer we are going to empliment an entry and exit for our program execution ;
        public static void Main(string[] args)
        {
            int[] given = new int[7]{3, 5, 7, 8, 9, 11, 13 };
            int[] given1 = new int[6] { -1, 0, 1, 2, -1, -4 };
            Threesum.getthreesum(given1);

      
            
            
        }
    } 

    public class Threesum
    {
        public static  IList<IList<int>> getthreesum(int[] array)
        {
           var Result = new List<IList<int>>();
           Array.Sort(array);
           int Length = array.Length;
           // HashSet<int> Distinct = new HashSet<int>();
           //int target = 0; 
           
            for(int i = 0; i < Length; i++)
            {
             
               //  if(i != 0 && array[i - 1] == array[i])
               //     {
                //   continue;
                  //  }

                for(int start = i+1 , end = Length - 1; start < end;)
                {
               
                 //   if(start!= i + 1 && array[start] == array[start -1])
                    
                 //  {
                 //      start++;
                  //     continue; 
                 //  }
                    
                    if (array[i] + array[start] + array[end] == 0 )
                    {
                        Result.Add(new List<int>() {array[i], array[start], array[end] });
                        Result.ToHashSet();
                        
                        
                       
                        start++;
                    } 

                    if (array[start] + array[end] + array[i] < 0 )
                    {
                        start++; 
                    } 
                    else
                    {
                        end--; 
                    }
                }

            } 


            foreach(var r  in Result)
            {
                Console.WriteLine("Result set is  " + String.Join(",", r));
            }
            return Result; 

        } 
    }
}

