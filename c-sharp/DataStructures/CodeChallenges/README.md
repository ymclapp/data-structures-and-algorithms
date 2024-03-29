## Code Challenge:  Class 11 - Stack and Queue Pseudo

We will be creating a a pseudo queue using stacks.

## Challenge
We need to create two stacks with the methods push, pop, and peek that process enqueue and dequeue processes through them.

## Approach & Efficiency
![Stack Queue Psuedo Whiteboard](./stack-queue-pseudo/whiteboardImage.jpg)

Dealing with a stack:
Time:  O(n)
Space: O(n)


## API
<!-- Description of each method publicly available to your Linked List -->

## Code Challenge:  Class 12 - Stack and Queue Animal Shelter

We need to create a queue to hold animals.

## Challenge
We need to create a queue that will allow us to hold both animal and dogs in the order they came in and then dequeue the first of that dog/cat that arrived at the shelter.

## Approach & Efficiency
![Stack Queue Animal Shelter Whiteboard](./Stack-Queue-Animal-Shelter/StackQueueAnimalShelter.jpg)

Dealing with a stack:
Time:  O(n)
Space: O(n)


## API
<!-- Description of each method publicly available to your Linked List -->

## Code Challenge:  Class 13 - Stack Queue Brackets

We need to create a queue to use to verify that a set of values received for brackets have open and closing in the correct order.

## Challenge
We need to create a queue that will allow us to compare the sets of brackets as each individual bracket is revealed.

## Approach & Efficiency
![Stack Queue Brackets Whiteboard](./stack-queue-brackets/stack-queue-brackets.jpg)

Dealing with a stack:
Time:  O(n)
Space: O(n)


## API
<!-- Description of each method publicly available to your Linked List -->


## Code Challenge:  Class 15 - Trees
We need to create a Binary Tree and a Binary Search Tree.

## Challenge
We need to create our trees and include methods for each depth first traversal - pre-order, in-order, and post-order as well as the required tests.

## Approach & Efficiency

Pre-Order:
	- Time: O(h)
	- Space: O(1)

In-Order:
	- Time: O(h)
	- Space: O(1)

Post-Order:
	- Time: O(h)
	- Space: O(1)


## API
<!-- Description of each method publicly available to your Linked List -->

## Code Challenge:  Class 17 - Trees - Breadth First
![Tree Breadth First Whiteboard](./stack-queue-brackets/tree-breadth-first.jpeg)
We have a tree and need to provide the values back in order.

## Challenge
We need to traverse our tree and track each of the values that we come to in the order that we encounter them.  We will work starting at the root and then go to the first left and straight over to the first right.  Once that is done, we go back to the left directly below the first left, record that value and then to the nodes directly to the right of that node on the same level.  We repeat until we reach the bottom of the tree where there are no more values.

## Approach & Efficiency

- Time: O(n)
- Space: O(n)


## API

## Code Challenge:  Class 18 - Trees - FizzBuzz
![Tree Fizz Buzz Whiteboard](./tree-fizz-buzz/FizzBuzz-Whiteboard.jpg)
We have a tree and need to evaluate it to FizzBuzz.

## Challenge
We are given a tree that we need to run against the fizzbuzz formula.  We will start at the root and determine if it has a left and a right.  If it does, we will copy the root int value into a new tree as the root string.  We will go to the left of the root and traverse that whole let copying the values into the new tree at the node that they were in the original tree.  As we copy them, if they are divisible by 3 or 5 or 15, then we will change the string from the number to either Fizz (divisible by 3), Buzz (divisible by 5), or FizzBuzz (divisible by 15).  If they are not divisible by one of those, then the string of the original value will be copied into the new tree.  Once we have done this to the left leg of the tree, we will travel to the right of root and do the same process for the right leg of the tree.

## Approach & Efficiency

- Time: O(n)
- Space: O(n)


## API

## Code Challenge:  Class 31 - Hashmap Repeated Word
![Hashmap Repeated Word Whiteboard](./HashmapRepeatWord/HashmapRepeatWord.jpg)
Find the first repeated word.

## Challenge
We are given a book and we need to write a function that will iterate through each word in the book and add them to a dictionary until it reaches a word that has already been added to the dictionary.  At that point it stops and returns the duplicated word.

## Approach & Efficiency

- Time: O(n)
- Space: O(n)


## API

## Code Challenge:  Class 32 - Hashset Tree Intersection
![Hash Tree Intersection Whiteboard](./HashTreeIntersection/HashTreeIntersection.jpg)

Find the values that are in BOTH trees
<br><br>
Example Trees:

![Tree 1](./HashTreeIntersection/HTITree1.png)
<br><br>

![Tree 2](./HashTreeIntersection/HTITree2.png)

## Challenge
We are given two trees to create a hashset out of the first and then compare the second to.  As we interate through the second tree, we are  comparing the values to the hashset.  If the value is not found in the current hashset, then the second tree's value is added to the hashset.  If the value IS found in the current hashset, then the second tree's value is added to the list of matching values.

## Approach & Efficiency

- Time: O(n)
- Space: O(n)


## API

## Code Challenge:  Class 33 - Hashmap Left Join
![Hashmap Left Join Whiteboard](./HashmapLeftJoin/HashmapLeftJoinWhiteboard.jpg)

Join the two hashmaps
![Hashmap Left Join Example](./HashmapLeftJoin/HashmapLeftJoin.png)

## Challenge
We are given two hashmaps with key value pairs.  We are to move the whole first hashmap into a datastructure output.  Then, we iterate through the second hashmap and compare the key of hashmap 2 to the key of hashmap 1.  If they are the same, then we add the value from hashmap 2 to the datastructure that the first hashmap's keys and values were created with.

## Approach & Efficiency

- Time: O(n + m)
- Space: O(n)


## API
