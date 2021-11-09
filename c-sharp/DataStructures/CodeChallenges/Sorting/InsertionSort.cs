using System;


namespace CodeChallenges.Sorting
{
  class InsertionSort
  {
    void sort(int[] arr)
    {
      int n = arr.Length;
      for(int i = 1; i < n; ++i)
      {
        int temp = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > temp)
        {
          arr[j + 1] = arr[j];
          j = j - 1;
        }
        arr[j + 1] = temp;
      }
    }

    static void printArray(int[] arr)
    {
      int n = arr.Length;
      for (int i = 0; i < n; ++i)
        Console.Write(arr[i] + " ");

      Console.Write("\n");
    }

    public static void Main()
    {
      int[] arr = { 8, 4, 23, 42, 16, 15 };
      InsertionSort ob = new InsertionSort();
      ob.sort(arr);
      printArray(arr);
    }
  }
}
