using System;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents;
/// <summary>
/// Interaktionslogik für RDTInkAtlasView.xaml
/// </summary>
public partial class RDTInkAtlasView : UserControl
{
    private int _oldIndex = -1;

    public RDTInkAtlasView()
    {
        InitializeComponent();

        DataContextChanged += OnDataContextChanged;
    }

    private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
        if (DataContext is not RDTInkTextureAtlasViewModel inkAtlasViewModel)
        {
            return;
        }

        SlotSelection.Items.Clear();
        foreach (var slotName in inkAtlasViewModel.GetUsedSlotNames())
        {
            SlotSelection.Items.Add(slotName);
        }

        if (SlotSelection.Items.Count > 0)
        {
            SlotSelection.SetCurrentValue(System.Windows.Controls.Primitives.Selector.SelectedIndexProperty, 0);
        }
    }

    private void ResetZoomPan(object sender, RoutedEventArgs e) => ImageCanvasItem.ResetZoomPan();

    private void SlotSelection_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (DataContext is not RDTInkTextureAtlasViewModel inkAtlasViewModel)
        {
            return;
        }

        if (SlotSelection.SelectedItem is not string slotName)
        {
            return;
        }

        var newIndex = slotName switch
        {
            "Slot 0" => 0,
            "Slot 1" => 1,
            "Slot 2" => 2,
            _ => throw new ArgumentOutOfRangeException()
        };

        if (_oldIndex == newIndex)
        {
            return;
        }

        _oldIndex = newIndex;

        inkAtlasViewModel.RenderAtlas(_oldIndex);
    }
}
