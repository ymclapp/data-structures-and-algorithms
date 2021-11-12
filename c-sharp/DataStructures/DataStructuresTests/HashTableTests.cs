using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructuresTests
{
  public class HashTableTests
  {
    [Fact]
    public void Hashtable_is_empty ( )
    {
      //Arrange
      var dict = new Dictionary<int, string>();

      //Act
      bool result = dict.Count == 0;


      //Assert
      Assert.True(result);
    }

    [Fact]
    public void Add_something_to_hashtable()
    {
      //Arrange
      Dictionary<int, string> dict = new Dictionary<int, string>();

      //Act
      dict.Add(1, "one");
      var result = dict.ContainsKey(1);


      //Assert
      Assert.True(result);
    }

    [Fact]
    public void Getting_something_from_hashtable ( )
    {
      //Arrange
      Dictionary<int, string> dict = new Dictionary<int, string>();

      //Act
      dict.Add(1, "one");


      //Assert
      dict.TryGetValue(1, out string value);
    }
  }
}
