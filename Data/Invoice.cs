using System.ComponentModel.DataAnnotations;

namespace CompanyRecProject.Data
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string musteriName { get; set; }
        public string? InvoiceType { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? Price { get; set; }
    }
}
