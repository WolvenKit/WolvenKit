using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData.Binding;
using Microsoft.Win32;
using ReactiveUI;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Documents;
using YamlDotNet.Serialization;
using static WolvenKit.RED4.Types.RedReflection;
using static WolvenKit.ViewModels.Dialogs.DialogViewModel;
using IRedString = WolvenKit.RED4.Types.IRedString;
using System.Text.Json;
using WolvenKit.Common;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;

using Mat4 = System.Numerics.Matrix4x4;
using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;
using WolvenKit.Core.Interfaces;
using WolvenKit.App.Models;

namespace WolvenKit.ViewModels.Shell
{
    public partial class ChunkViewModel : ObservableObject, ISelectableTreeViewItemModel, Functionality.Interfaces.INode<ReferenceSocket>
    {
        private readonly ILoggerService _loggerService;
        private static readonly List<string> s_hiddenProperties = new() { "meshMeshMaterialBuffer.rawDataHeaders", "meshMeshMaterialBuffer.rawData", "entEntityTemplate.compiledData", "appearanceAppearanceDefinition.compiledData" };

        private bool _propertiesLoaded;

        private const BindingFlags s_defaultLookup = BindingFlags.Instance | BindingFlags.Public;

        private readonly RDTDataViewModel? _tab;

        private Flags? _flags;

        private int _propertyCountCache = -1;

        #region Constructors

        public ChunkViewModel(IRedType data, string name, ChunkViewModel? parent = null, bool isReadOnly = false)
        {
            _loggerService = Locator.Current.GetService<ILoggerService>().NotNull();

            _data = data;
            Parent = parent;
            _propertyName = name;
            IsReadOnly = isReadOnly;
            SelfList = new ObservableCollectionExtended<ChunkViewModel>(new[] { this });

            if (HasChildren())
            {
                TempList = new ObservableCollectionExtended<ChunkViewModel>(new[] { new ChunkViewModel(new RedDummy(), nameof(RedDummy), this) });
            }


            this.WhenAnyValue(x => x.IsSelected)
                .Where(x => IsSelected && !_propertiesLoaded)
                .Subscribe(x => CalculateProperties());

            this.WhenAnyValue(x => x.IsExpanded)
                .Where(x => IsExpanded && !_propertiesLoaded)
                .Subscribe(x => CalculateProperties());

            CalculateValue();
            CalculateDescriptor();
            CalculateIsDefault();

            this.WhenAnyValue(x => x.Data).Skip(1)
                .Subscribe((_) =>
                {
                    CalculateValue();
                    CalculateDescriptor();
                    CalculateIsDefault();

                    if (Parent is not null)
                    {
                        if (Tab is not null)
                        {
                            if (Parent.Data is IRedArray arr)
                            {
                                var index = int.Parse(Name);
                                if (index != -1)
                                {
                                    arr[index] = Data;
                                    Tab.File.SetIsDirty(true);
                                    Parent.NotifyChain("Data");
                                }
                            }

                            var parentData = Parent.Data;
                            
                            if (Parent.Data is IRedBaseHandle handle)
                            {
                                parentData = handle.GetValue();
                            }
                            else if (Parent.Data is CVariant cVariant)
                            {
                                parentData = cVariant.Value;
                            }
                            else if (parentData is RedBaseClass rbc)
                            {
                                //if (rbc.HasProperty(propertyName) && rbc.GetProperty(propertyName) != Data)
                                //{
                                rbc.SetProperty(_propertyName, Data);
                                Tab.File.SetIsDirty(true);
                                Parent.NotifyChain("Data");
                                //}
                            }
                            else
                            {
                                var pi = parentData?.GetType().GetProperty(_propertyName);
                                if (pi is not null)
                                {
                                    if (pi.CanWrite)
                                    {
                                        pi.SetValue(parentData, Data);
                                    }
                                    else
                                    {
                                        Parent.Data = parentData is IRedRef ? RedTypeManager.CreateRedType(parentData.RedType, Data) : throw new Exception();
                                    }
                                    Tab.File.SetIsDirty(true);
                                    Parent.NotifyChain("Data");
                                }
                            }
                        }

                        Parent.CalculateDescriptor();

                        if (Parent.Data is CMeshMaterialEntry meshMaterialEntry && meshMaterialEntry.IsLocalInstance)
                        {
                            var materials = GetRootModel().GetModelFromPath("localMaterialBuffer.materials");
                            if (materials != null && materials.Properties.Count > meshMaterialEntry.Index)
                            {
                                materials.Properties[meshMaterialEntry.Index].CalculateDescriptor();
                            }

                            var preload = GetRootModel().GetModelFromPath("preloadLocalMaterialInstances");
                            if (preload != null && preload.Properties.Count > meshMaterialEntry.Index)
                            {
                                preload.Properties[meshMaterialEntry.Index].CalculateDescriptor();
                            }
                        }
                    }
                });

        }

        public ChunkViewModel(IRedType data, RDTDataViewModel tab) : this(data, nameof(RDTDataViewModel))
        {
            _tab = tab;
            RelativePath = _tab.File.RelativePath;
            IsExpanded = true;
            //Data = export;
            //if (!PropertiesLoaded)
            //{
            //CalculateProperties();
            //}
            //TVProperties.AddRange(Properties);
            //this.RaisePropertyChanged("Data");

            this.WhenAnyValue(x => x.Data).Skip(1).Subscribe((x) => Tab?.File.SetIsDirty(true));
        }

        public ChunkViewModel(IRedType export, ReferenceSocket socket) : this(export, nameof(ReferenceSocket))
        {
            Socket = socket;
            socket.Node = this;
            RelativePath = socket.File;
        }

        #endregion Constructors

        #region Properties

        public ObservableCollectionExtended<ChunkViewModel> Properties { get; } = new();

        public ObservableCollectionExtended<ChunkViewModel> SelfList { get; set; } = new();

        public ObservableCollectionExtended<ChunkViewModel> TempList { get; set; } = new();

        public ObservableCollectionExtended<ChunkViewModel> TVProperties => _propertiesLoaded ? Properties : TempList;

        public ObservableCollectionExtended<ChunkViewModel> DisplayProperties => MightHaveChildren() ? Properties : SelfList;

        [ObservableProperty] private string? _value;

        [ObservableProperty] private string? _descriptor;

        [ObservableProperty] private bool _isDefault;

        [ObservableProperty] private bool _isReadOnly;

        [ObservableProperty] private IRedType _data;

        [ObservableProperty] private CName _relativePath;

        [ObservableProperty] private bool _isSelected;

        [ObservableProperty] private bool _isDeleteReady;

        [ObservableProperty] private bool _isExpanded;

        [ObservableProperty] private bool _isHandled;

        [ObservableProperty] private string _propertyName;

        [ObservableProperty] private ReferenceSocket? _socket;

        [ObservableProperty] private IList<ReferenceSocket> _outputs = new ObservableCollection<ReferenceSocket>();

        [ObservableProperty] private System.Windows.Point _location;

        public bool ShouldShowWorldNodeDataImport => Data is worldNodeData;

        public bool ShouldShowExportNodeData => Parent is not null && Parent.Data is DataBuffer rb && rb.Data is worldNodeDataBuffer;

        public bool ShouldShowCopyPasteHandle => Data is IRedBaseHandle;

        public bool ShouldShowArrayOps => IsInArray || IsArray;

        public IRedArray? ArraySelfOrParent => Parent?.ResolvedData is IRedArray ira ? ira : ResolvedData as IRedArray;

        public RDTDataViewModel? Tab => _tab ?? Parent?.Tab;

        public IRedType ResolvedData
        {
            get
            {
                //if (_resolvedDataCache == null)
                //{
                var data = Data;
                if (Data is IRedBaseHandle handle)
                {
                    data = handle.GetValue();
                }
                else if (Data is CVariant v)
                {
                    data = v.Value;
                }
                else if (Data is TweakDBID tdb && _propertiesLoaded)
                {
                    data = Locator.Current.GetService<TweakDBService>().NotNull().GetFlat(tdb);
                    data ??= Locator.Current.GetService<TweakDBService>().NotNull().GetRecord(tdb);
                }
                else if (Data is DataBuffer db && db.Buffer.Data is IRedType irt)
                {
                    data = irt;
                }

                //_resolvedDataCache = data;
                //this.RaisePropertyChanged("ResolvedData");
                //}

                //return _resolvedDataCache.NotNull();
                return data;
            }
        }

        public ChunkViewModel? Parent { get; set; }

        public string Name
        {
            get
            {
                if (IsInArray && Parent is not null)
                {
                    return Parent.GetIndexOf(this).ToString().NotNull();
                }
                else if (Data is IBrowsableType ibt)
                {
                    return ibt.GetBrowsableName();
                }
                else if (Data is RedDummy dummy)
                {
                    return nameof(RedDummy);
                }
                else
                {
                    return PropertyName;
                }
            }
        }

        public int Level => Parent == null ? 0 : Parent.Level + 1;

        public int DetailsLevel => (IsSelected || Parent == null) ? 0 : Parent.DetailsLevel + 1;

