using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Utils;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.ViewModels.Documents
{
    public class ScriptDocumentViewModel : DocumentViewModel
    {
        private readonly ILoggerService _loggerService;

        public ScriptDocumentViewModel(string path) : base(path)
        {

            Document = new TextDocument();
            Extension = "reds";

            var hlManager = HighlightingManager.Instance;
            HighlightingDefinition = hlManager.GetDefinitionByExtension("swift");

            _loggerService = Locator.Current.GetService<ILoggerService>().NotNull();
        }

        [Reactive] public TextDocument Document { get; set; }

        [Reactive] public string Extension { get; set; }

        [Reactive] public IHighlightingDefinition HighlightingDefinition { get; set; }

        [Reactive] public bool IsReadOnly { get; set; }

        [Reactive] public string? IsReadOnlyReason { get; set; }

        public override Task OnSave(object parameter) => throw new NotImplementedException();

        public override bool OpenFile(string path)
        {
            _isInitialized = false;

            LoadDocument(path);

            ContentId = path;
            FilePath = path;
            _isInitialized = true;

            return true;
        }

        public override Task<bool> OpenFileAsync(string path)
        {
            _isInitialized = false;

            LoadDocument(path);

            ContentId = path;
            FilePath = path;
            _isInitialized = true;

            return Task.FromResult(true);
        }

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
