using System;
using System.Collections.Generic;
using WolvenKit.App.Scripting;

namespace WolvenKit.App.Services;

public interface IScriptableControl : IDisposable
{
    public string ScriptingName { get; set; }

    public void AddScriptedElements(List<ScriptFunctionWrapper> scriptEntries);
    public void RemoveScriptedElements();
}