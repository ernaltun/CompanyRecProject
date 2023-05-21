using CompanyRecProject.Context;
using Microsoft.EntityFrameworkCore;

namespace CompanyRecProject.Data
{
    public class SupportService
    {
        private readonly DataContext _dataContext;
        public SupportService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<Support>> GetAllSupports()
        {
            return await _dataContext.Supports.ToListAsync();
        }

        //  yeni talep ekle
        public async Task<bool> AddNewSupport(Support support)
        {
            await _dataContext.Supports.AddAsync(support);
            await _dataContext.SaveChangesAsync();
            return true;
        }
    }
}
