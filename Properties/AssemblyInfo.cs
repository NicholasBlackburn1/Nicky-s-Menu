using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(NickysMenu.BuildInfo.Description)]
[assembly: AssemblyDescription(NickysMenu.BuildInfo.Description)]
[assembly: AssemblyCompany(NickysMenu.BuildInfo.Company)]
[assembly: AssemblyProduct(NickysMenu.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + NickysMenu.BuildInfo.Author)]
[assembly: AssemblyTrademark(NickysMenu.BuildInfo.Company)]
[assembly: AssemblyVersion(NickysMenu.BuildInfo.Version)]
[assembly: AssemblyFileVersion(NickysMenu.BuildInfo.Version)]
[assembly: MelonInfo(typeof(NickysMenu.NickysMenu), NickysMenu.BuildInfo.Name, NickysMenu.BuildInfo.Version, NickysMenu.BuildInfo.Author, NickysMenu.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]