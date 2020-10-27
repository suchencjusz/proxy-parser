using System;
using System.IO;

namespace proxy_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Proxy parser for proxychains -suchy2020";

            string[] accounts={}, ip, port, user, pass;
            string type, all="";

            Console.Write("Proxies type (http, socks5, etc.): ");
            type = Console.ReadLine();

            if (File.Exists("toparse.txt"))
                accounts = File.ReadAllLines("toparse.txt");
            else
                File.Create("toparse.txt");
                Console.WriteLine("File created (\'toparse.txt\')");

            ip = new string[accounts.Length];
            port = new string[accounts.Length];
            user = new string[accounts.Length];
            pass = new string[accounts.Length];

            for (int i = 0; i < accounts.Length; i++)
            {
                string help = (accounts[i].ToString());

                ip[i] = help.Split(':')[0];
                all += $"{ip[i]}\t";

                port[i] = help.Split(':')[1];
                all += $"{port[i]}\t";

                if (help.Split(':').Length-1 >= 2)
                    user[i] = help.Split(':')[2];
                    all += $"{user[i]}\t";
                if (help.Split(':').Length-1 >= 3)
                    pass[i] = help.Split(':')[3];
                    all += $"{pass[i]}\t";

                all += "\n";
            }

            for (int i = 0; i < ip.Length; i++)
            {
                Console.WriteLine($"{type}\t{ip[i]}\t{port[i]}\t{user[i]}\t{pass[i]}");
            }

            Console.WriteLine();
            Random rnd = new Random();
            int r = rnd.Next(1111, 9999);
            File.AppendAllText($"{type}-{r}-proxyparsed.txt", all);
            Console.WriteLine($"Done! Saved to \'{type}-{r}-proxyparsed.txt\'");
            Console.ReadKey();
        }
    }
}
