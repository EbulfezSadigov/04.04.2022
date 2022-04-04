using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    class NotAvailableException:Exception
    {
        public NotAvailableException():base("Munasib deyil")
        {

        }
        public NotAvailableException(string message) : base("Not availabe"+message)
        {

        }
    }
}
