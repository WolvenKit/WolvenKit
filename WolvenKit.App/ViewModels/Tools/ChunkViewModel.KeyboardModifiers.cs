using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel : ObservableObject
{
    public void OnKeystateChanged(KeyEventArgs? _) => _modifierViewStatesModel.RefreshModifierStates();

    private void OnModifierStateChanged()
    {
        ShouldShowPasteIntoArray = ShouldShowArrayOps && !IsShiftKeyPressed;
        ShouldShowOverwriteArray = ShouldShowArrayOps && IsShiftKeyPressedOnly;
        ShouldShowDuplicateAsNew =
            IsInArray && !IsShiftKeyPressed && ResolvedData is worldCompiledEffectPlacementInfo or CMeshMaterialEntry;
        ShouldShowDuplicate = IsInArray && !ShouldShowDuplicateAsNew;
    }


    // If shift is not being held and we're a CMeshMaterialEntry or a WorldCompiledEffectPlacementInfo, 
    // show "Duplicate as new item" instead of "Duplicate Selection" 
    private bool _shouldShowDuplicateAsNew;

    // ReSharper disable once MemberCanBePrivate.Global - used in xaml
    public bool ShouldShowDuplicateAsNew
    {
        get => _shouldShowDuplicateAsNew;
        private set
        {
            if (_shouldShowDuplicateAsNew == value)
            {
                return;
            }

            _shouldShowDuplicateAsNew = value;
            OnPropertyChanged();
        }
    }

    // If shift is not being held and we're a CMeshMaterialEntry or a WorldCompiledEffectPlacementInfo, 
    // show "Duplicate as new item" instead of "Duplicate Selection" 
    private bool _shouldShowDuplicate;

    public bool ShouldShowDuplicate
    {
        get => _shouldShowDuplicate;
        private set
        {
            if (_shouldShowDuplicate == value)
            {
                return;
            }

            _shouldShowDuplicate = value;
            OnPropertyChanged();
        }
    }

    // When shift is not held, paste into array => PasteChunk.
    private bool _shouldShowPasteIntoArray;

    public bool ShouldShowPasteIntoArray
    {
        get => _shouldShowPasteIntoArray;
        private set
        {
            if (_shouldShowPasteIntoArray == value)
            {
                return;
            }

            _shouldShowPasteIntoArray = value;
            OnPropertyChanged();
        }
    }

// When shift is being held, overwrite array with selection => ClearAndPasteChunk
    private bool _shouldShowOverwriteArray;

    public bool ShouldShowOverwriteArray
    {
        get => _shouldShowOverwriteArray;
        private set
        {
            if (_shouldShowOverwriteArray == value)
            {
                return;
            }

            _shouldShowOverwriteArray = value;
            OnPropertyChanged();
        }
    }

    private void ModifierViewStatesModel_OnPropertyChanged(object? sender, PropertyChangedEventArgs e) =>
        OnPropertyChanged(e.PropertyName);

    #region ModifierStateAwareness

// ####################################################################################
// Integrate with _modifierViewStatesModel to expose keys to view 
// ####################################################################################

    public bool IsNoModifierPressed => _modifierViewStatesModel.IsNoModifierPressed;
    private bool IsShiftKeyPressed => _modifierViewStatesModel.IsShiftKeyPressed;
    private bool IsCtrlKeyPressed => _modifierViewStatesModel.IsCtrlKeyPressed;
    private bool IsShiftKeyPressedOnly => _modifierViewStatesModel.IsShiftKeyPressedOnly;
    public bool IsCtrlKeyPressedOnly => _modifierViewStatesModel.IsCtrlKeyPressedOnly;

    public void RefreshModifierStates() => _modifierViewStatesModel.RefreshModifierStates();

    #endregion
}