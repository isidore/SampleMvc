using System.Collections.Generic;
using System.Linq;

namespace SampleMvc
{
    public partial class Customer
    {
        public IEnumerable<Invoice> GetShippedInvoices()
        {
            return Invoices.Where(i => i.IsShipped);
        }

				public IEnumerable<Invoice> GetUnshippedInvoices()
        {
            return Invoices.Where(i => i.IsUnshipped);
        }
				public IEnumerable<Invoice> GetParitallyShippedInvoices()
        {
            return Invoices.Where(i => i.IsPartiallyShipped);
        }
    }
}