        public Type? PropertyType
        {
            get
            {
                var type = Data?.GetType();
                if (Parent is not null)
                {
                    //var parent = Parent.Data;
                    var parentType = Parent.ResolvedPropertyType;
                    // handles aren't the true parent type of these props, so need to get that
                    //if (Parent.Data is IRedBaseHandle handle && handle is not null)
                    //{
                    //    parent = handle.GetValue();
                    //    parentType = handle.GetValue().GetType();
                    //}
                    var propInfo = GetPropertyByRedName(parentType, PropertyName) ?? null;
                    if (propInfo is not null)
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

        public Type? ResolvedPropertyType
        {
            get
            {
                if (Data is IRedBaseHandle handle)
                {
                    return handle.GetValue().GetType() ?? handle.InnerType;
                }
                if (Data is CVariant v)
                {
                    return v.Value.GetType() ?? null;
                }
                if (Data is TweakDBID tdb)
                {
                    var type = Locator.Current.GetService<TweakDBService>().NotNull().GetType(tdb);
                    if (type is not null)
                    {
                        return type;
                    }
                }
                if (Data is ITweakXLItem iti)
                {
                    var type = Locator.Current.GetService<TweakDBService>().NotNull().GetType(iti.ID);
                    if (type is not null)
                    {
                        return type;
                    }
                }
                if (Data is IRedString str)
                {
                    var s = str.GetString();
                    if (s is not null && s.StartsWith("LocKey#") && ulong.TryParse(s[7..], out var _))
                    {
                        return typeof(localizationPersistenceOnScreenEntry);
                    }
                }
                if (Data is DataBuffer db && db.Data is not null)
                {
                    return db.Data.GetType();
                }
                if (Data is SharedDataBuffer sdb && sdb.Data is not null)
                {
                    return sdb.Data.GetType();
                }
                if (Data is SerializationDeferredDataBuffer sddb && sddb.Data is not null)
                {
                    return sddb.Data.GetType();
                }
                if (Data is gamedataLocKeyWrapper)
                {
                    return typeof(localizationPersistenceOnScreenEntry);
                }
                //if (Data is IBrowsableType ibt && ibt.GetBrowsableType() is var browsableType && browsableType is not null)
                //{
                //    return browsableType;
                //}
                return PropertyType;
            }
        }

        public string Type
        {
            get
            {
                if (PropertyType is not null)
                {
                    var redName = GetRedTypeFromCSType(PropertyType, _flags);
                    return redName != "" ? redName : PropertyType.Name;
                }
                return "null";
            }
        }

        public string ResolvedType => ResolvedPropertyType is not null ? (GetTypeRedName(ResolvedPropertyType) ?? ResolvedPropertyType.Name) : "";

        public bool TypesDiffer => PropertyType != ResolvedPropertyType;

        public bool IsInArray => Parent is not null && Parent.IsArray;

        public bool IsArray => PropertyType is not null &&
                    (PropertyType.IsAssignableTo(typeof(IRedArray)) ||
                    (ResolvedPropertyType is not null && ResolvedPropertyType.IsAssignableTo(typeof(IList))) ||
                    (ResolvedPropertyType is not null && ResolvedPropertyType.IsAssignableTo(typeof(CR2WList))) ||
                    (ResolvedPropertyType is not null && ResolvedPropertyType.IsAssignableTo(typeof(RedPackage))));


        public int PropertyCount
        {
            get
            {
                if (_propertyCountCache == -1)
                {
                    var count = 0;
                    if (ResolvedData is IRedArray ary)
                    {
                        count += ary.Count;
                    }
                    else if (ResolvedData is IRedRef)
                    {
                        // ignore
                    }
                    else if (ResolvedData is CKeyValuePair)
                    {
                        count += 2;
                    }
                    else if (ResolvedData is inkWidgetReference)
                    {
                        count += 1; // TODO
                    }
                    else if (Data is TweakDBID tdb)
                    {
                        // not actual
                        if (Locator.Current.GetService<TweakDBService>().NotNull().Exists(tdb))
                        {
                            count += 1;
                        }
                    }
                    else if (ResolvedData is IRedString str)
                    {
                        var s = str.GetString();
                        if (s is not null && s.StartsWith("LocKey#") && ulong.TryParse(s[7..], out var locKey))
                        {
                            // not actual
                            count += 1;
                        }
                    }
                    else if (ResolvedData is gamedataLocKeyWrapper locKey)
                    {
                        // not actual
                        count += 1;
                    }
                    else if (ResolvedData is RedBaseClass redClass)
                    {
                        var pis = GetTypeInfo(redClass).PropertyInfos;
                        count += pis.Count;

                        var dps = redClass.GetDynamicPropertyNames();
                        count += dps.Count;
                    }
                    else if (ResolvedData is SerializationDeferredDataBuffer sddb)
                    {
                        if (sddb.Data is RedPackage p4)
                        {
                            count += p4.Chunks.Count;
                        }
                        else if (sddb.Data is not null)
                        {
                            count += sddb.Data.GetType().GetProperties(s_defaultLookup).Count();
                        }
                    }
                    else if (ResolvedData is SharedDataBuffer sdb)
                    {
                        if (sdb.Data is RedPackage p42)
                        {
                            count += p42.Chunks.Count;
                        }
                        if (sdb.File is CR2WFile)
                        {
                            count += 1;
                        }
                        if (sdb.Data is not null)
                        {
                            count += 1;  // needs refinement?
                        }
                    }
                    else if (ResolvedData is DataBuffer db)
                    {
                        if (db.Data is RedPackage p43)
                        {
                            count += p43.Chunks.Count;
                        }
                        else if (db.Data is CR2WList cl)
                        {
                            count += cl.Files.Count;
                        }
                        else if (db.Data is IList list)
                        {
                            count += list.Count;
                        }
                        else if (db.Data is not null)
                        {
                            count += 1; // needs refinement?
                        }
                    }
                    else if (ResolvedData is not null)
                    {
                        if (Data is IBrowsableDictionary ibd)
                        {
                            var pns = ibd.GetPropertyNames();
                            count += pns.Count();
                        }
                        else if (Data is IList list)
                        {
                            count += list.Count;
                        }
                        else if (Data is Dictionary<string, object> dict)
                        {
                            count += dict.Count;
                        }
                        else if (Data is not null)
                        {
                            var pis = Data.GetType().GetProperties(s_defaultLookup);
                            count += pis.Length;
                        }
                        if (Data is worldNodeData)
                        {
                            count += 1;
                        }
                    }
                    _propertyCountCache = count;
                    //this.RaisePropertyChanged("PropertyCount");
                }
                return _propertyCountCache;
            }
            set
            {
                _propertyCountCache = -1;
                this.OnPropertyChanged(nameof(PropertyCount));
            }
        }

        public int ArrayIndexWidth
        {
            get
            {
                var width = 0;
                if (Parent is not null)
                {
                    //if (Parent.ResolvedData is IRedArray ary)
                    //{
                    //    width += 20;
                    //}
                    if (Parent.PropertyCount <= 10)
                    {
                        width += 16;
                    }
                    else if (Parent.PropertyCount <= 100)
                    {
                        width += 21;
                    }
                    else if (Parent.PropertyCount <= 1000)
                    {
                        width += 26;
                    }
                    else if (Parent.PropertyCount <= 10000)
                    {
                        width += 31;
                    }
                    else
                    {
                        width += 36;
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
                if (PropertyType.IsAssignableTo(typeof(IRedString)))
                {
                    return "SymbolString";
                }
                return PropertyType.IsAssignableTo(typeof(IRedArray))
                    ? "SymbolArray"
                    : PropertyType.IsAssignableTo(typeof(IRedEnum))
                    ? "SymbolEnum"
                    : PropertyType.IsAssignableTo(typeof(IRedRef))
                    ? "FileSymlinkFile"
                    : PropertyType.IsAssignableTo(typeof(IRedBitField))
                    ? "SymbolEnum"
                    : PropertyType.IsAssignableTo(typeof(CBool))
                    ? "SymbolBoolean"
                    : PropertyType.IsAssignableTo(typeof(IRedBaseHandle))
                    ? "References"
                    : PropertyType.IsAssignableTo(typeof(DataBuffer)) || PropertyType.IsAssignableTo(typeof(SerializationDeferredDataBuffer))
                    ? "GroupByRefType"
                    : PropertyType.IsAssignableTo(typeof(CResourceAsyncReference<>)) || PropertyType.IsAssignableTo(typeof(CResourceReference<>))
                    ? "RepoPull"
                    : PropertyType.IsAssignableTo(typeof(TweakDBID))
                    ? "DebugBreakpointConditionalUnverified"
                    : PropertyType.IsAssignableTo(typeof(IRedPrimitive))
                    ? "DebugBreakpointDataUnverified"
                    : PropertyType.IsAssignableTo(typeof(WorldTransform))
                    ? "Compass"
                    : PropertyType.IsAssignableTo(typeof(WorldPosition))
                    ? "Move"
                    : PropertyType.IsAssignableTo(typeof(Quaternion))
                    ? "IssueReopened"
                    : PropertyType.IsAssignableTo(typeof(CColor)) ? "SymbolColor" : "SymbolClass";
            }
        }

        #endregion Properties

        #region commands

        [RelayCommand]
        private void CreateTXLOverride()
        {
            var recordName = Name;
            IRedType? tdbEntry = null;
            var tdbs = Locator.Current.GetService<TweakDBService>().NotNull();

            var txl = new TweakXL();

            switch (Parent?.Data)
            {
                case gamedataTweakDBRecord tweakDBRecord:
                    recordName = $"{Parent.Name}.{Name}";
                    break;
                case TweakDBID tweakDBID:
                    recordName = $"{tweakDBID.ResolvedText}.{Name}";
                    break;
                case IRedArray:
                    break;
                case null:
                    break;
                default:
                    throw new NotImplementedException("Unknown parent type found for TweakXL override.");
            }

            switch (Data)
            {
                case gamedataTweakDBRecord tweakDBRecord:
                    tdbEntry = tweakDBRecord;
                    txl.ID = recordName;
                    txl.Type = tweakDBRecord.GetType().Name;
                    break;
                case TweakDBID tweakDBID:
                    tdbEntry = tdbs.GetFlat(tweakDBID);
                    tdbEntry ??= tdbs.GetRecord(tweakDBID);
                    txl.ID = tweakDBID;
                    txl.Type = tdbs.GetType(tweakDBID).Name;
                    break;
                case IRedType redType:
                    tdbEntry = Data;
                    txl.ID = recordName;
                    txl.Value = redType;
                    break;
                default:
                    throw new NotImplementedException("Unknown record type found for TweakXL override.");
            }

            // if a record was found, parse its data
            if (tdbEntry is gamedataTweakDBRecord)
            {
                ((gamedataTweakDBRecord)tdbEntry).GetPropertyNames().ForEach(name => txl.Properties.Add(name, ((gamedataTweakDBRecord)tdbEntry).GetProperty(name)));
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "YAML files (*.yaml; *.yml)|*.yaml;*.yml|All files (*.*)|*.*",
                FilterIndex = 1,
                FileName = $"{txl.ID.ResolvedText}.yaml",
                InitialDirectory = Locator.Current.GetService<IProjectManager>().NotNull().ActiveProject?.ResourcesDirectory
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    using var stream = saveFileDialog.OpenFile();
                    var serializer = new SerializerBuilder()
                        .WithTypeConverter(new TweakXLYamlTypeConverter())
                        .WithIndentedSequences()
                        .Build();

                    var yaml = serializer.Serialize(new TweakXLFile { txl });
                    stream.Write(yaml.ToCharArray().Select(c => (byte)c).ToArray());

                    _loggerService.Success($"TweakXL YAML written for {recordName}.");
                }
                catch (Exception ex)
                {
                    _loggerService.Error(ex);
                }
            }
        }

        public bool CanBeDroppedOn(ChunkViewModel target) => PropertyType == target.PropertyType;

        private bool CanOpenRef() => Data is IRedRef r && r.DepotPath != CName.Empty;
        [RelayCommand(CanExecute =nameof(CanOpenRef))]
        private void OpenRef()
        {
            if (Data is IRedRef r)
            {
                //string depotpath = r.DepotPath;
                //Tab.File.OpenRefAsTab(depotpath);
                Locator.Current.GetService<AppViewModel>().NotNull().OpenFileFromHash(r.DepotPath.GetRedHash());
            }
            //var key = FNV1A64HashAlgorithm.HashString(depotpath);

            //var _gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();
            //var _archiveManager = Locator.Current.GetService<IArchiveManager>();

            //if (_archiveManager.Lookup(key).HasValue)
            //{
            //    _gameControllerFactory.GetController().AddToMod(key);
            //}
        }

        private bool CanAddRef() => Data is IRedRef r && r.DepotPath != CName.Empty;
        [RelayCommand(CanExecute = nameof(CanAddRef))]
        private async Task AddRef()
        {
            if (Data is IRedRef r)
            {
                //string depotpath = r.DepotPath;
                //Tab.File.OpenRefAsTab(depotpath);
                //Locator.Current.GetService<AppViewModel>().OpenFileFromDepotPath(r.DepotPath);
                var key = r.DepotPath.GetRedHash();
                var gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>().NotNull();
                await gameControllerFactory.GetController().AddFileToModModal(key);
            }
        }

        private bool CanAddHandle() => PropertyType?.IsAssignableTo(typeof(IRedBaseHandle)) ?? false;
        [RelayCommand(CanExecute = nameof(CanAddHandle))]
        private void AddHandle()
        {
            var data = RedTypeManager.CreateRedType(PropertyType);
            if (data is IRedBaseHandle handle)
            {
                var existing = new ObservableCollection<string>(AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => handle.InnerType.IsAssignableFrom(p) && p.IsClass).Select(x => x.Name));
                var app = Locator.Current.GetService<AppViewModel>().NotNull();
                app.SetActiveDialog(new CreateClassDialogViewModel(existing, false)
                {
                    DialogHandler = HandlePointer
                });
            }
        }

        private bool CanAddItemToArray() => Parent is not null && !IsReadOnly && PropertyType is not null && (PropertyType.IsAssignableTo(typeof(IRedArray)) || PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)));
        [RelayCommand(CanExecute = nameof(CanAddItemToArray))]
        private void AddItemToArray()
        {
            ArgumentNullException.ThrowIfNull(Parent);
            ArgumentNullException.ThrowIfNull(PropertyType);

            if (PropertyType.IsAssignableTo(typeof(IRedArray)))
            {
                if (Data == null)
                {
                    var typeInfo = GetTypeInfo(Parent.ResolvedData);
                    var propertyInfo = typeInfo.GetPropertyInfoByName(Name);

                    if (propertyInfo.Flags.Equals(Flags.Empty))
                    {
                        if (System.Activator.CreateInstance(propertyInfo.Type) is IRedType o)
                        {
                            Data = o;
                        }
                    }
                    else
                    {
                        var flags = propertyInfo.Flags.NotNull();
                        if (System.Activator.CreateInstance(propertyInfo.Type, flags.MoveNext() ? flags.Current : 0) is IRedType o)
                        {
                            Data = o;
                        }
                    }
                }

                if (Data is IRedArray arr)
                {
                    var innerType = arr.InnerType;
                    if (innerType.IsValueType)
                    {
                        InsertChild(-1, RedTypeManager.CreateRedType(innerType));
                        return;
                    }
                    DialogHandlerDelegate handler = HandleChunk;
                    if (innerType.IsAssignableTo(typeof(IRedBaseHandle)))
                    {
                        handler = HandleChunkPointer;
                        innerType = innerType.GenericTypeArguments[0];
                    }
                    else if (innerType.IsGenericType) // handles CResoruceReference<>, etc
                    {
                        innerType = innerType.GetGenericTypeDefinition();
                    }

                    var existing = new ObservableCollection<string>(AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => innerType.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract)
                        .Select(x => x.Name));

                    // no inheritable
                    if (existing.Count == 1)
                    {
                        var type = arr.InnerType;
                        if (type == typeof(CKeyValuePair))
                        {
                            var app = Locator.Current.GetService<AppViewModel>().NotNull();
                            app.SetActiveDialog(new SelectRedTypeDialogViewModel
                            {
                                DialogHandler = HandleCKeyValuePair
                            });

                            return;
                        }

                        var newItem = RedTypeManager.CreateRedType(type);
                        if (newItem is IRedBaseHandle handle)
                        {
                            var pointee = RedTypeManager.CreateRedType(handle.InnerType);
                            handle.SetValue((RedBaseClass)pointee);
                        }
                        InsertChild(-1, newItem);
                    }
                    else
                    {
                        var app = Locator.Current.GetService<AppViewModel>().NotNull();
                        app.SetActiveDialog(new CreateClassDialogViewModel(existing, true)
                        {
                            DialogHandler = handler
                        });
                    }
                }
            }

            if (PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)))
            {
                Data ??= RedTypeManager.CreateRedType(PropertyType);

                var curve = (IRedLegacySingleChannelCurve)Data;

                var type = curve.ElementType;
                var newItem = RedTypeManager.CreateRedType(type);
                InsertChild(-1, newItem);
            }
        }

        private bool CanSaveBufferToDisk() => Data is IRedBufferWrapper { Buffer.MemSize: > 0 };
        [RelayCommand(CanExecute = nameof(CanSaveBufferToDisk))]
        private void SaveBufferToDisk()
        {
            if (Data is not IRedBufferWrapper { Buffer.MemSize: > 0 } buffer)
            {
                throw new Exception();
            }

            var dlg = new SaveFileDialog
            {
                FileName = "buffer.bin",
                Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*"
            };
            if (dlg.ShowDialog() == true)
            {
                File.WriteAllBytes(dlg.FileName, buffer.Buffer.GetBytes());
            }
        }

        private bool CanLoadBufferFromDisk() => PropertyType != null && PropertyType.IsAssignableTo(typeof(IRedBufferWrapper));
        [RelayCommand(CanExecute = nameof(CanLoadBufferFromDisk))]
        private void LoadBufferFromDisk()
        {
            var dlg = new OpenFileDialog()
            {
                FileName = "buffer.bin",
                Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*"
            };
            if (dlg.ShowDialog() != true)
            {
                return;
            }

            if (Data is null)
            {
                if (PropertyType == typeof(DataBuffer))
                {
                    Data = new DataBuffer();
                }

                if (PropertyType == typeof(SharedDataBuffer))
                {
                    Data = new SharedDataBuffer();
                }

                if (PropertyType == typeof(SerializationDeferredDataBuffer))
                {
                    Data = new SerializationDeferredDataBuffer();
                }
            }

            ((IRedBufferWrapper)Data!).Buffer.SetBytes(File.ReadAllBytes(dlg.FileName));

            Tab?.File.SetIsDirty(true);
        }

        private bool CanRegenerateAppearanceVisualController() => Name == "components" && Data is CArray<entIComponent>;
        [RelayCommand(CanExecute = nameof(CanRegenerateAppearanceVisualController))]
        private void RegenerateAppearanceVisualController()
        {
            if (Data is not CArray<entIComponent> arr)
            {
                throw new Exception();
            }

            entVisualControllerComponent? vc = null;
            var list = new CArray<entVisualControllerDependency>();

            foreach (var component in arr)
            {
                if (component is entMeshComponent c1)
                {
                    list.Add(new entVisualControllerDependency()
                    {
                        AppearanceName = c1.MeshAppearance,
                        ComponentName = c1.Name,
                        Mesh = c1.Mesh
                    });
                }

                if (component is entSkinnedMeshComponent c2)
                {
                    list.Add(new entVisualControllerDependency()
                    {
                        AppearanceName = c2.MeshAppearance,
                        ComponentName = c2.Name,
                        Mesh = c2.Mesh
                    });
                }

                if (component is entVisualControllerComponent c3)
                {
                    vc = c3;
                }
            }

            if (vc != null)
            {
                vc.AppearanceDependency = list;
                RecalculateProperties();
            }
        }

        private bool CanAddItemToCompiledData() => ResolvedPropertyType is not null && PropertyType is not null && PropertyType.IsAssignableTo(typeof(IRedBufferPointer));
        [RelayCommand(CanExecute = nameof(CanAddItemToCompiledData))]
        private void AddItemToCompiledData()
        {
            if (Data == null)
            {
                Data = RedTypeManager.CreateRedType(ResolvedPropertyType);
                if (Data is IRedBufferPointer ptr)
                {
                    ptr.SetValue(new RedBuffer()
                    {
                        Data = new RedPackage()
                        {
                            Chunks = new List<RedBaseClass>()
                        }
                    });
                }

            }
            if (Data is DataBuffer db2)
            {
                if (Name == "rawData" && db2.Data is null)
                {
                    db2.Buffer = RedBuffer.CreateBuffer(0, new byte[] { 0 });
                    db2.Data = new CR2WList();
                }
            }


            if (Data is IRedBufferPointer db)
            {
                ObservableCollection<string> existing = new();
                if (db.GetValue().Data is worldNodeDataBuffer worldNodeDataBuffer)
                {
                    worldNodeDataBuffer.Add(new worldNodeData());
                    RecalculateProperties(worldNodeDataBuffer);
                    return;
                }
                if (db.GetValue().Data is RedPackage pkg)
                {
                    existing = new ObservableCollection<string>(pkg.Chunks.Select(t => t.GetType().Name).Distinct());
                }
                var app = Locator.Current.GetService<AppViewModel>().NotNull();
                app.SetActiveDialog(new CreateClassDialogViewModel(existing, true)
                {
                    DialogHandler = HandleChunk
                });
            }
        }

        private bool CanDeleteItem() => !IsReadOnly && IsInArray && Tab is not null && Data is not null;
        [RelayCommand(CanExecute = nameof(CanDeleteItem))]
        private void DeleteItem()
        {
            if (Parent is null)
            {
                return;
            }

            ArgumentNullException.ThrowIfNull(Tab);
            ArgumentNullException.ThrowIfNull(Data);

            try
            {
                Tab.SelectedChunk = Parent;
                if (Parent.Data is IRedArray ary)
                {
                    ary.Remove(Data);
                }
                else if (Parent.Data is IRedLegacySingleChannelCurve curve)
                {
                    curve.Remove((IRedCurvePoint)Data);
                    if (curve.Count == 0)
                    {
                        //Parent.ResolvedData = null;
                        //Parent.Data = null; // TODO ???
                    }
                }
                else if (Parent.Data is IRedBufferPointer db && db.GetValue().Data is RedPackage pkg)
                {
                    if (!pkg.Chunks.Remove((RedBaseClass)Data))
                    {
                        _loggerService.Error("Unable to delete chunk");
                        return;
                    }
                }
                else if (Parent.Data is IRedBufferPointer db2 && db2.GetValue().Data is CR2WList list)
                {
                    list.Files.RemoveAll(x => x.RootChunk == Data);
                }
                else if (Parent.Data is IRedBufferPointer db3 && db3.GetValue().Data is worldNodeDataBuffer dict)
                {
                    dict.Remove((worldNodeData)Data);
                    //dict.RemoveAt(((worldNodeData)Data).NodeIndex);
                }
                else
                {
                    _loggerService.Error("Unknown collection - unable to delete chunk");
                    return;
                }

                Tab.File.SetIsDirty(true);
                Parent.RecalculateProperties();
            }
            catch (Exception ex) { _loggerService.Error(ex); }
        }

        private bool CanImportWorldNodeData() => Data is worldNodeData && PropertyCount > 0;
        [RelayCommand(CanExecute = nameof(CanImportWorldNodeData))]
        private Task ImportWorldNodeDataTask() => ImportWorldNodeDataTask(true);
        
        [RelayCommand(CanExecute = nameof(CanImportWorldNodeData))]
        private Task ImportWorldNodeDataWithoutCoordsTask() => ImportWorldNodeDataTask(false);

        private bool CanDeleteSelection() => IsInArray && Tab is not null && Parent is not null;
        [RelayCommand(CanExecute = nameof(CanDeleteSelection))]
        private void DeleteSelection()
        {
            ArgumentNullException.ThrowIfNull(Parent);
            ArgumentNullException.ThrowIfNull(Tab);
            //var selection = Parent.DisplayProperties
            //                .Where(_ => _.IsSelected)
            //                .Select(_ => _.Data)
            //                .ToList();

            var ts = Parent.DisplayProperties
                            .Where(_ => _.IsSelected)
                            .Select(_ => _)
                            .ToList();

            try
            {
                if (Parent.Data is IRedBufferPointer db3 && db3.GetValue().Data is IRedArray dict)
                {
                    //var indices = selection.Select(_ => (int)((worldNodeData)_).NodeIndex).ToList();
                    var indices = ts.Select(_ => _.Name).ToList().ConvertAll(int.Parse);
                    if (indices.Count == 0)
                    {
                        _loggerService.Warning("Please select something first");
                    }
                    else
                    {
                        var (start, end) = (indices.Min(), indices.Max());

                        var fullselection = Parent.DisplayProperties
                            .Where(_ => Enumerable.Range(start, end - start + 1).Contains(int.Parse(_.Name)))
                            .Where(x => x.Data is not null)
                            .Select(_ => _.Data.NotNull())
                            .ToList();

                        DeleteFullSelection(fullselection, dict);
                    }
                }
                else if (Parent.Data is IRedArray db4)
                {
                    var indices = ts.Select(_ => int.Parse(_.Name)).ToList();
                    var (start, end) = (indices.Min(), indices.Max());

                    var fullselection = Parent.DisplayProperties
                        .Where(_ => Enumerable.Range(start, end - start + 1).Contains(int.Parse(_.Name)))
                        .Where(x => x.Data is not null)
                        .Select(_ => _.Data.NotNull())
                        .ToList();

                    DeleteFullSelection(fullselection, db4);
                }
                else if (Parent.Data is null)
                {
                    _loggerService.Warning($"Parent.Data is null");
                }
                else
                {
                    _loggerService.Warning($"Unsupported type : {Parent.Data.NotNull().GetType().Name}");
                }
            }
            catch (Exception ex)
            {
                _loggerService.Warning($"Something went wrong while trying to delete the selection : {ex}");
            }

            Tab.SelectedChunk = Parent;
        }

        private bool CanExportNodeData() => IsInArray && Parent?.Data is DataBuffer rb && Parent?.Parent?.Data is worldStreamingSector && rb.Data is worldNodeDataBuffer;
        [RelayCommand(CanExecute = nameof(CanExportNodeData))]
        private void ExportNodeData()
        {
            try
            {
                if (Parent?.Data is DataBuffer rb && Parent?.Parent?.Data is worldStreamingSector && rb.Data is worldNodeDataBuffer wndb)
                {
                    WriteObjectToJSON(wndb.ToList());
                }
            }
            catch (Exception ex)
            {
                _loggerService.Error(ex);
            }
        }

        private bool CanExportChunk() => PropertyCount > 0;
        [RelayCommand(CanExecute = nameof(CanExportChunk))]
        private void ExportChunk()
        {
            var filename = XPath;
            if (!string.IsNullOrEmpty(Descriptor) && Descriptor != "root")
            {
                filename = Descriptor;
            }
            Stream myStream;
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 2,
                FileName = filename + ".json",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                if ((myStream = saveFileDialog.OpenFile()) is not null)
                {
                    var json = RedJsonSerializer.Serialize(ResolvedData);

                    if (string.IsNullOrEmpty(json))
                    {
                        throw new SerializationException();
                    }

                    myStream.Write(json.ToCharArray().Select(c => (byte)c).ToArray());
                    myStream.Close();

                    _loggerService.Success($"{ResolvedType} written to: {saveFileDialog.FileName}");
                }
                else
                {
                    _loggerService.Error($"Could not open file: {saveFileDialog.FileName}");
                }
            }
        }

        private bool CanOpenChunk() => Data is RedBaseClass && Parent is not null && Tab is not null;
        [RelayCommand(CanExecute = nameof(CanOpenChunk))]
        private void OpenChunk()
        {
            ArgumentNullException.ThrowIfNull(Tab);
            if (Data is RedBaseClass cls)
            {
                Tab.File.TabItemViewModels.Add(new RDTDataViewModel(cls, Tab.File));
            }
        }

        private bool CanCopyHandle() => Data is IRedBaseHandle;
        [RelayCommand(CanExecute = nameof(CanCopyHandle))]
        private void CopyHandle()
        {
            try
            {
                if (Data is IRedBaseHandle irbh)
                {
                    RedDocumentTabViewModel.CopiedChunk = irbh;
                }
            }
            catch (Exception ex) { _loggerService.Error(ex); }

        }

        private bool CanPasteHandle()
        {
            if (RedDocumentTabViewModel.CopiedChunk is IRedBaseHandle sourceHandle)
            {
                if (Parent is { Data: worldNodeData })
                {
                    return false;
                }

                if (Data is IRedBaseHandle destinationHandle)
                {
                    return destinationHandle.InnerType.IsAssignableFrom(sourceHandle.GetValue().GetType());
                }
            }
            return false;
        }
        [RelayCommand(CanExecute = nameof(CanPasteHandle))]
        private void PasteHandle()
        {
            if (RedDocumentTabViewModel.CopiedChunk is null)
            {
                return;
            }

            if (RedDocumentTabViewModel.CopiedChunk is IRedBaseHandle sourceHandle)
            {
                if (Data is IRedBaseHandle destinationHandle)
                {
                    if (destinationHandle.InnerType.IsAssignableFrom(sourceHandle.GetValue().GetType()))
                    {
                        destinationHandle.SetValue(sourceHandle.GetValue());
                        RecalculateProperties(destinationHandle);
                        RedDocumentTabViewModel.CopiedChunk = null;
                    }
                }
            }
        }

        private bool CanCopyChunk() => IsInArray;
        [RelayCommand(CanExecute = nameof(CanCopyChunk))]
        private void CopyChunk()
        {
            try
            {
                RedDocumentTabViewModel.CopiedChunk = Data is IRedCloneable irc ? (IRedType)irc.DeepCopy() : Data;
            }
            catch (Exception ex) { _loggerService.Error(ex); }
        }

        private bool CanPasteChunk()
        {
            if (RedDocumentTabViewModel.CopiedChunk is null)
            {
                return false;
            }

            if (Parent is not null && Parent.ResolvedData is IRedArray destinationParentArray)
            {
                return destinationParentArray.InnerType.IsAssignableFrom(RedDocumentTabViewModel.CopiedChunk.GetType());
            }
            else if (ResolvedData is IRedArray destinationArray)
            {
                return destinationArray.InnerType.IsAssignableFrom(RedDocumentTabViewModel.CopiedChunk.GetType());
            }
            return false;
        }
        [RelayCommand(CanExecute = nameof(CanPasteChunk))]
        private void PasteChunk()
        {
            try
            {
                if (RedDocumentTabViewModel.CopiedChunk is null)
                {
                    return;
                }

                if (Parent?.ResolvedData is IRedArray)
                {
                    if (Parent.InsertChild(Parent.GetIndexOf(this) + 1, RedDocumentTabViewModel.CopiedChunk))
                    {
                        RedDocumentTabViewModel.CopiedChunk = null;
                    }
                }
                else if (ResolvedData is IRedArray)
                {
                    if (InsertChild(-1, RedDocumentTabViewModel.CopiedChunk))
                    {
                        RedDocumentTabViewModel.CopiedChunk = null;
                    }
                }
            }
            catch (Exception ex) { _loggerService.Error(ex); }
        }

        private bool CanDeleteAll() => !IsReadOnly && ((IsArray && PropertyCount > 0) || (IsInArray && Parent is not null && Parent.PropertyCount > 0));
        [RelayCommand(CanExecute = nameof(CanDeleteAll))]
        private void DeleteAll()
        {
            if (IsArray)
            {
                ClearChildren();
            }
            else if (IsInArray && Parent is not null)
            {
                Parent.ClearChildren();
            }
        }

        private bool CanDuplicateChunk() => IsInArray && Parent is not null;
        [RelayCommand(CanExecute = nameof(CanDuplicateChunk))]
        private void DuplicateChunk()
        {
            if (Parent is null)
            {
                return;
            }

            if (Data is IRedCloneable irc)
            {
                Parent.InsertChild(Parent.GetIndexOf(this) + 1, (IRedType)irc.DeepCopy());
            }
            else if (Data is not null)
            {
                Parent.InsertChild(Parent.GetIndexOf(this) + 1, Data);
            }
        }

        private bool CanCopySelection() => IsInArray && Parent is not null;
        [RelayCommand(CanExecute = nameof(CanCopySelection))]
        private void CopySelection()
        {
            ArgumentNullException.ThrowIfNull(Parent);

            try
            {
                var ts = Parent.DisplayProperties
                                .Where(_ => _.IsSelected)
                                .Select(_ => _)
                                .ToList();

                var indices = ts.Select(_ => int.Parse(_.Name)).ToList();
                var (start, end) = (indices.Min(), indices.Max());

                var fullselection = Parent.DisplayProperties
                    .Where(_ => Enumerable.Range(start, end - start + 1).Contains(int.Parse(_.Name)))
                    .Where(x => x.Data is not null)
                    .Select(_ => _.Data.NotNull())
                    .ToList();

                if (Parent.Data is IRedBufferPointer)
                {
                    RedDocumentTabViewModel.CopiedChunks.Clear();
                    foreach (var i in fullselection)
                    {
                        AddToCopiedChunks(i);
                    }
                }
                else if (Parent.Data is IRedArray)
                {
                    RedDocumentTabViewModel.CopiedChunks.Clear();
                    foreach (var i in fullselection)
                    {
                        AddToCopiedChunks(i);
                    }
                }
                else if (Parent.Data is null)
                {
                    _loggerService.Warning($"Parent.Data is null");
                }
                else
                {
                    _loggerService.Warning($"Cannot copy unsupported type: {Parent.Data.GetType().Name}");
                }
            }
            catch (Exception ex)
            {
                _loggerService.Error($"Something went wrong while trying to copy the selection : {ex}");
            }
            //Tab.SelectedChunk = Parent;
        }

        private bool CanPasteSelection() => (IsArray || IsInArray) && Parent is not null && RedDocumentTabViewModel.CopiedChunks.Count > 0 && (ArraySelfOrParent?.InnerType.IsAssignableFrom(RedDocumentTabViewModel.CopiedChunks.First().GetType()) ?? true);
        [RelayCommand(CanExecute = nameof(CanPasteSelection))]
        private void ExecutePasteSelection()
        {
            ArgumentNullException.ThrowIfNull(Parent);

            try
            {
                if (RedDocumentTabViewModel.CopiedChunks.Count == 0)
                {
                    return;
                }

                for (var i = 0; i < RedDocumentTabViewModel.CopiedChunks.Count; i++)
                {
                    var e = RedDocumentTabViewModel.CopiedChunks[i];
                    var index = Parent.GetIndexOf(this) + i + 1;

                    if (ResolvedData is IRedBufferPointer db)
                    {
                        if (db.GetValue().Data is RedPackage pkg)
                        {
                            if (index == -1 || index > pkg.Chunks.Count)
                            {
                                index = pkg.Chunks.Count;
                            }
                            pkg.Chunks.Insert(index, (RedBaseClass)e);
                        }
                        else if (db.GetValue().Data is CR2WList list)
                        {
                            if (index == -1 || index > list.Files.Count)
                            {
                                index = list.Files.Count;
                            }
                            list.Files.Insert(index, new CR2WFile()
                            {
                                RootChunk = (RedBaseClass)e
                            });
                        }
                    }
                    if (Parent.ResolvedData is IRedBufferPointer)
                    {
                        if (Parent.InsertChild(index, e))
                        {
                            //RDTDataViewModel.CopiedChunk = null;
                        }
                    }
                    if (Parent.ResolvedData is IRedArray)
                    {
                        if (Parent.InsertChild(index, e))
                        {
                            //RDTDataViewModel.CopiedChunk = null;
                        }
                    }
                    if (ResolvedData is IRedArray)
                    {
                        if (InsertChild(-1, e))
                        {
                            //RDTDataViewModel.CopiedChunk = null;
                        }
                    }
                }
            }
            catch (Exception ex) { _loggerService.Error(ex); }
        }

        #endregion

        #region methods

        [MemberNotNull(nameof(Value))]
        private void CalculateValue()
        {
            Value = "";
            if (Data == null)
            {
                Value = "null";
            }

            if (PropertyType is null)
            {
                return;
            }

            if (PropertyType.IsAssignableTo(typeof(IRedString)) && Data is IRedString s)
            {
                var value = s.GetString();
                if (!string.IsNullOrEmpty(value))
                {
                    Value = value;
                    if (Value.StartsWith("LocKey#") && ulong.TryParse(Value[7..], out var key))
                    {
                        Value = "";
                    }
                }
            }
            else if (PropertyType.IsAssignableTo(typeof(CByteArray)) && Data is CByteArray b)
            {
                var ba = (byte[])b;
                Value = string.Join(" ", ba.Select(x => $"{x:X2}"));
            }
            else if (PropertyType.IsAssignableTo(typeof(LocalizationString)) && Data is LocalizationString l)
            {
                var value = l;
                Value = value.Value is "" or null ? "null" : value.Value;
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedEnum)) && Data is IRedEnum e)
            {
                var value = e;
                Value = value.ToEnumString();
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedBitField)) && Data is IRedBitField f)
            {
                var value = f;
                Value = value.ToBitFieldString();
            }
            //else if (PropertyType.IsAssignableTo(typeof(TweakDBID)))
            //{
            //    Value = (TweakDBID)Data.ToString();
            //    //Value = Locator.Current.GetService<TweakDBService>().GetString(value);
            //}
            else if (PropertyType.IsAssignableTo(typeof(CBool)) && Data is CBool cb)
            {
                var value = cb;
                Value = value ? "True" : "False";
            }
            else if (PropertyType.IsAssignableTo(typeof(CRUID)) && Data is CRUID cr)
            {
                var value = cr;
                Value = ((ulong)value).ToString();
            }
            else if (PropertyType.IsAssignableTo(typeof(CUInt64)) && Data is CUInt64 uInt64)
            {
                var value = uInt64;
                Value = value != 0 ? ((NodeRef)(ulong)value).ToString() : ((ulong)value).ToString();
            }
            else if (PropertyType.IsAssignableTo(typeof(gamedataLocKeyWrapper)))
            {
                //var value = (gamedataLocKeyWrapper)Data;
                //Value = ((ulong)value).ToString();
                //Value = Locator.Current.GetService<LocKeyService>().GetFemaleVariant(value);
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedInteger)) && Data is IRedInteger i)
            {
                var value = i;

                Value = value.ToString(CultureInfo.CurrentCulture);
            }
            else if (PropertyType.IsAssignableTo(typeof(FixedPoint)) && Data is FixedPoint fp)
            {
                var value = fp;
                Value = ((float)value).ToString("G9");
            }
            else if (PropertyType.IsAssignableTo(typeof(NodeRef)) && Data is NodeRef nr)
            {
                var value = nr;
                Value = value;
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedRef)) && Data is IRedRef rr)
            {
                var value = rr;
                Value = value is not null && value.DepotPath.GetResolvedText() != "" ? value.DepotPath.GetResolvedText() : "null";
            }
            else if (Data is IBrowsableType ibt)
            {
                Value = ibt.GetBrowsableValue();
            }
        }

        public void CalculateDescriptor()
        {
            Descriptor = "";
            if (PropertyType == null)
            {
                return;
            }

            if (Data is worldNodeData sst && Tab is RDTDataViewModel dvm && dvm.Chunks[0].Data is worldStreamingSector wss)
            {
                Descriptor = $"[{sst.NodeIndex}] {wss.Nodes[sst.NodeIndex].Chunk.DebugName}";
                return;
            }

            if (Data is worldStreamingSectorDescriptor wssd)
            {
                Descriptor = wssd.Data.DepotPath.ToString().Replace("base\\worlds\\03_night_city\\_compiled\\default\\", "").Replace(".streamingsector", "");
                return;
            }

            if (ResolvedData is IRedArray ary)
            {
                Descriptor = $"[{ary.Count}]";
            }
            else if (ResolvedData is IRedBufferPointer rbp && rbp.GetValue().Data is RedPackage pkg)
            {
                Descriptor = $"[{pkg.Chunks.Count}]";
            }
            else if (ResolvedData is IRedBufferPointer rbp2 && rbp2.GetValue().Data is CR2WList cl)
            {
                Descriptor = $"[{cl.Files.Count}]";
            }
            else if (ResolvedData is CKeyValuePair kvp)
            {
                Descriptor = kvp.Key;
            }
            else if (Data is TweakDBID tdb)
            {
                //Descriptor = Locator.Current.GetService<TweakDBService>().GetString(tdb);
                Descriptor = tdb.GetResolvedText();
                return;
            }
            else if (Data is gamedataLocKeyWrapper locKey)
            {
                Descriptor = ((ulong)locKey).ToString();
                //Value = Locator.Current.GetService<LocKeyService>().GetFemaleVariant(value);
            }
            else if (Data is IRedString str)
            {
                var s = str.GetString();
                if (s is not null && s.StartsWith("LocKey#") && ulong.TryParse(s[7..], out var locKey2))
                {
                    Descriptor = locKey2.ToString();
                }
            }
            //if (ResolvedData is CMaterialInstance && Parent is not null)
            //{
            //    if (Parent.Parent is not null && Parent.Parent.Parent is not null && Parent.Parent.Data is CMesh mesh)
            //    {
            //        Descriptor = mesh.MaterialEntries[int.Parse(Name)].Name;
            //    }
            //}
            else if (Data is Vector3 v3)
            {
                Descriptor = $"{v3.X}, {v3.Y}, {v3.Z}";
            }
            else if (Data is Vector4 v4)
            {
                Descriptor = $"{v4.X}, {v4.Y}, {v4.Z}, {v4.W}";
            }
            else if (Data is Quaternion q)
            {
                Descriptor = $"{q.I}, {q.J}, {q.K}, {q.R}";
            }
            if (Data is CMaterialInstance && Parent is not null && Tab is not null && Tab.File.Cr2wFile.RootChunk is CMesh mesh)
            {
                if (mesh.LocalMaterialBuffer.RawData?.Data is CR2WList list)
                {
                    for (var i = 0; i < list.Files.Count; i++)
                    {
                        if (list.Files[i].RootChunk == Data)
                        {
                            var entry = mesh.MaterialEntries.FirstOrDefault(x => x.IsLocalInstance && x.Index == i);
                            if (entry != null)
                            {
                                Descriptor = entry.Name;
                            }
                            break;
                        }
                    }
                }
            }
            else if (ResolvedData is CMaterialInstance && Parent is not null && Tab is not null && Tab.File.Cr2wFile.RootChunk is CMesh mesh2)
            {
                for (var i = 0; i < mesh2.PreloadLocalMaterialInstances.Count; i++)
                {
                    if (mesh2.PreloadLocalMaterialInstances[i] == Data)
                    {
                        if (mesh2.MaterialEntries.Count > i)
                        {
                            Descriptor = mesh2.MaterialEntries[i].Name;
                        }
                        break;
                    }
                }
            }
            else if (ResolvedData is not null)
            {
                if (Data is IBrowsableDictionary ibd)
                {
                    var pns = ibd.GetPropertyNames();
                    Descriptor = $"[{pns.Count()}]";
                }
                else if (Data is IList list)
                {
                    Descriptor = $"[{list.Count}]";
                }
                else if (Data is Dictionary<string, object> dict)
                {
                    Descriptor = $"[{dict.Count}]";
                }
            }
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
                    "category",
                    "entryName",
                    "className",
                    "actorName",
                    "sectorHash",
                    "propertyPath"
            };
            if (ResolvedData is RedBaseClass irc)
            {
                foreach (var propName in propNames)
                {
                    var prop = GetPropertyByRedName(irc.GetType(), propName);
                    if (prop is not null)
                    {
                        Descriptor = irc.GetProperty(prop.RedName).ToString().NotNull();
                        return;
                    }
                }
            }
            else
            {
                foreach (var propName in propNames)
                {
                    if (Data is not null)
                    {
                        var prop = Data.GetType().GetProperty(propName);

                        if (prop is not null)
                        {
                            var val = prop.GetValue(Data);
                            if (val is not null)
                            {
                                Descriptor = val.ToString().NotNull();
                            }
                            return;
                        }
                    }
                }
            }
        }

        public void CalculateProperties()
        {
            if (_propertiesLoaded)
            {
                return;
            }

            _propertiesLoaded = true;
            this.OnPropertyChanged(nameof(ResolvedData));

            Properties.Clear();

            var isreadonly = IsReadOnly;
            if (Parent is not null)
            {
                isreadonly = Parent.IsReadOnly;
            }
            var obj = Data;
            if (obj is IRedBaseHandle handle)
            {
                obj = handle.GetValue();
            }
            if (obj is CVariant v)
            {
                obj = v.Value;
            }
            if (obj is TweakDBID tdb)
            {
                obj = Locator.Current.GetService<TweakDBService>().NotNull().GetFlat(tdb);
                if (obj is not null)
                {
                    Properties.Add(new ChunkViewModel(obj, nameof(TweakDBID), this, true));
                    this.OnPropertyChanged(nameof(TVProperties));
                    return;
                }
                else
                {
                    obj = Locator.Current.GetService<TweakDBService>().NotNull().GetRecord(tdb);
                }
                isreadonly = true;
                //var record = Locator.Current.GetService<TweakDBService>().GetRecord(tdb);
                //if (record is not null)
                //{
                //    Properties.Add(new ChunkViewModel(record, this, "record"));
                //}
            }
            else if (obj is IRedString str)
            {
                var s = str.GetString();
                if (s is not null && s.StartsWith("LocKey#") && ulong.TryParse(s[7..], out var locKey))
                {
                    obj = Locator.Current.GetService<LocKeyService>().NotNull().GetEntry(locKey);
                    isreadonly = true;
                }
            }
            else if (obj is gamedataLocKeyWrapper locKey)
            {
                obj = Locator.Current.GetService<LocKeyService>().NotNull().GetEntry(locKey);
                isreadonly = true;
            }

            if (obj is IRedArray ary)
            {
                for (var i = 0; i < PropertyCount; i++)
                {
                    if (ary[i] is IRedType t)
                    {
                        Properties.Add(new ChunkViewModel(t, "Element", this, isreadonly));
                    }
                }
            }
            else if (obj is IRedRef)
            {
                // ignore
            }
            else if (obj is CKeyValuePair kvp)
            {
                for (var i = 0; i < PropertyCount; i++)
                {
                    if (i == 0)
                    {
                        Properties.Add(new ChunkViewModel(kvp.Key, "Key", this, isreadonly));
                    }
                    else
                    {
                        Properties.Add(new ChunkViewModel(kvp.Value, "Value", this, isreadonly));
                    }
                }
            }
            else if (obj is inkWidgetReference iwr)
            {
                // need to add XPath somewhere in the data structure
                Properties.Add(new ChunkViewModel((CString)"TODO", nameof(inkWidgetReference), this));
            }
            else if (obj is RedBaseClass redClass)
            {
                var pis = GetTypeInfo(redClass).PropertyInfos.Sort((a, b) => a.Name.CompareTo(b.Name));

                var dps = redClass.GetDynamicPropertyNames();
                dps.Sort();

                foreach (var propertyInfo in pis)
                {
                    if (s_hiddenProperties.Contains(obj.GetType().Name + "." + propertyInfo.RedName))
                    {
                        continue;
                    }

                    var name = !string.IsNullOrEmpty(propertyInfo.RedName) ? propertyInfo.RedName : propertyInfo.Name;
                    Properties.Add(new ChunkViewModel(redClass.GetProperty(name), propertyInfo.RedName, this, isreadonly));
                }

                foreach (var dp in dps)
                {
                    Properties.Add(new ChunkViewModel(redClass.GetProperty(dp), dp, this, isreadonly));
                }
            }
            else if (obj is SerializationDeferredDataBuffer sddb)
            {
                if (sddb.Data is RedPackage p4)
                {
                    for (var i = 0; i < PropertyCount; i++)
                    {
                        Properties.Add(new ChunkViewModel(p4.Chunks[i], nameof(RedPackage), this, isreadonly));
                    }
                }
                else if (sddb.Data is not null)
                {
                    var pis = sddb.Data.GetType().GetProperties(s_defaultLookup);
                    foreach (var pi in pis)
                    {
                        var value = pi.GetValue(sddb.Data);
                        if (value is IRedType irt)
                        {
                            Properties.Add(new ChunkViewModel(irt, pi.Name, this, isreadonly));
                        }
                    }
                }
            }
            else if (obj is SharedDataBuffer sdb)
            {
                if (sdb.Data is RedPackage p42)
                {
                    for (var i = 0; i < PropertyCount; i++)
                    {
                        Properties.Add(new ChunkViewModel(p42.Chunks[i], p42.Chunks[i].GetType().Name, this, isreadonly));
                    }
                }
                if (sdb.File is CR2WFile cr2)
                {
                    //var chunks = cr2.Chunks;
                    //for (int i = 0; i < chunks.Count; i++)
                    //{
                    //    properties.Add(i, new ChunkViewModel(i, chunks[i], this));
                    //}
                    Properties.Add(new ChunkViewModel(cr2.RootChunk, cr2.RootChunk.GetType().Name, this, isreadonly));
                }
                if (sdb.Data is IParseableBuffer ipb)
                {
                    Properties.Add(new ChunkViewModel(ipb.Data, ipb.Data.GetType().Name, this, isreadonly));
                }
            }
            else if (obj is DataBuffer db)
            {
                if (db.Data is RedPackage p43)
                {
                    for (var i = 0; i < PropertyCount; i++)
                    {
                        Properties.Add(new ChunkViewModel(p43.Chunks[i], p43.Chunks[i].GetType().Name, this, isreadonly));
                    }
                }
                else if (db.Data is CR2WList cl)
                {
                    for (var i = 0; i < PropertyCount; i++)
                    {
                        Properties.Add(new ChunkViewModel(cl.Files[i].RootChunk, cl.Files[i].RootChunk.GetType().Name, this, isreadonly));
                    }
                }
                else if (db.Data is IList list)
                {
                    foreach (var thing in list)
                    {
                        if (thing is IRedType redType)
                        {
                            Properties.Add(new ChunkViewModel(redType, redType.GetType().Name, this, isreadonly));
                        }
                    }
                }
                else if (db.Data is not null)
                {
                    var pis = db.Data.GetType().GetProperties(s_defaultLookup);
                    foreach (var pi in pis)
                    {
                        var value = pi.GetValue(db.Data);
                        if (value is IRedType irt)
                        {
                            Properties.Add(new ChunkViewModel(irt, pi.Name, this, isreadonly));
                        }
                    }
                }
            }
            //else if (Data is TweakXLFile)
            // fallback for non-RTTI data
            else if (Data is not null)
            {
                if (Data is IBrowsableDictionary ibd)
                {
                    var pns = ibd.GetPropertyNames();
                    foreach (var name in pns)
                    {
                        if (ibd.GetPropertyValue(name) is IRedType t)
                        {
                            Properties.Add(new ChunkViewModel(t, name, this, isreadonly));
                        }
                    }
                }
                else if (Data is IList list)
                {
                    foreach (var thing in list)
                    {
                        Properties.Add(new ChunkViewModel((IRedType)thing, "Element", this, isreadonly));
                    }
                }
                else if (Data is Dictionary<string, object> dict)
                {
                    foreach (var (name, thing) in dict)
                    {
                        Properties.Add(new ChunkViewModel((IRedType)thing, name, this, isreadonly));
                    }
                }
                else
                {
                    var pis = Data.GetType().GetProperties(s_defaultLookup);
                    foreach (var pi in pis)
                    {
                        var value = Data is not null ? pi.GetValue(Data) : null;
                        if (value is IRedType irt)
                        {
                            Properties.Add(new ChunkViewModel(irt, pi.Name, this, isreadonly));
                        }
                    }

                    if (Data is worldNodeData sst && Tab is RDTDataViewModel dvm && dvm.Chunks[0].Data is worldStreamingSector wss)
                    {
                        try
                        {
                            Properties.Add(new ChunkViewModel(wss.Nodes[sst.NodeIndex], "Node", this, isreadonly));
                        }
                        catch (Exception ex) { _loggerService.Error(ex); }
                    }
                }
            }
            this.OnPropertyChanged(nameof(TVProperties));
        }

        private void CalculateIsDefault()
        {
            IsDefault = Data == null;

            if (Parent is not null && Data is not IRedBaseHandle)
            {
                var epi = GetPropertyByRedName(Parent.ResolvedPropertyType, PropertyName);
                if (epi is not null)
                {
                    //IsDefault = IsDefault(Parent.ResolvedPropertyType, epi, Data);
                    IsDefault = IsDefault(Parent.ResolvedPropertyType, epi, ResolvedData);
                }
            }
        }

        public int GetIndexOf(ChunkViewModel child)
        {
            if (ResolvedData is IList ary)
            {
                var index = 0;
                foreach (var item in ary)
                {
                    if (child.Data is not null && item.GetHashCode() == child.Data.GetHashCode())
                    {
                        if (!_propertiesLoaded || Properties[index].GetHashCode() == child.GetHashCode())
                        {
                            return index;
                        }
                    }
                    index++;
                }
            }
            else if (ResolvedData is IRedBufferPointer rbp && rbp.GetValue().Data is RedPackage pkg)
            {
                var index = 0;
                foreach (var item in pkg.Chunks)
                {
                    if (child.Data is not null && item.GetHashCode() == child.Data.GetHashCode())
                    {
                        if (!_propertiesLoaded || Properties[index].GetHashCode() == child.GetHashCode())
                        {
                            return index;
                        }
                    }
                    index++;
                }
            }
            else if (ResolvedData is IRedBufferPointer rbp2 && rbp2.GetValue().Data is CR2WList cl)
            {
                var index = 0;
                foreach (var file in cl.Files)
                {
                    if (child.Data is not null && file.RootChunk.GetHashCode() == child.Data.GetHashCode())
                    {
                        if (!_propertiesLoaded || Properties[index].GetHashCode() == child.GetHashCode())
                        {
                            return index;
                        }
                    }
                    index++;
                }
            }
            return 0;
        }

        public void MoveChild(int index, ChunkViewModel item)
        {
            if (item.Parent == null)
            {
                return;
            }
            if (Tab == null)
            {
                return;
            }
            if (item.Data == null)
            {
                return;
            }

            var oldParent = item.Parent;

            IList? sourceList = null;
            IList? destList = null;
            if (oldParent.ResolvedData is IList il)
            {
                sourceList = il;
            }
            else if (oldParent.ResolvedData is IRedBufferPointer db)
            {
                if (db.GetValue().Data is RedPackage pkg)
                {
                    sourceList = (IList)pkg.Chunks;
                }
                else if (db.GetValue().Data is CR2WList cl)
                {
                    sourceList = cl.Files;
                }
            }

            if (ResolvedData is IList il2)
            {
                destList = il2;
            }
            else if (ResolvedData is IRedBufferPointer db)
            {
                if (db.GetValue().Data is RedPackage pkg)
                {
                    destList = (IList)pkg.Chunks;
                }
                else if (db.GetValue().Data is CR2WList cl)
                {
                    destList = cl.Files;
                }
            }

            if (sourceList is not null && destList is not null)
            {
                int oldIndex = -1, i = 0;
                foreach (var thing in sourceList)
                {
                    if (item.Data is not null && thing.GetHashCode() == item.Data.GetHashCode())
                    {
                        oldIndex = i;
                        break;
                    }
                    i++;
                }

                if (oldIndex > -1)
                {
                    sourceList.RemoveAt(oldIndex);
                    if (oldIndex < index && sourceList.GetHashCode() == destList.GetHashCode())
                    {
                        index--;
                    }
                    InsertChild(index, item.Data);
                    Tab?.File.SetIsDirty(true);
                    RecalculateProperties();
                    if (sourceList.GetHashCode() != destList.GetHashCode())
                    {
                        oldParent.RecalculateProperties();
                        if (oldParent.Tab is not null && Tab is not null)
                        {
                            if (oldParent.Tab.File.GetHashCode() != Tab.File.GetHashCode())
                            {
                                oldParent.Tab.File.SetIsDirty(true);
                            }
                        }
                    }
                }
            }
        }

        private bool InsertArrayItem(IRedArray ira, int index, IRedType item)
        {
            var iraType = ira.GetType();
            if (iraType.IsGenericType)
            {
                var arrayType = iraType.GetGenericTypeDefinition();
                if (arrayType == typeof(CArray<>) || (arrayType == typeof(CStatic<>) && ira.Count < ira.MaxSize))
                {
                    if (index == -1 || index > ira.Count)
                    {
                        index = ira.Count;
                    }
                    ira.Insert(index, item);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (Data is IRedBufferPointer db)
            {
                if (index == -1 || index > ira.Count)
                {
                    index = ira.Count;
                }
                ira.Insert(index, item);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertChild(int index, IRedType item)
        {
            try
            {
                if (ResolvedData is IRedArray ira && ira.InnerType.IsInstanceOfType(item))
                {
                    InsertArrayItem(ira, index, item);
                }
                else if (Data is IRedArray ira2 && ira2.InnerType.IsInstanceOfType(item)) // Not sure why, but seems to be important^^
                {
                    InsertArrayItem(ira2, index, item);
                }
                else if (ResolvedData is IRedLegacySingleChannelCurve curve && curve.ElementType.IsAssignableTo(item.GetType()))
                {
                    curve.Add(0F, item);
                }
                else if (item is RedBaseClass rbc)
                {
                    if (ResolvedData is IRedBufferPointer db)
                    {
                        if (db.GetValue().Data is RedPackage pkg)
                        {
                            if (index == -1 || index > pkg.Chunks.Count)
                            {
                                index = pkg.Chunks.Count;
                            }
                            pkg.Chunks.Insert(index, rbc);
                        }
                        else if (db.GetValue().Data is CR2WList list)
                        {
                            if (index == -1 || index > list.Files.Count)
                            {
                                index = list.Files.Count;
                            }
                            list.Files.Insert(index, new CR2WFile()
                            {
                                RootChunk = rbc
                            });
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

                //Name = null;
                //PropertyCount = -1;
                //CalculateDescriptor();
                //PropertiesLoaded = false;
                //CalculateProperties();
                //Tab.File.SetIsDirty(true);

                Tab?.File.SetIsDirty(true);
                RecalculateProperties(item);

                return true;
            }
            catch (Exception ex) { _loggerService.Error(ex); }
            return false;
        }

        public void RecalculateProperties(IRedType? selectChild = null)
        {
            PropertyCount = -1;
            // might not be needed
            _propertiesLoaded = false;
            //_resolvedDataCache = null;
            CalculateProperties();
            CalculateDescriptor();

            this.OnPropertyChanged("Data");

            IsExpanded = true;

            if (selectChild is not null)
            {
                foreach (var prop in Properties)
                {
                    if (prop.Data is not null && prop.Data.GetHashCode() == selectChild.GetHashCode())
                    {
                        prop.IsExpanded = true;
                        if (Tab is RDTDataViewModel dvm)
                        {
                            dvm.SelectedChunk = prop;
                        }
                        break;
                    }
                }
            }
        }

        public static bool IsControlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);

        // node stuff

        

        public IList<ReferenceSocket> Inputs
        {
            get => new List<ReferenceSocket>(new ReferenceSocket[] { Socket.NotNull() });
            set
            {

            }
        }
       

        //public ICommand OpenSelfCommand { get; private set; }
        //private bool CanOpenSelf() => RelativePath != CName.Empty && _tab == null;
        //private void ExecuteOpenSelf() => Locator.Current.GetService<AppViewModel>().NotNull().OpenFileFromDepotPath(RelativePath);

        private ChunkViewModel GetRootModel()
        {
            var result = this;
            while (result.Parent != null)
            {
                result = result.Parent;
            }
            return result;
        }

        private ChunkViewModel? GetModelFromPath(string path)
        {
            var parts = path.Split('.');

            var result = this;
            foreach (var part in parts)
            {
                var newResult = result.Properties.FirstOrDefault(x => x.Name == part);
                if (newResult == null)
                {
                    return null;
                }

                result = newResult;
            }

            return result;
        }

        public void NotifyChain(string property)
        {
            this.OnPropertyChanged(property);
            Parent?.NotifyChain(property);
        }

        private ObservableCollection<ISelectableTreeViewItemModel>? SplitProperties(ObservableCollection<ChunkViewModel> locations, int nSize = 100)
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

        public bool MightHaveChildren() => HasChildren() || IsArray;

        public bool HasChildren() => PropertyCount > 0;

        public void HandlePointer(DialogViewModel? sender)
        {
            var app = Locator.Current.GetService<AppViewModel>().NotNull();
            app.CloseDialogCommand.Execute(null);
            if (sender is CreateClassDialogViewModel vm)
            {
                var instance = RedTypeManager.Create(vm.SelectedClass);
                var data = RedTypeManager.CreateRedType(PropertyType);
                if (data is IRedBaseHandle handle)
                {
                    handle.SetValue(instance);
                    Data = data;

                    if (Parent?.ResolvedData is RedBaseClass rbc)
                    {
                        rbc.SetProperty(PropertyName, Data);
                    }
                    PropertyCount = -1;
                    // might not be needed
                    CalculateDescriptor();
                    _propertiesLoaded = false;
                    CalculateProperties();
                    this.OnPropertyChanged(nameof(Data));
                    Tab?.File.SetIsDirty(true);
                }
            }
        }

        public void HandleCKeyValuePair(DialogViewModel? sender)
        {
            var app = Locator.Current.GetService<AppViewModel>().NotNull();
            app.CloseDialogCommand.Execute(null);
            if (sender is SelectRedTypeDialogViewModel vm && vm.SelectedType is not null)
            {
                if (System.Activator.CreateInstance(vm.SelectedType) is IRedType t)
                {
                    var instance = new CKeyValuePair(CName.Empty, t);
                    InsertChild(-1, instance);
                }
            }
        }

        public void HandleChunk(DialogViewModel? sender)
        {
            var app = Locator.Current.GetService<AppViewModel>().NotNull();
            app.CloseDialogCommand.Execute(null);
            if (sender is CreateClassDialogViewModel vm && vm.SelectedType is not null)
            {
                var instance = RedTypeManager.CreateRedType(vm.SelectedType);
                if (!InsertChild(-1, instance))
                {
                    _loggerService.Error("Unable to insert child");
                }
            }
        }

        public void HandleChunkPointer(DialogViewModel? sender)
        {
            var app = Locator.Current.GetService<AppViewModel>().NotNull();
            app.CloseDialogCommand.Execute(null);
            if (sender is CreateClassDialogViewModel vm && Data is IRedArray arr)
            {
                var newItem = RedTypeManager.CreateRedType(arr.InnerType);
                if (newItem is IRedBaseHandle handle)
                {
                    var instance = RedTypeManager.Create(vm.SelectedClass);
                    handle.SetValue(instance);
                    if (!InsertChild(-1, newItem))
                    {
                        _loggerService.Error("Unable to insert child");
                    }
                }
            }
        }

        public bool ShouldShowTweakXLMenu()
        {
            var ret = Data is gamedataTweakDBRecord;
            ret |= Data is TweakDBID;
            ret |= Parent?.Data is gamedataTweakDBRecord;
            ret |= Parent?.Data is TweakDBID;
            return ret;
        }

        public void ClearChildren()
        {
            if (ResolvedData is IRedArray ary)
            {
                ary.Clear();
            }
            else if (ResolvedData is IRedLegacySingleChannelCurve curve)
            {
                //_resolvedDataCache = null;
                //Data = null;     // TODO ???
            }
            else if (ResolvedData is IRedBufferPointer db && db.GetValue().Data is RedPackage pkg)
            {
                pkg.Chunks.Clear();
            }
            else if (ResolvedData is IRedBufferPointer db2 && db2.GetValue().Data is CR2WList list)
            {
                list.Files.Clear();
            }
            else
            {
                return;
            }
            IsDeleteReady = false;
            Tab?.File.SetIsDirty(true);
            RecalculateProperties();
        }

        private Task<bool> ImportWorldNodeDataTask(bool updatecoords)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 2,
                FileName = Type + ".json",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    return AddFromJSON(openFileDialog, updatecoords);
                }
                catch (Exception ex)
                {
                    _loggerService.Error(ex);
                }
            }
            return Task.FromResult(false);
        }

        public async Task<bool> AddFromJSON(OpenFileDialog openFileDialog, bool updatecoords)
        {
            ArgumentNullException.ThrowIfNull(Data);

            var tr = RedJsonSerializer.Serialize(Data);
            var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);
            //deepcopy of Data but not really

            var text = File.ReadAllText(openFileDialog.FileName);
            if (string.IsNullOrEmpty(text) || current is null)
            {
                _loggerService.Error("Could not read file");
                return false;
            }

            if (RedJsonSerializer.TryDeserialize<JsonAMM>(text, out var json0) &&
               json0 is not null && json0.props is not null && json0.props.Count > 0)
            {
                AddFromAMM(json0.props, tr, updatecoords);
            }
            else if (RedJsonSerializer.TryDeserialize<JsonAMM2>(text, out var json1) &&
               json1 is not null && json1.childs is not null && json1.childs.Count > 0)
            {
                AddFromAMM2(json1, tr, updatecoords);
            }
            else if (RedJsonSerializer.TryDeserialize<List<List<object>>>(text, out var json2) &&
               json2 is not null)
            {
                AddFromUnreal(json2, tr, updatecoords);
            }
            else if (RedJsonSerializer.TryDeserialize<List<JsonObjectSpawner>>(text, out var json3) &&
               json3 is not null && json3.First() is not null && json3.First().pos is not null)
            {
                AddFromObjectSpawner(json3, tr, updatecoords);
            }
            else if (RedJsonSerializer.TryDeserialize<List<worldNodeData>>(text, out var json4) &&
               json4 is not null)
            {
                if (Parent?.Data is DataBuffer db && db.Buffer.Data is IRedArray ira && json4.Count == ira.Count)
                {
                    AddFromBlender(json4, tr);
                }
                else
                {
                    _loggerService.Warning("nodeData and your JSON must contain the same number of elements");
                    return false;
                }
            }
            else
            {
                _loggerService.Warning("Could not recognize the format of your JSON");
                return false;
            }

            if (Parent?.Data is DataBuffer dbf && dbf.Buffer.Data is IRedType irtt)
            {
                Tab?.File.SetIsDirty(true);
                RecalculateProperties(irtt);
            }

            ArgumentNullException.ThrowIfNull(Tab);
            var currentfile = new FileModel(Tab.File.FilePath, Locator.Current.GetService<AppViewModel>().NotNull().ActiveProject.NotNull());

            Locator.Current.GetService<AppViewModel>().NotNull().SaveFileCommand.SafeExecute(currentfile);

            await Refresh();

            _loggerService.Success($"Successfully imported from JSON");
            return true;
        }

        public void WriteObjectToJSON(object irt)
        {
            try
            {
                Stream myStream;
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                    FilterIndex = 2,
                    FileName = Type + ".json",
                    RestoreDirectory = true
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    if ((myStream = saveFileDialog.OpenFile()) is not null)
                    {
                        var json = RedJsonSerializer.Serialize(irt);
                        if (!string.IsNullOrEmpty(json))
                        {
                            myStream.Write(json.ToCharArray().Select(c => (byte)c).ToArray());
                            myStream.Close();

                            _loggerService.Success($"{irt.GetType().Name} written to: {saveFileDialog.FileName}");
                        }
                    }
                    else
                    {
                        _loggerService.Error($"Could not open file: {saveFileDialog.FileName}");
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerService.Error(ex);
            }
        }


        private void DeleteFullSelection(List<IRedType> l, IRedArray a)
        {
            foreach (var i in l)
            {
                try
                {
                    a.Remove(i);
                }
                catch (Exception ex)
                {
                    _loggerService.Error(ex);
                }
            }

            Tab?.File.SetIsDirty(true);
            Parent?.RecalculateProperties();
        }

        private void AddToCopiedChunks(object elem)
        {
            try
            {
                if (elem is IRedCloneable irc)
                {
                    RedDocumentTabViewModel.CopiedChunks.Add((IRedType)irc.DeepCopy());
                }
                else if (elem is worldNodeData)
                {
                    /*dynamic t = elem.GetType().GetProperty("Value").GetValue(elem, null);
                    var v = System.Activator.CreateInstance(t);*/
                    var tr = RedJsonSerializer.Serialize(elem);
                    var copied = RedJsonSerializer.Deserialize<worldNodeData>(tr);
                    if (copied is not null)
                    {
                        RedDocumentTabViewModel.CopiedChunks.Add(copied);
                    }
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            catch (Exception ex) { _loggerService.Error(ex); }
        }

        #endregion


        #region utils

        private static Vec4 GetCenter(List<Vec4> poslist)
        {
            //minX + (maxX - minX)/2 == (maxX + minX)/2;
            var (minX, maxX) = (poslist.Select(_ => _.X).Min(), poslist.Select(_ => _.X).Max());
            var cX = (maxX + minX) / 2;

            var (minY, maxY) = (poslist.Select(_ => _.Y).Min(), poslist.Select(_ => _.Y).Max());
            var cY = (maxY + minY) / 2;

            var (minZ, maxZ) = (poslist.Select(_ => _.Z).Min(), poslist.Select(_ => _.Z).Max());
            var cZ = (maxZ + minZ) / 2;

            var (minW, maxW) = (poslist.Select(_ => _.W).Min(), poslist.Select(_ => _.W).Max());
            var cW = (maxW + minW) / 2;

            return new Vec4(cX, cY, cZ, cW);
        }

        private static Vec4 GetCenter(List<List<object>> json)
        {
            var poslist =
                json.Select(j =>
                new Vec3()
                {
                    X = float.Parse(
                        ((JsonElement)j[5])[0].GetRawText()
                        ),
                    Y = float.Parse(
                        ((JsonElement)j[5])[1].GetRawText()
                        ),
                    Z = float.Parse(
                        ((JsonElement)j[5])[2].GetRawText()
                        )
                }
                ).ToList();

            //minX + (maxX - minX)/2 == (maxX + minX)/2;
            var (minX, maxX) = (poslist.Select(_ => _.X).Min(), poslist.Select(_ => _.X).Max());
            var cX = (maxX + minX) / 2;

            var (minY, maxY) = (poslist.Select(_ => _.Y).Min(), poslist.Select(_ => _.Y).Max());
            var cY = (maxY + minY) / 2;

            var (minZ, maxZ) = (poslist.Select(_ => _.Z).Min(), poslist.Select(_ => _.Z).Max());
            var cZ = (maxZ + minZ) / 2;

            return new Vec4(cX, cY, cZ, 1);
        }

        //private static Vec4 GetPos(Prop line)
        //{
        //    var posandrot = RedJsonSerializer.Deserialize<Vec7S>(PutQuotes(line.pos));
        //    return new Vec4()
        //    {
        //        X = float.Parse(posandrot.x),
        //        Y = float.Parse(posandrot.y),
        //        Z = float.Parse(posandrot.z),
        //        W = float.Parse(posandrot.w)
        //    };
        //}

        private static List<Vec4> GetPos(List<Prop> props)
        {
            var poslist = new List<Vec4>();
            foreach (var line in props)
            {
                var posandrot = RedJsonSerializer.Deserialize<Vec7S>(PutQuotes(line.pos)).NotNull();

                ArgumentNullException.ThrowIfNull(posandrot.x);
                ArgumentNullException.ThrowIfNull(posandrot.y);
                ArgumentNullException.ThrowIfNull(posandrot.z);
                ArgumentNullException.ThrowIfNull(posandrot.w);

                var v = new Vec4()
                {
                    X = float.Parse(posandrot.x),
                    Y = float.Parse(posandrot.y),
                    Z = float.Parse(posandrot.z),
                    W = float.Parse(posandrot.w)
                };
                poslist.Add(v);
            }
            return poslist;
        }

        private (Vec4, Quat) GetPosRot(Prop line)
        {
            var posandrot = RedJsonSerializer.Deserialize<Vec7S>(PutQuotes(line.pos)).NotNull();

            ArgumentNullException.ThrowIfNull(posandrot.x);
            ArgumentNullException.ThrowIfNull(posandrot.y);
            ArgumentNullException.ThrowIfNull(posandrot.z);
            ArgumentNullException.ThrowIfNull(posandrot.w);
            ArgumentNullException.ThrowIfNull(posandrot.yaw);
            ArgumentNullException.ThrowIfNull(posandrot.pitch);
            ArgumentNullException.ThrowIfNull(posandrot.roll);

            var v =
                posandrot == null
                ? new Vec4()
                : new Vec4()
                {
                    X = float.Parse(posandrot.x),
                    Y = float.Parse(posandrot.y),
                    Z = float.Parse(posandrot.z),
                    W = float.Parse(posandrot.w)
                };

            var euler =
                posandrot == null
                ? new Vec3()
                : new Vec3()
                {
                    X = (float)(Math.PI / 180) * float.Parse(posandrot.yaw),
                    Y = (float)(Math.PI / 180) * float.Parse(posandrot.pitch),
                    Z = (float)(Math.PI / 180) * float.Parse(posandrot.roll)
                };
            var q = line.isunreal ? FixRotation2(euler) :
                FixRotation(euler);

            return (v, q);
        }

        //private (List<Vec4>, List<Quat>) GetPosRot(List<Prop> props)
        //{
        //    var poslist = new List<Vec4>();
        //    var rotlist = new List<Quat>();

        //    foreach (var line in props)
        //    {
        //        var posandrot = RedJsonSerializer.Deserialize<Vec7S>(PutQuotes(line.pos));
        //        var v = new Vec4()
        //        {
        //            X = float.Parse(posandrot.x),
        //            Y = float.Parse(posandrot.y),
        //            Z = float.Parse(posandrot.z),
        //            W = float.Parse(posandrot.w)
        //        };
        //        poslist.Add(v);

        //        var euler = new Vec3()
        //        {
        //            X = (float)(Math.PI / 180) * float.Parse(posandrot.yaw),
        //            Y = (float)(Math.PI / 180) * float.Parse(posandrot.pitch),
        //            Z = (float)(Math.PI / 180) * float.Parse(posandrot.roll)
        //        };
        //        var q = FixRotation(euler);

        //        rotlist.Add(q);
        //    }
        //    return (poslist, rotlist);
        //}

        //private (List<Vec4>, List<Quat>, List<string>) GetPosRotApp(List<Prop> props)
        //{
        //    var poslist = new List<Vec4>();
        //    var rotlist = new List<Quat>();
        //    var applist = new List<string>();

        //    foreach (var line in props)
        //    {
        //        var posandrot = RedJsonSerializer.Deserialize<Vec7S>(PutQuotes(line.pos));
        //        var v = new Vec4()
        //        {
        //            X = float.Parse(posandrot.x),
        //            Y = float.Parse(posandrot.y),
        //            Z = float.Parse(posandrot.z),
        //            W = float.Parse(posandrot.w)
        //        };
        //        poslist.Add(v);

        //        var euler = new Vec3()
        //        {
        //            X = (float)(Math.PI / 180) * float.Parse(posandrot.yaw),
        //            Y = (float)(Math.PI / 180) * float.Parse(posandrot.pitch),
        //            Z = (float)(Math.PI / 180) * float.Parse(posandrot.roll)
        //        };

        //        var q = FixRotation(euler);

        //        // (q.Y, q.Z) = (-q.Z, -q.Y);
        //        rotlist.Add(q);

        //        applist.Add(line.app);
        //    }
        //    return (poslist, rotlist, applist);
        //}

        private (List<Vec4>, List<Quat>, List<string>) GetPosRotApp(List<Child> props)
        {
            var poslist = new List<Vec4>();
            var rotlist = new List<Quat>();
            var applist = new List<string>();

            foreach (var line in props)
            {
                var pos = line.pos;
                var rot = line.rot;
                var v = new Vec4()
                {
                    X = pos.x,
                    Y = pos.y,
                    Z = pos.z,
                    W = pos.w
                };
                poslist.Add(v);

                var euler = new Vec3()
                {
                    X = (float)(Math.PI / 180) * rot.yaw,
                    Y = (float)(Math.PI / 180) * rot.pitch,
                    Z = (float)(Math.PI / 180) * rot.roll
                };

                var q = FixRotation(euler);

                rotlist.Add(q);

                if (line.app != null)
                {
                    var app = line.app == "" ? "default" : line.app;
                    applist.Add(app);
                }
                else
                {
                    applist.Add("default");
                }
            }
            return (poslist, rotlist, applist);
        }

        private static string PutQuotes(string w)
        {
            w = w.Replace("{", "{\"");
            w = w.Replace("}", "\"}");
            w = w.Replace(", ", "\",\"");
            w = w.Replace(" = ", "\":\"");
            return w;
        }

        public async Task Refresh()
        {
            var document = Locator.Current.GetService<AppViewModel>().NotNull().ActiveDocument;

            if (Tab is not null && document is not null)
            {
                Tab.File.TabItemViewModels.Clear();
                await Task.Delay(1);
                throw new NotImplementedException();

                //await document.OpenFileAsync(Tab.File.FilePath);
            }
        }


        public static Quat FixRotation(Vec3 euler) =>
            Quat.CreateFromRotationMatrix(
                Mat4.Identity
                * Mat4.CreateFromAxisAngle(Vec3.UnitY, euler.Z)
                * Mat4.CreateFromAxisAngle(Vec3.UnitX, euler.Y)
                * Mat4.CreateFromAxisAngle(Vec3.UnitZ, euler.X)
                );

        public static Quat FixRotation2(Vec3 euler) =>
            Quat.CreateFromRotationMatrix(
                Mat4.Identity
                * Mat4.CreateFromAxisAngle(Vec3.UnitZ, (float)Math.PI)
                * Mat4.CreateFromAxisAngle(-Vec3.UnitX, euler.Y)
                * Mat4.CreateFromAxisAngle(Vec3.UnitY, euler.Z)
                * Mat4.CreateFromAxisAngle(-Vec3.UnitZ, euler.X)
                );


        private static Vec4 UpdateCoords(Vec4 pos, Vec4 center)
        {
            pos.X -= center.X;
            pos.Y -= center.Y;
            pos.Z -= center.Z;
            //pos.W -= center.W;

            return pos;
        }

        private static List<Vec4> UpdateCoords(List<Vec4> poslist, Vec4 center)
        {
            for (var i = 0; i < poslist.Count; i++)
            {
                var pos = poslist[i];
                pos.X -= center.X;
                pos.Y -= center.Y;
                pos.Z -= center.Z;
                //pos.W -= center.W;
                poslist[i] = pos;
            }
            return poslist;
        }

        //private void AddToData(string tr, Prop line, string ff = "", bool updatecoords = true)
        //{
        //    if (Parent.Parent is not null &&
        //        Parent.Parent.Data is not null &&
        //        Parent.Parent.Data is worldStreamingSector)
        //    {
        //        //loads the mesh when found and scaled
        //        if (GetScale(line) == Vec3.One)
        //        {
        //            AddEntity(tr, line, updatecoords);
        //        }
        //        else if (ff != "")
        //        {
        //            AddMesh(tr, line, updatecoords);
        //        }
        //    }
        //}

        private void AddEntity(string tr, Prop line, bool updatecoords = true, bool visible = true)
        {
            if (line.template_path is not null && Parent?.Parent?.Data is worldStreamingSector wss)
            {
                //var wss = (worldStreamingSector)Parent.Parent.Data;
                var current = RedJsonSerializer.Deserialize<worldNodeData>(tr).NotNull();

                var wen = new worldEntityNode();
                var wenh = new CHandle<worldNode>(wen);
                var index = wss.Nodes.Count;

                //gotta figure out colliders
                wen.IsVisibleInGame = visible;
                wen.EntityTemplate = new CResourceAsyncReference<entEntityTemplate>(line.template_path);
                wen.AppearanceName = string.IsNullOrEmpty(line.app) ? "default" : line.app;
                wen.DebugName = Path.GetFileNameWithoutExtension(line.template_path) + "_" + index.ToString();

                current.QuestPrefabRefHash = Convert.ToUInt64(current.GetHashCode()); // Add hash to make object interactible and persistent

                if (line.isdoor is bool b && b)
                {
                    var eeid = new entEntityInstanceData();
                    var eeidh = new CHandle<entEntityInstanceData>(eeid);

                    wen.InstanceData = eeidh;
                    eeid.Buffer = new DataBuffer();

                    var pk = new RedPackage();
                    var dc = new DoorController();
                    pk.Chunks = new List<RedBaseClass>();

                    dc.PersistentState = new DoorControllerPS()
                    {
                        IsInteractive = true
                    };
                    pk.Chunks.Add(dc);
                    eeid.Buffer.Data = pk;
                }

                ((IRedArray)wss.Nodes).Insert(index, wenh);
                SetCoords(current, index, line, updatecoords);
            }
        }

        private void AddMesh(string tr, Prop line, bool updatecoords = true, Vec4 pos = default, Quat rot = default)
        {
            if (Parent?.Parent?.Data is not worldStreamingSector wss)
            {
                return;
            }
            var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);
            if (current == null)
            {
                return;
            }

            //var cmesh = new worldStaticMeshNode();
            var cmesh = new worldGenericProxyMeshNode();

            var wenh = new CHandle<worldNode>(cmesh);
            var index = wss.Nodes.Count;

            cmesh.DebugName = Path.GetFileNameWithoutExtension(line.template_path) + "_" + index.ToString();
            cmesh.ForceAutoHideDistance = 20000;
            cmesh.NearAutoHideDistance = 0;
            //not sure what these do
            //cmesh.RemoveFromRainMap = true;
            //cmesh.OccluderType = visWorldOccluderType.Exterior;

            cmesh.Mesh = new CResourceAsyncReference<CMesh>(line.template_path);
            cmesh.MeshAppearance = string.IsNullOrEmpty(line.app) ? "default" : line.app;

            ((IRedArray)wss.Nodes).Insert(index, wenh);
            SetCoords(current, index, line, updatecoords, pos, rot);
        }

        private void SetCoords(worldNodeData current, int index, Prop line, bool updatecoords = true, Vec4 pos = default, Quat rot = default)
        {
            if (pos == default || rot == default)
            {
                (pos, rot) = GetPosRot(line);
            }

            var scale = line.isunreal ? GetScale(line, 1) : GetScale(line);
            var f = line.isunreal ? (float)0.01 : 1;
            var s = line.isunreal ? -1 : 1;

            if (line.center != default && updatecoords)
            {
                pos = UpdateCoords(pos, line.center);
                current.Position.X += s * pos.X * f;
                current.Position.Y += pos.Y * f;
                current.Position.Z += pos.Z * f;
                current.Position.W *= pos.W * f;
            }
            else
            {
                current.Position = Vec4.Multiply(f, pos);
                current.Position.X = s * current.Position.X;
            }

            current.Orientation = rot;
            //doesn't do anything in ents ?!?
            current.Scale = scale;
            current.Pivot.X = current.Position.X;
            current.Pivot.Y = current.Position.Y;
            current.Pivot.Z = current.Position.Z;
            //definitely does not go to 5000
            current.MaxStreamingDistance = 20000;
            //seem to be doing something to the max distance, kinda
            current.UkFloat1 = 20000;
            current.Uk11 = 20000;
            current.NodeIndex = (CUInt16)index;
            AddCurrent(current);
        }

        private void AddCurrent(worldNodeData current)
        {
            if (Parent?.Data is DataBuffer db00 &&
                db00.Buffer.Data is worldNodeDataBuffer db0)
            {
                if (!db0.Lookup.ContainsKey(current.NodeIndex))
                {
                    db0.Lookup[current.NodeIndex] = new();
                }
                db0.Lookup[current.NodeIndex].Add(current);
            }

            if (Parent?.Data is DataBuffer db && db.Buffer.Data is IRedType irt)
            {
                if (irt is IRedArray ira && ira.InnerType.IsAssignableTo(current.GetType()))
                {
                    var indexx = Parent.GetIndexOf(this) + 1;
                    if (indexx == -1 || indexx > ira.Count)
                    {
                        indexx = ira.Count;
                    }
                    ira.Insert(indexx, current);
                }
            }
        }

        private List<Child> GetLines(JsonAMM2 json)
        {
            ArgumentNullException.ThrowIfNull(json.name, nameof(json));
            ArgumentNullException.ThrowIfNull(json.pos, nameof(json));
            ArgumentNullException.ThrowIfNull(json.rot, nameof(json));

            var props = new List<Child>();

            var v = new Child(json.name, json.pos, json.rot);
            props.Add(v);

            foreach (var child in json.childs)
            {
                GetLines(child, props);
            }

            return props;
        }

        private void GetLines(Child c, List<Child> props)
        {
            var v = new Child(c.name, c.pos, c.rot)
            {
                path = c.path,
                app = c.app
            };
            props.Add(v);
            if (c.childs is not null)
            {
                foreach (var cc in c.childs)
                {
                    GetLines(cc, props);
                }
            }
        }

        private static Vec4 GetCenter(JsonAMM2 r)
        {
            ArgumentNullException.ThrowIfNull(r.pos, nameof(r));
            return new(r.pos.x, r.pos.y, r.pos.z, r.pos.w);
        }

        private void AddFromAMM(List<Prop> props, string tr, bool updatecoords = true)
        {
            try
            {
                var am = Locator.Current.GetService<IArchiveManager>().NotNull();
                var sm = Locator.Current.GetService<ISettingsManager>().NotNull();
                am.LoadModsArchives(new FileInfo(sm.CP77ExecutablePath.NotNull()));
                var af = am.GetGroupedFiles();

                var tempbool = am.IsModBrowserActive;
                am.IsModBrowserActive = true;
                var tt2 = am.GetGroupedFiles();

                var archiveMeshList = af[".mesh"].GroupBy(x => x.Key).Select(x => x.First()).ToList();
                var modMeshList = tt2[".mesh"].GroupBy(x => x.Key).Select(x => x.First()).ToList();
                var archiveEntList = af[".ent"].GroupBy(x => x.Key).Select(x => x.First()).ToList();
                var modEntList = tt2[".ent"].GroupBy(x => x.Key).Select(x => x.First()).ToList();
                am.IsModBrowserActive = tempbool;

                //lists of all ents and mesh found in archives and mods
                var entList = archiveEntList.Concat(modEntList).ToList();
                var meshList = archiveMeshList.Concat(modMeshList).ToList();

                var center = updatecoords ? GetCenter(GetPos(props)) : new Vec4();

                foreach (var line in props)
                {
                    if (updatecoords)
                    { line.center = center; }
                    var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);

                    var scale = GetScale(line);
                    var door = line.isdoor is bool b && b;

                    if (scale != Vec3.One)
                    {
                        var path = line.template_path;
                        var sp = Path.GetFileName(path);
                        var spm = Path.ChangeExtension(sp, ".mesh");

                        //find ent
                        var foundents = entList.Where(x => x.FileName.Contains(sp)).Select(_ => _).ToList();

                        if (foundents.Any() && foundents.Last() is FileEntry foundent)
                        {
                            using var stream = new MemoryStream();
                            foundent.Extract(stream);
                            using var reader = new BinaryReader(stream);
                            var cr2wFile = Locator.Current.GetService<Red4ParserService>().NotNull().ReadRed4File(reader);

                            //open ent
                            if (cr2wFile is not null &&
                                cr2wFile.RootChunk is entEntityTemplate rc &&
                                rc.CompiledData.Data is RedPackage data)
                            {
                                var meshes = data.Chunks.Where(x => x is entMeshComponent)
                                             .Select(_ => (entMeshComponent)_).ToList();

                                for (var i1 = 0; i1 < meshes.Count; i1++)
                                {
                                    var mesh = meshes[i1];
                                    var (p, r) = GetPosRot(line);

                                    var t = mesh.LocalTransform.Position;
                                    var mp = new Vec4(t.X, t.Y, t.Z, 1);

                                    var np = p + mp;
                                    var nrq = r * mesh.LocalTransform.Orientation;

                                    var newline = new Prop()
                                    {
                                        name = line.name + "_" + i1,
                                        app = line.app == "" ? "default" : line.app,
                                        template_path = mesh.Mesh.DepotPath,
                                        scale = line.scale
                                    };

                                    AddMesh(tr, newline, updatecoords, np, nrq);
                                }
                            }
                            else
                            {
                                var foundmesh = meshList.Where(x => x.FileName.Contains(spm)).Select(_ => _.FileName).ToList();
                                if (foundmesh.Count > 0)
                                {
                                    line.template_path = foundmesh.Last();
                                    AddMesh(tr, line, updatecoords);
                                }
                            }
                        }
                        else
                        {
                            var foundmesh = meshList.Where(x => x.FileName.Contains(spm)).Select(_ => _.FileName).ToList();
                            if (foundmesh.Count > 0)
                            {
                                line.template_path = foundmesh.Last();
                                AddMesh(tr, line, updatecoords);
                            }
                            else
                            {
                                //those ents will not be scaled properly
                                //if they load anything at all
                                AddEntity(tr, line, updatecoords);
                            }
                        }
                    }
                    else
                    {
                        AddEntity(tr, line, updatecoords);
                    }
                }
            }
            catch (Exception ex) { _loggerService.Error(ex); }
        }

        private void AddFromAMM2(JsonAMM2 json, string tr, bool updatecoords = true)
        {
            var center = updatecoords ? GetCenter(json) : new Vec4();
            var props = GetLines(json);

            foreach (var c in props)
            {
                var line = Prop.FromChild(c);
                if (updatecoords)
                {
                    line.center = center;
                }
                AddEntity(tr, line, updatecoords);
            }
        }

        private void AddFromUnreal(List<List<object>> json, string tr, bool updatecoords = true)
        {
            var center = updatecoords ? GetCenter(json) : new Vec4();
            var pm = Locator.Current.GetService<IProjectManager>().NotNull();
            ArgumentNullException.ThrowIfNull(pm.ActiveProject);

            foreach (var o in json)
            {
                var line = Prop.FromObjectList(o, pm.ActiveProject);

                if (updatecoords)
                {
                    line.center = center;
                }
                line.isunreal = true;
                AddMesh(tr, line, updatecoords);
            }
        }

        private void AddFromObjectSpawner(List<JsonObjectSpawner> json, string tr, bool updatecoords = true)
        {
            var v = json.Select(x =>
            {
                ArgumentNullException.ThrowIfNull(x.pos);

                return new Vec4(x.pos.x, x.pos.y, x.pos.z, x.pos.w);
            }).ToList();


            var center = updatecoords ? GetCenter(v) : new Vec4();

            foreach (var o in json)
            {
                var line = Prop.FromJsonObjectSpawner(o);
                if (updatecoords)
                {
                    line.center = center;
                }
                AddEntity(tr, line, updatecoords);
            }
        }

        private void AddFromBlender(List<worldNodeData> json, string tr, bool updatecoords = false)
        {
            if (Parent?.Data is DataBuffer db && db.Buffer.Data is IRedArray ira)
            {
                for (var i = 0; i < json.Count; i++)
                {
                    var line = json[i];
                    ira[i] = line;
                }
            }
        }

        private Vec3 GetScale(Prop line, float factor = (float)0.01)
        {
            var scala = line.scale == "nil"
                ? null
                : RedJsonSerializer.Deserialize<Vec3S>(PutQuotes(line.scale));

            if (scala is null)
            {
                return Vec3.One;
            }
            else
            {
                ArgumentNullException.ThrowIfNull(scala.x);
                ArgumentNullException.ThrowIfNull(scala.y);
                ArgumentNullException.ThrowIfNull(scala.z);

                return new Vec3(float.Parse(scala.x) * factor, float.Parse(scala.y) * factor, float.Parse(scala.z) * factor);
            }
        }

        public static void CreateFromYawPitchRoll(Quaternion r, out float yaw, out float pitch, out float roll)
        {
            yaw = MathF.Atan2(2.0f * ((r.J * r.R) + (r.I * r.K)), 1.0f - (2.0f * ((r.I * r.I) + (r.J * r.J))));
            pitch = MathF.Asin(2.0f * ((r.I * r.R) - (r.J * r.K)));
            roll = MathF.Atan2(2.0f * ((r.I * r.J) + (r.K * r.R)), 1.0f - (2.0f * ((r.I * r.I) + (r.K * r.K))));
        }

        #endregion


    }
}
