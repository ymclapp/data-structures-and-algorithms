using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{

  //class LinkedListNode
    //{
    //}

  public class Queue<T>
  {
    public int size;
    private Node Head;
    //private int rear;
    //front = -1;
    //rear = -1;
    // create a method to check whether 
    // the queue is empty or not  
    public bool IsEmpty()
    {
     
      if (Head == null)
      {
        return true;
      }
      return false;
    }//end of IsEmpty()

    public void Enqueue(int n)
    {
      Node currentNode = Head;
      Head = new Node
      {
        Value = n,
        Next = currentNode
      };
      size++;
    }//end of Enqueue
  }
}
