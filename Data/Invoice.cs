using System.ComponentModel.DataAnnotations;

namespace CompanyRecProject.Data
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public int musteriId { get; set; }
        public string InvoiceType { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int Price { get; set; }
    }
}
