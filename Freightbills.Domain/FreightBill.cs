using System;

namespace Freightbills.Domain
{
    public class FreightBill
    {
        public string FreightBillNumber { get; set; }
        public string Invoice { get; set; }
        public string TransportationProvider { get; set; }
        public decimal BilledAmount { get; set; }
        public decimal AuditAmount { get; set; }
    }
}