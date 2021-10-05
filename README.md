# Data Structures and Algorithms

See [setup instructions](https://codefellows.github.io/setup-guide/code-301/3-code-challenges), in the Code 301 Setup Guide.

## Repository Quick Tour and Usage

### 301 Code Challenges

Under the `javascript` folder, at the top level, is a sub-folder called `code-challenges`

Each day, you'll add one new file to this folder to do your work for the day's assigned code challenge

If you have not already done so, run `npm install` from within this folder to setup your system to be able to run tests using `Jest`

To run your tests

- Change to the `javascript` folder
- run `npm test` to run all of the tests
- run `npm test ##` to only run tests for challenge ## (i.e. 01)

### 401 Data Structures, Code Challenges

- Please follow the instructions specific to your 401 language, which can be found in the directory below, matching your course.

## Code Challenge:  Class 01 - Array Reverse
# Reverse an Array
We were given a specific array and asked to reverse it in place.

## Whiteboard Process
![Array Reverse Whiteboard](ArrayReverseWhiteBoard.jpg)

## Approach & Efficiency
We assumed the array was all numbers and we used the Array.Reverse method in C# to take the original array and exactly reverse the order of the that array in the same space.  Had we had it to do again, we would not have used the method.  We would have used a for loop to move two items at a time.

## Code Challenge:  Class 02 - Array Insert Shift
# Insert Shift Array
We were given a specific array and asked to insert an element into the middle of that array without using any known methods.

## Whiteboard Process
![Array Insert Shift Whiteboard](challenge02-whiteboard.jpg)

## Approach & Efficiency
Not knowing how big the original array was, we determined that  we would need to take the original array and create a new, empty array that contained one more element than the original.  Then, using a for loop, we would insert each member of the original array into the new array UP TO the middle of the original array.  At that point, we would insert the newly item and then continue adding elements from the original array, but at their original index + 1.  We were not completely sure on which all methods to use to insert the new element and the rest of the original array.