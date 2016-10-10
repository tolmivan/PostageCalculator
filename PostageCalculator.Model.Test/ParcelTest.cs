using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PostageCalculator.Model.Test
{
    [TestClass]
    public class ParcelTest
    {
        [TestMethod]
        public void Category_10_20_5_20_Medium_80()
        {
            Parcel parcel = new Parcel(10,20,5,20);
            Assert.AreEqual("Medium Parcel", parcel.ParcelCategory);
            Assert.AreEqual( "$80", parcel.PostageCostString);
        }
        
        [TestMethod]
        public void Category_22_5_5_5_Heavy_330()
        {
            Parcel parcel = new Parcel(22, 5, 5, 5);
            Assert.AreEqual("Heavy Parcel", parcel.ParcelCategory);
            Assert.AreEqual("$330", parcel.PostageCostString);
        }

        [TestMethod]
        public void Category_2_3_10_12_Small_18()
        {
            Parcel parcel = new Parcel(2, 3, 10, 12);
            Assert.AreEqual("Small Parcel", parcel.ParcelCategory);
            Assert.AreEqual("$18", parcel.PostageCostString);
        }

        [TestMethod]
        public void Category_110_20_55_120_Rejected_NA()
        {
            Parcel parcel = new Parcel(110, 20, 55, 120);
            Assert.AreEqual("Rejected", parcel.ParcelCategory);
            Assert.AreEqual("N/A", parcel.PostageCostString);
        }

        [TestMethod]
        public void Category_2_2_2_2_Small_1()
        {
            Parcel parcel = new Parcel(2, 2, 2, 2);
            Assert.AreEqual("Small Parcel", parcel.ParcelCategory);
            Assert.AreEqual("$1", parcel.PostageCostString);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid dimensions were allowed")]
        public void Category_InvalidDimensions_ExceptionThrown()
        {
            Parcel parcel = new Parcel(0, -1, 2, 2);
        }

    }
}
