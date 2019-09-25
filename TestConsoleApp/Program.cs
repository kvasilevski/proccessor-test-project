using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataToPost = "APIUsername=demo&APIPassword=password&ClientID=1009&EmployeeID=0&CCNumber=4222222222222222&CCExp=1025&Amount=10.0&CVV=999&TransactionType=sale&ISOCurrencyCode=USD&ISOCountryCode=US&AVS=Y";
            string ResponseStr = string.Empty;
            //WebRequest request = WebRequest.Create("http://demo.gpgway.com/gateway/GPGCCProcess.aspx");
            WebRequest request = WebRequest.Create("https://localhost:44398/gateway/GPGCCProcess.aspx");

            try
            {
                request.Method = "POST";
                request.Timeout = 180 * 1000;

                byte[] byteArray = Encoding.UTF8.GetBytes(dataToPost);

                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;

                Stream dataStream = request.GetRequestStream();

                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();

                // Display the status.
                // Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();

                // Display the content.
                //Console.WriteLine(responseFromServer);
                ResponseStr = responseFromServer;
                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();

            }
            catch (Exception  ex)
            {

                var exx = ex;
            }
           var xxx  = ResponseStr;

        }
    }
}
