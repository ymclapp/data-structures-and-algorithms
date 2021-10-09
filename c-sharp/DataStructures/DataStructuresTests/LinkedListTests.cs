using System;
using Xunit;

using DataStructures;

namespace DataStructuresTests
{
  public class LinkedListTests
  {
    [Fact]
    public void Empty_List_Starts_With_Head_Null()
    {

      //Arrange
      LinkedList list = new LinkedList();

      //Act
      Node head = list.Head;  //We named it Node - see class of Node.cs.  Using the light bulb on Head, it  can create the property and put it on LinkedList.cs where it add the get; and set; too

      //Assert
      Assert.Null(head);
    }

    [Fact]
    public void Insert_into_empty_linkedList()
    {

      //Arrange
      LinkedList list = new LinkedList();

      //Act
      list.Insert(1);  //inserting a 1 at the Head, but failing because we don't have our node built to accept a value in the LinkedList.cs

      //Assert
      //Make sure we have a Head node
      Assert.NotNull(list.Head);

      //Make sure the Head node has the inserted value
      Assert.Equal(1, list.Head.Value);//the value of the node at Head to be 1

      //Make sure the Head node does not have a Next
      Assert.Null(list.Head.Next);
    }
  }
}
