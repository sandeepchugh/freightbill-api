using System;

namespace Freightbills.Domain
{
    public class Shipment
    {
        public string ShipmentId { get; set; }
        public string Status { get; set; }
        public string PaymentTerm { get; set; }
        public string ServiceLevel { get; set; }
        public DateTime? ShipDate { get; set; }
    }
}