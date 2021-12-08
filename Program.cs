using System.Drawing;
using Pastel;
using ArsenicModuleInstaller;
using Steamworks;

SteamClient.Init(4000);

Console.WriteLine("\nWelcome to ArsenicModuleInstaller!".Pastel(Color.Blue));
Console.WriteLine("This app will install garry's mod modules that you can use on the ArsenicNetworks server\n");
Console.WriteLine("THIS ONLY WORKS ON WINDOWS".Pastel(Color.Red));
Console.WriteLine("Avalable Modules:\n  (1) ArsenicDiscordRPC (GDiscord)\n  (2) gmcl_midi\n");
Console.Write("Module you would like to install:    ".Pastel(Color.FromArgb(165, 229, 250)));

var module = Console.ReadLine();
var gmodPath = SteamApps.AppInstallDir(4000);
var gmodBinPath = gmodPath + "/garrysmod/lua/bin/";
if (!Directory.Exists(gmodBinPath))
{
    Directory.CreateDirectory(gmodBinPath);
}

if (module == "1")
{
    Console.WriteLine("Installing Module...".Pastel(Color.Blue));
    Installer.Download("fluffy-servers/gmod-discord-rpc/releases/tag/1.1/", "gmcl_gdiscord", gmodBinPath);
}
else if (module == "2")
{
    Console.WriteLine("Installing Module...".Pastel(Color.Blue));
    Installer.Download("FPtje/gmcl_midi/releases/tag/v0.2.0/", "gmcl_midi", gmodBinPath);
}

SteamClient.Shutdown();
Console.WriteLine("\nPress any key to exit!");
Console.ReadKey();
