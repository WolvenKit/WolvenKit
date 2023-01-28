using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Utils;
using Splat;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.ViewModels.Documents
{
    public partial class ScriptDocumentViewModel : DocumentViewModel
    {
        private readonly ILoggerService _loggerService;

        public ScriptDocumentViewModel(string path) : base(path)
        {

            _document = new TextDocument();
            _extension = "reds";

            var hlManager = HighlightingManager.Instance;
            _highlightingDefinition = hlManager.GetDefinitionByExtension("swift");

            _loggerService = Locator.Current.GetService<ILoggerService>().NotNull();
        }

        [ObservableProperty] private TextDocument _document;

        [ObservableProperty] private string _extension;

        [ObservableProperty] private IHighlightingDefinition _highlightingDefinition;

        [ObservableProperty] private bool _isReadOnly;

        [ObservableProperty] private string? _isReadOnlyReason;

        public override Task OnSave(object parameter) => throw new NotImplementedException();

        //public override bool OpenFile(string path)
        //{
        //    _isInitialized = false;

        //    LoadDocument(path);

        //    ContentId = path;
        //    FilePath = path;
        //    _isInitialized = true;

        //    return true;
        //}

        //public override Task<bool> OpenFileAsync(string path)
        //{
        //    _isInitialized = false;

        //    LoadDocument(path);

        //    ContentId = path;
        //    FilePath = path;
        //    _isInitialized = true;

        //    return Task.FromResult(true);
        //}

        private void LoadDocument(string paramFilePath)
        {
            if (!File.Exists(paramFilePath))
            {
                return;
            }

            var hlManager = HighlightingManager.Instance;

            Document = new TextDocument();
            var extension = Path.GetExtension(paramFilePath);
            HighlightingDefinition = hlManager.GetDefinitionByExtension(extension);

            // Check file attributes and set to read-only if file attributes indicate that
            if ((File.GetAttributes(paramFilePath) & FileAttributes.ReadOnly) != 0)
            {
                IsReadOnly = true;
                IsReadOnlyReason = "This file cannot be edit because another process is currently writting to it.\n" +
                                   "Change the file access permissions or save the file in a different location if you want to edit it.";
            }

            using (var fs = new FileStream(paramFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var fr = FileReader.OpenStream(fs, Encoding.UTF8))
            {
                Document = new TextDocument(fr.ReadToEnd());
            }

            FilePath = paramFilePath;

            if (string.IsNullOrEmpty(Document.Text))
            {
                return;
            }

        }

    }
}
