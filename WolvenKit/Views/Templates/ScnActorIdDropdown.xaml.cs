using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Views.Editors
{
    public partial class ScnActorIdDropdown : UserControl
    {
        private readonly DocumentTools _documentTools;
        private static ILoggerService s_loggerService;
        private static ILoggerService LoggerService => s_loggerService ??= Locator.Current.GetService<ILoggerService>();
        private bool _isUpdatingFromCode = false;

        public ScnActorIdDropdown()
        {
            _documentTools = Locator.Current.GetService<DocumentTools>();
            InitializeComponent();
            
            this.DataContextChanged += OnDataContextChanged;
            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            SetupIntegerEditor();
            PopulateDropdown();
            UpdateDropdownSelection();
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsLoaded)
            {
                SetupIntegerEditor();
                PopulateDropdown();
                UpdateDropdownSelection();
            }
        }

        private void SetupIntegerEditor()
        {
            // Update the current value display
            if (DataContext is ChunkViewModel { Data: IRedInteger integerData })
            {
                var currentValue = GetIntegerValue(integerData);
                var displayLabel = GetDisplayLabel();
                CurrentValueText.SetCurrentValue(TextBlock.TextProperty, $"Current {displayLabel}: {currentValue}");
            }
        }

        private string GetDisplayLabel()
        {
            if (DataContext is not ChunkViewModel cvm || cvm.Parent?.ResolvedData == null)
                return "ID";

            return cvm.Parent.ResolvedData switch
            {
                scnActorId => "Actor ID",
                scnPerformerId => "Performer ID",
                scnSceneWorkspotInstanceId => "Workspot ID",
                scnEffectInstanceId => "Effect ID",
                scnPropId => "Prop ID",
                scnCinematicAnimSetSRRefId => "Cinematic Anim ID",
                scnLipsyncAnimSetSRRefId => "Lipsync Anim ID",
                scnDynamicAnimSetSRRefId => "Dynamic Anim ID",
                _ => "ID"
            };
        }

        private string GetIntegerValue(IRedInteger integerData)
        {
            return integerData switch
            {
                CUInt32 cuint32 => ((uint)cuint32).ToString(),
                CInt32 cint32 => ((int)cint32).ToString(),
                CUInt16 cuint16 => ((ushort)cuint16).ToString(),
                CInt16 cint16 => ((short)cint16).ToString(),
                CUInt8 cuint8 => ((byte)cuint8).ToString(),
                CInt8 cint8 => ((sbyte)cint8).ToString(),
                _ => "0"
            };
        }

        private void PopulateDropdown()
        {
            if (DataContext is not ChunkViewModel cvm)
                return;

            try
            {
                var hasOptions = CvmDropdownHelper.HasDropdownOptions(cvm);
                
                if (hasOptions && _documentTools != null)
                {
                    var options = CvmDropdownHelper.GetDropdownOptions(cvm, _documentTools, false);
                    
                    if (options.Count > 0)
                    {
                        ActorDropdown.SetCurrentValue(ItemsControl.ItemsSourceProperty, options.ToList());
                        ActorDropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    }
                    else
                    {
                        ActorDropdown.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    }
                }
                else
                {
                    ActorDropdown.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                }
            }
            catch (System.Exception ex)
            {
                LoggerService.Error($"Error populating ScnActorIdDropdown: {ex.Message}");
                ActorDropdown.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            }
        }

        private void UpdateDropdownSelection()
        {
            if (DataContext is not ChunkViewModel { Data: IRedInteger integerData })
                return;

            _isUpdatingFromCode = true;
            
            var currentValue = GetIntegerValue(integerData);
            ActorDropdown.SetCurrentValue(System.Windows.Controls.Primitives.Selector.SelectedValueProperty, currentValue);
            _isUpdatingFromCode = false;
        }

        private void ActorDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_isUpdatingFromCode || ActorDropdown.SelectedValue is not string selectedValue)
                return;

            if (DataContext is not ChunkViewModel cvm || cvm.Data is not IRedInteger integerData)
                return;

            if (uint.TryParse(selectedValue, out var newValue))
            {
                // Update the integer value based on the type
                switch (integerData)
                {
                    case CUInt32:
                        cvm.Data = (CUInt32)newValue;
                        break;
                    case CInt32:
                        cvm.Data = (CInt32)(int)newValue;
                        break;
                    case CUInt16:
                        cvm.Data = (CUInt16)(ushort)newValue;
                        break;
                    case CInt16:
                        cvm.Data = (CInt16)(short)newValue;
                        break;
                    case CUInt8:
                        cvm.Data = (CUInt8)(byte)newValue;
                        break;
                    case CInt8:
                        cvm.Data = (CInt8)(sbyte)newValue;
                        break;
                }
                
                // Update the display
                var displayLabel = GetDisplayLabel();
                CurrentValueText.SetCurrentValue(TextBlock.TextProperty, $"Current {displayLabel}: {selectedValue}");
            }
        }
    }
}  