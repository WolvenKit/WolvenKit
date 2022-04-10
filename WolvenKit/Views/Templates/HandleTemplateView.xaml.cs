using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;
using UserControl = System.Windows.Controls.UserControl;

namespace WolvenKit.Views.Templates
{
    /// <summary>
    /// Interaction logic for EnumTemplateView.xaml
    /// </summary>
    public partial class HandleTemplateView : UserControl
    {
        public HandleTemplateView()
        {
            InitializeComponent();
        }

        public IRedType SelectedItem { get; set; }


        public ObservableCollection<IRedType> BindingCollection { get; set; } = new();

        public IRedBaseHandle RedChunkPtr
        {
            get => (IRedBaseHandle)GetValue(RedChunkPtrProperty);
            set => SetValue(RedChunkPtrProperty, value);
        }

        public static readonly DependencyProperty RedChunkPtrProperty =
            DependencyProperty.Register(nameof(RedChunkPtr), typeof(IRedBaseHandle),
                typeof(HandleTemplateView), new PropertyMetadata(OnRedChunkPtrChanged));

        //public event EventHandler<GoToChunkRequestedEventArgs> GoToChunkRequested;

        private static void OnRedChunkPtrChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not HandleTemplateView view)
            {
                return;
            }
            if (view.RedChunkPtr == null)
            {
                return;
            }
            if (e.NewValue is not IRedBaseHandle iptr)
            {
                return;
            }

            view.BindingCollection.Clear();
            view.BindingCollection.Add(null);

            //throw new TodoException("handle editor");

            //var type = iptr.InnerType;
            //var available = RedReflection.GetSubClassesOf(type).Select(x => x.Name).ToList();
            //available.Add(type.Name);

            //var availableChunks = iptr.File.Chunks.Where(x => available.Contains(x.GetType().Name));

            //foreach (var s in availableChunks)
            //{
            //    view.BindingCollection.Add(s);
            //}

            //view.SelectedItem = iptr.GetValue();



            // get all possible chunks in the cr2w file
            //var reftype = AssemblyDictionary.GetTypeByName(iptr.ReferenceType);
            //var available = AssemblyDictionary.GetSubClassesOf(reftype).Select(x => x.Name).ToList();
            //available.Add(reftype.Name);

            //var availableChunks = iptr.File.Chunks.Where(x => available.Contains(x.REDType));

            //foreach (var s in availableChunks)
            //{
            //    view.BindingCollection.Add(s);
            //}

            //view.SelectedItem = iptr.GetReference();
        }

        private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectedItem == null)
            {
                return;
            }



            //throw new TodoException("handle editor");

            //if (RedChunkPtr.GetReference() == SelectedItem)
            //{
            //    return;
            //}

            //RedChunkPtr.SetValue(SelectedItem.ChunkIndex + 1);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) => throw new TodoException("handle editor");//var target = RedChunkPtr.Pointer;//GoToChunkRequested?.Invoke(this, new GoToChunkRequestedEventArgs() { Export = target });
    }

    public class GoToChunkRequestedEventArgs : EventArgs
    {
        public IRedType Export { get; set; }
    }
}
