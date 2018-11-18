using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;

namespace TrueConnect_By_Goodup302
{
    class NetworkConnection
    {
        public const int maxTrameSize = 1472;
        public const int maxIcmpSize = 65500;

        public NetworkConnection(string lastName, string firstName)
        {
            
        }

        public static PingReply PingHost(string ip = "127.0.0.1", int bufferSize = 32, int timeout = 1000)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            PingReply reply = null;
            options.DontFragment = false;
            try
            {
                reply = pingSender.Send(ip, timeout, new byte[bufferSize], options);
            }
            catch (ArgumentException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (pingSender != null)
                {
                    pingSender.Dispose();
                }
            }
            return reply;
        }
    }
}
