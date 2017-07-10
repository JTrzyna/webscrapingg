using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapingg
{
    class TekstStrony
    {

        public static string GetSourceCode(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string sourceCode = sr.ReadToEnd();
            sr.Close();
            response.Close();
            return sourceCode;

        }

    }
}
