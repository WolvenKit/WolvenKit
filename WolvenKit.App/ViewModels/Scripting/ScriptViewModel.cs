using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WolvenKit.Modkit.Scripting;

namespace WolvenKit.App.ViewModels.Scripting;

public abstract class ScriptViewModel : INotifyPropertyChanged
{
    protected bool _enabled;

    public string Name { get; protected set; }
    public string Path { get; }
    public ScriptType Type { get; }
    public ScriptSource Source { get; }

    public bool Enabled
    {
        get => _enabled;
        set => SetField(ref _enabled, value);
    }

    public bool CanEnable => Type != ScriptType.General;
    public abstract bool CanExecute { get; }
    public abstract bool CanDelete { get; }

    public ScriptViewModel(string name, string path, ScriptType type, ScriptSource source)
    {
        Name = name;
        Path = path;
        Type = type;
        Source = source;
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}