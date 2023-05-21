using CompanyRecProject.Context;
using Microsoft.EntityFrameworkCore;

namespace CompanyRecProject.Data
{
    public class InvoiceService
    {
        private readonly DataContext _dataContext;

        public InvoiceService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<Invoice>> GetAllInvoices()
        {
            return await _dataContext.Invoices.ToListAsync();
        }
		//  yeni fatura ekle
		public async Task<bool> AddNewInvoice(Invoice ınvoice)
		{
			await _dataContext.Invoices.AddAsync(ınvoice);
			await _dataContext.SaveChangesAsync();
			return true;
		}

		// id lere göre kaydedilen faturaların kaydını getirme
		public async Task<Invoice> GetInvoiceById(int id)
		{
			Invoice ınvoice = await _dataContext.Invoices.FirstOrDefaultAsync(x => x.InvoiceId == id);
			return ınvoice;

		}

		// fatura bilgisi düzenle
		public async Task<bool> UpdateInvoiceDetails(Invoice ınvoice)
		{
			_dataContext.Invoices.Update(ınvoice);
			await _dataContext.SaveChangesAsync(true);
			return true;
		}

		// fatura sil
		public async Task<bool> DeleteInvoice(Invoice ınvoice)
		{
			_dataContext.Invoices.Remove(ınvoice);
			await _dataContext.SaveChangesAsync(true);
			return true;
		}
	}
}
