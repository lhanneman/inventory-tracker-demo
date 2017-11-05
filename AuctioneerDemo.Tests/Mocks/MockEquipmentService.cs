using AuctioneerDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctioneerDemo.Entities;

namespace AuctioneerDemo.Tests.Mocks
{
    class MockEquipmentService : IEquipmentService
    {
        public void AddUpdateEquipment(Equipment equipment)
        {
            throw new NotImplementedException();
        }

        public void DeleteEquipment(Equipment equipment)
        {
            throw new NotImplementedException();
        }

        public List<Equipment> GetAllEquipment()
        {
            return new List<Equipment>()
            {
                new Equipment() { EquipmentId = 123, Make = "Test Make", Model = "Test Model", Year = 2002, Description = "Test Description" }
            };
        }

        public Equipment GetEquipment(int id)
        {
            if (id > 0)
            {
                return new Equipment() { EquipmentId = id, Make = "Test Make", Model = "Test Model", Year = 2002, Description = "Test Description" };
            }

            return null;
        }
    }
}
