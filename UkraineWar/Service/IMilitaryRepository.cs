using UkraineWar.Models;

namespace UkraineWar.Service
{
    public interface IMilitaryRepository
    {
        Task<IEnumerable<MilitaryEquipment>> GetAll();
        IQueryable<MilitaryEquipment> GetAllAsync();
        Task<MilitaryEquipment> GetById(int? id);    
        Task<MilitaryEquipment> GetByIdMust(int id);
        Task<MilitaryEquipment> GetByIdAsNoTracking(int id);
        bool Add(MilitaryEquipment equipment);
        bool Delete(MilitaryEquipment equipment);
        bool Update(MilitaryEquipment equipment);
        bool Save();

    }
}
