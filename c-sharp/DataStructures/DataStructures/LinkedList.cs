using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public void Insert(int value)
    {
      Node newNode = new Node();  //created linkedList empty
      newNode.Value = value;  //told it to insert what it is told
      Head = newNode;  //we are drawing the arrow from the Head to the newNode.  we are pointing it to the newNode. Head is a reference to the first node.
      //throw new NotImplementedException();  //commented out so that the insert would work with out throwing this exception
    }
  }
}
