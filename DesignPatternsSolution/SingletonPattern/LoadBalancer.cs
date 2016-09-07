using System;
using System.Collections.Generic;

namespace SingletonPattern
{
    public class LoadBalancer
    {
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }

        private static LoadBalancer _instanceSingleton;

        private List<string> _servers = new List<string>();

        private Random _random = new Random();

        public LoadBalancer()
        {
            _servers.Add("server1");
            _servers.Add("server2");
            _servers.Add("server3");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (_instanceSingleton == null)
            {
                _instanceSingleton = new LoadBalancer();
            }

            return _instanceSingleton;
        }

    }
}
