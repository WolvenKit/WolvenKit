using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Windows.Input;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Documents;
using static WolvenKit.RED4.Types.RedReflection;

namespace WolvenKit.ViewModels.Shell
{
    public class ChunkViewModel : ReactiveObject, ISelectableTreeViewItemModel
    {
        private bool _propertiesLoaded;

        public ObservableCollectionExtended<ChunkViewModel> Properties { get; } = new();

        public ObservableCollection<ISelectableTreeViewItemModel> TVProperties { get; } = new();
        public ObservableCollection<ChunkViewModel> DisplayProperties { get; } = new();

        [Reactive] public string Value { get; private set; }
        [Reactive] public string Descriptor { get; private set; }
        [Reactive] public bool IsDefault { get; private set; }

        #region Constructors

        public ChunkViewModel(IRedType export, ChunkViewModel parent = null, string name = null, bool lazy = false)
        {
            Data = export;
            Parent = parent;
            propertyName = name;

            SelfList = new ObservableCollection<ChunkViewModel>(new[] { this });

            Properties.ToObservableChangeSet()
                .Subscribe(x =>
                {
                    TVProperties.Clear();
                    DisplayProperties.Clear();

                    if (Properties == null || Properties.Count == 0)
                    {
                        DisplayProperties.AddRange(SelfList);
                    }
                    else
                    {
                        if (Data is not IRedArray && Data is not IRedBufferWrapper)
                        {
                            TVProperties.AddRange(Properties);
                            DisplayProperties.AddRange(Properties);
                        }
                        else
                        {
                            var settings = Locator.Current.GetService<ISettingsManager>();
                            if (settings.TreeViewGroups && settings.TreeViewGroupSize > 1)
                            {
                                TVProperties.AddRange(SplitProperties(Properties, (int)settings.TreeViewGroupSize));
                            }
                            else
                            {
                                TVProperties.AddRange(Properties);
                            }


                            DisplayProperties.AddRange(SelfList);
                        }
                    }
                    CalculateDescriptor();
                });

            this.WhenAnyValue(x => x.IsSelected)
                .Where(x => IsSelected && !_propertiesLoaded)
                .Subscribe(x => CalculateProperties());

            this.WhenAnyValue(x => x.Data)
                .Subscribe((_) =>
                {
                    CalculateValue();
                    CalculateDescriptor();
                    CalculateIsDefault();

                    if (Parent != null)
                    {
                        if (Parent.Properties != null && Parent.Data is IRedArray arr)
                        {
                            var index = int.Parse(Name);
                            if (index != -1)
                            {
                                arr[index] = Data;

                                Parent.NotifyChain("Data");
                            }
                        }

                        if (propertyName != null)
                        {
                            var parentType = Parent.PropertyType;
                            var parentData = Parent.Data;
                            if (Parent.Data is IRedBaseHandle handle)
                            {
                                parentData = handle.GetValue();
                                parentType = handle.GetValue().GetType();
                            }
                            var epi = GetPropertyByRedName(parentType, propertyName);
                            if (epi != null)
                            {
                                if (epi.GetValue((RedBaseClass)parentData) != Data)
                                {
                                    epi.SetValue((RedBaseClass)parentData, Data);
                                    Tab.File.SetIsDirty(true);
                                    Parent.NotifyChain("Data");
                                }
                            }
                        }
                    }
                });

            //DoSubscribe();

            OpenRefCommand = new DelegateCommand(_ => ExecuteOpenRef(), _ => CanOpenRef());
            AddRefCommand = new DelegateCommand(_ => ExecuteAddRef(), _ => CanAddRef());
            ExportChunkCommand = new DelegateCommand(_ => ExecuteExportChunk(), _ => CanExportChunk());
            AddItemToArrayCommand = new DelegateCommand(_ => ExecuteAddItemToArray(), _ => CanAddItemToArray());
            AddHandleCommand = new DelegateCommand(_ => ExecuteAddHandle(), _ => CanAddHandle());
            ForceLoadCommand = new DelegateCommand(_ => ExecuteForceLoad(), _ => CanForceLoad());
            AddItemToCompiledDataCommand = new DelegateCommand(_ => ExecuteAddItemToCompiledData(), _ => CanAddItemToCompiledData());
            DeleteItemCommand = new DelegateCommand(_ => ExecuteDeleteItem(), _ => CanDeleteItem());
            DeleteAllCommand = new DelegateCommand(_ => ExecuteDeleteAll(), _ => CanDeleteAll());
            OpenChunkCommand = new DelegateCommand(_ => ExecuteOpenChunk(), _ => CanOpenChunk());
        }

