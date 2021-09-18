using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Text.Json;
using System.Threading;
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
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace WolvenKit.ViewModels.Documents
{
    public abstract class TweakEntryViewModel : ReactiveObject
    {
        public string Name { get; set; }

        public abstract string DisplayString { get; }
    }

    public sealed class GroupViewModel : TweakEntryViewModel
    {
        private readonly TweakRecord _value;

        public GroupViewModel(string name, TweakRecord value)
        {
            Name = name;
            _value = value;
        }

        
        public override string DisplayString => _value.ToString();

        public TweakRecord GetValue() => _value;
    }

    public sealed class FlatViewModel : TweakEntryViewModel
    {
        private readonly IType _value;

        public FlatViewModel(string name, IType value)
        {
            Name = name;
            _value = value;
        }

        public override string DisplayString => _value.ToString();

        public IType GetValue() => _value;
    }


    public class TweakDocumentViewModel : DocumentViewModel
    {

        public TweakDocumentViewModel(string path) : base(path)
        {
            Document = new TextDocument();
            TweakDocument = new TweakDocument();

            Types = new(Enum.GetNames<ETweakType>());

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

        [Reactive] public TweakDocument TweakDocument {  get; set; }

        [Reactive] public IEnumerable<TweakEntryViewModel> Entries { get; set; }

        [Reactive] public TweakEntryViewModel SelectedItem { get; set; }

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
            if (TweakDocument.Flats.ContainsKey(FlatName))
            {
                MessageBox.Show($"A flat with name {FlatName} is already part of your database. Please give a unique name to the item you are adding, or delete the existing item first.",
                    "WolvenKit", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!Serialization.Json.TryParseJsonFlat(SelectedType, ValueString, out var ivalue))
            {
                return;
            }

            var newFlat = new FlatViewModel(FlatName, ivalue);
            TweakDocument.Flats.Add(FlatName, newFlat.GetValue());



            GenerateEntries();
            Document.Text = Serialization.Serialize(TweakDocument);
        }

        public ReactiveCommand<Unit, Unit> EditFlatCommand { get; }
        private void EditFlat()
        {
           
        }

        public ReactiveCommand<Unit, Unit> DeleteFlatCommand { get; }
        private void DeleteFlat()
        {
            if (SelectedItem is null)
            {
                return;
            }

            switch (SelectedItem)
            {
                case FlatViewModel fvm:
                    TweakDocument.Flats.Remove(fvm.Name);
                    break;
                case GroupViewModel gvm:
                    TweakDocument.Groups.Remove(gvm.Name);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            
            SelectedItem = null;

            GenerateEntries();
            Document.Text = Serialization.Serialize(TweakDocument);
        }

        #endregion

        #region methods

        private void GenerateEntries()
        {
            var flatvms = TweakDocument.Flats
                .Select(f => new FlatViewModel(f.Key, f.Value))
                .Cast<TweakEntryViewModel>();
            var groupvms = TweakDocument.Groups
                .Select(g => new GroupViewModel(g.Key, g.Value))
                .Cast<TweakEntryViewModel>();
            Entries = flatvms.Concat(groupvms);
        }

        public override void OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            using var bw = new StreamWriter(fs);
            bw.Write(Document.Text);

            if (Serialization.Deserialize(Document.Text, out var dict))
            {
                TweakDocument = dict;
                GenerateEntries();
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
            if (!File.Exists(paramFilePath))
            {
                return;
            }

            var hlManager = HighlightingManager.Instance;

            Document = new TextDocument();
            var extension = Path.GetExtension(paramFilePath);
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

            if (string.IsNullOrEmpty(Document.Text))
            {
                return;
            }

            if (Serialization.Deserialize(Document.Text, out var dict))
            {
                TweakDocument = dict;
                GenerateEntries();
            }
            else
            {
                MessageBox.Show($"The tweak file could not be parsed. Please check the file for errors.",
                    "WolvenKit",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
        }

        #endregion

    }
}
