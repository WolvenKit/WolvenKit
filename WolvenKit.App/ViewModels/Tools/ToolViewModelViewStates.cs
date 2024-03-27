using System.Windows.Input;

namespace WolvenKit.App.ViewModels.Tools;

public abstract class ToolViewModelViewStates : ToolViewModel
{
    protected ToolViewModelViewStates(string name) : base(name) => RefreshModifierStates();

    private bool _isNoModifierPressed;

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

    private bool _isCtrlKeyOnlyPressed;

    public bool IsCtrlKeyOnlyPressed
    {
        get => _isCtrlKeyOnlyPressed;
        private set
        {
            if (_isCtrlKeyOnlyPressed == value)
            {
                return;
            }

            _isCtrlKeyOnlyPressed = value;
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
        IsCtrlKeyOnlyPressed = IsCtrlBeingHeld && !IsShiftBeingHeld && !IsAltBeingHeld;

        IsShiftKeyPressed = IsShiftBeingHeld;
        IsShiftKeyPressedOnly = IsShiftBeingHeld && !IsCtrlBeingHeld && !IsAltBeingHeld;

        IsAltKeyPressed = IsAltBeingHeld;
        IsAltKeyPressedOnly = IsAltBeingHeld && !IsCtrlBeingHeld && !IsShiftBeingHeld;

        IsCtrlShiftOnlyPressed = IsShiftBeingHeld && IsCtrlBeingHeld && !IsAltBeingHeld;
        IsCtrlAltOnlyPressed = IsShiftBeingHeld && !IsCtrlBeingHeld && IsAltBeingHeld;
        IsAltShiftOnlyPressed = IsShiftBeingHeld && IsCtrlBeingHeld && !IsAltBeingHeld;

        OnModifierStateChanged();
    }

    protected abstract void OnModifierStateChanged();
}