using System.Collections.Generic;
using AuctioneerDemo.Entities;

namespace AuctioneerDemo.Services.Interfaces
{
    public interface IEquipmentService
    {
        void AddUpdateEquipment(Equipment equipment);
        void DeleteEquipment(Equipment equipment);
        List<Equipment> GetAllEquipment();
        Equipment GetEquipment(int id);
    }
}
