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
                // this.Bind(ViewModel,
                //         x => x.ChunkMask,
                //         x => (ulong)(CUInt32)(IRedPrimitive)x.ChunkmaskEditor.RedNumber)
                //     .DisposeWith(disposables);
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
                s_lastChunkMask = null;
                return;
            }

            s_lastComponentName = ViewModel.ComponentName;
            s_lastChunkMask = ViewModel.ChunkMask;
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