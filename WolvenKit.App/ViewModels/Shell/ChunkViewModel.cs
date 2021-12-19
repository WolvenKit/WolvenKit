using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using System.Windows.Input;
using WolvenKit.Functionality.Commands;
using static WolvenKit.RED4.Types.RedReflection;
using WolvenKit.Common.Conversion;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Dynamic;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Text;
using System.Reactive;
using WolvenKit.RED4.Archive.Buffer;

namespace WolvenKit.ViewModels.Shell
{
    public class ChunkViewModel : ReactiveObject, ISelectableTreeViewItemModel
    {

        #region Constructors

        public ChunkViewModel(IRedType export)
        {
            Data = export;
            Data.WhenAnyValue(x => x).Subscribe(x => IsDirty = true);
            OpenRefCommand = new DelegateCommand<IRedRef>(p => ExecuteOpenRef(p), CanOpenRef);
            ExportChunkCommand = new DelegateCommand((p) => ExecuteExportChunk(), (p) => CanExportChunk());
            AddItemToArrayCommand = new DelegateCommand((p) => ExecuteAddItemToArray(), (p) => CanAddItemToArray());
            DeleteItemCommand = new DelegateCommand((p) => ExecuteDeleteItem(), (p) => CanDeleteItem());
        }

        public ChunkViewModel(string name, IRedType export) : this(export)
        {
            propertyName = name;
        }

        public ChunkViewModel(int i, IRedType export, ChunkViewModel parent) : this(export, parent)
        {
            Index = i;
        }

        public ChunkViewModel(IRedType export, ChunkViewModel parent) : this(export)
        {
            Parent = parent;
            this.WhenAnyValue(x => x.IsDirty).Subscribe(x => Parent.IsDirty |= x);
        }

        public ChunkViewModel(string name, IRedType export, ChunkViewModel parent) : this(export, parent)
        {
            propertyName = name;
        }

        #endregion Constructors

        #region Properties

        private IRedType _data;
        public IRedType Data
        {
            get => _data;
            set => this.RaiseAndSetIfChanged(ref _data, value);
        }
        [Reactive] public bool IsDirty { get; protected set; }
        public ChunkViewModel Parent { get; set; }
        public int? Index { get; set; }

        public class RedArrayWrapper : IRedType
        {
            private IRedArray list;

            [TypeConverter(typeof(ExpandableObjectConverter))]
            public Dictionary<string, object> Properties { get; set; }

            public RedArrayWrapper(IRedArray ary)
            {
                list = ary;
                Properties = new Dictionary<string, object>();
                foreach (var item in ary)
                {
                    if (item is IRedBaseHandle hnd)
                    {
                        var star = hnd?.File?.Chunks[hnd.Pointer] ?? null;
                        Properties.Add(ary.IndexOf(item).ToString(), star);
                    }
                    else
                    {
                        Properties.Add(ary.IndexOf(item).ToString(), item);
                    }
                }
            }
        }

        public class RedArrayItem<T> : IRedType
        {
            private IRedArray list;
            private int index;
            public T Value
            {
                get => (T)list[index];
                set => list[index] = value;
            }

            public RedArrayItem(IRedArray ary, int i)
            {
                list = ary;
                index = i;
            }
        }

        public class RedClassProperty<T> : IRedType
        {
            private IRedClass obj;
            private string propertyName;
            public T Value
            {
                get
                {
                    var epi = GetPropertyByName(obj.GetType(), propertyName);
                    if (epi != null)
                    {
                        return (T)epi.GetValue(obj);
                    }
                    return default(T);
                }
                set {
                    var epi = GetPropertyByName(obj.GetType(), propertyName);
                    if (epi != null)
                    {
                        epi.SetValue(obj, value);
                    }
                }
            }

            public RedClassProperty(IRedClass cls, string i)
            {
                obj = cls;
                propertyName = i;
            }
        }

        private IRedType _propertyGridData;

