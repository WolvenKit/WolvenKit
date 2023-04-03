using Microsoft.ClearScript;
using System.Collections.Generic;

namespace WolvenKit.App.Services;

public partial class ExtendedScriptService
{
    public class WScriptUIHelper
    {
        private readonly ExtendedScriptService _extendedScriptService;

        public WScriptUIHelper(ExtendedScriptService extendedScriptService) => _extendedScriptService = extendedScriptService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public ScriptEntry AddMenuItem(string target, string name) => AddMenuItem(target, name, null, null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="onClick"></param>
        /// <returns></returns>
        public ScriptEntry AddMenuItem(string target, string name, ScriptObject onClick) => AddMenuItem(target, name, onClick, null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="onClick"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public ScriptEntry AddMenuItem(string target, string name, ScriptObject? onClick, params object?[]? args)
        {
            var scriptEntry = new ScriptEntry(name, onClick, args);
        
            if (!_extendedScriptService._uiScripts.ContainsKey(target))
            {
                _extendedScriptService._uiScripts.Add(target, new List<ScriptEntry>());
            }
            _extendedScriptService._uiScripts[target].Add(scriptEntry);

            return scriptEntry;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="onClick"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public ScriptEntry AddMenuItem(ScriptEntry target, string name, ScriptObject? onClick = null, params object?[]? args)
        {
            var scriptEntry = new ScriptEntry(name, onClick, args);
            target.Children.Add(scriptEntry);
            return scriptEntry;
        }
    }
}