namespace Freightbills.Domain
{
    public class FreightBill
    {
        public string FreightBillNumber { get; set; }
        public Invoice Invoice { get; set; }
        public TransportationProvider TransportationProvider { get; set; }
        public Billing Billing { get; set; }
        public Address Origin { get; set; }
        public Address Destination { get; set; }
    }
}