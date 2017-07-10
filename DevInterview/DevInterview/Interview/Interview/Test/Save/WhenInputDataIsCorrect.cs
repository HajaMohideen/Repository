using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Interview.Test;

namespace Interview.Test.Save
{
    
    [TestFixture]    
    public class WhenInputDataIsCorrect : Tests
    {        

        [Test]
        public void When_Valid_Id_Provided_But_FindBy_InValid_Id()
        {
            int fakeId = 123;
                        
            Save(1001);

            Assert.IsNull(repository.FindById(fakeId), "FindById method returns invalid result");
        }


        [Test]
        public void When_Input_Id_Is_Valid_Data()
        {
            var id = 1002;

            Save(id);

            Assert.IsNotNull(repository.FindById(id), "Id not found.");
        }


        [Test]
        public void When_Collection_Of_Input_Save_Method()
        {
            var index = 2;

            SaveAll(collection);

            Assert.IsNotNull( repository.FindById(collection[index]), "Saved ID not found." );
        }

    }

}
