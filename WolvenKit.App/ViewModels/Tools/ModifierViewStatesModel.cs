using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Tools;

/// <summary>
/// Use as composite pattern (declare instance variable and set it to GetInstance())
/// </summary>
/// <example>
/// In your implementing object's constructor, hook the following events:
/// <code>
/// _modifierViewStatesModel.ModifierStateChanged += OnModifierStateChanged;
/// _modifierViewStatesModel.PropertyChanged += ModifierViewStatesModel_OnPropertyChanged;
/// </code>
/// <br/>
/// Declare internal method OnModifierStateChanged to react to view state modifier changes (custom view vars etc.)
/// <br/>
/// Declare internal method ModifierViewStatesModel_OnPropertyChanged to forward the change event:
/// <code>
/// private void ModifierViewStatesModel_PropertyChangedRaised(object? sender, PropertyChangedEventArgs e) {
///   OnPropertyChanged(e.PropertyName);
/// } 
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
        }
    }

    private bool _isShiftKeyPressed;

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
        }
    }

    private bool _isShiftKeyPressedOnly;

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
        }
    }

    private bool _isSCtrlShiftOnlyPressed;

    // ReSharper disable once MemberCanBeProtected.Global
    public bool IsCtrlShiftOnlyPressed
    {
        get => _isSCtrlShiftOnlyPressed;
        private set
        {
            if (_isSCtrlShiftOnlyPressed == value)
            {
                return;
            }

            _isSCtrlShiftOnlyPressed = value;
            OnPropertyChanged();
        }
    }

    private bool _isSAltShiftOnlyPressed;

    public bool IsAltShiftOnlyPressed
    {
        get => _isSAltShiftOnlyPressed;
        private set
        {
            if (_isSAltShiftOnlyPressed == value)
            {
                return;
            }

            _isSAltShiftOnlyPressed = value;
            OnPropertyChanged();
        }
    }


    private bool _isSCtrlAltOnlyPressed;

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
            OnPropertyChanged();
        }
    }

    private bool _isAltKeyPressed;

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
        }
    }

    private bool _isAltKeyPressedOnly;

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
        }
    }

    private bool _isCtrlKeyPressed;

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
        }
    }

    private bool _isCtrlKeyPressedOnly;

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
        }
    }

    private static bool IsShiftBeingHeld => Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
    private static bool IsCtrlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);
    private static bool IsAltBeingHeld => Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt);

    public void RefreshModifierStates()
    {
        IsNoModifierPressed = !IsShiftBeingHeld && !IsCtrlBeingHeld && !IsAltBeingHeld;

        IsCtrlKeyPressed = IsCtrlBeingHeld;
        IsCtrlKeyPressedOnly = IsCtrlBeingHeld && !IsShiftBeingHeld && !IsAltBeingHeld;

        IsShiftKeyPressed = IsShiftBeingHeld;
        IsShiftKeyPressedOnly = IsShiftBeingHeld && !IsCtrlBeingHeld && !IsAltBeingHeld;

        IsAltKeyPressed = IsAltBeingHeld;
        IsAltKeyPressedOnly = IsAltBeingHeld && !IsCtrlBeingHeld && !IsShiftBeingHeld;

        IsCtrlShiftOnlyPressed = IsShiftBeingHeld && IsCtrlBeingHeld && !IsAltBeingHeld;
        IsCtrlAltOnlyPressed = IsShiftBeingHeld && !IsCtrlBeingHeld && IsAltBeingHeld;
        IsAltShiftOnlyPressed = IsShiftBeingHeld && IsCtrlBeingHeld && !IsAltBeingHeld;

        OnModifierStateChanged();
    }

    public event Action? ModifierStateChanged;
    private void OnModifierStateChanged() => ModifierStateChanged?.Invoke();
}