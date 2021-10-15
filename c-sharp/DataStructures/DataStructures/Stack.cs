using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  class LinkedListNode
  {
    internal int value;
    internal Node underTop;
  }
  public class Stack<T>
  {
    private Node top;
    private int size;

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
