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
        // id lere göre kaydedilen ftaleplerin kaydını getirme
        public async Task<Support> GetSupportsById(int id)
        {
            Support support = await _dataContext.Supports.FirstOrDefaultAsync(x => x.SupportId == id);
            return support;

        }
        // talep bilgisi düzenle
        public async Task<bool> UpdateSupportDetails(Support support)
        {
            _dataContext.Supports.Update(support);
            await _dataContext.SaveChangesAsync(true);
            return true;
        }
        public async Task<bool> UpdateSupportStatus(Support support)
        {
            var newStatus = "İşlemde";
            support.SupportStatus = (string)newStatus;

            return true;
        }

        // talep sil
        public async Task<bool> DeleteSupports(Support support)
        {
            _dataContext.Supports.Remove(support);
            await _dataContext.SaveChangesAsync(true);
            return true;
        }
    }
}

