﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };

            string expected = "Baggins";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };

            string expected = "Bilbo";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            //--Act

            //--Assert
            Assert.AreEqual(2, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer()
            {
                LastName = "Baggins",
                FirstName = "Flo",
                EmailAddress = "fbagging@gmail.com"
            };

            var expected = true;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
