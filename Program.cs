using System.Drawing;
using Pastel;
using ArsenicModuleInstaller;

Console.WriteLine("Welcome to ArsenicModuleInstaller!".Pastel(Color.Blue));
Console.WriteLine("This app will install garry's mod modules that you can use on the ArsenicNetworks server\n");
Console.WriteLine("THIS ONLY WORKS ON WINDOWS".Pastel(Color.Red));
Console.WriteLine("Avalable Modules:\n  (1) ArsenicDiscordRPC (GDiscord)\n  (2) gmcl_midi\n");
Console.Write("Module you would like to install:    ".Pastel(Color.FromArgb(165, 229, 250)));

string module;
module = Console.ReadLine();

Console.Write("Enter your garrysmod directory (e.g. c:/steam/GarrysMod/):   ");
string gmodPath;
gmodPath = Console.ReadLine();

string gmodBinPath;
gmodBinPath = gmodPath + "/garrysmod/lua/bin/";

if (module == "1")
{
    Console.WriteLine("Installing Module...".Pastel(Color.Blue));
    Installer.Download("fluffy-servers/gmod-discord-rpc/releases/tag/1.1/", "gmcl_gdiscord", gmodBinPath);
}

if (module == "2")
{
    Console.WriteLine("Installing Module...".Pastel(Color.Blue));
    Installer.Download("FPtje/gmcl_midi/releases/tag/v0.2.0/", "gmcl_midi", gmodBinPath);
}


Console.WriteLine("\nPress any key to exit!");
Console.ReadKey();
