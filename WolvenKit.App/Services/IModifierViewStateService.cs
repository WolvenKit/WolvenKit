using System;
using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Core.Interfaces;
using ObservableObject = HelixToolkit.SharpDX.Core.Model.ObservableObject;

namespace WolvenKit.Core.Services;

public interface IModifierViewStateService
{
    public abstract void RefreshModifierStates(bool skipUpdate = false);
    public abstract bool GetModifierState(ModifierKeys key, bool noOtherModifiersPressed = false);
    public abstract void SetLogger(ILoggerService loggerService);
    public abstract bool IsShiftKeyPressed { get; }
    public abstract bool IsShiftKeyPressedOnly { get; }

    public abstract bool IsCtrlKeyPressed { get; }
    public abstract bool IsCtrlKeyPressedOnly { get; }

    public abstract bool IsAltKeyPressed { get; }
    public abstract bool IsAltKeyPressedOnly { get; }

    public abstract bool IsNoModifierPressed { get; }
    public abstract bool IsCtrlShiftOnlyPressed { get; }
    public abstract bool IsCtrlAltOnlyPressed { get; }
    public abstract bool IsAltShiftOnlyPressed { get; }

    public abstract event Action? ModifierStateChanged;

    public event PropertyChangedEventHandler? PropertyChanged;
}