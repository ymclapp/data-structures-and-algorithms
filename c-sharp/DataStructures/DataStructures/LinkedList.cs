using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }  //used light bulb in the tests to create this

    public void Insert(int value)  //used the light bulb in the tests to create this
    {
      Node newNode = new Node();  //created linkedList empty
      newNode.Value = value;  //told it to insert what it is told - needed this for the second test
      Head = newNode;  //we are drawing the arrow from the Head to the newNode.  we are pointing it to the newNode. Head is a reference to the first node.  Need this for every new Linked List
      //throw new NotImplementedException();  //commented out so that the insert would work with out throwing this exception
    }
  }
}
