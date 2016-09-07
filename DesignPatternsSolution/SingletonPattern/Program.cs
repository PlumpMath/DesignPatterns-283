using System;

namespace SingletonPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();

            //Same Instance?
            if (b1 == b2 && b2 == b3)
            {
                Console.WriteLine("Same Instance\n");
            }

            // Load balance 15 server requests
            var balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
