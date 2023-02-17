using System.Net.NetworkInformation;
using System.Net;
using System.Runtime.Intrinsics.X86;

namespace geip
{
    internal class Program
    {
        static int display(string ipaddress)
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(ipaddress, 100);
                if (reply != null)
                {
                    if (reply.Status.ToString() == "TimedOut")
                    {
                        // Console.WriteLine("Status: " + reply.Status + "\n time: " + reply.RoundtripTime.ToString() + "\n Addres: " + reply.Address);
                        return 1;
                    }
                    return 0;
                }

            }
            catch
            {
                // Console.WriteLine("Error: timeout");
                return 1;
            }

            return 0;
        }
        static void ERR(string ipaddress)
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(ipaddress, 100);
                if (reply != null)
                {
                    Console.WriteLine("Status: " + reply.Status + "\n time: " + reply.RoundtripTime.ToString() + "\n Addres: " + reply.Address);
                }
            }
            catch
            {
                Console.WriteLine("Error: timeout");
            }
        }

        static int SUB_Sticking()
        {
            Console.WriteLine("SUB Sticking");
            int cnt = 0;
            for (int i = 95; i < 101; i++)
            {
                string ip = "10.122.240." + i;
                System.Threading.Thread.Sleep(1000);
                if (display(ip) == 0)
                {
                    cnt++;
                }
                else
                {
                    ERR(ip);
                }
            }
            return cnt;
        }
        static int SUV_Cush()
        {
            Console.WriteLine("SUV Cush");
            int cnt = 0;
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.240.126") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.240.126");
            }
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.240.128") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.240.128");
            }
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.240.132") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.240.132");
            }
            return cnt;
        }
        static int SUV_Rear()
        {
            Console.WriteLine("SUV Rear");
            int cnt = 0;
            for (int i = 115; i < 126; i++)
            {
                string ip = "10.122.240." + i;
                if (display(ip) == 0 && i != 121 && i != 122)
                {
                    cnt++;
                }
                else
                {
                    ERR(ip);
                }
                System.Threading.Thread.Sleep(1000);

            }
            return cnt;
        }
        static int SUV_Front()
        {
            Console.WriteLine("SUV Front");
            int cnt = 0;
            for (int i = 70; i < 94; i++)
            {
                string ip = "10.122.240." + i;
                if (display(ip) == 0)
                {
                    cnt++;
                }
                else
                {
                    ERR(ip);
                }
                System.Threading.Thread.Sleep(1000);
            }
            return cnt;
        }
        static int PD_Rear()
        {
            Console.WriteLine("PD Rear");
            int cnt = 0;
            for (int i = 170; i < 176; i++)
            {
                string ip = "10.122.240." + i;
                System.Threading.Thread.Sleep(1000);
                if (display(ip) == 0)
                {
                    cnt++;
                }
                else
                {
                    ERR(ip);
                }
            }

            System.Threading.Thread.Sleep(1000);
            if (display("10.122.240.198") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.240.198");
            }
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.240.163") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.240.163");
            }
            return cnt;
        }
        static int PD_Front()
        {
            Console.WriteLine("PD Front");
            int cnt = 0;
            for (int i = 133; i < 148; i++)
            {

                string ip = "10.122.240." + i;
                System.Threading.Thread.Sleep(1000);
                if (display(ip) == 0 & i != 142 & i != 143)
                {
                    cnt++;
                }
                else
                {
                    ERR(ip);
                }
            }
            return cnt;
        }
        static int Foam_Pad()
        {
            Console.WriteLine("Foam Pad");
            int cnt = 0;
            for (int i = 66; i < 73; i++)
            {
                string ip = "10.122.245." + i;
                System.Threading.Thread.Sleep(1000);
                if (display(ip) == 0)
                {
                    cnt++;
                }
                else
                {
                    ERR(ip);
                }
            }
            for (int i = 79; i < 89; i++)
            {
                string ip = "10.122.245." + i;
                System.Threading.Thread.Sleep(1000);
                if (display(ip) == 0)
                {
                    cnt++;
                }
                else
                {
                    ERR(ip);
                }
            }
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.245.95") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.245.95");
            }
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.245.96") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.240.126");
            }
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.245.102") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.240.126");
            }
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.245.103") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.240.126");
            }
            
            return cnt;
        }

        static int CLS()
        {
            Console.WriteLine("CLS a WMS");
            int cnt = 0;
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.246.195") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.246.195");
            }
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.246.196") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.246.196");
            }
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.246.194") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.246.194");
            }
            System.Threading.Thread.Sleep(1000);
            if (display("10.122.246.199") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.246.199");
            }
            System.Threading.Thread.Sleep(1000);
            if (display("10.36.139.25") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.36.139.25");
            }
            if (display("10.122.246.193") == 0)
            {
                cnt++;
            }
            else
            {
                ERR("10.122.246.193");
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            bool end = true;
            while (end)
            {
                int[] array = { SUV_Front(), SUV_Rear(), SUV_Cush(), SUB_Sticking(), PD_Rear(), PD_Front(), Foam_Pad(), CLS() };
                Console.WriteLine("\n \n \n \n \n \n \n \n \n");
                Console.WriteLine("\n Testing -> SUV Front  -> " + array[0] + "/24 \n");
                Console.WriteLine("\n Testing -> SUV Rear " + array[1] + "/11 \n");
                Console.WriteLine("\n Testing -> SUV Cush " + array[2] + "/3 \n");
                Console.WriteLine("\n Testing -> SUB Sticking " + array[3] + "/6 \n");
                Console.WriteLine("\n Testing -> PD Rear " + array[4] + "/8\n");
                Console.WriteLine("\n Testing -> PD Front " + array[5] + "/14\n");
                Console.WriteLine("\n Testing -> Foam Pad " + array[6] + "/21\n");
                Console.WriteLine("\n Testing -> CLS " + array[7] + "/6\n");
            }
        }
    }
}

