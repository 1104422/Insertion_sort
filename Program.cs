using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arrayValues = {5,4,1,8,2,6,9,3,7};
           Console.WriteLine(" Before sort");
           for(int i = 0;i<9;i++)
           {                                    // printing the array values before sorting
               Console.WriteLine(arrayValues[i]);
           }     
         sort(arrayValues);
         Console.WriteLine("  After sort");     // printing the array values after sorting
         printArray(arrayValues);  
        }

         static void sort(int[] arrayValues)        // declearing function
            {
               
                for( int j = 1;j<9;j++)
                {
                   int key = arrayValues[j];         
                   int i = j-1;
                 while(i>=0 && arrayValues[i] > key){
                    arrayValues[i+1] = arrayValues[i];
                    i = i-1;
                }
                arrayValues[i+1] = key;
                }
            }
          static  void printArray(int[] array)
            {   
                for(int i = 0;i<9;i++){
                    Console.WriteLine(array[i]);
                }
            }
        
    }
}
