// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Linq;
using System.Collections.Generic;



public class program
{   
    // This is where excution of the program enters.....
    public static void Main(string[] args)
    {
        int[] given1 = { 1, 4, 5, 7, 19, 12 };
        int[] given2 = { 15, 17, 9, 45, 56 };
        MedianOfTwoSortedArray.MergingTwoSortedArray(given1, given2);
        

       
    }
}

// Building another class which has
// 1 -Two Given Sorted arrays Which are (Array1[] and Array2[]) 
// 2 -We need Length1 and Length2 for Array1[] and Array2[] Respectivly;
// 3 -We new Array3[] Which holds the Merged Sorted array of Array1[] and Array2[] 
// 4- We need Length of Array3 Which Will be the sum of Array1[].Lenght and Arrayy2[].Length

// Our First Approach will be naive approch which will be merging the two arrays and Sort the result or 
// output Array using built_in sort function and using two For Loops ....


// Now we are going to create Public Class For Defining our programing Logic of FindingMedianOfTwoSortedArray

public class MedianOfTwoSortedArray
{
    // here we will have our Function That Returns  Merged array of the sorted arrays ;
    //public int[] array3 ;

    public static double MergingTwoSortedArray(int[] array1, int[] array2)
    {
        int Length1 = array1.Length; // 6
        int Length2 = array2.Length; // 5
        int Length3 = Length1 + Length2; // 11 
        int[] array3 = new int[Length3];

        int i;
        int j;
        int K = 0;

        for (i = 0; i < Length1; i++)
        {
            array3[i] = array1[i];
            //Console.WriteLine(array3[i]);
        }
        for (j = Length1 ; j < Length3; j++)
        {
            array3[j] = array2[K];
            K++;
        }

        // Here we are going to sort the array in assending Order or Decending Order If we want 

        Array.Sort(array3);

        for (K = 0; K < Length3; K++)
        {
            Console.WriteLine(array3[K]);
        }
          double median = 0;

        if (Length3 % 2 == 0)
        {
            median = (array3[Length3 / 2] + array3[(Length3 / 2) + 1]) / 2;
            Console.WriteLine("Median Of the array is " + median);
            return median;
        }

        if (Length3 % 2 == 1)
        {
            median = (array3[Convert.ToInt32(Length3 / 2) ]);
            Console.WriteLine("Median Of the array is " + median);
        }
        
         return median;
    
    }

       
}  


   









