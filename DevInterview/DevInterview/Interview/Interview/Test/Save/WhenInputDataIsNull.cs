using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using Interview.Test;
using System.Diagnostics;
namespace Interview.Test.Save
{

    [TestFixture]    
    public class WhenInputDataIsNull : Tests
    {

        [Test]
        public void When_Input_Id_Is_Null()
        {   
            int expected = 0;
            int actual = 0;
            expected = ItemCount(); 

            Save(null);

            actual = ItemCount(); 
            
            Assert.AreEqual(expected, actual, "Error: Null input value has been added.");
        }

    }

}
