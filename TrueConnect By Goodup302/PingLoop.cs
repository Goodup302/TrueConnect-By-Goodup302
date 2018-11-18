using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueConnect_By_Goodup302
{
    class PingLoop
    {
        public int bufferSize;
        public string addressIp;
        public int timeout;

        private bool queryIsInit;

        public int[] logPing;
        public int[] logPingSuccess;
        public IPStatus[] logPingError;
        public int loopSize;

        public int error;
        public int success;

        public int resultMinMs;
        public int resultMaxMs;

        public double averageLatency;

        public PingLoop(string ip, int time)
        {
            this.queryIsInit = false;
            this.addressIp = ip;
            this.loopSize = time;
            this.logPing = new int[time];
            this.logPingSuccess = new int[time];
            this.logPingError = new IPStatus[time];
        }

        public void defineQuery(int buffer, int timeout)
        {
            this.queryIsInit = true;
            this.resultMinMs = timeout;
            this.bufferSize = buffer;
            this.timeout = timeout;
        }


        public void run()
        {
            if (queryIsInit)
            {
                double additionOfPing = 0;
                PingReply result;
                for (int i = 0; i < this.loopSize; i++)
                {
                    result = NetworkConnection.PingHost(this.addressIp, this.bufferSize, this.timeout);
                    if (result != null && result.Status == IPStatus.Success && result.RoundtripTime <= timeout)
                    {
                        additionOfPing += result.RoundtripTime;
                        logPing[i] = (int)result.RoundtripTime;
                        logPingSuccess[i] = (int)result.RoundtripTime;
                        if (resultMaxMs < result.RoundtripTime)
                        {
                            resultMaxMs = (int)result.RoundtripTime;
                        }
                        if (resultMinMs > result.RoundtripTime)
                        {
                            resultMinMs = (int)result.RoundtripTime;
                        }
                        success++;
                    }
                    else
                    {
                        logPing[i] = -1;
                        if (result != null)
                        {
                            logPingError[i] = result.Status;
                        }
                        else
                        {
                            logPingError[i] = IPStatus.Unknown;
                        }
                        error++;
                    }
                    //set the percentage of charging
                }
                averageLatency = (additionOfPing / success);
            }
            else
            {
                MessageBox.Show("(Class) "+this.GetType().Name+ ": defineQuery() isn't set.");
            }
        }
    }
}
