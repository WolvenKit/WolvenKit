using System;
using System.Windows.Forms;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Gma.System.MouseKeyHook;
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
    private readonly IKeyboardMouseEvents _globalHook;

    public ModifierViewStateService()
    {
        _globalHook = Hook.GlobalEvents();
        _globalHook.KeyDown += OnGlobalKeyDown;
        _globalHook.KeyUp += OnGlobalKeyUp;
    }

    private void OnGlobalKeyUp(object? sender, System.Windows.Forms.KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.LShiftKey or Keys.RShiftKey or Keys.Shift or Keys.ShiftKey:
                if (!IsShiftKeyPressed)
                {
                    return;
                }

                IsShiftKeyPressed = false;
                break;
            case Keys.LControlKey or Keys.RControlKey or Keys.ControlKey or Keys.Control:
                if (!IsCtrlKeyPressed)
                {
                    return;
                }

                IsCtrlKeyPressed = false;
                break;
            case Keys.Alt:
                if (!IsAltKeyPressed)
                {
                    return;
                }

                IsAltKeyPressed = false;
                break;
            default:
                return;
        }

        IsShiftKeyPressedOnly = IsShiftKeyPressed && !IsCtrlKeyPressed && !IsAltKeyPressed;
        IsAltKeyPressedOnly = IsAltKeyPressed && !IsCtrlKeyPressed && !IsShiftKeyPressed;
        IsCtrlShiftOnlyPressed = IsShiftKeyPressed && IsCtrlKeyPressed && !IsAltKeyPressed;
        IsCtrlAltOnlyPressed = IsShiftKeyPressed && !IsCtrlKeyPressed && IsAltKeyPressed;
        IsAltShiftOnlyPressed = IsShiftKeyPressed && IsCtrlKeyPressed && !IsAltKeyPressed;

        ModifierStateChanged?.Invoke(this, e);
    }

    private void OnGlobalKeyDown(object? sender, System.Windows.Forms.KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.LShiftKey or Keys.RShiftKey or Keys.Shift or Keys.ShiftKey:
                if (IsShiftKeyPressed)
                {
                    return;
                }

                IsShiftKeyPressed = true;
                break;
            case Keys.LControlKey or Keys.RControlKey or Keys.ControlKey or Keys.Control:
                if (IsCtrlKeyPressed)
                {
                    return;
                }

                IsCtrlKeyPressed = true;
                break;
            case Keys.Alt:
                if (IsAltKeyPressed)
                {
                    return;
                }

                IsAltKeyPressed = true;
                break;
            default:
                return;
        }

        IsShiftKeyPressedOnly = IsShiftKeyPressed && !IsCtrlKeyPressed && !IsAltKeyPressed;
        IsAltKeyPressedOnly = IsAltKeyPressed && !IsCtrlKeyPressed && !IsShiftKeyPressed;
        IsCtrlShiftOnlyPressed = IsShiftKeyPressed && IsCtrlKeyPressed && !IsAltKeyPressed;
        IsCtrlAltOnlyPressed = IsShiftKeyPressed && !IsCtrlKeyPressed && IsAltKeyPressed;
        IsAltShiftOnlyPressed = IsShiftKeyPressed && IsCtrlKeyPressed && !IsAltKeyPressed;

        ModifierStateChanged?.Invoke(this, e);
    }


    public event EventHandler<System.Windows.Forms.KeyEventArgs>? ModifierStateChanged; 

    /// <summary>
    /// Use for view state binding as observable.  To query as-Is from Model, use <see cref="IsNoModifierBeingHeld"/> 
    /// </summary>
    [ObservableProperty]    
    private bool _isNoModifierPressed = true;

    /// <summary>
    /// Use for view state binding as observable. To query as-Is from Model, use <see cref="IsShiftBeingHeld"/> 
    /// </summary>
    [ObservableProperty]
    private bool _isShiftKeyPressed;

    /// <summary>
    /// Use for view state binding as observable. To query as-Is from Model, use <see cref="IsShiftBeingHeld"/> 
    /// </summary>
    [ObservableProperty]
    private bool _isShiftKeyPressedOnly;

    /// <summary>
    /// Use for view state binding as observable. To query as-Is from Model, use <see cref="IsShiftBeingHeld"/> and <see cref="IsCtrlBeingHeld"/>
    /// </summary>
    [ObservableProperty]
    private bool _isCtrlShiftOnlyPressed;

    /// <summary>
    /// Use for view state binding as observable. To query as-Is from Model, use <see cref="IsShiftBeingHeld"/> and <see cref="IsAltBeingHeld"/>
    /// </summary>
    [ObservableProperty]
    private bool _isAltShiftOnlyPressed;

    /// <summary>
    /// Use for view state binding as observable. To query as-Is from Model, use <see cref="IsAltBeingHeld"/> and <see cref="IsCtrlBeingHeld"/>
    /// </summary>
    [ObservableProperty]
    private bool _isCtrlAltOnlyPressed;

    /// <summary>
    /// Use for view state binding as observable. To query as-Is from Model, use <see cref="IsAltBeingHeld"/>
    /// </summary>
    [ObservableProperty]
    private bool _isAltKeyPressed;

    /// <summary>
    /// Use for view state binding as observable. To query as-Is from Model, use <see cref="IsAltBeingHeld"/>
    /// </summary>
    [ObservableProperty]
    private bool _isAltKeyPressedOnly;

    /// <summary>
    /// Use for view state binding as observable. To query as-Is from Model, use <see cref="IsCtrlBeingHeld"/>
    /// </summary>
    [ObservableProperty]
    private bool _isCtrlKeyPressed;

    /// <summary>
    /// Use for view state binding as observable. To query as-Is from Model, use <see cref="IsCtrlBeingHeld"/>
    /// </summary>
    [ObservableProperty]
    private bool _isCtrlKeyPressedOnly;

    private static bool IsShiftBeingHeld => Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
    private static bool IsCtrlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);
    private static bool IsAltBeingHeld => Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt);
    public static bool IsNoModifierBeingHeld => !IsShiftBeingHeld && !IsCtrlBeingHeld && !IsAltBeingHeld;
   
}
