using System;
using System.Collections.Generic;
using System.Text;

namespace WebOnline.Enlity.Exception
{
    public class WebOnlineException : Exception
    {
        public WebOnlineException()
        {

        }
        public WebOnlineException(string messenger)
            : base(messenger)
        {

        }
    }
}
