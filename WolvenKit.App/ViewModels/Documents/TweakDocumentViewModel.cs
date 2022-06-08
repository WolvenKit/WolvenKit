using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Utils;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.App.Interaction;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4.Serialization;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.Types;
using Activator = System.Activator;

namespace WolvenKit.App.ViewModels.Documents
{
    public class TweakDocumentViewModel : DocumentViewModel
    {
        private readonly ILoggerService _loggerService;

        public TweakDocumentViewModel(string path) : base(path)
        {
            Document = new TextDocument();
            TweakDocument = new TweakDocument();
            Extension = "tweak";

            Types = new(Enum.GetNames<ETweakType>());

            AddFlatCommand = ReactiveCommand.CreateFromTask(AddFlat);
            AddArrayCommand = ReactiveCommand.CreateFromTask(AddArray);
            AddGroupCommand = ReactiveCommand.CreateFromTask(AddGroup);
            DeleteFlatCommand = ReactiveCommand.Create(DeleteFlat);
            EditFlatCommand = ReactiveCommand.Create(EditFlat);

            var hlManager = HighlightingManager.Instance;
            HighlightingDefinition = hlManager.GetDefinitionByExtension("C#");

            _loggerService = Locator.Current.GetService<ILoggerService>();
        }

        #region properties

        [Reactive] public TextDocument Document { get; set; }

        [Reactive] public string Extension { get; set; }

        [Reactive] public IHighlightingDefinition HighlightingDefinition { get; set; }

        [Reactive] public bool IsReadOnly { get; set; }

        [Reactive] public string IsReadOnlyReason { get; set; }



        [Reactive] public string FlatName { get; set; }

        [Reactive] public string SelectedType { get; set; }

        [Reactive] public string ValueString { get; set; }


        [Reactive] public ObservableCollection<string> Types { get; set; }

        [Reactive] public TweakDocument TweakDocument { get; set; }

        [Reactive] public ObservableCollection<TweakEntryViewModel> Entries { get; set; }

        [Reactive] public TweakEntryViewModel SelectedItem { get; set; }

        #endregion

        #region commands

        public ReactiveCommand<Unit, Unit> AddGroupCommand { get; }
        private async Task AddGroup()
        {
            if (string.IsNullOrEmpty(FlatName))
            {
                return;
            }

            // check name
            if (TweakDocument.Groups.ContainsKey(FlatName))
            {
                _ = await Interactions.ShowMessageBoxAsync(
                    $"A group with name {FlatName} is already part of your database. Please give a unique name to the item you are adding, or delete the existing item first.",
                     "WolvenKit", WMessageBoxButtons.Ok, WMessageBoxImage.Error);
                return;
            }

            TweakDocument.Groups.Add(FlatName, new gamedataTweakDBRecord());

            GenerateEntries();
            Document.Text = Serialization.Serialize(TweakDocument);
        }

        public ReactiveCommand<Unit, Unit> AddFlatCommand { get; }
        private async Task AddFlat()
        {
            if (string.IsNullOrEmpty(SelectedType)
                || string.IsNullOrEmpty(FlatName)
                || string.IsNullOrEmpty(ValueString))
            {
                return;
            }

            if (!Serialization.Json.TryParseJsonFlat(SelectedType, ValueString, out var ivalue))
            {
                return;
            }

            if (SelectedItem is GroupViewModel/* { IsSelected:true }*/ group)
            {
                // check name
                if (group.GetValue().GetPropertyNames().Contains(FlatName))
                {
                    _ = await Interactions.ShowMessageBoxAsync(
                    $"A flat with name {FlatName} is already part of this group. Please give a unique name to the item you are adding, or delete the existing item first.",
                    "WolvenKit", WMessageBoxButtons.Ok, WMessageBoxImage.Error);
                    return;
                }

                group.GetValue().SetProperty(FlatName, ivalue);
            }
            else if (SelectedItem is FlatViewModel { IsArray: true } arrayVm && arrayVm.GetValue() is IRedArray array)
            {
                _ = array.Add(ivalue);
            }
            else
            {
                // check name
                if (TweakDocument.Flats.ContainsKey(FlatName))
                {
                    _ = await Interactions.ShowMessageBoxAsync(
                    $"A flat with name {FlatName} is already part of your database. Please give a unique name to the item you are adding, or delete the existing item first.",
                    "WolvenKit", WMessageBoxButtons.Ok, WMessageBoxImage.Error);
                    return;
                }
                TweakDocument.Flats.Add(FlatName, ivalue);
            }


            GenerateEntries();
            Document.Text = Serialization.Serialize(TweakDocument);
        }

