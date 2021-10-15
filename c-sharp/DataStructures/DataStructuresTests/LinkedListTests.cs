using System;
using Xunit;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using System.Collections;
//using System.Collections.Generic;

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

    [Fact]
    public void Print_out_linked_list_values()
    {
      //Arrange
      LinkedList list = new LinkedList();
      list.Insert(10);
      list.Insert(20);
      list.Insert(30);
      //list.Insert(50);
      //list.Insert(80);
      //list.Insert(130);
      //list.Insert(210);
      //list.Insert(340);
      //list.Insert(550);
     //Console.WriteLine(list);
      //Act
      string result = list.ToString();

      //Assert
      Assert.Equal("30 -> 20 -> 10 -> NULL", result);

    }

    [Fact]
    public void Insert_at_end_of_linkedList()
    {

      //Arrange
      LinkedList list = new LinkedList();
      list.Insert(210);
      list.Insert(340);
      list.Insert(550);

      //Act
      list.AtEnd(890);  //inserting 890 at the Tail

      //Assert
      Assert.Equal("550 -> 340 -> 210 -> 890 -> NULL", list.ToString());

    }

    [Fact]
    public void Add_new_value_at_Head()
    {

      //Arrange
      LinkedList list = new LinkedList();
      list.Insert(210);
      //list.Insert(340);
      //list.Insert(550);

      //Act
      list.AddAtHead(210, 890);

      //Assert
      Assert.NotNull(list.Head);
      Assert.Equal("890 -> 210 -> NULL", list.ToString());
    }


   
    [Fact(Skip = "need to fix for lab 06")]
    public void Add_after_340_of_linkedList()
    {

      //Arrange
      LinkedList list = new LinkedList();
      list.Insert(210);
      list.Insert(340);
      list.Insert(550);

      //Act
      list.AddAfter(340, 3);


      //Assert
      Assert.Equal("550 -> 340 -> 3 -> 210 -> NULL", list.ToString());

    }


   [Fact]
    public void Starting_with_an_empty_stack()
    {
      //Arrange
      Stack<string> stack = new Stack<string>();

      //Act

      bool result = stack.IsEmpty();

      //Assert
      Assert.True(result);

    }





    [Fact (Skip = "zipped")]
    public void Zipping_two_linkedlists_together()
    {
      //Arrange
      LinkedList list1 = new LinkedList();
      list1.Insert(210);
      list1.Insert(340);
      list1.Insert(550);

      LinkedList list2 = new LinkedList();
      list2.Insert(10);
      list2.Insert(20);
      list2.Insert(30);


      //Act
      LinkedList zipped = new LinkedList();
      zipped.Insert(210);
      list2.Insert(10);
      list1.Insert(340);
      list2.Insert(20);
      list1.Insert(550);
      list2.Insert(30);

      //Assert
      Assert.Equal("30 -> 550 -> 20 -> 340 -> 10 -> 210 -> NULL", zipped.ToString());

    }//end of zipping
  }
}
