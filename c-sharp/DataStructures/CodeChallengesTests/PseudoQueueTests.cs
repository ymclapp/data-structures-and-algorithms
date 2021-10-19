using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengesTests
{
  public class PseudoQueueTests
  {

    [Fact]
    public void Starting_with_empty_stacks()
    {
      //Arrange
      Stack<int> qstack1 = new Stack<int>();
      Stack<int> qstack2 = new Stack<int>();

      //Act
      bool result1 = qstack1.Count == 0;
      bool result2 = qstack2.Count == 0;


      //Assert
      Assert.True(result1);
      Assert.True(result2);


    }//end of starting with empty stacks

    [Fact]
    public void Pushing_onto_empty_stacks()
    {

      //Arrange
      Stack<int> qstack1 = new Stack<int>();
      Stack<int> qstack2 = new Stack<int>();

      //Act
      qstack1.Push(1);
      qstack2.Push(1);

      //Assert
      //bool result1 = qstack1.Count == 1;
      //bool result2 = qstack2.Count == 1;
      //Assert.True(true, result1);
      //Assert.True(true, result2);
      Assert.Single(qstack1);
      Assert.Single(qstack2);

    }//end of pushing onto an empty stack


    [Fact]
    public void Pushing_onto_1_popping_off_2_and_peeking()
    {

      //Arrange
      Stack<int> qstack1 = new Stack<int>();
      Stack<int> qstack2 = new Stack<int>();

      //Act
      qstack1.Push(5);
      qstack1.Push(4);
      qstack1.Push(3);
      qstack2.Push(qstack1.Pop());
      qstack1.Push(2);
      int result = (int)qstack1.Peek();

      //Assert
      Assert.Equal(3, qstack1.Count);
      Assert.Single(qstack2);
      //Assert.Equal(2, qstack2.Count);
      Assert.Equal(2, result);

    }

    //[Fact]
    //public void Pushing

  }
}
