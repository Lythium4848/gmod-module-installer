using System.Drawing;
using System.Net;
using Pastel;

namespace ArsenicModuleInstaller;

public static class Installer
{
    public static void Download(string url, string packageName, string gmodPath)
    {
        WebClient client = new WebClient();
        if (File.Exists(packageName))
        {
            File.Delete(packageName+"_win32.dll");
            File.Delete(packageName+"_win64.dll");
        }
        client.DownloadFile("https://github.com/"+url+packageName+"_win32.dll", gmodPath+packageName+"_win32.dll");
        client.DownloadFile("https://github.com/"+url+packageName+"_win64.dll", gmodPath+packageName+"_win64.dll");
        Console.WriteLine("Module Successfully Installed!".Pastel(Color.Green));
    }

}