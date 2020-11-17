using System;

namespace Freightbills.Domain
{
    public class Payment
    {
        public string TransportationProvider { get; set; }
        public string PaymentId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int BillCount { get; set; }
        public decimal PaidAmount { get; set; }
        public string WireReference { get; set; }
        public string Note { get; set; }
        public decimal Remittance { get; set;}
    }
}