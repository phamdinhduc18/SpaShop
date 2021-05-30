using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaShop.Utilities.Exceptions
{
    public class SpaShopException : Exception
    {
        public SpaShopException()
        {
        }

        public SpaShopException(string message)
            : base(message)
        {
        }

        public SpaShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
