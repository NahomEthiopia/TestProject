
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeetCodeProgram 
{

    // Defining a program class whic acts as an entry point 
    public class program
    {
        public static void Main(string[] args)
        {

            int[] given = new int[6] {5,7,9,11,12,14};
            int[] given1 = new int[9] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int[] given2 = new int[5] { 3, 1, 2, 4, 5 };
            int[] given3 = new int[4] { 1, 5, 4, 3 };
            int[] given4 = new int[7] { 2, 3, 4, 5, 18, 17, 6 };
            ContainerWithMostWater.FindAreaOfContainerWithMostWater(given4);
            ContainerWithMostWater.findcontainerwithmostwater(given4);

        }

    } 

    public class ContainerWithMostWater
    {
        public static int FindAreaOfContainerWithMostWater(int[] container )
        {
            int i = 0 ; int j = 1 ; //int //k = 0;
            int[] result = new int[0];
            int Length = container.Length ;
            int area = 0 ;
            int maxarea = 0; 
            
            for(i = 0 ; i < Length   ; i++)
            {
            
                for(j = i + 1 ; j < Length  ; j++)
                
                {
                    area = (Math.Min(container[i] , container[j])) * ((j - i)) ;
                    maxarea = (Math.Max(area, maxarea));
                    //Console.WriteLine("area is " + area);
                }
                   
            }
            
            Console.WriteLine("Area of container with most water is " + maxarea);
            return area ; 
        } 
       
        public static int findcontainerwithmostwater(int[] container ) 
        
        {

            int start = 0;
            int end = container.Length -1 ;
            int width = 0;
            int Length = 0;
            int area = 0; 
            int maxarea = 0;  
            

            while(start < end)
            {
                Length = Math.Min(container[start], container[end]);
                width = end - start;
                area = Length * width;
                maxarea = Math.Max(maxarea, area); 

                if (container[start] < container[end] )
                {
                    start++; 
                }
                else
                {
                    end--;
                }

            }

            Console.WriteLine("Container with most water is " + maxarea); 
            return maxarea; 

        
        }

       
    }


}
