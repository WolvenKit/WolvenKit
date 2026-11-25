using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services.Themes;
using WolvenKit.App.ViewModels.Events;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedTypeView.xaml
    /// </summary>
    public partial class RedTypeView : ReactiveUserControl<ChunkViewModel>, IThemeAware
    {
        /// <summary>
        /// The editor styles of this view built on library styles, and the keys of those: the base is taken once
        /// (StaticResource), so after a theme switch the drop-downs and fields kept the old theme until the file
        /// was opened again.
        /// </summary>
        private static readonly (Type Target, object BaseKey)[] s_renewedStyles =
        [
            (typeof(ComboBox), "WPFComboBoxStyle"),
            (typeof(TextBox), typeof(TextBox)),
            (typeof(CheckBox), "CheckBoxBaseStyle"),
            (typeof(Syncfusion.Windows.Shared.UpDown), "SyncfusionUpDownStyle"),
        ];

        public RedTypeView()
        {
            InitializeComponent();

            Locator.Current.GetService<IThemeService>()?.Register(this);

            this.WhenActivated(disposables =>
            {
                if (DataContext is ChunkViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }
            });
        }

        public event EventHandler ValueChanged;

        // after the library re-applied its skin, so the bases found are the new theme's
        void IThemeAware.OnThemeChanged() =>
            Dispatcher.BeginInvoke(RenewEditorStyles, DispatcherPriority.ApplicationIdle);

        /// <summary>
        /// Rebuilds the editor styles on the current base styles. Replacing an implicit style in the resources
        /// restyles the editors that use it, as opening the file again would.
        /// </summary>
        private void RenewEditorStyles()
        {
            foreach (var (target, baseKey) in s_renewedStyles)
            {
                if (RootGrid.Resources[target] is not Style old ||
                    Application.Current?.TryFindResource(baseKey) is not Style fresh ||
                    ReferenceEquals(old.BasedOn, fresh))
                {
                    continue;
                }

                var renewed = new Style(target, fresh);
                foreach (var setter in old.Setters)
                {
                    if (setter is Setter s)
                    {
                        renewed.Setters.Add(new Setter(s.Property, s.Value, s.TargetName));
                    }
                }

                RootGrid.Resources[target] = renewed;
            }
        }

        private void RedCNameEditor_ValueChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is not ChunkViewModel vm || e is not ValueChangedEventArgs args)
            {
                ValueChanged?.Invoke(sender, e);
                return;
            }

            args.RedType = vm.ResolvedData.GetType();
            ValueChanged?.Invoke(sender, args);
        }
    }
}
