using System;
using System.Collections.Generic;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.Tools;

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
public class ModifierViewStatesModel : ObservableObject
{
    private static ModifierViewStatesModel? s_instance;
    
    public static ModifierViewStatesModel GetInstance()
    {
        s_instance ??= new ModifierViewStatesModel();
        return s_instance;
    }

    private bool _isNoModifierPressed = true;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.None) instead.
    /// </summary>
    public bool IsNoModifierPressed
    {
        get => _isNoModifierPressed;
        private set
        {
            if (_isNoModifierPressed == value)
            {
                return;
            }

            _isNoModifierPressed = value;
            OnPropertyChanged();
            ModifierStateChanged?.Invoke();
           
        }
    }

    private bool _isShiftKeyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Shift) instead.
    /// </summary>
    public bool IsShiftKeyPressed
    {
        get => _isShiftKeyPressed;
        private set
        {
            if (_isShiftKeyPressed == value)
            {
                return;
            }

            _isShiftKeyPressed = value;
            OnPropertyChanged();
            ModifierStateChanged?.Invoke();
        }
    }

    private bool _isShiftKeyPressedOnly;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Shift, true) instead.
    /// </summary>
    public bool IsShiftKeyPressedOnly
    {
        get => _isShiftKeyPressedOnly;
        private set
        {
            if (_isShiftKeyPressedOnly == value)
            {
                return;
            }

            _isShiftKeyPressedOnly = value;
            OnPropertyChanged();
            ModifierStateChanged?.Invoke();
        }
    }

    private bool _isCtrlShiftOnlyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState twice, or call RefreshKeyStates first.
    /// </summary>
    // ReSharper disable once MemberCanBeProtected.Global
    public bool IsCtrlShiftOnlyPressed
    {
        get => _isCtrlShiftOnlyPressed;
        private set
        {
            if (_isCtrlShiftOnlyPressed == value)
            {
                return;
            }

            _isCtrlShiftOnlyPressed = value;
            OnPropertyChanged();
            ModifierStateChanged?.Invoke();
        }
    }

    private bool _isAltShiftOnlyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState twice, or call RefreshKeyStates first.
    /// </summary>
    public bool IsAltShiftOnlyPressed
    {
        get => _isAltShiftOnlyPressed;
        private set
        {
            if (_isAltShiftOnlyPressed == value)
            {
                return;
            }

            _isAltShiftOnlyPressed = value;
            OnPropertyChanged();
            ModifierStateChanged?.Invoke();
        }
    }


    private bool _isSCtrlAltOnlyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState twice, or call RefreshKeyStates first.
    /// </summary>
    public bool IsCtrlAltOnlyPressed
    {
        get => _isSCtrlAltOnlyPressed;
        private set
        {
            if (_isSCtrlAltOnlyPressed == value)
            {
                return;
            }

            _isSCtrlAltOnlyPressed = value;
            OnPropertyChanged();
            ModifierStateChanged?.Invoke();
        }
    }

    private bool _isAltKeyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Alt) instead.
    /// </summary>
    // ReSharper disable once MemberCanBePrivate.Global
    public bool IsAltKeyPressed
    {
        get => _isAltKeyPressed;
        private set
        {
            if (_isAltKeyPressed == value)
            {
                return;
            }

            _isAltKeyPressed = value;
            OnPropertyChanged();
            ModifierStateChanged?.Invoke();
        }
    }

    private bool _isAltKeyPressedOnly;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Alt, true) instead.
    /// </summary>
    // ReSharper disable once MemberCanBePrivate.Global
    public bool IsAltKeyPressedOnly
    {
        get => _isAltKeyPressedOnly;
        private set
        {
            if (_isAltKeyPressedOnly == value)
            {
                return;
            }

            _isAltKeyPressedOnly = value;
            OnPropertyChanged();
            ModifierStateChanged?.Invoke();
        }
    }

    private bool _isCtrlKeyPressed;

    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Ctrl) instead.
    /// </summary>
    public bool IsCtrlKeyPressed
    {
        get => _isCtrlKeyPressed;
        private set
        {
            if (_isCtrlKeyPressed == value)
            {
                return;
            }

            _isCtrlKeyPressed = value;
            OnPropertyChanged();
            ModifierStateChanged?.Invoke();
        }
    }

    private bool _isCtrlKeyPressedOnly;


    /// <summary>
    /// Use for view state binding as observable. From the model, please use GetKeyState(Modifiers.Ctrl, true) instead.
    /// </summary>
    public bool IsCtrlKeyPressedOnly
    {
        get => _isCtrlKeyPressedOnly;
        private set
        {
            if (_isCtrlKeyPressedOnly == value)
            {
                return;
            }

            _isCtrlKeyPressedOnly = value;
            OnPropertyChanged();
            ModifierStateChanged?.Invoke();
        }
    }

    private static bool IsShiftBeingHeld => Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
    private static bool IsCtrlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);
    private static bool IsAltBeingHeld => Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt);

    private readonly Dictionary<Key, bool> _keyStates = [];

    public void OnKeystateChanged(KeyEventArgs? e)
    {
        if (e?.Key is not (Key.RightCtrl or Key.LeftCtrl or Key.LeftShift or Key.RightShift or Key.LeftAlt
            or Key.RightAlt))
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
        IsCtrlKeyPressedOnly = IsCtrlBeingHeld && !IsShiftBeingHeld && !IsAltBeingHeld;
        _keyStates[Key.LeftCtrl] = IsCtrlBeingHeld;
        _keyStates[Key.RightCtrl] = IsCtrlBeingHeld;
        
        IsShiftKeyPressed = IsShiftBeingHeld;
        IsShiftKeyPressedOnly = IsShiftBeingHeld && !IsCtrlBeingHeld && !IsAltBeingHeld;
        _keyStates[Key.LeftShift] = IsShiftBeingHeld;
        _keyStates[Key.RightShift] = IsShiftBeingHeld;

        IsAltKeyPressed = IsAltBeingHeld;
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

    public event Action? ModifierStateChanged;

    // ReSharper disable once UnusedMember.Local - Needed for ModifierStateChanged to work
#pragma warning disable IDE0051
    private void OnModifierStateChanged()
    {
        _loggerService?.Debug("OnModifierStateChanged");
        ModifierStateChanged?.Invoke();
    }
#pragma warning restore IDE0051

    private ILoggerService? _loggerService;

    public void SetLogger(ILoggerService loggerService)
    {
        if (_loggerService is not null)
        {
            return;
        }

        _loggerService = loggerService;
    }
}
