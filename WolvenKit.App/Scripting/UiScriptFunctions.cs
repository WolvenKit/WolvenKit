using Microsoft.ClearScript;
using WolvenKit.App.Services;

namespace WolvenKit.App.Scripting;

public class UiScriptFunctions
{
    private readonly AppScriptService _appScriptService;

    public UiScriptFunctions(AppScriptService appScriptService) => _appScriptService = appScriptService;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public ScriptFunctionWrapper AddMenuItem(string target, string name) => AddMenuItem(target, name, null, null);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="name"></param>
    /// <param name="onClick"></param>
    /// <returns></returns>
    public ScriptFunctionWrapper AddMenuItem(string target, string name, ScriptObject onClick) => AddMenuItem(target, name, onClick, null);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="name"></param>
    /// <param name="onClick"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public ScriptFunctionWrapper AddMenuItem(string target, string name, ScriptObject? onClick, params object?[]? args)
    {
        var scriptEntry = new ScriptFunctionWrapper(name, onClick, args);

        _appScriptService.AddScriptEntry(target, scriptEntry);

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
    public ScriptFunctionWrapper AddMenuItem(ScriptFunctionWrapper target, string name, ScriptObject? onClick = null, params object?[]? args)
    {
        var scriptEntry = new ScriptFunctionWrapper(name, onClick, args);
        target.Children.Add(scriptEntry);
        return scriptEntry;
    }
}