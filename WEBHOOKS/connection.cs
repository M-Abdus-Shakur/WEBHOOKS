using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;

namespace WEBHOOKS
{
    internal class connection
    {
        public static byte[] post(string uri, NameValueCollection pair)
        {
            using (WebClient wc = new WebClient())
            {
                return wc.UploadValues(uri, pair);  
            }
        }
    }
}
