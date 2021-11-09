#  Insertion Sort

![Insertion Sort Pseudocode](../Sorting/insertionSortPseudoCode.jpg)

## Definition (https://www.geeksforgeeks.org/insertion-sort/)
Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands. The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part.
  -  Algorithm:
    -  To sort an array of size n in ascending order: 
        1.  Iterate from arr[1] to arr[n] over the array. 
        2.  Compare the current element (key) to its predecessor. 
        3.  If the key element is smaller than its predecessor, compare it to the elements before. Move the greater elements one position up to make space for the swapped element.
        -  Example:
        ![Insertion Sort Example](../Sorting/insertionsort.png)

##  Trace
Input array 1 = [8,4,23,42,16,15]
![Insertion Sort Passes](../Sorting/insertionSortPasses.jpg)


## Efficiency

Time:  O(n^2)
Space:  O(1)
