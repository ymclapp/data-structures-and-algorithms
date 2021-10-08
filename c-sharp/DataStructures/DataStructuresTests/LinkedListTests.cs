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
  }
}