        public IRedType PropertyGridData
        {
            get
            {
                if (_propertyGridData != null)
                    return _propertyGridData;
                try
                {
                    IRedType data;
                    if (Parent != null && Parent.Data is IRedArray ar)
                    {
                        Type type = typeof(RedArrayItem<>).MakeGenericType(PropertyType);
                        var rai = (IRedType)System.Activator.CreateInstance(type, ar, ar.IndexOf(Data));
                        rai.WhenAnyValue(x => x).Subscribe(x => IsDirty = true);
                        return _propertyGridData = rai;
                    }
                    if (Parent != null && Parent.Data is IRedClass cls && propertyName != null)
                    {
                        Type type = typeof(RedClassProperty<>).MakeGenericType(PropertyType);
                        var rcp = (IRedType)System.Activator.CreateInstance(type, cls, propertyName);
                        rcp.WhenAnyValue(x => x).Subscribe(x => IsDirty = true);
                        return _propertyGridData = rcp;
                    }
                    if (Data is IRedArray ary)
                    {
                        var raw = new RedArrayWrapper(ary);
                        raw.WhenAnyValue(x => x).Subscribe(x => IsDirty = true);
                        return _propertyGridData = raw;
                    }
                    if (PropertyType.IsAssignableTo(typeof(IRedClass)))
                    {
                        data = Data;
                    }
                    else
                    {
                        data = Parent?.Data ?? null;
                    }

                    if (data is IRedBaseHandle handle)
                    {
                        return _propertyGridData = handle?.File?.Chunks[handle.Pointer] ?? null;
                    }
                    else 
                    {
                        return _propertyGridData = data;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        private ObservableCollection<ChunkViewModel> _properties;

        public ObservableCollection<ChunkViewModel> Properties
        {
            get
            {
                if (_properties == null)
                {
                    _properties = new ObservableCollection<ChunkViewModel>();
                    try
                    {
                        var obj = Data;
                        if (Data is IRedBaseHandle handle)
                        {
                            obj = handle.File.Chunks[handle.Pointer];
                        }
                        if (obj is IRedArray ary)
                        {
                            for (int i = 0; i < ary.Count; i++)
                            {
                                _properties.Add(new ChunkViewModel((IRedType)ary[i], this));
                            }
                        }
                        else if (obj is RedBaseClass redClass)
                        {
                            var pis = GetTypeInfo(redClass.GetType()).PropertyInfos;
                            pis.Sort((a, b) => a.Name.CompareTo(b.Name));
                            pis.ForEach((pi) =>
                            {
                                IRedType value;
                                if (pi.RedName == null)
                                {
                                    value = (IRedType)redClass.GetType().GetProperty(pi.Name).GetValue(redClass, null);
                                }
                                else
                                {
                                    value = (IRedType)pi.GetValue(redClass);
                                }
                                _properties.Add(new ChunkViewModel(pi.Name, value, this));
                            });
                        }
                        else if (obj is SerializationDeferredDataBuffer sddb && sddb.Data.Data is Package04 p4)
                        {
                            var chunks = p4.Chunks;
                            for (int i = 0; i < chunks.Count; i++)
                            {
                                _properties.Add(new ChunkViewModel(i, chunks[i], this));
                            }
                        }
                        else if (obj is DataBuffer db && db.Data.Data is Package04 p42)
                        {
                            var chunks = p42.Chunks;
                            for (int i = 0; i < chunks.Count; i++)
                            {
                                _properties.Add(new ChunkViewModel(i, chunks[i], this));
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        //throw;
                    }
                }

                return _properties;
            }
            set
            {

            }
        }

        [Reactive] public bool IsSelected { get; set; }

        [Reactive] public bool IsDeleteReady { get; set; }

        [Reactive] public bool IsExpanded { get; set; }

        public string propertyName { get; }
        public string Name { get
            {
                if (propertyName != null)
                {
                    return propertyName;
                }
                if (Index != null)
                {
                    return Index.ToString();
                }
                if (Parent != null)
                {
                    return Parent.Properties.IndexOf(this).ToString();
                }
                return null;
            }
            set
            {

            }
        }

        public int Level { get
            {
                if (Parent == null)
                {
                    return 0;
                }
                else if (Parent.Parent == null)
                {
                    return 1;
                }
                else if (Parent.Parent.Parent == null)
                {
                    return 2;
                }
                else if (Parent.Parent.Parent.Parent == null)
                {
                    return 3;
                }
                else if (Parent.Parent.Parent.Parent.Parent == null)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        public Type PropertyType
        {
            get
            {
                var type = Data?.GetType() ?? null;
                if (type == null)
                {
                    var parent = Parent.Data;
                    if (Parent.PropertyType == typeof(IRedBaseHandle))
                    {
                        var handle = (IRedBaseHandle)parent;
                        parent = handle.File.Chunks[handle.Pointer];
                    }
                    var propInfo = RedReflection.GetPropertyByName(parent.GetType(), propertyName) ?? null;
                    type = propInfo?.Type ?? null;
                }
                return type;
            }
        }

        public string Type
        {
            get
            {
                //if (PropertyType == typeof(IRedBaseHandle))
                //{
                //    var handle = (IRedBaseHandle)Data;
                //    return "Handle: " + (handle?.File?.Chunks[handle.Pointer]?.GetType().Name ?? "null");
                //}
                return PropertyType != null ? RedReflection.GetRedTypeFromCSType(PropertyType) : "null";
            }
        }

        public bool IsInArray { get
            {
                return Parent != null && (Parent.Data is IRedArray || Parent.Data is DataBuffer || Parent.Data is SerializationDeferredDataBuffer);
            }
        }

        public int ArrayIndexWidth { get
            {
                if (Parent.Properties.Count < 10)
                    return 16;
                else if (Parent.Properties.Count < 100)
                    return 21;
                else if (Parent.Properties.Count < 1000)
                    return 26;
                return 31;
            }
        }

        public string Value {
            get {
                var str = new StringBuilder();
                if (Data == null)
                {
                    return "null";
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedString)))
                {
                    var value = (IRedString)Data;
                    if (value.GetValue() == "")
                    {
                        return "null";
                    }
                    else
                    {
                        return value.GetValue();
                    }
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedArray)))
                {
                    var value = (IRedArray)Data;
                    return $"{Type} [{value.Count}]";
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedBaseHandle)))
                {
                    var value = (IRedBaseHandle)Data;
                    str.Append(Type);
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedEnum)))
                {
                    var value = (IRedEnum)Data;
                    return value.ToEnumString();
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedBitField)))
                {
                    var value = (IRedBitField)Data;
                    return value.ToBitFieldString();
                }
                else if (PropertyType.IsAssignableTo(typeof(CBool)))
                {
                    var value = (CBool)Data;
                    return value ? "True" : "False";
                }
                else if (PropertyType.IsAssignableTo(typeof(CRUID)))
                {
                    var value = (CRUID)Data;
                    return ((ulong)value).ToString();
                }
                else if (PropertyType.IsAssignableTo(typeof(CUInt64)))
                {
                    var value = (CUInt64)Data;
                    return ((ulong)value).ToString();
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedInteger)))
                {
                    var value = (IRedInteger)Data;
                    return (value switch {
                        CUInt8 uint64 => (float)uint64,
                        CInt8 uint64 => (float)uint64,
                        CInt16 uint64 => (float)uint64,
                        CUInt16 uint64 => (float)uint64,
                        CInt32 uint64 => (float)uint64,
                        CUInt32 uint64 => (float)uint64,
                        CInt64 uint64 => (float)uint64,
                        _ => throw new ArgumentOutOfRangeException(nameof(value)),
                    }).ToString();
                }
                else if (PropertyType.IsAssignableTo(typeof(FixedPoint)))
                {
                    var value = (FixedPoint)Data;
                    return ((float)value).ToString("R");
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedPrimitive<float>)))
                {
                    var value = (IRedPrimitive)Data;
                    return ((float)(CFloat)value).ToString("R");
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedRef)))
                {
                    var value = (IRedRef)Data;
                    if (value != null && value.DepotPath != "")
                    {
                        return value.DepotPath;
                    }
                    else
                    {
                        return "null";
                    }
                }
                else
                {
                    str.Append(Type ?? "null");
                }

                var epi = GetPropertyByName(PropertyType, "Name");
                if (propertyName == null && epi != null)
                {
                    str.Append($" ({epi.GetValue((IRedClass)Data)})");
                }

                return str.ToString();
            }
            set
            {

            }
        }

        public string Extension
        {
            get
            {
                if (PropertyType == null)
                {
                    return "Error";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedInteger)))
                {
                    return "SymbolNumeric";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedPrimitive<float>)))
                {
                    return "SymbolNumeric";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedString)))
                {
                    return "SymbolString";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedArray)))
                {
                    return "SymbolArray";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedEnum)))
                {
                    return "SymbolEnum";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedRef)))
                {
                    return "FileSymlinkFile";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedBitField)))
                {
                    return "SymbolEnum";
                }
                if (PropertyType.IsAssignableTo(typeof(CBool)))
                {
                    return "SymbolBoolean";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedBaseHandle)))
                {
                    return "References";
                }
                if (PropertyType.IsAssignableTo(typeof(DataBuffer)) || PropertyType.IsAssignableTo(typeof(SerializationDeferredDataBuffer)))
                {
                    return "GroupByRefType";
                }
                if (PropertyType.IsAssignableTo(typeof(CResourceAsyncReference<>)) || PropertyType.IsAssignableTo(typeof(CResourceReference<>)))
                {
                    return "RepoPull";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedPrimitive)))
                {
                    return "DebugBreakpointDataUnverified";
                }
                if (PropertyType.IsAssignableTo(typeof(WorldTransform)))
                {
                    return "Compass";
                }
                if (PropertyType.IsAssignableTo(typeof(WorldPosition)))
                {
                    return "Move";
                }
                if (PropertyType.IsAssignableTo(typeof(Quaternion)))
                {
                    return "IssueReopened";
                }
                if (PropertyType.IsAssignableTo(typeof(CColor)))
                {
                    return "SymbolColor";
                }
                return "SymbolClass";
            }
        }

        #endregion Properties

        public bool CanBeDroppedOn(ChunkViewModel target)
        {
            return PropertyType == target.PropertyType;
        }

        public ICommand OpenRefCommand { get; private set; }
        private bool CanOpenRef(IRedRef redRef) => redRef != null && redRef.DepotPath != null;
        private void ExecuteOpenRef(IRedRef redRef)
        {
            var depotpath = redRef.DepotPath;
            //var key = FNV1A64HashAlgorithm.HashString(depotpath);

            //var _gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();
            //var _archiveManager = Locator.Current.GetService<IArchiveManager>();

            //if (_archiveManager.Lookup(key).HasValue)
            //{
            //    _gameControllerFactory.GetController().AddToMod(key);
            //}
        }


        public ICommand AddItemToArrayCommand { get; private set; }
        private bool CanAddItemToArray() => Data is IRedArray;
        private void ExecuteAddItemToArray()
        {
            var newItem = RedTypeManager.CreateRedType((Data as IRedArray).InnerType);
            (Data as IRedArray).Add(newItem);
            _properties.Add(new ChunkViewModel(newItem, this));
            IsExpanded = true;
        }

        public ICommand DeleteItemCommand { get; private set; }
        private bool CanDeleteItem() => IsInArray;
        private void ExecuteDeleteItem()
        {
            if (Parent.Data is IRedArray ary)
            {
                //IsSelected = false;
                Parent.IsSelected = true;
                ary.Remove(Data);
                Parent.Properties.Remove(this);
            }
        }

        public ICommand ExportChunkCommand { get; private set; }
        private bool CanExportChunk() => _properties.Count > 0;
        private void ExecuteExportChunk()
        {
            Stream myStream;
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.FileName = Type + ".json";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    var dto = new RedClassDto(PropertyGridData, new
                    {
                        WolvenKitVersion = "8.4.0",
                        WKitJsonVersion = "0.0.1",
                        Exported = DateTime.UtcNow.ToString("o")
                    });
                    var json = JsonConvert.SerializeObject(dto, Formatting.Indented);

                    if (string.IsNullOrEmpty(json))
                    {
                        throw new SerializationException();
                    }

                    myStream.Write(json.ToCharArray().Select(c => (byte)c).ToArray());
                    myStream.Close();
                }
            }
        }
    }
}
