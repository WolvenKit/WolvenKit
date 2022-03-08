using System;
using System.Collections.ObjectModel;
using System.Reflection;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.Functionality.Services;
using System.Diagnostics.CodeAnalysis;

namespace WolvenKit.Functionality.Services
{
    //https://stackoverflow.com/a/4778347
    public static class PluginExtensions
    {
        public static string GetName(this EPlugin p)
        {
            var attr = GetAttr(p);
            return attr.Name;
        }
        private static IdAttribute GetAttr(EPlugin p)
            => (IdAttribute)Attribute.GetCustomAttribute(ForValue(p), typeof(IdAttribute));

        private static MemberInfo ForValue(EPlugin p)
            => typeof(EPlugin).GetField(Enum.GetName(typeof(EPlugin), p));

    }

    public enum EPlugin
    {
        [Id("yamashi/cyberenginetweaks")] cyberenginetweaks,
        [Id("jac3km4/redscript")] redscript,
        [Id("neurolinked/mlsetupbuilder")] mlsetupbuilder,
        [Id("yigsoft/redmod")] redmod
    }

    internal class IdAttribute : Attribute
    {
        public IdAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }

    public enum EPluginStatus
    {
        NotInstalled,
        Outdated,
        Latest
    }

    public interface IPluginService
    {
        public ObservableCollection<PluginViewModel> Plugins { get; set; }

        bool IsInstalled(EPlugin pluginName);

        bool TryGetInstallPath(EPlugin plugin, [NotNullWhen(true)] out string path);
    }
}
