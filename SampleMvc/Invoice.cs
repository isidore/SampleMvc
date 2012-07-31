using System.Collections.Generic;
using System.Linq;

namespace SampleMvc
{
    public partial class Invoice
    {
        public bool IsShipped { get { return InvoiceItems.All(i => i.Shipped); } }

        public bool IsUnshipped { get { return InvoiceItems.All(i => !i.Shipped); } }

        public bool IsPartiallyShipped { get { return !IsShipped && !IsUnshipped; } }

				public IEnumerable<InvoiceItem> GetUnshippedItems()
        {
            return InvoiceItems.Where(i => !i.Shipped);
        }

				public void CalculateTotal()
        {
            Total = InvoiceItems.Sum(i=>i.Price);
        }
    }
}
