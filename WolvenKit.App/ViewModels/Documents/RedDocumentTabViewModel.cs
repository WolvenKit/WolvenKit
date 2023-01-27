using System.Collections.Generic;
using System.Reactive.Linq;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Commands;
using WolvenKit.Interaction;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public abstract partial class RedDocumentTabViewModel : ObservableObject
    {
        protected RedDocumentTabViewModel(RedDocumentViewModel parent, string header)
        {
            DeleteEmbeddedFileCommand = new DelegateCommand(ExecuteDeleteEmbeddedFile, CanDeleteEmbeddedFile);
            RenameEmbeddedFileCommand = new DelegateCommand(ExecuteRenameEmbeddedFile, CanRenameEmbeddedFile);

            _file = parent;
            FilePath = parent.FilePath;
            Header = header;
        }

        public abstract ERedDocumentItemType DocumentItemType { get; }
        public string Header { get; set; }
        public string FilePath { get; set; }

        [ObservableProperty] private RedDocumentViewModel _file;

        [ObservableProperty] private bool _canClose;

        public static IRedType? CopiedChunk;

        public static List<IRedType> CopiedChunks = new();

        public ICommand DeleteEmbeddedFileCommand { get; private set; }
        private bool CanDeleteEmbeddedFile() => this is RDTDataViewModel data && data.IsEmbeddedFile;
        private void ExecuteDeleteEmbeddedFile()
        {
            if (this is RDTDataViewModel datavm)
            {
                for (var i = 0; i < File.Cr2wFile.EmbeddedFiles.Count; i++)
                {
                    var file = File.Cr2wFile.EmbeddedFiles[i];
                    if (file.Content == datavm.GetData())
                    {
                        File.Cr2wFile.EmbeddedFiles.Remove(file);
                        break;
                    }
                }
                for (var i = 0; i < File.TabItemViewModels.Count; i++)
                {
                    var vm = File.TabItemViewModels[i];
                    if (vm == this)
                    {
                        File.TabItemViewModels.Remove(this);
                        File.SetIsDirty(true);
                        break;
                    }
                }
            }
        }

        public ICommand RenameEmbeddedFileCommand { get; private set; }
        private bool CanRenameEmbeddedFile() => this is RDTDataViewModel data && data.IsEmbeddedFile;
        private async void ExecuteRenameEmbeddedFile()
        {
            if (this is RDTDataViewModel datavm)
            {
                CR2WEmbedded? embeddedFile = null;
                for (var i = 0; i < File.Cr2wFile.EmbeddedFiles.Count; i++)
                {
                    var file = File.Cr2wFile.EmbeddedFiles[i];
                    if (file.Content == datavm.GetData())
                    {
                        embeddedFile = (CR2WEmbedded)file;
                    }
                }
                if (embeddedFile != null)
                {
                    var newfilename = await Interactions.Rename.Handle(embeddedFile.FileName);

                    if (string.IsNullOrEmpty(newfilename))
                    {
                        return;
                    }

                    datavm.FilePath = newfilename;
                    embeddedFile.FileName = newfilename;
                    File.SetIsDirty(true);
                }
            }
        }

        public virtual void OnSelected()
        {

        }
    }
}
