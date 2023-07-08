using System;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.RED4.Archive;

namespace WolvenKit.App.ViewModels.Tools;

public class CollectionItemViewModel<T> : ObservableObject, IDisplayable
{
    public CollectionItemViewModel(T model) => Model = model;

    public string Info
    {
        get
        {
            return Model switch
            {
                FileEntry fe => fe.Name,
                uint u => u.ToString(),
                _ => throw new ArgumentException()
            };
        }
    }

    public string Name
    {
        get
        {
            return Model switch
            {
                FileEntry fe => fe.ShortName,
                uint u => u.ToString(),
                _ => throw new ArgumentException()
            };
        }
    }


    public T Model { get; set; }
}