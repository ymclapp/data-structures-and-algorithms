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

    [Fact] //You can do [Fact (Skip = "Homework")
    public void Insert_into_list_not_empty_works() //we are inserting a value at Head
    {
      //Arrange
      LinkedList list = new LinkedList();  //Head points to nothing
      list.Insert(5);  //Head points to 5

      //Act
      list.Insert(3);  //Head points to 5, we add the 3 and now it points to 5

      //Assert
      Assert.NotNull(list.Head);  //making sure Head is pointing to Null
      Assert.Equal(3, list.Head.Value); //inserting 3 into the node that the 
      Assert.NotNull(list.Head.Next);  //making sure that the 3 points to 5
      Assert.Equal(5, list.Head.Next.Value); //makes the value in the node after the one that the head is pointing to (3) is 5
      Assert.Null(list.Head.Next.Next);  //makes the node after Next (5) to be Null
    }

    [Theory]
    [InlineData(7, false)]
    [InlineData(10, true)]
    [InlineData(21, true)]

    public void Include_finds_a_value_or_not(int valueToFind, bool expected)
    {
      //Arrange
      LinkedList list = new LinkedList();
      list.Insert(10);
      list.Insert(21);

      //Act
      bool result = list.Includes(valueToFind);

      //Assert

      Assert.Equal(expected, result);
    }

  }
}
