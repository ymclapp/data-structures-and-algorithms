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
      Assert.Equal("one", value);
    }

    [Fact]
    public void Does_not_find_in_hashtable ( )
    {
      //Arrange
      Dictionary<int, string> dict = new Dictionary<int, string>();

      //Act
      dict.Add(1, "one");


      //Assert
      Assert.False (dict.TryGetValue(2, out string value));

    }

    [Fact]
    public void Cannot_add_two_items_with_same_key()
    {

      //Arrange
      Dictionary<int, string> dict = new Dictionary<int, string>();

      //Act
      dict.Add(1, "one");
      //dict.Add(1, "o-n-e");
      dict.Add(10, "one zero");
      dict.Add(20, "two zero");
      dict.Add(100, "one zero zero");


      //Assert
      Assert.True(dict.TryGetValue(1, out string value1));
      Assert.Equal("one", value1);
      Assert.True(dict.TryGetValue(1, out string value2));
      Assert.NotEqual("o-n-e", value2);




    }
  }
}
