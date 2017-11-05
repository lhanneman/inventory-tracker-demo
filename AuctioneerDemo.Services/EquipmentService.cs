using AuctioneerDemo.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using AuctioneerDemo.Entities;
using AuctioneerDemo.Data;

namespace AuctioneerDemo.Services
{
    public class EquipmentService : IEquipmentService
    {
        public void AddUpdateEquipment(Equipment equipment)
        {
            if (equipment.EquipmentId == 0)
            {
                AddEquipment(equipment);
            }
            else
            {
                UpdateEquipment(equipment);
            }
        }

        public void DeleteEquipment(Equipment equipment)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var equipmentToDelete = ctx.Equipment.FirstOrDefault(e => e.EquipmentId.Equals(equipment.EquipmentId));

                if (equipmentToDelete != null)
                {
                    ctx.Equipment.Remove(equipmentToDelete);
                    ctx.SaveChanges();
                }
            }

        }

        public List<Equipment> GetAllEquipment()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Equipment.ToList();
            }
        }

        public Equipment GetEquipment(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Equipment.FirstOrDefault(e => e.EquipmentId.Equals(id));
            }
        }

        private void AddEquipment(Equipment equipment)
        {
            using(var ctx = new ApplicationDbContext())
            {
                ctx.Equipment.Add(equipment);
                ctx.SaveChanges();
            }
        }

        private void UpdateEquipment(Equipment equipment)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var equipmentToUpdate = ctx.Equipment.Find(equipment.EquipmentId);
                if (equipmentToUpdate == null)
                {
                    return;
                }

                ctx.Entry(equipmentToUpdate).CurrentValues.SetValues(equipment);
                ctx.SaveChanges();
            }
        }

    }
}
