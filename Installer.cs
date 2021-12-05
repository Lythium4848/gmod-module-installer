using System.Drawing;
using System.Net;
using Pastel;

namespace ArsenicModuleInstaller;

public static class Installer
{
    public static void Download(string url, string packageName, string gmodPath)
    {
        WebClient client = new WebClient();
        client.DownloadFile("https://github.com/"+url+packageName+"_win32", gmodPath+packageName+"_win32.dll");
        client.DownloadFile("https://github.com/"+url+packageName+"_win64", gmodPath+packageName+"_win64.dll");
        Console.WriteLine("Module Successfully Installed!".Pastel(Color.Green));
    }

}