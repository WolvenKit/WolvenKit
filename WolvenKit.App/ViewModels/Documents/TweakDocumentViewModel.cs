using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Utils;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.TweakDB;

namespace WolvenKit.ViewModels.Documents
{
    public class TweakDocumentViewModel : DocumentViewModel
    {
        private TweakDB _tweakDb;


        public TweakDocumentViewModel(string path) : base(path)
        {
            Document = new TextDocument();
            _tweakDb = new TweakDB();
            Flats = new();

            Types = new(Enum.GetNames<EIType>());

            AddFlatCommand = ReactiveCommand.Create(AddFlat, canAddFlat);

        }


        #region properties

        [Reactive] public TextDocument Document {  get; set; }

        [Reactive] public IHighlightingDefinition HighlightingDefinition { get; set; }

        [Reactive] public bool IsReadOnly { get; set; }

        [Reactive] public string IsReadOnlyReason { get; set; }



        [Reactive] public string FlatName { get; set; }

        [Reactive] public string SelectedType { get; set; }
        [Reactive] public ObservableCollection<string> Types { get; set; }

        [Reactive] public ObservableCollection<TweakFlatDto> Flats {  get; set; }

        #endregion

        #region commands

        public ReactiveCommand<Unit, Unit> AddFlatCommand { get; }
        private IObservable<bool> canAddFlat => this.WhenAnyValue(x => x.FileName, b =>
        {
            return !string.IsNullOrEmpty(b);
        });
        private void AddFlat()
        {
            if (string.IsNullOrEmpty(SelectedType) || string.IsNullOrEmpty(FlatName))
            {
                return;
            }

            var newFlat = new TweakFlatDto()
            {
                Name = FlatName,
                Type = SelectedType

            };

            Flats.Add(newFlat);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(Flats, options);
            Document.Text = jsonString;
        }


        #endregion

        public override void OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            using var bw = new StreamWriter(fs);
            bw.Write(Document.Text);
        }

        public override async Task<bool> OpenFileAsync(string path)
        {
            _isInitialized = false;


            LoadDocument(path);

            ContentId = path;
            FilePath = path;
            IsDirty = false;
            Title = FileName;
            _isInitialized = true;

            return await Task.FromResult<bool>(true);
        }

        public bool LoadDocument(string paramFilePath)
        {
            if (File.Exists(paramFilePath))
            {
                var hlManager = HighlightingManager.Instance;

                Document = new TextDocument();
                string extension = Path.GetExtension(paramFilePath);
                HighlightingDefinition = hlManager.GetDefinitionByExtension(extension);

                IsDirty = false;
                //IsReadOnly = false;

                // Check file attributes and set to read-only if file attributes indicate that
                if ((System.IO.File.GetAttributes(paramFilePath) & FileAttributes.ReadOnly) != 0)
                {
                    IsReadOnly = true;
                    IsReadOnlyReason = "This file cannot be edit because another process is currently writting to it.\n" +
                                       "Change the file access permissions or save the file in a different location if you want to edit it.";
                }

                using (FileStream fs = new FileStream(paramFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (StreamReader reader = FileReader.OpenStream(fs, Encoding.UTF8))
                {
                    Document = new TextDocument(reader.ReadToEnd());
                }

                FilePath = paramFilePath;

                return true;
            }

            return false;
        }
    }
}
