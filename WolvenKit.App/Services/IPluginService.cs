using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using WolvenKit.ViewModels.HomePage;
using System.Threading.Tasks;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Functionality.Services
{
    //https://stackoverflow.com/a/4778347
    public static class PluginExtensions
    {
        public static string GetDisplayName(this EPlugin p) => GetAttr(p).Name;
        public static string GetDescription(this EPlugin p) => GetAttr(p).Description;
        public static string GetFile(this EPlugin p) => GetAttr(p).File;
        public static string GetUrl(this EPlugin p) => GetAttr(p).Url;

        private static IdAttribute GetAttr(EPlugin p)
            => (IdAttribute)Attribute.GetCustomAttribute(ForValue(p), typeof(IdAttribute));

        private static MemberInfo ForValue(EPlugin p)
            => typeof(EPlugin).GetField(Enum.GetName(typeof(EPlugin), p));

    }

    public enum EPlugin
    {
        [Id("CyberEngineTweaks", "yamashi/cyberenginetweaks", @"cet.*\.zip", "Cyberpunk 2077 tweaks, hacks and scripting framework.")]
        cyberenginetweaks,
        [Id("Redscript", "jac3km4/redscript", @"redscript-mod.*\.zip", "Compiler/decompiler toolkit for redscript.")]
        redscript,
        [Id("MlsetupBuilder", "neurolinked/mlsetupbuilder", @"MlsetupBuilder-.*\.zip", "Cyberpunk 2077 modding tool to build json version of .mlsetup files.")]
        mlsetupbuilder,
        [Id("Wolvenkit Resources", "WolvenKit/Wolvenkit-Resources", @"resources.zip", "Resource depot for Wolvenkit.")]
        wolvenkit_resources,
        [Id("RedMod", "yigsoft/redmod", @"redmod.zip", "RedMod tools.")]
        redmod
    }

    [AttributeUsage(AttributeTargets.Field)]
    internal class IdAttribute : Attribute
    {
        public IdAttribute(string name, string url, string file, string description = "")
        {
            Name = name;
            Url = url;
            File = file;
            Description = description;
        }

        public string Name { get; }
        public string Url { get; }
        public string File { get; }
        public string Description { get; }
    }

    public enum EPluginStatus
    {
        Installed,
        NotInstalled,
        Outdated,
        Latest
    }

    /// <summary>
    /// A service that manages Wolvenkit Plugins like mlsetupbuilder, cet or redscript
    /// </summary>
    public interface IPluginService
    {
        /// <summary>
        /// Initializes the service and populates the plugins list
        /// </summary>
        void Init();

        public ObservableCollection<PluginViewModel> Plugins { get; set; }

        /// <summary>
        /// Checks all Plugins for an update
        /// </summary>
        /// <returns></returns>
        Task CheckForUpdatesAsync();

        /// <summary>
        /// Install a plugin, downloads from github and extracts the zip to the install path
        /// </summary>
        /// <param name="pluginModel"></param>
        /// <returns></returns>
        Task InstallPluginAsync(EPlugin id);

        /// <summary>
        ///  Checks if a plugin is installed
        /// </summary>
        /// <param name="pluginName"></param>
        /// <returns></returns>
        bool IsInstalled(EPlugin pluginName);

        /// <summary>
        /// Removes a plugin, deletes all installed files and updates the plugin status
        /// </summary>
        /// <param name="pluginModel"></param>
        /// <returns></returns>
        Task RemovePluginAsync(EPlugin id);

        /// <summary>
        /// try to get the install path for a plugin
        /// </summary>
        /// <param name="plugin"></param>
        /// <param name="path"></param>
        /// <returns>false if not installed</returns>

        bool TryGetInstallPath(EPlugin plugin, [NotNullWhen(true)] out string path);
    }
}
