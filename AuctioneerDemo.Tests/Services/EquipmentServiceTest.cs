using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuctioneerDemo.Services.Interfaces;
using AuctioneerDemo.Tests.Mocks;

namespace AuctioneerDemo.Tests.Services
{
    [TestClass]
    public class EquipmentServiceTest
    {
        [TestMethod]
        public void CanGetAllEquipmentItems()
        {
            IEquipmentService mockService = new MockEquipmentService();
            var allEquipment = mockService.GetAllEquipment();
            Assert.AreEqual(allEquipment.Count, 1);
        }

        [TestMethod]
        public void CanGetEquipmentById_WhenThatItemExists()
        {
            IEquipmentService mockService = new MockEquipmentService();
            var equipmentItem = mockService.GetEquipment(123);
            Assert.IsNotNull(equipmentItem);
            Assert.AreEqual(equipmentItem.EquipmentId, 123);
        }

        [TestMethod]
        public void CanGetEquipmentById_WhenThatItemDoesNotExist()
        {
            IEquipmentService mockService = new MockEquipmentService();
            var equipmentItem = mockService.GetEquipment(-1);
            Assert.IsNull(equipmentItem);
        }
    }
}
