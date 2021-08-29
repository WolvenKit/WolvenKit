using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Utils;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.TweakDB.Converters;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class TweakDocumentViewModel : DocumentViewModel
    {
        private TweakDB _tweakDb;
        private JsonSerializerOptions options;

        public TweakDocumentViewModel(string path) : base(path)
        {
            Document = new TextDocument();
            _tweakDb = new TweakDB();
            Flats = new();

            Types = new(Enum.GetNames<EIType>());

            AddFlatCommand = ReactiveCommand.Create(AddFlat/*, canAddFlat*/);

            options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters =
                    {
                        new ITypeConverterWithTypeDiscriminator(),
                        new JsonStringEnumConverter(),

                        new CNameJsonConverter(),
                        new CStringJsonConverter(),

                        new CFloatJsonConverter(),
                        new CBoolJsonConverter(),

                        new JsonConverterCUint8(),
                        new JsonConverterCUint16(),
                        new JsonConverterCUint32(),
                        new JsonConverterCUint64(),
                        new JsonConverterCInt8(),
                        new JsonConverterCInt16(),
                        new JsonConverterCInt32(),
                        new JsonConverterCInt64(),  
                        
                    }

            };
        }


        #region properties

        [Reactive] public TextDocument Document {  get; set; }

        [Reactive] public IHighlightingDefinition HighlightingDefinition { get; set; }

        [Reactive] public bool IsReadOnly { get; set; }

        [Reactive] public string IsReadOnlyReason { get; set; }

        [Reactive] public string ValueString { get; set; }

        [Reactive] public string FlatName { get; set; }

        [Reactive] public string SelectedType { get; set; }

        [Reactive] public ObservableCollection<string> Types { get; set; }

        [Reactive] public ObservableCollection<TweakFlatDto> Flats {  get; set; }

        #endregion

        #region commands

        public ReactiveCommand<Unit, Unit> AddFlatCommand { get; }
        //private IObservable<bool> canAddFlat => this.WhenAnyValue(x => x.FileName, b =>
        //{
        //    return !string.IsNullOrEmpty(b);
        //});
        private void AddFlat()
        {
            if (string.IsNullOrEmpty(SelectedType)
                || string.IsNullOrEmpty(FlatName)
                || string.IsNullOrEmpty(ValueString))
            {
                return;
            }

            // parse type
            if (!Enum.TryParse<EIType>(SelectedType, out var type))
            {
                return;
            }

            if (!TryParseText(type, out IType ivalue))
            {
                return;
            }

            var newFlat = new TweakFlatDto()
            {
                Name = FlatName,
                //Type = type,
                Value = ivalue
            };

            if (Flats.Any(_ => _.Name == FlatName))
            {
                MessageBox.Show($"A flat with name {FlatName} is already part of your database. Please give a unique name to the item you are adding, or delete the existing item first.",
                    "WolvenKit", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // add to db
            Flats.Add(newFlat);

            // serialize textfile
            var dict = Flats.ToList();
            var d = dict.ToDictionary(x => x.Name, x => x.Value);
            
            Document.Text = JsonSerializer.Serialize(d, options);
        }

        private bool TryParseText(EIType type, out IType itype)
        {
            itype = null;
            object value = null;

            try
            {
                switch (type)
                {
                    case EIType.CName:
                        value = (CName)ValueString;
                        break;
                    case EIType.CString:
                        value = (CString)ValueString;
                        break;
                    case EIType.CFloat:
                        value = (CFloat)float.Parse(ValueString);
                        break;
                    case EIType.CBool:
                        value = (CBool)bool.Parse(ValueString);
                        break;
                    case EIType.CUint8:
                        value = (CUint8)byte.Parse(ValueString);
                        break;
                    case EIType.CUint16:
                        value = (CUint16)ushort.Parse(ValueString);
                        break;
                    case EIType.CUint32:
                        value = (CUint32)uint.Parse(ValueString);
                        break;
                    case EIType.CUint64:
                        value = (CUint64)ulong.Parse(ValueString);
                        break;
                    case EIType.CInt8:
                        value = (CInt8)sbyte.Parse(ValueString);
                        break;
                    case EIType.CInt16:
                        value = (CInt16)short.Parse(ValueString);
                        break;
                    case EIType.CInt32:
                        value = (CInt32)int.Parse(ValueString);
                        break;
                    case EIType.CInt64:
                        value = (CInt64)long.Parse(ValueString);
                        break;
                    case EIType.CColor:
                        value = CColor.Parse(ValueString);
                        break;
                    case EIType.CEulerAngles:
                        value = CEulerAngles.Parse(ValueString);
                        break;
                    case EIType.CQuaternion:
                        value = CQuaternion.Parse(ValueString);
                        break;
                    case EIType.CVector2:
                        value = CVector2.Parse(ValueString);
                        break;
                    case EIType.CVector3:
                        value = CVector3.Parse(ValueString);
                        break;
                    default:
                        break;
                }

                // parse Value
                if (value is not IType ivalue)
                {
                    itype = null;
                    return false;
                }

                itype = ivalue;
                return true;
            }
            catch (Exception)
            {
                itype = null;
                return false;
            }
        }


        #endregion

        public override void OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            using var bw = new StreamWriter(fs);
            bw.Write(Document.Text);

            ParseTextFile();

            //dbg
            var deltaFilePath = $"{FilePath}.bin";
            var db = new TweakDB();
            foreach (var item in Flats)
            {
                db.Add(item.Name, item.Value);
            }
            db.Save(deltaFilePath);
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

                ParseTextFile();

                return true;
            }

            return false;
        }

        private bool ParseTextFile()
        {
            try
            {
                var lib = JsonSerializer.Deserialize<Dictionary<string, IType>>(Document.Text, options);
                var list = lib.Select(_ => new TweakFlatDto()
                {
                    Name = _.Key,
                    Value = _.Value
                });
                Flats = new ObservableCollection<TweakFlatDto>(list);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show($"The tweak file could not be parsed. Please check the file for errors.",
                    "WolvenKit", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }
    }
}
