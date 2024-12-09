using System.ComponentModel;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Editors;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class ChangeComponentChunkMaskDialog : IViewFor<ChangeComponentChunkMaskDialogViewModel>
    {
        private static string s_lastComponentName = "";
        private static IRedPrimitive<ulong> s_lastChunkMask;
        private static string s_lastDepotPath = "";
        private static string s_lastMeshAppearance = "";

        public ChangeComponentChunkMaskDialog()
        {
            InitializeComponent();

            ViewModel = new ChangeComponentChunkMaskDialogViewModel();
            DataContext = ViewModel;

            LoadLastSelection();

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.ComponentName,
                        x => x.ComponentNameBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.DepotPath,
                        x => x.DepotPathBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.MeshAppearance,
                        x => x.MeshAppearanceNameBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.RememberValues,
                        x => x.RememberValuesCheckBox.IsChecked)
                    .DisposeWith(disposables);
            });
        }

        public ChangeComponentChunkMaskDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (ChangeComponentChunkMaskDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void LoadLastSelection()
        {
            if (ViewModel is null)
            {
                return;
            }

            if (s_lastComponentName != "")
            {
                ViewModel.ComponentName = s_lastComponentName;
                ViewModel.RememberValues = true;
            }

            if (s_lastDepotPath != "")
            {
                ViewModel.DepotPath = s_lastDepotPath;
                ViewModel.RememberValues = true;
            }

            if (s_lastMeshAppearance != "")
            {
                ViewModel.MeshAppearance = s_lastMeshAppearance;
                ViewModel.RememberValues = true;
            }

            if (s_lastChunkMask is not IRedPrimitive<ulong> value)
            {
                return;
            }

            ViewModel.ChunkMask = value;
            ViewModel.RememberValues = true;
        }

        private void SaveLastSelection()
        {
            if (ViewModel is null)
            {
                return;
            }

            if (!ViewModel.RememberValues)
            {
                s_lastComponentName = "";
                s_lastDepotPath = "";
                s_lastMeshAppearance = "";
                s_lastChunkMask = null;
                return;
            }

            s_lastComponentName = ViewModel.ComponentName;
            s_lastChunkMask = ViewModel.ChunkMask;
            s_lastDepotPath = ViewModel.DepotPath;
            s_lastMeshAppearance = ViewModel.MeshAppearance;
        }

        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            SaveLastSelection();
            e.Handled = true;
            DialogResult = true;
            Close();
        }

        private void WizardControl_OnFinish(object sender, RoutedEventArgs e) => SaveLastSelection();

        private void On_Chunkmask_Changed(object sender, PropertyChangedEventArgs e)
        {
            if (sender is not RedChunkMaskEditor editor || e.PropertyName is not (nameof(editor.RedNumber)) ||
                ViewModel is null)
            {
                return;
            }

            ViewModel.ChunkMask = (CUInt64)editor.RedNumber;
        }
    }
}