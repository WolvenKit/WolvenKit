using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class NpvCreationDialogViewModel : DialogViewModel
{
    [ObservableProperty] private string _destFolderPath = "";

    public int Eyes = 0;
    public int Nose = 0;
    public int Mouth = 0;
    public int Jaw = 0;
    public int Ears = 0;

    public List<string> ListBoxOptions { get; set; } = Enumerable.Range(1, 22).Select(i => i.ToString("D2")).ToList();

    public bool CanSave() => !string.IsNullOrEmpty(DestFolderPath);

    public NpvCreationDialogViewModel()
    {
    }
}