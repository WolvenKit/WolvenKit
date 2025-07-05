using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;

namespace WolvenKit.App.Services;

/// <summary>
/// Use as composite pattern (declare instance variable and set it to GetInstance())
/// Set up change detection as far up the component hierarchy as you can get away with, refresh child components
/// from hand. Until we can make this a proper singleton and untangle the event propagation, that's the only
/// way to avoid memory leaking from hell
/// </summary>
/// <example>
/// In implementing object's constructor:
/// <code>
/// _modifierViewStates.ModifierStateChanged += OnModifierStateChanged;
/// </code>
/// </example>
public partial class ModifierViewStateService : ObservableObject, IModifierViewStateService
{
    public ModifierViewStateService()
    {
    }
    
    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        ModifierStateChanged?.Invoke();
    }

    public event Action? ModifierStateChanged;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.None) instead.
    /// </summary>
    [ObservableProperty]    
    private bool _isNoModifierPressed = true;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Shift) instead.
    /// </summary>
    [ObservableProperty]
    private bool _isShiftKeyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Shift, true) instead.
    /// </summary>
    [ObservableProperty]
    private bool _isShiftKeyPressedOnly;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState twice, or call RefreshKeyStates first.
    /// </summary>
    [ObservableProperty]
    private bool _isCtrlShiftOnlyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState twice, or call RefreshKeyStates first.
    /// </summary>
    [ObservableProperty]
    private bool _isAltShiftOnlyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState twice, or call RefreshKeyStates first.
    /// </summary>
    [ObservableProperty]
    private bool _isCtrlAltOnlyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Alt) instead.
    /// </summary>
    [ObservableProperty]
    private bool _isAltKeyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Alt, true) instead.
    /// </summary>
    [ObservableProperty]
    private bool _isAltKeyPressedOnly;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Ctrl) instead.
    /// </summary>
    [ObservableProperty]
    private bool _isCtrlKeyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Ctrl, true) instead.
    /// </summary>
    [ObservableProperty]
    private bool _isCtrlKeyPressedOnly;

    public static bool IsShiftBeingHeld => Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
    public static bool IsCtrlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);
    public static bool IsAltBeingHeld => Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt);
    public static bool IsNoModifierBeingHeld => !IsShiftBeingHeld && !IsCtrlBeingHeld && !IsAltBeingHeld;
    public static bool IsShiftBeingHeldOnly => IsShiftBeingHeld && !IsCtrlBeingHeld && !IsAltBeingHeld;
    public static bool IsCtrlBeingHeldOnly => !IsShiftBeingHeld && IsCtrlBeingHeld && !IsAltBeingHeld;
    public static bool IsAltBeingHeldOnly => !IsShiftBeingHeld && !IsCtrlBeingHeld && IsAltBeingHeld;

    private readonly Dictionary<Key, bool> _keyStates = [];

    public void OnKeystateChanged(KeyEventArgs? e)
    {
        if (e is null || !IModifierViewStateService.ModifierKeys.Contains(e.Key))
        {
            return;
        }

        // If the key state hasn't changed, ignore the event
        if (_keyStates.TryGetValue(e.Key, out var value) && value == e.IsDown)
        {
            return;
        }

        RefreshModifierStates();
    }

    public void RefreshModifierStates(bool skipUpdate = false)
    {
        IsNoModifierPressed = !IsShiftBeingHeld && !IsCtrlBeingHeld && !IsAltBeingHeld;

        IsCtrlKeyPressed = IsCtrlBeingHeld;
        IsShiftKeyPressed = IsShiftBeingHeld;
        IsAltKeyPressed = IsAltBeingHeld;

        IsCtrlKeyPressedOnly = IsCtrlBeingHeld && !IsShiftBeingHeld && !IsAltBeingHeld;
        _keyStates[Key.LeftCtrl] = IsCtrlBeingHeld;
        _keyStates[Key.RightCtrl] = IsCtrlBeingHeld;

        IsShiftKeyPressedOnly = IsShiftBeingHeld && !IsCtrlBeingHeld && !IsAltBeingHeld;
        _keyStates[Key.LeftShift] = IsShiftBeingHeld;
        _keyStates[Key.RightShift] = IsShiftBeingHeld;

        IsAltKeyPressedOnly = IsAltBeingHeld && !IsCtrlBeingHeld && !IsShiftBeingHeld;
        _keyStates[Key.LeftAlt] = IsAltBeingHeld;
        _keyStates[Key.RightAlt] = IsAltBeingHeld;

        IsCtrlShiftOnlyPressed = IsShiftBeingHeld && IsCtrlBeingHeld && !IsAltBeingHeld;
        IsCtrlAltOnlyPressed = IsShiftBeingHeld && !IsCtrlBeingHeld && IsAltBeingHeld;
        IsAltShiftOnlyPressed = IsShiftBeingHeld && IsCtrlBeingHeld && !IsAltBeingHeld;

        if (skipUpdate)
        {
            return;
        }

        ModifierStateChanged?.Invoke();
    }

    /// <summary>
    /// In model, bind to this rather than the observable properties, as it'll refresh the internal states
    /// </summary>
    public bool GetModifierState(ModifierKeys key, bool noOtherModifiersPressed = false)
    {
        RefreshModifierStates(true);
        return key switch
        {
            ModifierKeys.Alt => noOtherModifiersPressed ? IsAltKeyPressed : IsAltKeyPressedOnly,
            ModifierKeys.Shift => noOtherModifiersPressed ? IsShiftKeyPressed : IsShiftKeyPressedOnly,
            ModifierKeys.Control => noOtherModifiersPressed ? IsCtrlKeyPressed : IsCtrlKeyPressedOnly,
            ModifierKeys.None => IsNoModifierPressed,
            ModifierKeys.Windows => false,
            _ => false
        };
    }

    
}
