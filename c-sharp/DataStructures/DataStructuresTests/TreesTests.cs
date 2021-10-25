using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructures.Trees;
using static DataStructures.Trees.Trees;

namespace DataStructuresTests
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
      Node<int> root = btree.Root;

      //Assert
      Assert.Null(root);

    }

    [Fact]
    public void Adding_A_Root_To_A_Tree()
    {
      //Arrange
      BinaryTree<int> btree = new BinaryTree<int>();



      //Act
      //Node<int> root = btree.Root;
      btree.Root = new Node<int>(1);


      //Assert
      Assert.NotNull(btree.Root);

    }

    [Fact]
    public void Adding_a_left_on_root()
    {
      //Arrange
      BinaryTree<int> btree = new BinaryTree<int>();
      //Node<int> root = btree.Root;
      btree.Root = new Node<int>(100);


      //Act
      btree.Root.Left = new Node<int>(25);
      //btree.Root.Right = new Node<int>(12);


      //Assert
      Assert.NotNull(btree.Root);
      Assert.Equal(100, btree.Root.Value);
      Assert.NotNull(btree.Root.Left);
      Assert.Equal(25, btree.Root.Left.Value);
      Assert.Null(btree.Root.Left.Left);
      Assert.Null(btree.Root.Right);

    }

    [Fact]
    public void Adding_a_right_on_root()
    {
      //Arrange
      BinaryTree<int> btree = new BinaryTree<int>();
      //Node<int> root = btree.Root;
      btree.Root = new Node<int>(100);


      //Act
      btree.Root.Left = new Node<int>(25);
      btree.Root.Right = new Node<int>(12);


      //Assert
      Assert.NotNull(btree.Root);
      Assert.Equal(100, btree.Root.Value);
      Assert.NotNull(btree.Root.Left);
      Assert.Equal(25, btree.Root.Left.Value);
      Assert.Null(btree.Root.Left.Left);
      Assert.NotNull(btree.Root.Right);
      Assert.Equal(12, btree.Root.Right.Value);

    }
    [Fact]
    public void Adding_a_another_left_onto_left ( )
    {
      //Arrange
      BinaryTree<int> btree = new BinaryTree<int>();
      //Node<int> root = btree.Root;
      btree.Root = new Node<int>(100);
      btree.Root.Left = new Node<int>(25);
      btree.Root.Right = new Node<int>(12);

      //Act
      btree.Root.Left.Left = new Node<int>(75);


      //Assert
      Assert.NotNull(btree.Root);
      Assert.Equal(100, btree.Root.Value);
      Assert.NotNull(btree.Root.Left);
      Assert.Equal(25, btree.Root.Left.Value);
      Assert.NotNull(btree.Root.Right);
      Assert.Equal(12, btree.Root.Right.Value);
      Assert.NotNull(btree.Root.Left.Left);
      Assert.Equal(75, btree.Root.Left.Left.Value);

    }

    [Fact]
    public void PreOrder_return ()
    {
      //Arrange
      BinaryTree<int> btree = new BinaryTree<int>();
      btree.Root = new Node<int>(100);

      btree.Root.Left = new Node<int>(25);
      btree.Root.Left.Left = new Node<int>(75);
      btree.Root.Left.Right = new Node<int>(56);

      btree.Root.Right = new Node<int>(12);
      btree.Root.Right.Left = new Node<int>(23);
      btree.Root.Right.Right = new Node<int>(66);

      //Act
      var results = PreOrder(btree.Root); //<<--it doesn't like this

      //Assert
      Assert.Equal(new[] { 100, 25, 75, 56, 12, 23, 66 }, results);


    }
    public IEnumerable<int> PreOrder ( Node<int> root, List<int> results )
    {

      return PreOrder(root);
      List<int> result = new List<int>();
      PreOrder(root, results);
      return result;
    }

    public IEnumerable<int> PreOrder ( Node<int> root )
    {
      if (root is null) yield break;

      yield return root.Value;

      foreach (int item in PreOrder(root.Left))
      {
        yield return item;
      }
      foreach (int item in PreOrder(root.Right))
      {
        yield return item;
      }

    }
  }
}
