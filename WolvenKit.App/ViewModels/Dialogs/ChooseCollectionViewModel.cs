using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Dialogs
{
    public interface IDisplayable
    {
        string Name { get; }
    }

    public partial class ChooseCollectionViewModel : DialogWindowViewModel
    {
        public ChooseCollectionViewModel() => Title = "Select Items";

        public string Title { get; set; }

        [ObservableProperty] private ObservableCollection<IDisplayable> _availableItems = new();
        [ObservableProperty] private ObservableCollection<IDisplayable> _selectedItems = new();

        [ObservableProperty] private IDisplayable? _selectedAvailableItem;
        [ObservableProperty] private IDisplayable? _selectedSelectedItem;

        [ObservableProperty] private ObservableCollection<object> _selectedAvailableItems = new();
        [ObservableProperty] private ObservableCollection<object> _selectedSelectedItems = new();

        public void SetAvailableItems(IEnumerable<IDisplayable> input) => AvailableItems = new(input);
        public void SetSelectedItems(IEnumerable<IDisplayable> input)
        {
            if (input is not null)
            {
                SelectedItems = new(input);
            }
        }

        [RelayCommand]
        private void AddItem()
        {
            var items = SelectedAvailableItems;
            if (items is not null && items.Any())
            {
                foreach (var item in items.Cast<IDisplayable>())
                {
                    if (!SelectedItems.Contains(item))
                    {
                        SelectedItems.Add(item);
                    }
                }
            }
        }

        [RelayCommand]
        private void RemoveItem()
        {
            var items = SelectedSelectedItems;
            if (items is not null && items.Any())
            {
                SelectedItems.RemoveMany(items.Cast<IDisplayable>());
            }
        }

    }




}
