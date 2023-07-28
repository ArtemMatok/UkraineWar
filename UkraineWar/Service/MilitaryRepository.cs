using Microsoft.EntityFrameworkCore;
using UkraineWar.Data;
using UkraineWar.Models;

namespace UkraineWar.Service
{
    public class MilitaryRepository : IMilitaryRepository
    {
        private readonly ApplicationDbContext _context;

        public MilitaryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(MilitaryEquipment equipment)
        {
            _context.Add(equipment);
            return Save();
        }

        public bool Delete(MilitaryEquipment equipment)
        {
            _context.Remove(equipment);
            return Save();
        }

        public async Task<IEnumerable<MilitaryEquipment>> GetAll()
        {
            return await _context.MilitaryEquipments.ToListAsync();
        }

        public IQueryable<MilitaryEquipment> GetAllAsync()
        {
            return _context.MilitaryEquipments;
        }

        public async Task<MilitaryEquipment> GetById(int? id)
        {
            return await _context.MilitaryEquipments.FirstOrDefaultAsync(x => x.MilitaryEquipmentId == id);
        }

        public async Task<MilitaryEquipment> GetByIdAsNoTracking(int id)
        {
            return await _context.MilitaryEquipments.AsNoTracking().FirstOrDefaultAsync(x => x.MilitaryEquipmentId == id);
        }

        public async Task<MilitaryEquipment> GetByIdMust(int id)
        {
            return await _context.MilitaryEquipments.FirstOrDefaultAsync(x => x.MilitaryEquipmentId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(MilitaryEquipment equipment)
        {
            _context.Update(equipment);
            return Save();
        }
    }
}
