using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;
using WolvenKit.Converters;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels;

namespace WolvenKit.Views.Templates
{
    /// <summary>
    /// Interaction logic for RedCollectionEditor.xaml
    /// </summary>
    public partial class RedCollectionEditor
    {
        private readonly IRedArray _redarray;

        public RedCollectionEditor(IRedArray redarray)
        {
            InitializeComponent();

            _redarray = redarray;

            if (DataContext is RedCollectionEditorViewModel vm)
            {
                var type = _redarray.GetType();
                var innerType = type.GetGenericArguments()[0];

                var method = typeof(RedCollectionEditorViewModel)
                    .GetMethod(nameof(RedCollectionEditorViewModel.SetElements), new[] { typeof(IRedArray) });
                var generic = method.MakeGenericMethod(innerType);

                generic.Invoke(vm, new object[] { _redarray });


                //vm.SetElements(_redarray);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void PropertyGrid_AutoGeneratingPropertyGridItem(object sender, Syncfusion.Windows.PropertyGrid.AutoGeneratingPropertyGridItemEventArgs e)
        {
            if (e.OriginalSource is PropertyItem { } propertyItem)
            {
                if (DataContext is RedCollectionEditorViewModel viewModel)
                {
                    var propertyType = propertyItem.PropertyType;
                    var propertyName = propertyItem.DisplayName;

                    ITypeEditor customEditor;
                    if (propertyType == typeof(object) && propertyName.Equals("Element"))
                    {
                        var type = viewModel.SelectedElement.Element.GetType();
                        customEditor = PropertyGridEditors.GetPropertyEditor(type);
                    }
                    else
                    {
                        customEditor = PropertyGridEditors.GetPropertyEditor(propertyItem.PropertyType);
                    }

                    if (customEditor is not null)
                    {
                        propertyItem.Editor = customEditor;
                        e.ExpandMode = PropertyExpandModes.FlatMode;
                    }

                }

            }
        }

        private void PropertyGrid_CollectionEditorOpening(object sender, CollectionEditorOpeningEventArgs e)
        {
            //Restrict collection editor window opening
            e.Cancel = true;

            if (sender is PropertyGrid pg)
            {
                var selectedProperty = pg.SelectedPropertyItem;
                var prop = selectedProperty.Value;

                if (prop is IRedArray editableVariable)
                {
                    // open custom collection editor
                    var collectionEditor = new RedCollectionEditor(editableVariable);
                    var r = collectionEditor.ShowDialog();
                    if (r ?? true)
                    {
                        //TODO
                    }
                }
                else
                {
                    throw new ArgumentException(nameof(editableVariable));
                }
            }
        }
        private void PropertyGrid_Loaded(object sender, RoutedEventArgs e)
        {
            if (VisualUtils.FindDescendant(this, typeof(PropertyView)) is PropertyView item1)
            {
                item1.ItemContainerGenerator.StatusChanged += ItemContainerGenerator_StatusChanged;
            }
        }

        private void ItemContainerGenerator_StatusChanged(object sender, EventArgs e)
        {
            foreach (PropertyCatagoryViewItem item in VisualUtils.EnumChildrenOfType(this, typeof(PropertyCatagoryViewItem)))
            {
                foreach (var items in item.Items)
                {
                    foreach (PropertyViewItem propertyViewItem in VisualUtils.EnumChildrenOfType(this, typeof(PropertyViewItem)))
                    {
                        var button = (ToggleButton)propertyViewItem.Template.FindName("ToggleButton", propertyViewItem);
                        if (button.Visibility == System.Windows.Visibility.Visible && !button.IsMouseOver)
                        {
                            button.IsChecked = true;
                        }
                    }
                }
            }
        }
    }
}
