using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Core.Services;
using System.Diagnostics;
using System.Runtime.InteropServices;

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
    private static IntPtr s_hookId = IntPtr.Zero;

    public ModifierViewStateService()
    {
        s_hookId = SetHook(HookCallback);
        Instance = this;
    }

    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

    private static IntPtr SetHook(LowLevelKeyboardProc proc)
    {
        using var curProcess = Process.GetCurrentProcess();
        using var curModule = curProcess.MainModule;
        return SetWindowsHookEx(s_whKeyboardLl, proc, GetModuleHandle(curModule!.ModuleName), 0);
    }

    private const int s_whKeyboardLl = 13;
    private const int s_wmKeydown = 0x0100;
    private const int s_wmKeyup = 0x0101;

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode < 0 || IsSuspended)
        {
            return CallNextHookEx(s_hookId, nCode, wParam, lParam);
        }

        var vkCode = Marshal.ReadInt32(lParam);
        var key = KeyInterop.KeyFromVirtualKey(vkCode);

        switch (wParam)
        {
            case s_wmKeydown:
                OnKeyDownStatic(key);
                break;
            case s_wmKeyup:
                OnKeyUpStatic(key);
                break;
        }

        return CallNextHookEx(s_hookId, nCode, wParam, lParam);
    }

    private static bool IsSuspended;
    
    private static void OnKeyDownStatic(Key key) => Instance?.OnKeyDown(null, key);

    private static void OnKeyUpStatic(Key key) => Instance?.OnKeyUp(null, key);

    public static ModifierViewStateService? Instance { get; private set; }

    ~ModifierViewStateService()
    {
        UnhookWindowsHookEx(s_hookId);
    }

    public void OnKeyUp(object? _, Key key)
    {
        switch (key)
        {
            case Key.LeftShift or Key.RightShift:
                if (!IsShiftKeyPressed)
                {
                    return;
                }

                IsShiftKeyPressed = false;
                break;
            case Key.LeftCtrl or Key.RightCtrl:
                if (!IsCtrlKeyPressed)
                {
                    return;
                }

                IsCtrlKeyPressed = false;
                break;
            case Key.LeftAlt or Key.RightAlt:
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

        ModifierStateChanged?.Invoke(this, key);
    }

    public void OnKeyDown(object? _, Key key)
    {
        switch (key)
        {
            case Key.LeftShift or Key.RightShift:
                if (IsShiftKeyPressed)
                {
                    return;
                }

                IsShiftKeyPressed = true;
                break;
            case Key.LeftCtrl or Key.RightCtrl:
                if (IsCtrlKeyPressed)
                {
                    return;
                }

                IsCtrlKeyPressed = true;
                break;
            case Key.LeftAlt or Key.RightAlt:
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

        ModifierStateChanged?.Invoke(this, key);
    }

    public void Suspend() => IsSuspended = true;

    public void Resume() =>  IsSuspended = false;


    public event EventHandler<Key>? ModifierStateChanged; 

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

    public static bool IsShiftBeingHeld => Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
    public static bool IsCtrlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);
    public static bool IsAltBeingHeld => Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt);
    public static bool IsNoModifierBeingHeld => !IsShiftBeingHeld && !IsCtrlBeingHeld && !IsAltBeingHeld;
   
}
