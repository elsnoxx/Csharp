
using System.Net;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

void foo()
{
    // Console.WriteLine("new app");
    //Console.WriteLine("\n");
    //display();
    //Console.WriteLine("\n");
    
    //Console.WriteLine("\n");
    //hostByName();

    Console.WriteLine("\n");
    ipddress();
    Console.ReadLine();
}


void display(string ipaddress)
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

void hostByIP4(string ipaddres)
{
    
    IPAddress hostIPAddress = IPAddress.Parse(ipaddres);
    IPHostEntry hostInfo = Dns.GetHostByAddress(hostIPAddress);
    IPAddress[] address = hostInfo.AddressList;
    String[] alias = hostInfo.Aliases;

    Console.WriteLine("Host name : " + hostInfo.HostName);
    Console.WriteLine("\nAliases :");
    for (int index = 0; index < alias.Length; index++)
    {
        Console.WriteLine(alias[index]);
    }
    Console.WriteLine("\nIP address list : ");
    for (int index = 0; index < address.Length; index++)
    {
        Console.WriteLine(address[index]);
    }
    
    

}

void hostByName()
{
    string hostName = "RisaHP";
    IPHostEntry hostInfo = Dns.GetHostByName(hostName);
    IPAddress[] address = hostInfo.AddressList;

    String[] alias = hostInfo.Aliases;

    Console.WriteLine("Host name : " + hostInfo.HostName);
    Console.WriteLine("\nAliases : ");

    for (int index = 0; index < alias.Length; index++)
    {
        Console.WriteLine(alias[index]);
    }

    Console.WriteLine("\nIP address list : ");
    for (int index = 0; index < address.Length; index++)
    {
        Console.WriteLine(address[index]);
    }
}

void ipddress()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("\n");
        Random rnd = new Random();
        string ip = "10.122.10." + rnd.Next(256);
        Console.WriteLine(ip);
        System.Threading.Thread.Sleep(1000);
        display(ip);
        hostByIP4(ip);
    }
}





foo();



