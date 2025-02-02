﻿using System.Net.NetworkInformation;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {

        public string SendPing()
        {
            return "Success: Ping Sent";
        }

        public int PingTimeout(int a, int b)
        {
            return a + b;
        }

        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }

        public PingOptions GetPingOptions()
        { 
            return new PingOptions() { DontFragment = true, Ttl = 64 }; 
        }

        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pings = new[]
            {
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 64
                },
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 64
                },
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 64
                }
            };

            return pings;
        }
    }
}
