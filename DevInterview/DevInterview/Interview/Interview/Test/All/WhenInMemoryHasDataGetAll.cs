using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Interview.Test;

namespace Interview.Test.All
{

    [TestFixture]
    public class WhenInMemoryHasDataGetAll : Tests
    {

        [Test]
        public void When_Collection_Of_Items_Added_Check_Items_Count()
        {   

            SaveAll(collection);

            var expected = collection.Count();

            var actual = ItemCount(); 

            Assert.AreEqual(expected, actual, "Added items count mismatch");
        }


        [Test]
        public void When_Collection_Items_That_Is_On_The_InMemory_Type_Must_Match()
        {

            var result = repository.All();

            Assert.IsInstanceOf( typeof(IEnumerable<IStoreable>), result, "Repo retun type does not match" );

        }
        

    }
}
