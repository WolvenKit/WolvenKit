using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Wolvenkit.Installer.Services;

namespace Wolvenkit.Installer.ViewModel;

[ObservableObject]
public partial class MainViewModel
{
    private readonly IDialogService _dialogService;
    //private readonly IFileService _fileService;

    public MainViewModel(IDialogService dialogService /*, IFileService fileService*/) => _dialogService = dialogService;//_fileService = fileService;


}
