using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFY.Fatura.Models
{
    public class MalHizmetTableModel
    {
        public string malHizmet { get; set; }
        public int miktar { get; set; } = 1;
        public string birim { get; set; } = "C62";
        public decimal birimFiyat { get; set; }
        public decimal fiyat { get; set; }
        public int iskontoOrani { get; set; } = 0;
        public string iskontoTutari { get; set; } = "0";
        public string iskontoNedeni { get; set; } = "";
        public decimal malHizmetTutari { get; set; }
        public int kdvOrani { get; set; }
        public int vergiOrani { get; set; } = 0;
        public decimal kdvTutari { get; set; }
        public string vergininKdvTutari { get; set; } = "0";
        public string ozelMatrahTutari { get; set; } = "0";
        public string hesaplananotvtevkifatakatkisi { get; set; } = "0";

        public MalHizmetTableModel(InvoiceDetailsItemModel invoiceDetailsItem)
        {
            malHizmet = invoiceDetailsItem.name;
            miktar = invoiceDetailsItem.quantity;
            birim = invoiceDetailsItem.unit;
            birimFiyat = invoiceDetailsItem.unitPrice;
            fiyat = invoiceDetailsItem.price;
            malHizmetTutari = decimal.Round(invoiceDetailsItem.quantity * invoiceDetailsItem.unitPrice, 2, MidpointRounding.AwayFromZero);
            kdvOrani = invoiceDetailsItem.VATRate;
            kdvTutari = decimal.Round(invoiceDetailsItem.VATAmount, 2, MidpointRounding.AwayFromZero);
        }
    }
}
