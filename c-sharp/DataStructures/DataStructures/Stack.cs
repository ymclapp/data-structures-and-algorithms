using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  //public class LinkedListNode
  //{
    //internal int value;
    //internal Node underTop;
  //}
  public class Stack<T>
  {
    private Node top;
    private int size;
    //Stack<int> stack = new Stack<int>();

    //public virtual Object Peek();
    //{
     // if (Size == 0)
     //   throw new InvalidOperationException("The stack is empty");
     // return stack.top;
    //}


    public int Size { get { return size; } }

    public bool IsEmpty()
    {
      return top == null;
    }

    public int Pop()
    {
      if (IsEmpty())
        throw new InvalidOperationException("Stack is empty");

      int value = top.Value;
      top = top.underTop;
      size--;
      return value;
      //Peek();
    }


    public void Push(int v)
    {
      top = new Node
      {
        Value = v,
        underTop = top
      };
      size++;
    }
  }
}


//public bool IsEmpty
//{
 // get
  //{
  //  if (size == 0)
 //    return true;
 //   else
//      return false;
//  }
