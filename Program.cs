using System;

internal class program
{
    // Selection Sort
    // Select min element from collection, place in appropriate position, repeat
static void SelectionSort(int[]A)
    {
        int minposition = 0;
        int temp = 0;

        for (int i = 0; i < A.Length-1; i++) // moves through ea index
        {
            minposition = i; // i  tracks correct position  to put element
            for (int j = i + 1; j < A.Length; j++) // j= index for inne loop.j checks rest of numbers after i to see if smaller
            {
                if (A[j] < A[minposition]) // Logic to find min
                {
                    minposition = j; // next min num
                }
            }
                if (minposition!= i)
                {
                    temp = A[i];
                    A[i] = A[minposition]; 
                    A[minposition] = temp;
                }
        }

    }
    static void Main(string[] args)
    {
        int[] arr = { 100, 67, 83, 78, 100, 43, 99, 56,80 };
        SelectionSort(arr);
        Console.WriteLine(" Sorted Array: ");
        foreach (int i in arr) Console.WriteLine(i);
        Console.ReadKey();
    }
}


// Insertion sort
// select on element one at at time from left to right. Insert element in proper position so that all element on the LEFT are lesser than this element 
internal class MyInsertion
{
    static void InsertionSort(int[] arr)
    {
        int position = 0;
        int temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            temp = arr[i];
            arr[i] = arr[position];
        }
        while (position > 0 && arr[position - 1] > temp)
        {
            arr[position] = arr[position - 1]; //shift
            position--;
        }
        arr[position] = temp;
    }
}





    