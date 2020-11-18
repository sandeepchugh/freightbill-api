CREATE TABLE Freightbills (
    Id int  NOT NULL IDENTITY  PRIMARY KEY,
    FreightbillNo varchar(100) NOT NULL,
    InvoiceNumber varchar(100),
    TransportationProvider varchar(100),
    BilledAmount decimal(16,2) ,
    AuditAmount decimal (16,2)
);
