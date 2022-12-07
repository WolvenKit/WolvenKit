using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Importers;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Tools;
using YamlDotNet.Core;

namespace WolvenKit.Views.Importers;

public partial class TextureImportView : IViewFor<TextureImportViewModel>
{
    public TextureImportView()
    {
        InitializeComponent();

        ViewModel = Locator.Current.GetService<TextureImportViewModel>();
        DataContext = ViewModel;



        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel,
                    x => x.SelectedObject.Properties,
                    x => x.OverlayPropertyGrid.SelectedObject)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                    x => x.ImportableItems,
                    x => x.ImportGrid.ItemsSource)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                   x => x.SelectedObject,
                   x => x.ImportGrid.SelectedItem)
               .DisposeWith(disposables);

        });

    }

    public TextureImportViewModel ViewModel { get; set; }
    object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (TextureImportViewModel)value; }

    public bool? ShowDialog(System.Windows.Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }

    private void ShowSettings()
    {
        if (ViewModel == null)
        {
            return;
        }

        //if (ViewModel.IsImportsSelected)
        //{
        //    if (ImportGrid.SelectedItem is ImportExportItemViewModel selectedImport)
        //    {
        //        if (Enum.TryParse(selectedImport.Extension.TrimStart('.'), out ERawFileFormat rawExtension))
        //        {
        //            XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
        //            XAML_AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedImport.Extension);
        //            XAML_AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedImport.Name);

        //            if (rawExtension == ERawFileFormat.re)
        //            {
        //                var mod = projectManager.ActiveProject;
        //                var animsets = Directory.GetFiles(mod.ModDirectory, "*.anims", SearchOption.AllDirectories);
        //                var depotPaths = animsets.Select(x => x[(mod.ModDirectory.Length + 1)..]);

        //                AddSettingsRe.SetCurrentValue(VisibilityProperty, Visibility.Visible);

        //                AnimsetComboBox.SetCurrentValue(System.Windows.Controls.ItemsControl.ItemsSourceProperty, depotPaths);

        //                // set defaults if no change in selection
        //                if (selectedImport.Properties is ReImportArgs args)
        //                {
        //                    if (AnimsetComboBox.SelectedItem is not string selectedItem)
        //                    {
        //                        return;
        //                    }
        //                    if (string.IsNullOrEmpty(selectedItem))
        //                    {
        //                        return;
        //                    }

        //                    args.Animset = selectedItem;
        //                    //args.Output = Path.ChangeExtension(selectedItem, "cooked.anims");

        //                    if (AnimNameComboBox.SelectedItem is not string selectedName)
        //                    {
        //                        return;
        //                    }
        //                    if (string.IsNullOrEmpty(selectedName))
        //                    {
        //                        return;
        //                    }

        //                    args.AnimationToRename = selectedName;
        //                }

        //            }
        //        }
        //        else
        //        {
        //            throw new ArgumentOutOfRangeException();
        //        }
        //    }
        //}


    }

    //private void AnimsetComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    //{
    //    if (ViewModel is not ImportExportViewModel vm)
    //    {
    //        return;
    //    }
    //    if (vm.IsImportsSelected
    //        && ImportGrid.SelectedItem is ImportableItemViewModel selectedImport
    //        && selectedImport.Properties is ReImportArgs args)
    //    {
    //        if (AnimsetComboBox.SelectedItem is not string selectedItem)
    //        {
    //            return;
    //        }

    //        args.Animset = selectedItem;
    //        //args.Output = Path.ChangeExtension(selectedItem, "cooked.anims");

    //        // parse animset and populate the animnameBox
    //        var path = Path.Combine(projectManager.ActiveProject.ModDirectory, selectedItem);
    //        if (File.Exists(path))
    //        {
    //            using var fs = new FileStream(path, FileMode.Open);
    //            if (parser.TryReadRed4File(fs, out var originalFile))
    //            {
    //                if (originalFile.RootChunk is animAnimSet animset)
    //                {
    //                    var animnames = animset.Animations.Select(x => x.Chunk.Animation.Chunk.Name.ToString());
    //                    AnimNameComboBox.SetCurrentValue(System.Windows.Controls.ItemsControl.ItemsSourceProperty, animnames);
    //                }
    //            }
    //        }
    //    }
    //}

    //private void AnimNameComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    //{
    //    if (ViewModel is not ImportExportViewModel vm)
    //    {
    //        return;
    //    }
    //    if (vm.IsImportsSelected
    //        && ImportGrid.SelectedItem is ImportableItemViewModel selectedImport
    //        && selectedImport.Properties is ReImportArgs args)
    //    {
    //        if (AnimNameComboBox.SelectedItem is not string selectedItem)
    //        {
    //            return;
    //        }

    //        args.AnimationToRename = selectedItem;
    //    }
    //}

    private void OverlayPropertyGrid_AutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
    {
        switch (e.DisplayName)
        {
            case nameof(ReactiveObject.Changed):
            case nameof(ReactiveObject.Changing):
            case nameof(ReactiveObject.ThrownExceptions):
                e.Cancel = true;
                return;
        }

        if (ViewModel.SelectedObject?.Properties is XbmImportArgs { })
        {
            if (e.DisplayName == "Use existing file")
            {
                e.Cancel = true;
                return;
            }

            //if (!_settingsManager.ShowAdvancedOptions)
            //{
            //    if (e.Category is "Image Import Settings")
            //    {
            //        e.Cancel = true;
            //        return;
            //    }
            //}
        }
    }


    //private PropertyItem _propertyItem;
    ///// <summary>
    ///// Override PG Collection Editor
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //private void PropertyGrid_CollectionEditorOpening(object sender, Syncfusion.Windows.PropertyGrid.CollectionEditorOpeningEventArgs e)
    //{
    //    if (ViewModel is TextureImportViewModel vm && sender is PropertyGrid pg)
    //    {
    //        _propertyItem = pg.SelectedPropertyItem;
    //        vm.SetCollectionCommand.SafeExecute(_propertyItem.Name);
    //    }

    //    e.Cancel = true;
    //    XAML_FileSelectingOverlay.SetCurrentValue(VisibilityProperty, Visibility.Visible);
    //}
}