        public ChunkViewModel(IRedType export, RDTDataViewModel tab) : this(export)
        {
            _tab = tab;
            IsExpanded = true;
            Data = export;
            //this.RaisePropertyChanged("Data");
            this.WhenAnyValue(x => x.Data).Skip(1).Subscribe((x) =>
            {
                Tab.File.SetIsDirty(true);
            });
        }

        #endregion Constructors

        public void NotifyChain(string property)
        {
            this.RaisePropertyChanged(property);
            if (Parent != null)
            {
                Parent.NotifyChain(property);
            }
        }

        private ObservableCollection<ISelectableTreeViewItemModel> SplitProperties(ObservableCollection<ChunkViewModel> locations, int nSize = 100)
        {
            if (locations == null)
            {
                return null;
            }

            if (locations.Count < nSize)
            {
                return new ObservableCollection<ISelectableTreeViewItemModel>(locations);
            }

            var list = new ObservableCollection<ISelectableTreeViewItemModel>();

            for (var i = 0; i < locations.Count; i += nSize)
            {
                var size = Math.Min(nSize, locations.Count - i);
                list.Add(new GroupedChunkViewModel($"[{i}-{i + size - 1}]", locations.Skip(i).Take(size)));
            }

            return list;
        }

        public bool HasChildren()
        {
            if (Data is DataBuffer db && db.Data is Package04 pkg1 && pkg1.Chunks.Count > 0)
            {
                return true;
            }

            if (Data is DataBuffer db2 && db2.Data is CR2WList cl && cl.Files.Count > 0)
            {
                return true;
            }

            if (Data is DataBuffer db3 && db3.Data is TilesBuffer)
            {
                return true;
            }

            if (Data is SerializationDeferredDataBuffer sddb && sddb.Data is Package04 pkg2 && pkg2.Chunks.Count > 0)
            {
                return true;
            }

            if (Data is SharedDataBuffer sdb && ((sdb.Data is Package04 pkg3 && pkg3.Chunks.Count > 0) || (sdb.File is CR2WFile crw && crw.RootChunk != null)))
            {
                return true;
            }

            if (Data is DataBuffer db4 && db4.Data is IParseableBuffer ipb)
            {
                return true;
            }

            if (Data is IRedArray arr && arr.Count > 0)
            {
                return true;
            }

            if (Data is RedBaseClass || (Data is IRedBaseHandle hdl && hdl.GetValue() != null))
            {
                return true;
            }

            if (Data is CKeyValuePair)
            {
                return true;
            }

            return false;
        }

        #region Properties

        private readonly RDTDataViewModel _tab;

        public RDTDataViewModel Tab
        {
            get
            {
                if (_tab != null)
                {
                    return _tab;
                }

                return Parent.Tab;
            }
        }

        [Reactive] public IRedType Data { get; set; }

        public IRedType ResolvedData
        {
            get
            {
                if (Data is IRedBaseHandle handle)
                {
                    return handle.GetValue();
                }
                else if (Data is CVariant v)
                {
                    return v.Value;
                }
                else
                {
                    return Data;
                }
            }
        }

        public ChunkViewModel Parent { get; set; }

        //public object DisplayProperties
        //{
        //    get
        //    {
        //        if (Properties == null || Properties.Count == 0)
        //            return new ObservableCollection<object>(new[] {
        //               this
        //            });
        //        else
        //            return Properties;
        //    }
        //}

        public ObservableCollection<ChunkViewModel> SelfList { get; set; }

        [Reactive] public bool ForceLoadProperties { get; set; }

        public class RedArrayWrapper : IRedType
        {
            private readonly IRedArray list;

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
                        var star = hnd.GetValue();
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
            private readonly IRedArray list;
            private readonly int index;
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

