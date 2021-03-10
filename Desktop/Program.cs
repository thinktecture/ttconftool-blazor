using System;
using Photino.Blazor;

namespace TTConfTool.Desktop
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ComponentsDesktop.Run<Startup>("TT ConfTool", "wwwroot/index.html");
        }
    }
}
