using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengesTests
{
  public class TreesTests
  {
    [Fact]
    public void Empty_tree ( )
    {

      //Arrange
      BinaryTree<int> btree = new BinaryTree<int>();
      //btree.Root = new Node(1);
      //btree.Root.Left = new Node(2);

      //Act
      Node root = btree.Root;

      //Assert
      Assert.Null(root);

    }

    [Fact]
    public void Adding_A_Root_To_A_Tree()
    {
      //Arrange
      BinaryTree<int> btree = new BinaryTree<int>();



      //Act
      btree.Root = new Node<int>(1);


      //Assert
      Assert.NotNull(btree.Root);

    }


  }

  

  public class BinaryTree<T>
  {
    public Node<int> Root { get; internal set; }
    public class Node<T> : Node
    {
      public Node Root { get; set; }
      //public Node Node { get; set; }
      public Node Left { get; set; }
      //public Node Value { get; set; }

      public Node ( int value )
      {
      this.Value = value;
      }
    }

  }
}
