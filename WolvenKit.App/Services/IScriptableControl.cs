using System;
using System.Collections.Generic;

namespace WolvenKit.Functionality.Services;

public interface IScriptableControl : IDisposable
{
    public string ScriptingName { get; set; }

    public void AddScriptedElements(List<ScriptEntry> scriptEntries);
    public void RemoveScriptedElements();
}