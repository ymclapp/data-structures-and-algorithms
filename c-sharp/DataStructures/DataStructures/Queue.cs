using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{

  public class Queue<T>
  {
    //private int size;
    private int front;
    private int rear;
    //front = -1;
    //rear = -1;
    // create a method to check whether 
    // the queue is empty or not  
    public bool IsEmpty()
    {
      if (rear == front)
      {
        return true;
      }
      return false;
    }
  }
}
