using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTests
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesValid()
        {
            //--Arrange
            string text = "Ionut  Toader";
            string expected = "Ionut Toader";

            //--Act
            string actual = StringHandler.InsertSpaces(text);

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
