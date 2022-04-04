using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    class NotFoundException:Exception
    {
        public NotFoundException() : base("Not found")
        {

        }
        public NotFoundException(string Message) : base(Message)
        {

        }
    }
}
