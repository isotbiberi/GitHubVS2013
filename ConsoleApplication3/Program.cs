using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using System.IO;
using System.Threading;
using System.ComponentModel;
using System.CodeDom;
using System.Drawing;
using System.Windows.Input;



namespace ConsoleApplication3
{
    class Program
    {
        static Renci.SshNet.SshClient ssh;
        static Renci.SshNet.ShellStream stream;
        static void Main(string[] args)
        {
            Console.WriteLine("fd");
           
            try
            {
                ssh = new SshClient("10.141.3.110", "root", "ismail");
                ssh.Connect();
                 //status = true;
                 //timer_enable();
            }
            //catch (Exception ex)
            // {
            //    Console.Write(ex.Message);
            //}

            catch { }

           if (true)
            try
            {
                stream = ssh.CreateShellStream("xterm", 80, 50, 1024, 1024, 1024);
                Thread.Sleep(100);
                stream.WriteLine("telnet localhost 6571");
                Thread.Sleep(100);
            }
            catch (Exception)
            {
                Console.WriteLine("hata");
            }                    
            
            Console.ReadKey();
        }
        
    }
}
