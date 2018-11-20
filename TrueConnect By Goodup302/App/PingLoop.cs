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
        public event EventHandler endRunEvent;
        public event EventHandler loadingUpEvent;


        public int bufferSize;
        public string addressIp;
        public int timeout;

        private bool queryIsInit;

        public int[] logPing;
        public int[] logPingSuccess;
        public IPStatus[] logPingError;
        public double loopSize;

        public int error;
        public int success;

        public int resultMinMs;
        public int resultMaxMs;

        public double averageLatency;

        public int progressPercentage;

        public bool breaking;

        public PingLoop(string ip, int time)
        {
            this.queryIsInit = false;
            this.addressIp = ip;
            this.loopSize = time;
            this.logPing = new int[time];
            this.logPingSuccess = new int[time];
            this.logPingError = new IPStatus[time];
            this.breaking = false;
        }

        public void defineQuery(int buffer, int timeout)
        {
            this.queryIsInit = true;
            this.resultMinMs = timeout;
            this.bufferSize = buffer;
            this.timeout = timeout;
        }

        public void stop()
        {
            breaking = true;
        }

        public void run()
        {
            if (queryIsInit)
            {
                this.breaking = false;
                progressPercentage = 0;
                double additionOfPing = 0;
                PingReply result;
                for (int i = 0; i < this.loopSize; i++)
                {
                    if (breaking)
                    {
                        break;
                    }
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
                    progressPercentage = (int)((i + 1) / loopSize * 100);
                    loadingUp(EventArgs.Empty);
                }
                averageLatency = (additionOfPing / success);
                endRun(EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("(Class) "+this.GetType().Name+ ": defineQuery() isn't set.");
            }
        }


        protected virtual void endRun(EventArgs e)
        {
            if (endRunEvent != null)
            {
                endRunEvent(this, e);
            }
        }
        protected virtual void loadingUp(EventArgs e)
        {
            if (loadingUpEvent != null)
            {
                loadingUpEvent(this, e);
            }
        }
    }
}
