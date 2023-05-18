using CompanyRecProject.Context;
using Microsoft.EntityFrameworkCore;

namespace CompanyRecProject.Data
{
    public class MusteriService
    {
        private readonly DataContext _dataContext;
        public MusteriService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<Musteri>> GetAllMusteris()
        {
            return await _dataContext.Musteris.ToListAsync();
        }

        //  yeni müşteri ekle
        public async Task<bool> AddNewMusteri(Musteri musteri)
        {
            await _dataContext.Musteris.AddAsync(musteri);
            await _dataContext.SaveChangesAsync();
            return true;
        }
        
        // id lere göre kaydedilen müşterilerin kaydını getirme
        public async Task<Musteri> GetMusteriById(int id)
        {
            Musteri musteri = await _dataContext.Musteris.FirstOrDefaultAsync(x => x.Id == id);
            return musteri;
            
        }

        // musteri bilgisi düzenle
        public async Task<bool> UpdateMusteriDetails(Musteri musteri)
        {
            _dataContext.Musteris.Update(musteri);
            await _dataContext.SaveChangesAsync(true);
            return true;
        }

        // musteriyi sil
        public async Task<bool> DeleteMusteri(Musteri musteri)
        {
            _dataContext.Musteris.Remove(musteri);
            await _dataContext.SaveChangesAsync(true);
            return true;
        }

    }
}
