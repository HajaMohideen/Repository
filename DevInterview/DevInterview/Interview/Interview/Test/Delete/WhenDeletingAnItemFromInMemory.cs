using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Interview.Test;
using System.Diagnostics;


namespace Interview.Test.Delete
{
    
    [TestFixture]
    public class WhenDeletingAnItemFromInMemory : Tests
    {

        [Test]
        public void When_Removing_An_Item_That_Does_Not_Exists_On_InMemory()
        {
            int fakeID = 0;
            var id = 1004;
                        
            Save(id);            
            repository.Delete(fakeID);
            var result = (repository.FindById(id) != null ? true : false);

            Assert.IsTrue(result, "Wrong item has been removed .");
        }


        [Test]
        public void When_Removing_An_Item_That_Does_Exists_On_InMemory()
        {
            var id = collection[2];

            SaveAll(collection);

            repository.Delete(id);

            var result = (repository.FindById(id) == null ? true : false);

            Assert.IsTrue(result, "Deleted wrong item");
        }

    }


}