        public class RedClassProperty<T> : IRedType where T : IRedType
        {
            private readonly RedBaseClass obj;
            private readonly string propertyName;
            public T Value
            {
                get
                {
                    var epi = GetPropertyByRedName(obj.GetType(), propertyName);
                    if (epi != null)
                    {
                        return (T)epi.GetValue(obj);
                    }
                    return default(T);
                }
                set
                {
                    var epi = GetPropertyByRedName(obj.GetType(), propertyName);
                    if (epi != null)
                    {
                        epi.SetValue(obj, value);
                    }
                }
            }

            public RedClassProperty(RedBaseClass cls, string i)
            {
                obj = cls;
                propertyName = i;
            }
        }

        private IRedType CalculatePropertyGridData()
        {
            try
            {
                IRedType data;
                if (Parent != null && Parent.Data is IRedArray ar)
                {
                    var type = typeof(RedArrayItem<>).MakeGenericType(PropertyType);
                    var rai = (IRedType)System.Activator.CreateInstance(type, ar, ar.IndexOf(Data));
                    //rai.WhenAnyValue(x => x).Subscribe(x => IsDirty = true);
                    return rai;
                }
                if (Parent != null && Parent.Data is RedBaseClass cls && propertyName != null)
                {
                    var type = typeof(RedClassProperty<>).MakeGenericType(PropertyType);
                    var rcp = (IRedType)System.Activator.CreateInstance(type, cls, propertyName);
                    //rcp.WhenAnyValue(x => x).Subscribe(x => IsDirty = true);
                    return rcp;
                }
                if (Data is IRedArray ary)
                {
                    var raw = new RedArrayWrapper(ary);
                    //raw.WhenAnyValue(x => x).Subscribe(x => IsDirty = true);
                    return raw;
                }
                if (PropertyType.IsAssignableTo(typeof(RedBaseClass)))
                {
                    data = Data;
                }
                else
                {
                    data = Parent?.Data ?? null;
                }

                if (data is IRedBaseHandle handle)
                {
                    //this.File.Chunks[handle.Pointer].IsHandled = true;
                    return handle.GetValue();
                }
                else
                {
                    return data;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        //private ObservableCollection<ChunkViewModel> _properties;

        public void CalculateProperties()
        {
            if (_propertiesLoaded)
            {
                return;
            }

            var disposable = Properties.SuspendNotifications();

            Properties.Clear();
            try
            {
                var obj = Data;
                if (obj is IRedBaseHandle handle)
                {
                    //this.File.Chunks[handle.Pointer].IsHandled = true;
                    obj = handle.GetValue();
                }
                if (obj is CVariant v)
                {
                    obj = v.Value;
                }
                if (obj is IRedArray ary)
                {
                    var lazy = ary.Count > 100;
                    for (var i = 0; i < ary.Count; i++)
                    {
                        Properties.Add(new ChunkViewModel((IRedType)ary[i], this, null, lazy));
                    }
                }
                else if (obj is CKeyValuePair kvp)
                {
                    Properties.Add(new ChunkViewModel(kvp.Key, this, "key"));
                    Properties.Add(new ChunkViewModel(kvp.Value, this, "value"));
                }
                else if (obj is inkWidgetReference iwr)
                {
                    // need to add XPath somewhere in the data structure
                    Properties.Add(new ChunkViewModel((CString)"TODO", this));
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
                        Properties.Add(new ChunkViewModel(value, this, pi.RedName));
                    });
                }
                else if (obj is SerializationDeferredDataBuffer sddb && sddb.Data is Package04 p4)
                {
                    var chunks = p4.Chunks;

                    var lazy = chunks.Count > 100;
                    for (var i = 0; i < chunks.Count; i++)
                    {
                        Properties.Add(new ChunkViewModel(chunks[i], this, null, lazy));
                    }
                }
                else if (obj is SharedDataBuffer sdb)
                {
                    if (sdb.Data is Package04 p42)
                    {
                        var chunks = p42.Chunks;

                        var lazy = chunks.Count > 100;
                        for (var i = 0; i < chunks.Count; i++)
                        {
                            Properties.Add(new ChunkViewModel(chunks[i], this, null, lazy));
                        }
                    }
                    if (sdb.File is CR2WFile cr2)
                    {
                        //var chunks = cr2.Chunks;
                        //for (int i = 0; i < chunks.Count; i++)
                        //{
                        //    properties.Add(new ChunkViewModel(i, chunks[i], this));
                        //}
                        Properties.Add(new ChunkViewModel(cr2.RootChunk, this));
                    }
                    if (sdb.Data is IParseableBuffer ipb)
                    {
                        Properties.Add(new ChunkViewModel(ipb.Data, this));
                    }
                }
                else if (obj is DataBuffer db)
                {
                    if (db.Data is Package04 p43)
                    {
                        var chunks = p43.Chunks;

                        var lazy = chunks.Count > 100;
                        for (var i = 0; i < chunks.Count; i++)
                        {
                            Properties.Add(new ChunkViewModel(chunks[i], this, null, lazy));

                        }
                    }
                    else if (db.Data is CR2WList cl)
                    {
                        foreach (var file in cl.Files)
                        {
                            Properties.Add(new ChunkViewModel(file.RootChunk, this, null, cl.Files.Count > 100));
                        }
                    }
                    else if (db.Data is IParseableBuffer ipb)
                    {
                        Properties.Add(new ChunkViewModel(ipb.Data, this));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
            }

            disposable.Dispose();

            _propertiesLoaded = true;
        }

        [Reactive] public bool IsSelected { get; set; }

        [Reactive] public bool IsDeleteReady { get; set; }

        [Reactive] public bool IsExpanded { get; set; }

        [Reactive] public bool IsHandled { get; set; }

        public string propertyName { get; }

        public string Name
        {
            get
            {
                if (propertyName != null)
                {
                    return propertyName;
                }
                if (IsInArray)
                {
                    return Parent.GetIndexOf(this).ToString();
                }
                return null;
            }
            set
            {

            }
        }

        private void CalculateIsDefault()
        {
            IsDefault = Data == null;

            if (Parent != null && propertyName != null && Data is not IRedBaseHandle)
            {
                var parentType = Parent.PropertyType;
                if (Parent.Data is IRedBaseHandle handle && handle != null)
                {
                    parentType = handle.GetValue().GetType();
                }
                var epi = GetPropertyByRedName(parentType, propertyName);
                if (epi != null)
                {
                    IsDefault = IsDefault(parentType, epi, Data);
                }
            }
        }

        public int GetIndexOf(ChunkViewModel child) => Properties.IndexOf(child);

        public int Level => Parent == null ? 0 : Parent.Level + 1;

        public int DetailsLevel => (IsSelected || Parent == null) ? 0 : Parent.DetailsLevel + 1;

        private Flags _flags;

        public Type PropertyType
        {
            get
            {
                var type = Data?.GetType() ?? null;
                if (Parent != null)
                {
                    var parent = Parent.Data;
                    var parentType = Parent.ResolvedPropertyType;
                    // handles aren't the true parent type of these props, so need to get that
                    //if (Parent.Data is IRedBaseHandle handle && handle != null)
                    //{
                    //    parent = handle.GetValue();
                    //    parentType = handle.GetValue().GetType();
                    //}
                    var propInfo = GetPropertyByRedName(parentType, propertyName) ?? null;
                    if (propInfo != null)
                    {
                        if (type == null || type == propInfo.Type)
                        {
                            _flags = propInfo.Flags;
                            type = propInfo.Type;
                        }
                    }
                }
                return type;
            }
        }

        public Type ResolvedPropertyType
        {
            get
            {
                if (Data is IRedBaseHandle handle)
                {
                    return handle?.GetValue()?.GetType() ?? handle.InnerType;
                }
                if (Data is CVariant v)
                {
                    return v?.Value.GetType() ?? null;
                }
                return PropertyType;
            }
        }

        public string Type => PropertyType != null ? GetRedTypeFromCSType(PropertyType, _flags) : "null";

        public string ResolvedType => GetTypeRedName(ResolvedPropertyType);

        public bool TypesDiffer => PropertyType != ResolvedPropertyType;

        public bool IsInArray => Parent != null && Parent.IsArray;

        public bool IsArray => PropertyType != null && (PropertyType.IsAssignableTo(typeof(IRedArray)) || PropertyType.IsAssignableTo(typeof(DataBuffer)) || PropertyType.IsAssignableTo(typeof(SharedDataBuffer)) || PropertyType.IsAssignableTo(typeof(SerializationDeferredDataBuffer)));

        public int ArrayIndexWidth
        {
            get
            {
                var width = 0;
                if (Parent != null)
                {
                    if (Parent.Properties.Count <= 10)
                    {
                        width += 16;
                    }
                    else if (Parent.Properties.Count <= 100)
                    {
                        width += 21;
                    }
                    else if (Parent.Properties.Count <= 1000)
                    {
                        width += 26;
                    }
                    else
                    {
                        width += 31;
                    }
                }
                if (PropertyType?.IsAssignableTo(typeof(IRedArray)) ?? false)
                {
                    width += 20;
                }

                return width;
            }
        }

        public string XPath
        {
            get
            {
                if (Parent == null)
                {
                    return "root";
                }
                else
                {
                    var xpath = Parent.XPath;
                    if (IsInArray)
                    {
                        xpath += $"[{Name}]";
                    }
                    else if (Name != "")
                    {
                        xpath += "." + Name;
                    }

                    return xpath;
                }
            }
        }

        private void CalculateValue()
        {
            Value = "";
            if (Data == null)
            {
                Value = "null";
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedString)))
            {
                var value = (IRedString)Data;
                if (value.GetValue() == "")
                {
                    Value = "null";
                }
                else
                {
                    Value = value.GetValue();
                }
            }
            else if (PropertyType.IsAssignableTo(typeof(CByteArray)))
            {
                var ba = (byte[])(CByteArray)Data;
                Value = string.Join(" ", ba.Select(x => $"{x:X2}"));
            }
            else if (PropertyType.IsAssignableTo(typeof(LocalizationString)))
            {
                var value = (LocalizationString)Data;
                if (value.Value == "")
                {
                    Value = "null";
                }
                else
                {
                    Value = value.Value;
                }
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedEnum)))
            {
                var value = (IRedEnum)Data;
                Value = value.ToEnumString();
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedBitField)))
            {
                var value = (IRedBitField)Data;
                Value = value.ToBitFieldString();
            }
            else if (PropertyType.IsAssignableTo(typeof(TweakDBID)))
            {
                var value = (TweakDBID)Data;
                Value = Locator.Current.GetService<ITweakDBService>().Get(value);
            }
            else if (PropertyType.IsAssignableTo(typeof(CBool)))
            {
                var value = (CBool)Data;
                Value = value ? "True" : "False";
            }
            else if (PropertyType.IsAssignableTo(typeof(CRUID)))
            {
                var value = (CRUID)Data;
                Value = ((ulong)value).ToString();
            }
            else if (PropertyType.IsAssignableTo(typeof(CUInt64)))
            {
                var value = (CUInt64)Data;
                Value = ((ulong)value).ToString();
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedInteger)))
            {
                var value = (IRedInteger)Data;
                Value = (value switch
                {
                    CUInt8 uint64 => uint64,
                    CInt8 uint64 => uint64,
                    CInt16 uint64 => uint64,
                    CUInt16 uint64 => uint64,
                    CInt32 uint64 => uint64,
                    CUInt32 uint64 => uint64,
                    CInt64 uint64 => (float)uint64,
                    _ => throw new ArgumentOutOfRangeException(nameof(value)),
                }).ToString();
            }
            else if (PropertyType.IsAssignableTo(typeof(FixedPoint)))
            {
                var value = (FixedPoint)Data;
                Value = ((float)value).ToString("R");
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedPrimitive<float>)))
            {
                var value = (IRedPrimitive)Data;
                Value = ((float)(CFloat)value).ToString("R");
            }
            else if (PropertyType.IsAssignableTo(typeof(NodeRef)))
            {
                var value = (NodeRef)Data;
                Value = value.Text;
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedRef)))
            {
                var value = (IRedRef)Data;
                if (value != null && value.DepotPath != "")
                {
                    Value = value.DepotPath;
                }
                else
                {
                    Value = "null";
                }
            }
        }

        public void CalculateDescriptor()
        {
            Descriptor = "";
            if (PropertyType == null)
            {
                return;
            }

            if (ResolvedData is IRedArray ary)
            {
                Descriptor = $"[{ary.Count}]";
            }
            if (ResolvedData is IRedBufferPointer rbp && rbp.GetValue().Data is Package04 pkg)
            {
                Descriptor = $"[{pkg.Chunks.Count}]";
            }
            if (ResolvedData is IRedBufferPointer rbp2 && rbp2.GetValue().Data is CR2WList cl)
            {
                Descriptor = $"[{cl.Files.Count}]";
            }
            if (ResolvedData is CKeyValuePair kvp)
            {
                Descriptor = kvp.Key;
            }
            //if (ResolvedData is CMaterialInstance && Parent != null)
            //{
            //    if (Parent.Parent != null && Parent.Parent.Parent != null && Parent.Parent.Data is CMesh mesh)
            //    {
            //        Descriptor = mesh.MaterialEntries[int.Parse(Name)].Name;
            //    }
            //}
            if (Data is CMaterialInstance && Parent != null && Tab.File.Cr2wFile.RootChunk is CMesh mesh)
            {
                if (mesh.LocalMaterialBuffer.RawData.Data is CR2WList list)
                {
                    for (var i = 0; i < list.Files.Count; i++)
                    {
                        if (list.Files[i].RootChunk == Data)
                        {
                            if (mesh.MaterialEntries.Count > i)
                            {
                                Descriptor = mesh.MaterialEntries[i].Name;
                            }
                            break;
                        }
                    }
                }
            }
            if (ResolvedData is RedBaseClass irc)
            {
                // some common "names" of classes that might be useful to display in the UI
                var propNames = new string[]
                {
                    "name",
                    "partName",
                    "slotName",
                    "hudEntryName",
                    "stateName",
                    "n",
                    "componentName",
                    "parameterName",
                    "debugName",
                    "category"
                };

                foreach (var propName in propNames)
                {
                    var prop = GetPropertyByRedName(irc.GetType(), propName);
                    if (prop != null)
                    {
                        Descriptor = prop.GetValue(irc).ToString();
                    }
                }
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

        public bool CanBeDroppedOn(ChunkViewModel target) => PropertyType == target.PropertyType;

        public ICommand OpenRefCommand { get; private set; }
        private bool CanOpenRef() => Data is IRedRef r && r.DepotPath != null;
        private void ExecuteOpenRef()
        {
            if (Data is IRedRef r)
            {
                //string depotpath = r.DepotPath;
                //Tab.File.OpenRefAsTab(depotpath);
                Locator.Current.GetService<AppViewModel>().OpenFileFromDepotPath(r.DepotPath);
            }
            //var key = FNV1A64HashAlgorithm.HashString(depotpath);

            //var _gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();
            //var _archiveManager = Locator.Current.GetService<IArchiveManager>();

            //if (_archiveManager.Lookup(key).HasValue)
            //{
            //    _gameControllerFactory.GetController().AddToMod(key);
            //}
        }

        public ICommand AddRefCommand { get; private set; }
        private bool CanAddRef() => Data is IRedRef r && r.DepotPath != null;
        private void ExecuteAddRef()
        {
            if (Data is IRedRef r)
            {
                //string depotpath = r.DepotPath;
                //Tab.File.OpenRefAsTab(depotpath);
                //Locator.Current.GetService<AppViewModel>().OpenFileFromDepotPath(r.DepotPath);
                var key = r.DepotPath.GetRedHash();

                var gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();
                var archiveManager = Locator.Current.GetService<IArchiveManager>();

                if (archiveManager.Lookup(key).HasValue)
                {
                    gameControllerFactory.GetController().AddToMod(key);
                }
            }
        }


        public ICommand ForceLoadCommand { get; private set; }
        private bool CanForceLoad() => Properties is null;
        private void ExecuteForceLoad()
        {
            ForceLoadProperties = true;
            this.RaisePropertyChanged("Properties");
            if (Parent != null)
            {
                Parent.RaisePropertyChanged("Properties");
            }
        }

        public ICommand AddHandleCommand { get; private set; }
        private bool CanAddHandle() => (PropertyType?.IsAssignableTo(typeof(IRedBaseHandle)) ?? false) && Properties != null;
        private void ExecuteAddHandle()
        {
            Data = RedTypeManager.CreateRedType(PropertyType);
            if (Data is IRedBaseHandle handle)
            {
                var existing = new ObservableCollection<string>(AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => handle.InnerType.IsAssignableFrom(p) && p.IsClass).Select(x => x.Name));
                var app = Locator.Current.GetService<AppViewModel>();
                app.SetActiveDialog(new CreateClassDialogViewModel(existing, false)
                {
                    DialogHandler = HandlePointer
                });
            }
        }

        public void HandlePointer(DialogViewModel sender)
        {
            var app = Locator.Current.GetService<AppViewModel>();
            app.CloseDialogCommand.Execute(null);
            if (sender != null)
            {
                var vm = sender as CreateClassDialogViewModel;
                var instance = RedTypeManager.Create(vm.SelectedClass);
                if (Data is IRedBaseHandle handle)
                {
                    handle.SetValue(instance);
                    this.RaisePropertyChanged("Data");
                    Tab.File.SetIsDirty(true);
                }
            }
        }

        public ICommand AddItemToArrayCommand { get; private set; }
        private bool CanAddItemToArray() => Data is IRedArray && Properties != null;
        private void ExecuteAddItemToArray()
        {
            var type = (Data as IRedArray).InnerType;
            var newItem = RedTypeManager.CreateRedType(type);
            if (newItem is IRedBaseHandle handle)
            {
                var pointee = RedTypeManager.CreateRedType(handle.InnerType);
                handle.SetValue((RedBaseClass)pointee);
            }
            (Data as IRedArray).Add(newItem);
            var cvm = new ChunkViewModel(newItem, this);
            Properties.Add(cvm);
            this.RaisePropertyChanged("Data");
            cvm.IsExpanded = true;
            IsExpanded = true;
            Parent.IsExpanded = true;
            Tab.SelectedChunk = cvm;
            Tab.File.SetIsDirty(true);
        }

        public ICommand AddItemToCompiledDataCommand { get; private set; }
        private bool CanAddItemToCompiledData() => ResolvedPropertyType != null && ResolvedPropertyType.IsAssignableTo(typeof(IRedBufferPointer)) && Properties != null;
        private void ExecuteAddItemToCompiledData()
        {
            if (Data == null)
            {
                Data = RedTypeManager.CreateRedType(ResolvedPropertyType);
                (Data as IRedBufferPointer).SetValue(new RED4.RedBuffer()
                {
                    Data = new Package04()
                    {
                        Chunks = new List<RedBaseClass>()
                    }
                });
            }
            if (Data is DataBuffer db2)
            {
                if (Name == "rawData" && db2.Data is null)
                {
                    db2.Buffer = RedBuffer.CreateBuffer(0, new byte[] { 0 });
                    db2.Data = new CR2WList();
                }
            }
            var db = Data as IRedBufferPointer;
            ObservableCollection<string> existing = null;
            if (db.GetValue().Data is Package04 pkg)
            {
                existing = new ObservableCollection<string>(pkg.Chunks.Select(t => t.GetType().Name).Distinct());
            }
            var app = Locator.Current.GetService<AppViewModel>();
            app.SetActiveDialog(new CreateClassDialogViewModel(existing, true)
            {
                DialogHandler = HandleChunk
            });
        }
        public void HandleChunk(DialogViewModel sender)
        {
            var app = Locator.Current.GetService<AppViewModel>();
            app.CloseDialogCommand.Execute(null);
            if (sender != null)
            {
                var vm = sender as CreateClassDialogViewModel;
                var instance = RedTypeManager.Create(vm.SelectedClass);
                AddChunkToDataBuffer(instance, Properties.Count);
            }
        }

        private void UpdateProperties(RedBaseClass instance, int index)
        {
            var cvm = new ChunkViewModel(instance, this);
            Properties.Insert(index, cvm);
            foreach (var prop in Properties)
            {
                prop.RaisePropertyChanged("Name");
            }

            this.RaisePropertyChanged("Data");
            IsExpanded = true;
            cvm.IsExpanded = true;
            Tab.SelectedChunk = cvm;
            Tab.File.SetIsDirty(true);
        }

        public void AddChunkToDataBuffer(RedBaseClass instance, int index)
        {//engine\materials\metal_base.remt
            if (Data is IRedBufferPointer db && db.GetValue().Data is Package04 pkg)
            {
                //pkg.Chunks.Add(instance);
                pkg.Chunks.Insert(index, instance);
                //_properties.Add(new ChunkViewModel(instance, this));
                UpdateProperties(instance, index);
            }
        }

        public void AddClassToArray(RedBaseClass instance, int index)
        {
            if (Data is not IRedArray arr)
            {
                return;
            }

            var arrayType = Data.GetType().GetGenericTypeDefinition();

            if (arrayType == typeof(CArray<>))
            {
                arr.Insert(index, instance);
                UpdateProperties(instance, index);
            }

            if (arrayType == typeof(CStatic<>) && arr.Count < arr.MaxSize)
            {
                ((IRedArray)Data).Insert(index, instance);
                UpdateProperties(instance, index);
            }
            else if (Data is IRedBufferPointer db2 && db2.GetValue().Data is CR2WList list)
            {
                //pkg.Chunks.Add(instance);
                list.Files.Insert(index, new CR2WFile()
                {
                    RootChunk = instance
                });
                //_properties.Add(new ChunkViewModel(instance, this));
                var cvm = new ChunkViewModel(instance, this);
                Properties.Insert(index, cvm);
                foreach (var prop in Properties)
                {
                    prop.RaisePropertyChanged("Name");
                }

                this.RaisePropertyChanged("Data");
                IsExpanded = true;
                cvm.IsExpanded = true;
                Tab.SelectedChunk = cvm;
                Tab.File.SetIsDirty(true);
            }
        }

        public ICommand DeleteItemCommand { get; private set; }
        private bool CanDeleteItem() => IsInArray;
        private void ExecuteDeleteItem()
        {
            if (Parent.Data is IRedArray ary)
            {
                Tab.SelectedChunk = Parent;
                ary.Remove(Data);
                Parent.Properties.Remove(this);
                foreach (var prop in Parent.Properties)
                {
                    prop.RaisePropertyChanged("Name");
                }

                Tab.File.SetIsDirty(true);
            }
            if (Parent.Data is IRedBufferPointer db && db.GetValue().Data is Package04 pkg)
            {
                Tab.SelectedChunk = Parent;
                pkg.Chunks.Remove((RedBaseClass)Data);
                Parent.Properties.Remove(this);
                foreach (var prop in Parent.Properties)
                {
                    prop.RaisePropertyChanged("Name");
                }

                Tab.File.SetIsDirty(true);
            }
            if (Parent.Data is IRedBufferPointer db2 && db2.GetValue().Data is CR2WList list)
            {
                Tab.SelectedChunk = Parent;
                list.Files.RemoveAll(x => x.RootChunk == Data);
                Parent.Properties.Remove(this);
                foreach (var prop in Parent.Properties)
                {
                    prop.RaisePropertyChanged("Name");
                }

                Tab.File.SetIsDirty(true);
            }
        }

        public ICommand DeleteAllCommand { get; private set; }
        private bool CanDeleteAll() => IsArray && Properties != null && Properties.Count > 0;
        private void ExecuteDeleteAll()
        {
            if (ResolvedData is IRedArray ary)
            {
                ary.Clear();
                Properties.Clear();
                this.RaisePropertyChanged("Data");
                IsDeleteReady = false;
                Tab.File.SetIsDirty(true);
            }
            if (ResolvedData is IRedBufferPointer db && db.GetValue().Data is Package04 pkg)
            {
                pkg.Chunks.Clear();
                Properties.Clear();
                this.RaisePropertyChanged("Data");
                IsDeleteReady = false;
                Tab.File.SetIsDirty(true);
            }
            if (ResolvedData is IRedBufferPointer db2 && db2.GetValue().Data is CR2WList list)
            {
                list.Files.Clear();
                Properties.Clear();
                this.RaisePropertyChanged("Data");
                IsDeleteReady = false;
                Tab.File.SetIsDirty(true);
            }
        }

        public ICommand ExportChunkCommand { get; private set; }
        private bool CanExportChunk() => Properties.Count > 0;
        private void ExecuteExportChunk()
        {
            Stream myStream;
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 2,
                FileName = Type + ".json",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    var dto = new RedTypeDto(ResolvedData);
                    var json = RedJsonSerializer.Serialize(dto);

                    if (string.IsNullOrEmpty(json))
                    {
                        throw new SerializationException();
                    }

                    myStream.Write(json.ToCharArray().Select(c => (byte)c).ToArray());
                    myStream.Close();
                }
            }
        }

        public ICommand OpenChunkCommand { get; private set; }
        private bool CanOpenChunk() => Data is RedBaseClass && Parent != null;
        private void ExecuteOpenChunk()
        {
            if (Data is RedBaseClass cls)
            {
                Tab.File.TabItemViewModels.Add(new RDTDataViewModel(cls, Tab.File));
            }
        }
    }
}
