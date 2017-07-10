using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Interview.Test;
using System.Diagnostics;

namespace Interview.Test.FindBy
{

    [TestFixture]
    public class WhenFindingItemById : Tests
    {

        [Test]
        public void When_Finding_An_Item_That_Does_Not_Exists_On_Collection_InMemory()
        {
            int fakeID = 12345;

            SaveAll(collection);

            var result = ( repository.FindById(fakeID) == null ? true : false );

            Assert.IsTrue(result, "Repository code returns an item that does not exists");            
        }


        public void When_Finding_An_Item_That_Does_Exists_On_Collection_InMemory()
        {
            var id = collection[2];

            SaveAll(collection);

            var result = (repository.FindById(id) != null ? true : false);

            Assert.IsInstanceOf(typeof(IStoreable), repository.FindById(id), "Returned item type not mached.");

            Assert.IsTrue(result, "Added item not found");
        }



        [Test]
        public void When_Finding_An_Item_That_Exists_On_InMemory()
        {
            var id = 1004;

            Save(id);

            var result = (repository.FindById(id) != null ? true : false);

            Assert.IsTrue(result, "Repository code does not find an item that exists on inMemory");
        }


    }
}
