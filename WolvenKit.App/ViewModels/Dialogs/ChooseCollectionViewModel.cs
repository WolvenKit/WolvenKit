using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Tools;

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

        [Reactive] public ObservableCollection<IDisplayable> AvailableItems { get; set; } = new();
        [Reactive] public ObservableCollection<IDisplayable> SelectedItems { get; set; } = new();

        [Reactive] public IDisplayable? SelectedAvailableItem { get; set; }
        [Reactive] public IDisplayable? SelectedSelectedItem { get; set; }

        [Reactive] public ObservableCollection<object> SelectedAvailableItems { get; set; } = new();
        [Reactive] public ObservableCollection<object> SelectedSelectedItems { get; set; } = new();

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