        public ReactiveCommand<Unit, Unit> AddArrayCommand { get; }
        private async Task AddArray()
        {
            if (string.IsNullOrEmpty(SelectedType)
                || string.IsNullOrEmpty(FlatName))
            {
                return;
            }

            // parse type
            if (!Enum.TryParse<ETweakType>(SelectedType, out var enumType))
            {
                return;
            }

            var innertype = Serialization.GetTypeFromEnum(enumType);
            var array = Activator.CreateInstance(
                typeof(CArray<>).MakeGenericType(
                    new Type[] { innertype }),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: null,
                culture: null);

            var iarray = array as IRedType;

            if (SelectedItem is GroupViewModel/* { IsSelected:true }*/ group)
            {
                // check name
                if (group.GetValue().GetPropertyNames().Contains(FlatName))
                {
                    _ = await Interactions.ShowMessageBoxAsync(
                    $"A flat with name {FlatName} is already part of this group. Please give a unique name to the item you are adding, or delete the existing item first.",
                    "WolvenKit", WMessageBoxButtons.Ok, WMessageBoxImage.Error);
                    return;
                }

                group.GetValue().SetProperty(FlatName, iarray);
            }
            else
            {
                // check name
                if (TweakDocument.Flats.ContainsKey(FlatName))
                {
                    _ = await Interactions.ShowMessageBoxAsync(
                    $"A flat with name {FlatName} is already part of your database. Please give a unique name to the item you are adding, or delete the existing item first.",
                    "WolvenKit", WMessageBoxButtons.Ok, WMessageBoxImage.Error);
                    return;
                }
                TweakDocument.Flats.Add(FlatName, iarray);
            }


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
                    // if not in a group
                    if (!string.IsNullOrEmpty(fvm.GroupName))
                    {
                        _ = TweakDocument.Groups[fvm.GroupName].ResetProperty(fvm.Name);
                    }
                    else if (!string.IsNullOrEmpty(fvm.ArrayName))
                    {

                    }
                    else
                    {
                        _ = TweakDocument.Flats.Remove(fvm.Name);
                    }

                    break;
                case GroupViewModel gvm:
                    _ = TweakDocument.Groups.Remove(gvm.Name);
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
            try
            {
                var flatvms = TweakDocument?.Flats
                .Select(f => new FlatViewModel(f.Key, f.Value))
                .Cast<TweakEntryViewModel>();
                var groupvms = TweakDocument?.Groups
                    .Select(g => new GroupViewModel(g.Key, g.Value))
                    .Cast<TweakEntryViewModel>();
                Entries = new ObservableCollection<TweakEntryViewModel>(flatvms.Concat(groupvms));
            }
            catch (Exception)
            {
                Entries = new ObservableCollection<TweakEntryViewModel>();
                TweakDocument = new TweakDocument();
            }

            SetIsDirty(true);
        }

        public override async Task OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            using var bw = new StreamWriter(fs);
            bw.Write(Document.Text);

            try
            {
                if (Serialization.Deserialize(Document.Text, out var dict))
                {
                    TweakDocument = dict;
                    GenerateEntries();
                }
            }
            catch (Exception e)
            {
                _ = await Interactions.ShowMessageBoxAsync(
                        $"The tweak file could not be parsed. Please check the file for errors.",
                        "WolvenKit",
                        WMessageBoxButtons.Ok,
                        WMessageBoxImage.Error);
                _loggerService.Error(e);
            }

            _loggerService.Success($"{FilePath} saved.");
            SetIsDirty(false);

            //dbg
            //var deltaFilePath = $"{FilePath}.bin";
            //var db = new TweakDB();
            //foreach (var item in Flats)
            //{
            //    db.Add(item.Name, item.Value);
            //}
            //db.Save(deltaFilePath);
        }

        public override bool OpenFile(string path)
        {
            _isInitialized = false;

            _ = LoadDocument(path);

            ContentId = path;
            FilePath = path;
            _isInitialized = true;

            return true;
        }

        public override async Task<bool> OpenFileAsync(string path)
        {
            _isInitialized = false;

            await LoadDocument(path);

            ContentId = path;
            FilePath = path;
            _isInitialized = true;

            return await Task.FromResult(true);
        }

        private async Task LoadDocument(string paramFilePath)
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

            try
            {
                if (Serialization.Deserialize(Document.Text, out var dict))
                {
                    TweakDocument = dict;
                    GenerateEntries();
                }
                else
                {
                    throw new SerializationException();
                }
            }
            catch (Exception e)
            {
                _ = await Interactions.ShowMessageBoxAsync(
                        $"The tweak file could not be parsed. Please check the file for errors.",
                        "WolvenKit",
                        WMessageBoxButtons.Ok,
                        WMessageBoxImage.Error);
                _loggerService.Error(e);
            }


        }

        #endregion

    }
}
