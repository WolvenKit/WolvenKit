using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Interaction;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public abstract partial class RedDocumentTabViewModel : ObservableObject
{
    protected RedDocumentTabViewModel(RedDocumentViewModel parent, string header)
    {
        _parent = parent;
        FilePath = parent.FilePath;
        Header = header;

        PropertyChanged += RedDocumentTabViewModel_PropertyChanged;
    }

    private void RedDocumentTabViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(RDTDataViewModel.IsEmbeddedFile))
        {
            DeleteEmbeddedFileCommand.NotifyCanExecuteChanged();
            RenameEmbeddedFileCommand.NotifyCanExecuteChanged();
        }
    }

    public abstract ERedDocumentItemType DocumentItemType { get; }
    public string Header { get; set; }
    public string FilePath { get; set; }

    [ObservableProperty] private RedDocumentViewModel _parent;

    [ObservableProperty] private bool _canClose;

    public static IRedType? CopiedChunk;

    public static List<IRedType> CopiedChunks { get; } = new();

    private bool CanDeleteEmbeddedFile() => this is RDTDataViewModel data && data.IsEmbeddedFile;
    [RelayCommand(CanExecute = nameof(CanDeleteEmbeddedFile))]
    private void DeleteEmbeddedFile()
    {
        if (this is RDTDataViewModel datavm)
        {
            for (var i = 0; i < Parent.Cr2wFile.EmbeddedFiles.Count; i++)
            {
                var file = Parent.Cr2wFile.EmbeddedFiles[i];
                if (file.Content == datavm.GetData())
                {
                    Parent.Cr2wFile.EmbeddedFiles.Remove(file);
                    break;
                }
            }
            for (var i = 0; i < Parent.TabItemViewModels.Count; i++)
            {
                var vm = Parent.TabItemViewModels[i];
                if (vm == this)
                {
                    Parent.TabItemViewModels.Remove(this);
                    Parent.SetIsDirty(true);
                    break;
                }
            }
        }
    }

    private bool CanRenameEmbeddedFile() => this is RDTDataViewModel data && data.IsEmbeddedFile;
    [RelayCommand(CanExecute = nameof(CanRenameEmbeddedFile))]
    private void RenameEmbeddedFile()
    {
        if (this is RDTDataViewModel datavm)
        {
            CR2WEmbedded? embeddedFile = null;
            for (var i = 0; i < Parent.Cr2wFile.EmbeddedFiles.Count; i++)
            {
                var file = Parent.Cr2wFile.EmbeddedFiles[i];
                if (file.Content == datavm.GetData())
                {
                    embeddedFile = (CR2WEmbedded)file;
                }
            }
            if (embeddedFile != null)
            {
                var newfilename = Interactions.Rename(embeddedFile.FileName.GetResolvedText()!);

                if (string.IsNullOrEmpty(newfilename))
                {
                    return;
                }

                datavm.FilePath = newfilename;
                embeddedFile.FileName = newfilename;
                Parent.SetIsDirty(true);
            }
        }
    }

    public virtual void OnSelected()
    {

    }
}
