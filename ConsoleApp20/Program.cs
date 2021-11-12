using CefSharp.OffScreen;
using System;
using System.Threading;
using CefSharp;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Cef.Initialize(new CefSettings());
            var browser = new ChromiumWebBrowser("http://www.google.com");
            Thread.Sleep(2000); //wait for init
            browser.ShowDevTools();
            Console.ReadLine();
        }
    }
}
