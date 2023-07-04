using Microsoft.ClearScript;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WolvenKit.App.Scripting;

public class ScriptFunctionWrapper
{
    private readonly ScriptObject? _function;
    private readonly object?[]? _args;

    public string Name { get; }
    public List<ScriptFunctionWrapper> Children { get; set; } = new();

    public bool HasFunction => _function != null;

    public ScriptFunctionWrapper(string name, ScriptObject? function, params object?[]? args)
    {
        Name = name;

        _function = function;
        _args = args;
    }

    public async void Execute() => await Task.Run(() => _function?.Invoke(false, _args));
}