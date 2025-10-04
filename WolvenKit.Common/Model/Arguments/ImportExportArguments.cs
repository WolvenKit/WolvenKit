using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.Common.Model.Arguments
{
    /// <summary>
    /// Tags a property as accessible in a WolvenKit Script
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class WkitScriptAccess : Attribute
    {
        public string ScriptName { get; }

        // by default the script name is the name of the property or class
        public WkitScriptAccess([CallerMemberName] string scriptName = "") => ScriptName = scriptName;
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class UsedWith : Attribute
    {
        public string PropertyName { get; }
        public object?[] Values { get; }

        public UsedWith(string propertyName, params object?[] values)
        {
            PropertyName = propertyName;
            Values = values;
        }
    }

    /// <summary>
    /// Import Export Arguments
    /// </summary>
    public abstract class ImportExportArgs : ObservableObject
    {
        [Browsable(false)] public static bool IsCLI { get; set; } = false;
    }
}
