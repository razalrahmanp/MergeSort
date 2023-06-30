# MergeSort

The following code is an implementation of the Merge Sort algorithm in C#. 
 1. The code starts by prompting the user to enter numbers to be sorted, separated by spaces.
2. It reads the input from the user and checks if it is null, empty, or contains only whitespace. If any of these conditions are true, it displays an error message and exits the program.
3. If the input is valid, it converts the input string into an integer array using the Array.ConvertAll() method.
4. The MergeSort() method is called, passing the integer array as an argument.
5. The MergeSort() method checks if the array is null or has a length less than or equal to 1. If either condition is true, it returns without doing anything.
6. If the array has more than one element, it calculates the midpoint and creates two subarrays: left and right.
7. The elements from the original array are copied to the left and right subarrays using the Array.Copy() method.
8. The MergeSort() method is recursively called for both the left and right subarrays.
9. The Merge() method is called, passing the left, right, and original array as arguments.
10. The Merge() method merges the sorted left and right subarrays back into the original array in ascending order.
11. Finally, the sorted array is displayed by joining the elements with spaces and printing it to the console.
 Step-wise explanation:
1. The user is prompted to enter numbers to be sorted.
2. The input is read and stored in the 'input' variable.
3. The input is checked for validity. If it is null, empty, or contains only whitespace, an error message is displayed, and the program exits.
4. If the input is valid, it is converted into an integer array using the Array.ConvertAll() method.
5. The MergeSort() method is called, passing the integer array as an argument.
6. The MergeSort() method checks if the array is null or has a length less than or equal to 1. If either condition is true, it returns without doing anything.
7. If the array has more than one element, it calculates the midpoint and creates two subarrays: left and right.
8. The elements from the original array are copied to the left and right subarrays using the Array.Copy() method.
9. The MergeSort() method is recursively called for both the left and right subarrays.
10. The Merge() method is called, passing the left, right, and original array as arguments.
11. The Merge() method merges the sorted left and right subarrays back into the original array in ascending order.
12. Finally, the sorted array is displayed by joining the elements with spaces and printing it to the console.
