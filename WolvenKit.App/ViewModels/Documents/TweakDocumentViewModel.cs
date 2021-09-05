using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Utils;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.TweakDB.Serialization;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class TweakDocumentViewModel : DocumentViewModel
    {

        public TweakDocumentViewModel(string path) : base(path)
        {
            Document = new TextDocument();
            Flats = new();

            Types = new(Enum.GetNames<EIType>());

            AddFlatCommand = ReactiveCommand.Create(AddFlat);
            DeleteFlatCommand = ReactiveCommand.Create(DeleteFlat);
            EditFlatCommand = ReactiveCommand.Create(EditFlat);

            var hlManager = HighlightingManager.Instance;
            HighlightingDefinition = hlManager.GetDefinitionByExtension(".json");
            

        }


        #region properties

        [Reactive] public TextDocument Document {  get; set; }

        [Reactive] public IHighlightingDefinition HighlightingDefinition { get; set; }

        [Reactive] public bool IsReadOnly { get; set; }

        [Reactive] public string IsReadOnlyReason { get; set; }

        

        [Reactive] public string FlatName { get; set; }

        [Reactive] public string SelectedType { get; set; }

        [Reactive] public string ValueString { get; set; }


        [Reactive] public ObservableCollection<string> Types { get; set; }

        [Reactive] public ObservableCollection<FlatViewModel> Flats {  get; set; }

        [Reactive] public FlatViewModel SelectedItem { get; set; }

        #endregion

        #region commands

        public ReactiveCommand<Unit, Unit> AddFlatCommand { get; }
        private void AddFlat()
        {
            if (string.IsNullOrEmpty(SelectedType)
                || string.IsNullOrEmpty(FlatName)
                || string.IsNullOrEmpty(ValueString))
            {
                return;
            }

            // check name
            if (Flats.Any(_ => _.Name == FlatName))
            {
                MessageBox.Show($"A flat with name {FlatName} is already part of your database. Please give a unique name to the item you are adding, or delete the existing item first.",
                    "WolvenKit", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // parse type
            if (!Enum.TryParse<EIType>(SelectedType, out var enumType))
            {
                return;
            }

            var jsonvalue = ValueString;
            // parse value
            // some pretty input helpers
            switch (enumType)
            {
                case EIType.CName:
                case EIType.CString:
                    if (!jsonvalue.StartsWith('\"'))
                    {
                        jsonvalue = $"\"{jsonvalue}";
                    }
                    if (!jsonvalue.EndsWith('\"'))
                    {
                        jsonvalue = $"{jsonvalue}\"";
                    }
                    break;
                case EIType.CColor:
                case EIType.CEulerAngles:
                case EIType.CQuaternion:
                case EIType.CVector2:
                case EIType.CVector3:
                    if (!jsonvalue.StartsWith('['))
                    {
                        jsonvalue = $"[{jsonvalue}";
                    }
                    if (!jsonvalue.EndsWith(']'))
                    {
                        jsonvalue = $"{jsonvalue}]";
                    }
                    break;
            }
            if (!Serialization.TryParseJsonFlat(Serialization.GetTypeFromEnum(enumType), jsonvalue, out var ivalue))
            {
                return;
            }

            var newFlat = new FlatViewModel(FlatName, ivalue);
            Flats.Add(newFlat);

            // serialize textfile
            var dict = Flats.ToList();
            var d = dict.ToDictionary(x => x.Name, x => x.GetValue());

            Document.Text = JsonSerializer.Serialize(d, Serialization.Options);
        }

        public ReactiveCommand<Unit, Unit> EditFlatCommand { get; }
        private void EditFlat()
        {
            if (SelectedItem is null)
            {
                return;
            }

            
        }

        public ReactiveCommand<Unit, Unit> DeleteFlatCommand { get; }
        private void DeleteFlat()
        {
            if (SelectedItem is null)
            {
                return;
            }

            Flats.Remove(SelectedItem);
            SelectedItem = null;

            // serialize textfile
            var dict = Flats.ToList();
            var d = dict.ToDictionary(x => x.Name, x => x.GetValue());

            Document.Text = JsonSerializer.Serialize(d, Serialization.Options);
        }

        #endregion

        public override void OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            using var bw = new StreamWriter(fs);
            bw.Write(Document.Text);

            if (Serialization.TryParseJsonFlatsDict(Document.Text, out var dict))
            {
                var list = dict.Select(_ => new FlatViewModel(_.Key, _.Value));
                Flats = new ObservableCollection<FlatViewModel>(list);
            }

            //dbg
            //var deltaFilePath = $"{FilePath}.bin";
            //var db = new TweakDB();
            //foreach (var item in Flats)
            //{
            //    db.Add(item.Name, item.Value);
            //}
            //db.Save(deltaFilePath);
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

            return await Task.FromResult(true);
        }

        private void LoadDocument(string paramFilePath)
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

                if (Serialization.TryParseJsonFlatsDict(Document.Text, out var dict))
                {
                    var list = dict.Select(_ => new FlatViewModel(_.Key, _.Value));
     
                    Flats = new ObservableCollection<FlatViewModel>(list);
                }
                else
                {
                    MessageBox.Show($"The tweak file could not be parsed. Please check the file for errors.",
                        "WolvenKit",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);

                }
            }
        }

        public class FlatViewModel
        {
            private readonly IType _value;

            public FlatViewModel(string name, IType value)
            {
                Name = name;
                _value = value;
            }

            public string Name { get; set; }

            public string DisplayString => _value.ToString();

            public IType GetValue() => _value;
        }
    }
}
