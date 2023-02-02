using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Common.Interfaces;

namespace WolvenKit.App.ViewModels.Tools;

public abstract partial class FileSystemViewModel : ObservableObject, IFileSystemViewModel, ISelectableViewModel
{
    public abstract string Name { get; }

    public abstract string FullName { get; }

    public abstract string DisplayExtension { get; }

    public abstract uint Size { get; }

    public abstract string SizeString { get; }

    //public abstract ulong Key { get; }

    //public abstract ulong ParentKey { get; }

    [Browsable(false)][ObservableProperty] private bool _isChecked;
}
