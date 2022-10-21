﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Navigation;
using Wolvenkit.Installer.Services;

namespace Wolvenkit.Installer.ViewModel;

[ObservableObject]
internal partial class InstalledViewModel
{
    private readonly IDialogService _dialogService;
    public ILibraryService LibraryService { get; }

    public InstalledViewModel(IDialogService dialogService, ILibraryService libraryService)
    {
        _dialogService = dialogService;
        LibraryService = libraryService;

        // TODO if service updated
        //foreach (var item in _libraryService.Apps)
        //{
        //    InstalledApps.Add(new PackageViewModel(item.IdStr, "", item.Version, false)
        //    {
        //        ImagePath = "ms-appx:///Assets/ControlImages/Acrylic.png"
        //    });
        //}
    }

    //public ObservableCollection<PackageViewModel> InstalledApps { get; set; } = new();


}
