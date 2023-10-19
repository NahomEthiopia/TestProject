// See https://aka.ms/new-console-template for more information




/* In this Code we will solve Two sum problem using Technique called "Two Poninters Technique" */

using System;
using System.Collections.Generic;
using System.Linq;


namespace LeetcodeProjects
{

    public class program
    {
        public static void Main(string[] args)
        {
            int[] given = new int[] { 5, 3, 7, 13, 16, 18, 12 };
            int[] nums = new int[]{4,6,7,23,27,34,46,51,54,58};
            int tar = 80;

            //  Twosumproblem.Twosum(given, tar);
            //  twopointersapproach.Twosums(nums, tar);
            fatestsslowest.Twosum(nums, tar);
            
        }

    }

    public class Twosumproblem
    {
        // hear we are going to use Two Pointer Technique 
        // hear we impliment two for loops to traverse through and make copmarision until result .
        
        public static int[] Twosum(int[] array, int target)
        {
            int startpointer = 0 ;
            int endpointer = 0 ;
         
            int num1 = 0;
            int num2 = 0;
            int[] indices = new int[] {2};

            for (startpointer = 0; startpointer < array.Length; startpointer++)
            {
                for (endpointer = 0; endpointer < array.Length; endpointer++)

                {
                    if (target == array[startpointer] + array[endpointer])
                    {
                        num1 = array[startpointer];
                        num2 = array[endpointer];

                        indices = new int[] {startpointer, endpointer};
                        
                    }

                   
                }

               
            }

            Console.WriteLine(num1 + " + " + num2  +  " = " + target);
            for(int i = 0; i < indices.Length; i++)
            {
                Console.Write("{0}  : " , string.Join(","  ,indices[i]));
            }
          
            return indices ;
        }

    }

    // Solution for two some project using Two pointers technique...
    public class twopointersapproach
    {
        public static int[] Twosums(int[] array, int target)
        {
            int lowerindex = 0;
            int uperindex = array.Length - 1;

            int[] result = new int[2];



            while (lowerindex < uperindex)
            {

                if (target == array[lowerindex] + array[uperindex])
                {
                    result = new int[] { array[lowerindex], array[uperindex] };
                    for (int i = 0; i < result.Length; i++)
                    {

                        Console.Write("[" + result[i] + ",]");

                    }
                    break;

                }


                else if ((array[lowerindex] + array[uperindex]) < target)
                {
                    lowerindex = lowerindex + 1;
                }
                else if ((array[lowerindex] + array[uperindex]) > target)
                {
                    uperindex = uperindex - 1;
                }




            }


            return result;
        }



    }
        // solving twosum problem using two pointers ;

        public class fatestsslowest
        {

            public static int[] Twosum(int[] array, int target) 
            {

                int fast = 1;
                int slow = 0;
                int[] result = new int[2] ; 

             while(fast < array.Length)
                {


                if (target == array[fast] + array[slow])
                {
                    result = new int[] { array[fast], array[slow] };
                    Console.WriteLine(array[fast] + ","  + array[slow]);
                    for (int i = 0; i < result.Length; i++)
                    {
                        Console.Write(string.Join("",result[i],","));
                    }
                    break;
                }
                else
                {
                    fast = fast + 1;
                    slow = slow + 1;
                } 

                }



                return result;
            }

        }
    
    // As we see above we use all approaches to perform the two sum problem 
    //1-Naive Solution (using two foreach Loops )
    //but the Naive solution is not optimal so we implemnt some dynamic programing concepts 
    //such as two pointers Techeniques....

    // one is using one pointer at athe start of the array .
    // and another is using pointer at the end of the pointer. 

    // another technique is using fast and slow pointers.


}


          
   
