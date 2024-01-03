using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using DynamicData.Binding;
using Microsoft.ClearScript.JavaScript;
using Microsoft.Win32;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Nodify;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using YamlDotNet.Serialization;
using static WolvenKit.App.ViewModels.Dialogs.DialogViewModel;
using static WolvenKit.RED4.Types.RedReflection;
using CKeyValuePair = WolvenKit.RED4.Types.CKeyValuePair;
using IRedString = WolvenKit.RED4.Types.IRedString;
using Mat4 = System.Numerics.Matrix4x4;
using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel : ObservableObject, ISelectableTreeViewItemModel, INode<ReferenceSocket>
{
    private readonly IChunkViewmodelFactory _chunkViewmodelFactory;
    private readonly IDocumentTabViewmodelFactory _tabViewmodelFactory;
    private readonly ILoggerService _loggerService;
    private readonly ISettingsManager _settingsManager;
    private readonly IProjectManager _projectManager;
    private readonly IGameControllerFactory _gameController;
    private readonly IArchiveManager _archiveManager;
    private readonly IHashService _hashService;
    private readonly AppViewModel _appViewModel;
    private readonly ITweakDBService _tweakDbService;
    private readonly ILocKeyService _locKeyService;
    private readonly Red4ParserService _parserService;

    private static readonly List<string> s_hiddenProperties = new() 
    { 
        "meshMeshMaterialBuffer.rawDataHeaders", 
        "meshMeshMaterialBuffer.rawData", 
        "entEntityTemplate.compiledData", 
        "appearanceAppearanceDefinition.compiledData" 
    };

    private bool _propertiesLoaded;

    private const BindingFlags s_defaultLookup = BindingFlags.Instance | BindingFlags.Public;

    private readonly RDTDataViewModel? _tab;

    private Flags? _flags;

    private int _propertyCountCache = -1;

    public int NodeIdxInParent = -1;

    #region Constructors

    public ChunkViewModel(IRedType data, string name, AppViewModel appViewModel,
        IChunkViewmodelFactory chunkViewmodelFactory,
        IDocumentTabViewmodelFactory tabViewmodelFactory,
        IHashService hashService,
        ILoggerService loggerService,
        IProjectManager projectManager,
        IGameControllerFactory gameController,
        ISettingsManager settingsManager,
        IArchiveManager archiveManager,
        ITweakDBService tweakDbService,
        ILocKeyService locKeyService,
        Red4ParserService parserService,
        ChunkViewModel? parent = null,
        bool isReadOnly = false
    )
    {
        _chunkViewmodelFactory = chunkViewmodelFactory;
        _tabViewmodelFactory = tabViewmodelFactory;
        _hashService = hashService;
        _loggerService = loggerService;
        _settingsManager = settingsManager;
        _projectManager = projectManager;
        _gameController = gameController;
        _archiveManager = archiveManager;
        _tweakDbService = tweakDbService;
        _locKeyService = locKeyService;
        _parserService = parserService;

        _appViewModel = appViewModel;
        _data = data;
        Parent = parent;
        _propertyName = name;
        IsReadOnly = isReadOnly;

        // If the parent is an array, the numeric index will be passed as property name 
        if (IsInArray && int.TryParse(name, out var arrayIndex))
        {
            NodeIdxInParent = arrayIndex;
        }
            

        SelfList = new ObservableCollectionExtended<ChunkViewModel>(new[] { this });

        if (HasChildren())
        {
            TempList = new ObservableCollectionExtended<ChunkViewModel>(new[] 
            {
                chunkViewmodelFactory.ChunkViewModel(new RedDummy(), nameof(RedDummy), _appViewModel, this) 
            });
        }

        CalculateValue();
        CalculateDescriptor();
        CalculateIsDefault();
    }

    public ChunkViewModel(IRedType data, RDTDataViewModel tab, AppViewModel appViewModel,
        IChunkViewmodelFactory chunkViewmodelFactory,
        IDocumentTabViewmodelFactory tabViewmodelFactory,
        IHashService hashService,
        ILoggerService loggerService,
        IProjectManager projectManager,
        IGameControllerFactory gameController,
        ISettingsManager settingsManager,
        IArchiveManager archiveManager,
        ITweakDBService tweakDbService,
        ILocKeyService locKeyService,
        Red4ParserService parserService,
        bool isReadOnly = false
        ) 
        : this(data, nameof(RDTDataViewModel), appViewModel,
            chunkViewmodelFactory, tabViewmodelFactory, hashService, loggerService, projectManager,
            gameController, settingsManager, archiveManager, tweakDbService, locKeyService, parserService, null,
            isReadOnly
              )
    {
        _tab = tab;
        RelativePath = _tab.Parent.RelativePath;
        IsExpanded = true;
        //Data = export;
        //if (!PropertiesLoaded)
        //{
        //CalculateProperties();
        //}
        //TVProperties.AddRange(Properties);
        //this.RaisePropertyChanged("Data");

        //this.WhenAnyValue(x => x.Data).Skip(1).Subscribe((x) => Tab?.Parent.SetIsDirty(true));
    }

    public ChunkViewModel(IRedType export, ReferenceSocket socket, AppViewModel appViewModel,
        IChunkViewmodelFactory chunkViewmodelFactory,
        IDocumentTabViewmodelFactory tabViewmodelFactory,
        IHashService hashService,
        ILoggerService loggerService,
        IProjectManager projectManager,
        IGameControllerFactory gameController,
        ISettingsManager settingsManager,
        IArchiveManager archiveManager,
        ITweakDBService tweakDbService,
        ILocKeyService locKeyService,
        Red4ParserService parserService,
        bool isReadOnly = false
        ) 
        : this(export, nameof(ReferenceSocket), appViewModel,
              chunkViewmodelFactory, tabViewmodelFactory, hashService, loggerService, projectManager,
              gameController, settingsManager, archiveManager, tweakDbService, locKeyService, parserService, null, isReadOnly
              )
    {
        Socket = socket;
        socket.Node = this;
        RelativePath = socket.File;
    }
    
    partial void OnIsSelectedChanged(bool value)
    {
        if (IsSelected && !_propertiesLoaded)
        {
            CalculateProperties();
        }
    }

    partial void OnIsExpandedChanged(bool value)
    {
        if (IsExpanded && !_propertiesLoaded)
        {
            CalculateProperties();
        }

        if (IsShiftBeingHeld)
        {
            SetChildExpansionStates(IsExpanded);
        }
    }

    partial void OnDataChanged(IRedType value)
    {
        CalculateValue();
        CalculateDescriptor();
        CalculateIsDefault();

        if (Parent is null)
        {
            return;
        }

        if (Tab is not null)
        {
            if (Parent.Data is IRedArray arr)
            {
                // use PropertyName for now, since Name doesn't always work
                var index = int.Parse(PropertyName);
                if (index != -1)
                {
                    arr[index] = Data;
                    Tab.Parent.SetIsDirty(true);
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

            if (parentData is RedBaseClass rbc)
            {
                if (Data is RedDummy)
                {
                    rbc.ResetProperty(PropertyName);
                }
                else
                {
                    rbc.SetProperty(PropertyName, Data);
                }

                Tab.Parent.SetIsDirty(true);
                Parent.NotifyChain("Data");
            }
            else
            {
                var pi = parentData?.GetType().GetProperty(PropertyName);
                if (pi is not null)
                {
                    if (pi.CanWrite)
                    {
                        pi.SetValue(parentData, Data is RedDummy ? null : Data);
                    }
                    else
                    {
                        Parent.Data = parentData is IRedRef
                            ? RedTypeManager.CreateRedType(parentData.RedType, Data)
                            : throw new Exception();
                    }

                    Tab.Parent.SetIsDirty(true);
                    Parent.NotifyChain("Data");
                }
            }
        }

        Parent.CalculateDescriptor();

        // For materials: Update display of other entry
        if (Parent.Data is CMeshMaterialEntry meshMaterialEntry)
        {
            string[] keys =
            {
                "localMaterialBuffer.materials", "preloadLocalMaterialInstances", "externalMaterials",
                "preloadExternalMaterials",
            };

            ushort idx = meshMaterialEntry.Index;

            foreach (var key in keys)
            {
                var list = GetRootModel().GetModelFromPath(key);
                if (list is not null && list.Properties.Count > idx)
                {
                    list.Properties[idx].CalculateDescriptor();
                    list.Properties[idx].CalculateValue();
                }
            }
        }
        // if we were an external material instance without a descriptor because we haven't been unique, update all
        else if (
            Parent.Data is CResourceAsyncReference<IMaterial>
            || Data is CResourceAsyncReference<IMaterial>
        )
        {
            Parent.RecalculateProperties();
            CalculateDescriptor();
            Parent.CalculateDescriptor();
        }
        else if (Data is CName && Parent.Data is IRedArray &&
                 Parent.Parent is
                     {
                         ResolvedData: meshMeshAppearance
                     } or
                     {
                         ResolvedData: redTagList
                     } or
                     {
                         ResolvedData: entVisualTagsSchema
                     })

        {
            Parent.Parent?.CalculateValue();
        }


        if (Parent.IsValueExtrapolated)
        {
            Parent.CalculateValue();
        }
    }

    

    #endregion Constructors

    #region Properties

    public ObservableCollectionExtended<ChunkViewModel> Properties { get; } = new();

    public ObservableCollectionExtended<ChunkViewModel> SelfList { get; set; } = new();

    public ObservableCollectionExtended<ChunkViewModel> TempList { get; set; } = new();

    public ObservableCollectionExtended<ChunkViewModel> TVProperties => _propertiesLoaded ? Properties : TempList;

    public ObservableCollectionExtended<ChunkViewModel> DisplayProperties => MightHaveChildren() ? Properties : SelfList;

    // Fix annoying "Property not found" error spam
    public bool IsDeletable => true;

    // Second view column. Populated in CalculateValue().
    // For view style, see PropertyValueStyle in RedTreeView.xml
    [ObservableProperty] private string? _value;

    // First view column (e.g. name). 
    // For view style, see PropertyKeyStyle in RedTreeView.xml
    [ObservableProperty] private string? _descriptor;

    // For view decoration, default values will be displayed in italic
    [ObservableProperty] private bool _isDefault;

    // Would be cool to still allow copying from readonly nodes :/
    [ObservableProperty] private bool _isReadOnly;

    // For view decoration. Extrapolated values will be darker.
    [ObservableProperty] private bool _isValueExtrapolated;

    [ObservableProperty]
    //[NotifyCanExecuteChangedFor(nameof(OpenRefCommand))]
    //[NotifyCanExecuteChangedFor(nameof(AddRefCommand))]
    //[NotifyCanExecuteChangedFor(nameof(AddHandleCommand))]
    //[NotifyCanExecuteChangedFor(nameof(AddItemToArrayCommand))]
    //[NotifyCanExecuteChangedFor(nameof(SaveBufferToDiskCommand))]
    //[NotifyCanExecuteChangedFor(nameof(LoadBufferFromDiskCommand))]
    //[NotifyCanExecuteChangedFor(nameof(RegenerateAppearanceVisualControllerCommand))]
    //[NotifyCanExecuteChangedFor(nameof(AddItemToCompiledDataCommand))]
    //[NotifyCanExecuteChangedFor(nameof(DeleteItemCommand))]
    private IRedType _data;

    [ObservableProperty] private ResourcePath _relativePath;

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

    public bool ShouldShowHandleOperations => PropertyType.IsAssignableTo(typeof(IRedBaseHandle));

    public bool ShouldShowArrayOps => IsInArray || IsArray;

    public bool ShouldShowClassOperations => PropertyType.IsAssignableTo(typeof(RedBaseClass));

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
                data = handle.GetValue() ?? (IRedType)new RedDummy();
            }
            else if (Data is CVariant v)
            {
                data = v.Value.NotNull();
            }
            else if (Data is TweakDBID tdb && _propertiesLoaded)
            {
                var flat = TweakDBService.GetFlat(tdb);
                if (flat is not null)
                {
                    data = flat;
                }
                else
                {
                    var record = TweakDBService.GetRecord(tdb);
                    if (record is not null)
                    {
                        data = record;
                    }
                }
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
            if (IsInArray && NodeIdxInParent > -1)
            {
                return NodeIdxInParent.ToString();
            }

            // TODO: This is obsolete with NodeIdxInParent
            if (IsInArray && Parent is not null)
            {
                return Parent.GetIndexOf(this).ToString().NotNull();
            }

            if (Data is IBrowsableType ibt)
            {
                return ibt.GetBrowsableName();
            }
            //else if (Data is RedDummy dummy)
            //{
            //    return nameof(RedDummy);
            //}
            return PropertyName;
            
        }
    }

    public int Level => Parent == null ? 0 : Parent.Level + 1;

    public int DetailsLevel => IsSelected || Parent == null ? 0 : Parent.DetailsLevel + 1;

    public Type PropertyType
    {
        get
        {
            var type = Data.GetType();
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
                    if (type == typeof(RedDummy) || type == propInfo.Type)
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
                return handle.GetValue()?.GetType() ?? handle.InnerType;
            }
            if (Data is CVariant v)
            {
                return v.Value?.GetType() ?? null;
            }
            if (Data is TweakDBID tdb)
            {
                if (TweakDBService.TryGetType(tdb, out var type))
                {
                    return type;
                }
            }
            if (Data is ITweakXLItem iti)
            {
                if (TweakDBService.TryGetType(iti.ID, out var type))
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

    public Flags? Flags => _flags?.Clone();

    public string Type
    {
        get
        {
            var redName = GetRedTypeFromCSType(PropertyType, Flags);
            return redName != "" ? redName : PropertyType.Name;
        }
    }

    public string ResolvedType => ResolvedPropertyType is not null ? GetTypeRedName(ResolvedPropertyType) ?? ResolvedPropertyType.Name : "";

    public bool TypesDiffer => PropertyType != ResolvedPropertyType;

    public bool IsInArray => Parent is not null && Parent.IsArray;

    public bool IsArray =>(PropertyType.IsAssignableTo(typeof(IRedArray)) ||
                ResolvedPropertyType is not null && ResolvedPropertyType.IsAssignableTo(typeof(IList)) ||
                ResolvedPropertyType is not null && ResolvedPropertyType.IsAssignableTo(typeof(CR2WList)) ||
                ResolvedPropertyType is not null && ResolvedPropertyType.IsAssignableTo(typeof(RedPackage)));


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
                    if (TweakDBService.Exists(tdb))
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
            OnPropertyChanged(nameof(PropertyCount));
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
            if (PropertyType.IsAssignableTo(typeof(IRedArray)))
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

    public IRedType? ParentData
    {
        get
        {
            var parentData = Parent?.Data;

            if (parentData is IRedBaseHandle handle)
            {
                parentData = handle.GetValue();
            }
            else if (parentData is CVariant cVariant)
            {
                parentData = cVariant.Value;
            }

            return parentData;
        }
    }

    #endregion Properties

    #region commands

    private TweakXL GetTXL()
    {
        var recordName = Name;
        IRedType? tdbEntry = null;

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
                tdbEntry = TweakDBService.GetFlat(tweakDBID);
                tdbEntry ??= TweakDBService.GetRecord(tweakDBID);
                txl.ID = tweakDBID;
                if (TweakDBService.TryGetType(tweakDBID, out var type))
                {
                    txl.Type = type.Name;
                }
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
        if (tdbEntry is gamedataTweakDBRecord record)
        {
            record.GetPropertyNames().ForEach(name => txl.Properties.Add(name, record.GetProperty(name).NotNull()));
        }

        return txl;
    }

    private string GetTXLString(TweakXL txl)
    {
        var serializer = new SerializerBuilder()
                    .WithTypeConverter(new TweakXLYamlTypeConverter(_locKeyService, _tweakDbService))
                    .WithIndentedSequences()
                    .Build();
        var yaml = serializer.Serialize(new TweakXLFile { txl });
        return yaml;
    }

    [RelayCommand]
    private void CopyTXLOverride()
    {
        var yaml = GetTXLString(GetTXL());
        if (!string.IsNullOrEmpty(yaml))
        {
            Clipboard.SetDataObject(yaml);
        }
    }

    [RelayCommand]
    private void CreateTXLOverride()
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }

        var txl = GetTXL();
        var path = Path.Combine(_projectManager.ActiveProject.ResourceTweakDirectory, $"{txl.ID.ResolvedText}.yaml");

        try
        {
            var yaml = GetTXLString(txl);
            File.WriteAllText(path, yaml);

            _loggerService.Success($"TweakXL YAML written for {txl.ID.ResolvedText}.");
        }
        catch (Exception ex)
        {
            _loggerService.Error(ex);
        }
        
    }

    public bool CanBeDroppedOn(ChunkViewModel target) => PropertyType == target.PropertyType;

    private bool CanOpenRef() => Data is IRedRef r && r.DepotPath != ResourcePath.Empty;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanOpenRef))]
    private void OpenRef()
    {
        if (Data is IRedRef r)
        {
            _appViewModel.OpenFileFromDepotPath(r.DepotPath);
        }
    }

    private bool CanAddRef() => Data is IRedRef r && r.DepotPath != ResourcePath.Empty;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanAddRef))]
    private async Task AddRef()
    {
        if (Data is IRedRef r)
        {
            await _gameController.GetController().AddFileToModModal(r.DepotPath.GetRedHash());
        }
    }

    private bool CanAddHandle() => PropertyType.IsAssignableTo(typeof(IRedBaseHandle));   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanAddHandle))]
    private async Task AddHandle()
    {
        var data = RedTypeManager.CreateRedType(PropertyType);
        if (data is IRedBaseHandle handle)
        {
            var existing = new ObservableCollection<string>(AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => handle.InnerType.IsAssignableFrom(p) && p.IsClass).Select(x => x.Name));
            await _appViewModel.SetActiveDialog(new CreateClassDialogViewModel(existing, false)
            {
                DialogHandler = HandlePointer
            });
        }
    }

    private bool CanAddItemToArray() => Parent is not null && !IsReadOnly && (PropertyType.IsAssignableTo(typeof(IRedArray)) || PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)));   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanAddItemToArray))]
    private async Task AddItemToArray()
    {
        ArgumentNullException.ThrowIfNull(Parent);

        if (PropertyType.IsAssignableTo(typeof(IRedArray)))
        {
            if (!CreateArray())
            {
                throw new Exception("Error while accessing or creating the array!");
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
                        await _appViewModel.SetActiveDialog(new SelectRedTypeDialogViewModel
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
                    await _appViewModel.SetActiveDialog(new CreateClassDialogViewModel(existing, true)
                    {
                        DialogHandler = handler
                    });
                }
            }
        }

        if (PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)))
        {
            if (!CreateArray())
            {
                throw new Exception("Error while accessing or creating the array!");
            }

            var curve = (IRedLegacySingleChannelCurve)Data;

            var type = curve.ElementType;
            var newItem = RedTypeManager.CreateRedType(type);
            InsertChild(-1, newItem);
        }
    }

    private bool CanSaveBufferToDisk() => Data is IRedBufferWrapper { Buffer.MemSize: > 0 };   // TODO RelayCommand check notify
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

    private bool CanLoadBufferFromDisk() => PropertyType.IsAssignableTo(typeof(IRedBufferWrapper));   // TODO RelayCommand check notify
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

        Tab?.Parent.SetIsDirty(true);
    }

    private bool CanRegenerateAppearanceVisualController() => Name == "components" && Data is CArray<entIComponent>;   // TODO RelayCommand check notify
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

    private bool CanAddItemToCompiledData() => ResolvedPropertyType is not null  && PropertyType.IsAssignableTo(typeof(IRedBufferPointer));   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanAddItemToCompiledData))]
    private async Task AddItemToCompiledData()
    {
        ArgumentNullException.ThrowIfNull(ResolvedPropertyType);
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
            await _appViewModel.SetActiveDialog(new CreateClassDialogViewModel(existing, true)
            {
                DialogHandler = HandleChunk
            });
        }
    }

    private bool CanDeleteItem() => !IsReadOnly && IsInArray && Tab is not null && Data is not null;   // TODO RelayCommand check notify
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
                ary.RemoveAt(int.Parse(Name));
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

            Tab.Parent.SetIsDirty(true);
            Parent.RecalculateProperties();
        }
        catch (Exception ex) { _loggerService.Error(ex); }
    }

    private bool CanImportWorldNodeData() => Data is worldNodeData && PropertyCount > 0;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanImportWorldNodeData))]
    private Task ImportWorldNodeDataAsync() => ImportWorldNodeDataTask(true);

    [RelayCommand(CanExecute = nameof(CanImportWorldNodeData))]   // TODO RelayCommand check notify
    private Task ImportWorldNodeDataWithoutCoordsAsync() => ImportWorldNodeDataTask(false);

    private bool CanDeleteSelection() => IsInArray && Tab is not null && Parent is not null;   // TODO RelayCommand check notify
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
                    DeleteFullSelection(indices, dict);
                }
            }
            else if (Parent.Data is IRedArray db4)
            {
                DeleteFullSelection(ts.Select(_ => int.Parse(_.Name)).ToList(), db4);
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

    private bool CanExportNodeData() => IsInArray && Parent?.Data is DataBuffer rb && Parent?.Parent?.Data is worldStreamingSector && rb.Data is worldNodeDataBuffer;   // TODO RelayCommand check notify
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

    private bool CanExportChunk() => PropertyCount > 0;   // TODO RelayCommand check notify
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

    private bool CanOpenChunk() => Data is RedBaseClass && Parent is not null && Tab is not null;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanOpenChunk))]
    private void OpenChunk()
    {
        ArgumentNullException.ThrowIfNull(Tab);
        if (Data is RedBaseClass cls)
        {
            Tab.Parent.TabItemViewModels.Add(_tabViewmodelFactory.RDTDataViewModel(cls, Tab.Parent, _appViewModel, _chunkViewmodelFactory));
        }
    }

    private bool CanCopyHandle() => Data is IRedBaseHandle;   // TODO RelayCommand check notify
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

            return PropertyType.IsAssignableTo(typeof(IRedBaseHandle));
        }
        return false;
    }   // TODO RelayCommand check notify
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
                if (destinationHandle.InnerType.IsAssignableFrom(sourceHandle.GetValue().NotNull().GetType()))
                {
                    destinationHandle.SetValue(sourceHandle.GetValue());
                    RecalculateProperties(destinationHandle);
                    RedDocumentTabViewModel.CopiedChunk = null;
                }
            }
            else if (Data is RedDummy)
            {
                if (PropertyType.GetGenericTypeDefinition() == typeof(CHandle<>))
                {
                    Data = CHandle.Parse(sourceHandle.InnerType, sourceHandle.GetValue());
                    RecalculateProperties(Data);
                    RedDocumentTabViewModel.CopiedChunk = null;
                }
                else if (PropertyType.GetGenericTypeDefinition() == typeof(CWeakHandle<>))
                {
                    Data = CWeakHandle.Parse(sourceHandle.InnerType, sourceHandle.GetValue());
                    RecalculateProperties(Data);
                    RedDocumentTabViewModel.CopiedChunk = null;
                }
            }
        }
    }

    private bool CanResetObject() => Parent != null;
    [RelayCommand(CanExecute = nameof(CanResetObject))]
    private void ResetObject()
    {
        if (Parent == null)
        {
            return;
        }

        IRedType data = new RedDummy();
        if (ParentData is RedBaseClass redBaseClass)
        {
            var defaultValue = redBaseClass.GetPropertyDefaultValue(PropertyName);
            if (defaultValue != null)
            {
                data = defaultValue;
            }
        }

        Data = data;
        RecalculateProperties(Data);
    }

    private bool CanCopyChunk() => IsInArray;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanCopyChunk))]
    private void CopyChunk()
    {
        try
        {
            RedDocumentTabViewModel.CopiedChunk = Data is IRedCloneable irc ? (IRedType)irc.DeepCopy() : Data;
        }
        catch (Exception ex) { _loggerService.Error(ex); }
    }

    private bool CanPasteChunks()
    {
        if (RedDocumentTabViewModel.CopiedChunk is null && RedDocumentTabViewModel.CopiedChunks.Count == 0)
        {
            return false;
        }

        Type? innerType = null;
        if (PropertyType.IsAssignableTo(typeof(IRedArray)))
        {
            innerType = PropertyType.GetGenericArguments()[0];
        }
        else if (Parent != null && Parent.PropertyType.IsAssignableTo(typeof(IRedArray)))
        {
            innerType = Parent.PropertyType.GetGenericArguments()[0];
        }

        if (innerType == null)
        {
            return false;
        }

        if (RedDocumentTabViewModel.CopiedChunk != null)
        {
            return CheckTypeCompatibility(innerType, RedDocumentTabViewModel.CopiedChunk.GetType()) != TypeCompability.None;
        }

        return RedDocumentTabViewModel.CopiedChunks.All(chunk => CheckTypeCompatibility(innerType, chunk.GetType()) != TypeCompability.None);
    } // TODO RelayCommand check notify

    [RelayCommand(CanExecute = nameof(CanPasteChunks))]
    private void PasteChunk()
    {
        try
        {
            if (RedDocumentTabViewModel.CopiedChunk is null)
            {
                return;
            }
            if (RedDocumentTabViewModel.CopiedChunk is IRedCloneable irc)
            {
                if (PropertyType.IsAssignableTo(typeof(IRedArray)))
                {
                    if (!CreateArray())
                    {
                        throw new Exception("Error while accessing or creating the array!");
                    }

                    var clone = irc.DeepCopy();
                    if (clone is IRedType redtype)
                    {
                        InsertChild(-1, redtype);
                    }
                }
                else if (Parent != null && Parent.PropertyType.IsAssignableTo(typeof(IRedArray)))
                {
                    var clone = irc.DeepCopy();
                    if (clone is IRedType redtype)
                    {
                        Parent.InsertChild(Parent.GetIndexOf(this) + 1, redtype);
                    }
                }
            }
        }
        catch (Exception ex)
        { 
            _loggerService.Error(ex);
        }
    }

    private bool CanDeleteAll() => !IsReadOnly && (IsArray && PropertyCount > 0 || IsInArray && Parent is not null && Parent.PropertyCount > 0);   // TODO RelayCommand check notify
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

    private bool CanDuplicateChunk() => IsInArray && Parent is not null;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanDuplicateChunk))]
    private void DuplicateChunk()
    {
        if (Parent is null || Data is null)
        {
            return;
        }

        if (Data is IRedCloneable irc)
        {
            Parent.InsertChild(Parent.GetIndexOf(this) + 1, (IRedType)irc.DeepCopy());
        }
        else 
        {
            Parent.InsertChild(Parent.GetIndexOf(this) + 1, Data);
        }
    }

    private bool CanCopySelection() => IsInArray && Parent is not null;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanCopySelection))]
    private void CopySelection()
    {
        if (Parent is not { } || Tab is not { SelectedChunks: IList lst })
        {
            return;
        }

        try
        {
            var ts = Parent.DisplayProperties.Where(property => lst.Contains(property)).ToList();

            var indices = ts.Select(_ => int.Parse(_.Name)).ToList();

            var fullselection = Parent.DisplayProperties
                .Where(_ => indices.Contains(int.Parse(_.Name)))
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

    [RelayCommand(CanExecute = nameof(CanPasteChunks))]
    private void PasteSelection()
    {
        ArgumentNullException.ThrowIfNull(Parent);

        try
        {
            if (RedDocumentTabViewModel.CopiedChunks.Count == 0)
            {
                return;
            }

            if (PropertyType.IsAssignableTo(typeof(IRedArray)) && ResolvedData is RedDummy)
            {
                if (!CreateArray())
                {
                    throw new Exception("Error while accessing or creating the array!");
                }
            }

            var index = Parent.GetIndexOf(this) + 1;
            for (var i = 0; i < RedDocumentTabViewModel.CopiedChunks.Count; i++)
            {
                var e = RedDocumentTabViewModel.CopiedChunks[i];

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
                if (PropertyType.IsAssignableTo(typeof(IRedArray)))
                {
                    if (InsertChild(-1, e))
                    {
                        //RDTDataViewModel.CopiedChunk = null;
                    }
                }
                if (Parent.ResolvedData is IRedBufferPointer)
                {
                    if (Parent.InsertChild(index, e))
                    {
                        //RDTDataViewModel.CopiedChunk = null;
                    }
                }
                
                if (Parent.PropertyType.IsAssignableTo(typeof(IRedArray)))
                {
                    if (Parent.InsertChild(index, e))
                    {
                        //RDTDataViewModel.CopiedChunk = null;
                    }
                }

                index++;
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

        if (Data is null)
        {
            Value = "null";
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
        else if (ResolvedData is CKeyValuePair kvp)
        {
            // If the CValuePair has a value, we'll try to resolve it
            Value = kvp.Value switch
            {
                CName cname => cname.GetResolvedText() ?? "",
                CResourceReference<ITexture> reference => reference.DepotPath.GetResolvedText() ?? "",
                _ => kvp.Value.ToString()
            };
            IsValueExtrapolated = true;
        }
        else if (ResolvedData is meshMeshAppearance { ChunkMaterials: not null } appearance)
        {
            Value = string.Join(", ", appearance.ChunkMaterials);
            IsValueExtrapolated = true;
        }
        // Material instance (mesh): "[2] - engine\materials\multilayered.mt" (show #keyValuePairs)
        else if (ResolvedData is CMaterialInstance { BaseMaterial: { } cResourceReference } material)
        {
            var numMaterials = $"[{material.Values?.Count ?? 0}] - ";
            Value = $"{numMaterials}{cResourceReference.DepotPath.GetResolvedText() ?? "none"}";
            IsValueExtrapolated = true;
        }
        else if (ResolvedData is CResourceAsyncReference<IMaterial> materialRef)
        {
            Value = materialRef.DepotPath.GetResolvedText();
            IsValueExtrapolated = true;
        }
        else if (ResolvedData is workWorkEntryId id)
        {
            Value = $"{id.Id}";
            IsValueExtrapolated = true;
        }
        else if (ResolvedData is workWorkspotAnimsetEntry animsetEntry)
        {
            Value = $"{animsetEntry.Rig.DepotPath.GetResolvedText() ?? "none"}";
            IsValueExtrapolated = true;
        }
        else if (ResolvedData is CMeshMaterialEntry materialDefinition)
        {
            Value = materialDefinition.IsLocalInstance ? "" : " (external)";
            IsValueExtrapolated = true;
        }
        else if (NodeIdxInParent > -1 && ResolvedData is physicsRagdollBodyInfo &&
                 GetRootModel().GetModelFromPath("ragdollNames")?.ResolvedData is CArray<physicsRagdollBodyNames>
                     ragdollNames)
        {
            var ragdollName = ragdollNames[NodeIdxInParent];
            Value =
                $"{ragdollName.ParentAnimName.GetResolvedText() ?? ""} -> {ragdollName.ChildAnimName.GetResolvedText() ?? ""}";
            IsValueExtrapolated = true;
        }
        else if (ResolvedData is animRigRetarget retarget)
        {
            Value = $"{retarget.SourceRig}";
            IsValueExtrapolated = true;
        }
        else if (ResolvedData is redTagList list)
        {
            Value = $"[ {string.Join(", ", list.Tags.ToList().Select(t => t.GetResolvedText().NotNull()).ToArray())} ]";
            IsValueExtrapolated = true;
        }
        else if (NodeIdxInParent > -1 && Parent?.Name == "referenceTracks" &&
                 GetRootModel().GetModelFromPath("trackNames")?.ResolvedData is CArray<CName> trackNames)
        {
            Value = trackNames[NodeIdxInParent].GetResolvedText();
            IsValueExtrapolated = true;
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
            // if a path is resolved in the file, but is not yet added to the list of known hashes, add it
            var depotPath = rr.DepotPath;
            if (!_hashService.Contains(depotPath) && !ResourcePath.IsNullOrEmpty(depotPath))
            {
                _hashService.AddCustom(depotPath.GetResolvedText().NotNull());
            }

            if (depotPath.IsResolvable)
            {
                Value = depotPath.GetResolvedText().NotNull();
            }
            else
            {
                Value = depotPath == ResourcePath.Empty ? "null" : $"{(ulong)depotPath}{_hashService.GetGuessedExtension(depotPath)}";
            }
        }
        else if (Data is IBrowsableType ibt)
        {
            Value = ibt.GetBrowsableValue();
        }
        // factory.csv
        else if (Parent is { Name: "compiledData" } && GetRootModel().Data is C2dArray &&
                 Data is CArray<CString> { Count: 3 } ary)
        {
            IsValueExtrapolated = true;
            Value = ary[1];
        }
        // i18n.json
        else if (Data is localizationPersistenceOnScreenEntry i18n)
        {
            IsValueExtrapolated = true;
            // fall back to male variant only if female variant is
            Value = i18n.FemaleVariant;
            if (Value == "" && i18n.MaleVariant != "")
            {
                Value = i18n.MaleVariant;
            }
        }
      
        if (Value is null)
        {
            Value = "null";
        }

    }
    
    public void CalculateDescriptor()
    {
        Descriptor = "";

        if (Data is worldNodeData sst && Tab is RDTDataViewModel dvm && dvm.Chunks[0].Data is worldStreamingSector wss)
        {
            Descriptor = $"[{sst.NodeIndex}] {wss.Nodes[sst.NodeIndex].NotNull().Chunk.NotNull().DebugName}";
            return;
        }

        if (Data is worldStreamingSectorDescriptor wssd)
        {
            Descriptor = wssd.Data.DepotPath.GetResolvedText().NotNull()
                .Replace("base\\worlds\\03_night_city\\_compiled\\default\\", "").Replace(".streamingsector", "");
            return;
        }

        if (ResolvedData is IRedArray ary && ary.Count > 0)
        {
            // csv files and the like 
            if (Parent is { Name: "compiledData" } && GetRootModel().Data is C2dArray csv)
            {
                var index = 0;
                for (var i = 0; i < csv.CompiledHeaders.Count; i++)
                {
                    if (((string)csv.CompiledHeaders[i]).Contains("name", StringComparison.InvariantCultureIgnoreCase))
                    {
                        index = i;
                        break;
                    }
                }

                Descriptor = $"{ary[index]}";
                if (Descriptor != "")
                {
                    return;
                }
            }

            Descriptor = $"[{ary.Count}]";
        }
        else if (ResolvedData is appearanceAppearancePart)
        {
            Descriptor = ((appearanceAppearancePart)ResolvedData).Resource.DepotPath.GetResolvedText() ?? "";
            if (Descriptor != "")
            {
                return;
            }
        }
        else if (ResolvedData is animAnimSetEntry)
        {
            var animation = ((animAnimSetEntry)ResolvedData).Animation?.GetValue();
            Descriptor = animation?.GetProperty("Name")?.ToString() ?? "";
            if (Descriptor != "")
            {
                return;
            }
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

        if (ResolvedData is CMaterialInstance or CResourceAsyncReference<IMaterial> && NodeIdxInParent > -1
            && GetRootModel().GetModelFromPath("materialEntries")?.ResolvedData is CArray<CMeshMaterialEntry>
                materialEntries && materialEntries.Count > NodeIdxInParent)
        {
            Descriptor = materialEntries[NodeIdxInParent].Name.GetResolvedText() ?? "";
        }
        else if (ResolvedData is localizationPersistenceOnScreenEntry localizationPersistenceOnScreenEntry)
        {
            var desc = $"[{localizationPersistenceOnScreenEntry.PrimaryKey}]";
            if (!string.IsNullOrEmpty(localizationPersistenceOnScreenEntry.SecondaryKey))
            {
                desc += $" {localizationPersistenceOnScreenEntry.SecondaryKey}";
            }

            Descriptor = desc;
        }
        // mesh: boneTransforms (in different coordinate spaces)
        else if (NodeIdxInParent > -1 &&
                 (Parent?.Name == "boneTransforms" || Parent?.Name == "aPoseLS" || Parent?.Name == "aPoseMS") &&
                 GetRootModel().GetModelFromPath("boneNames")?.ResolvedData is CArray<CName> boneNames &&
                 boneNames.Count > NodeIdxInParent)
        {
            Descriptor = boneNames[NodeIdxInParent];
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
            "name", // default property
            "partName", // ?
            "slotName", // ?
            "hudEntryName", // ?
            "stateName", // ?
            "characterRecordId", // tweak record children
            "secondaryKey", // json
            "femaleVariant", // also json
            "maleVariant", // also json
            "n", // ?
            "componentName", // ?
            "parameterName", // ?
            "debugName", // ?
            "idleAnim", // .workspot handle work entry items
            "category", // ?
            "entryName", // ?
            "className", // ?
            "actorName", // ?
            "sectorHash", // sectors
            "propertyPath" // ?
        };
        if (ResolvedData is RedBaseClass irc)
        {
            foreach (var propName in propNames)
            {
                var prop = GetPropertyByRedName(irc.GetType(), propName);
                if (prop is not null)
                {
                    var p = irc.GetProperty(prop.RedName.NotNull());
                    Descriptor = p?.ToString();
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
        OnPropertyChanged(nameof(ResolvedData));

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
            obj = TweakDBService.GetFlat(tdb);
            if (obj is not null)
            {
                Properties.Add(_chunkViewmodelFactory.ChunkViewModel(obj, nameof(TweakDBID), _appViewModel, this, true));
                OnPropertyChanged(nameof(TVProperties));
                return;
            }
            else
            {
                obj = TweakDBService.GetRecord(tdb);
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
                obj = _locKeyService.GetEntry(locKey);
                isreadonly = true;
            }
        }
        else if (obj is gamedataLocKeyWrapper locKey)
        {
            obj = _locKeyService.GetEntry(locKey);
            isreadonly = true;
        }

        if (obj is IRedArray ary)
        {
            for (var i = 0; i < PropertyCount; i++)
            {
                if (ary[i] is IRedType t)
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(t, i.ToString(), _appViewModel, this, isreadonly));
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
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(kvp.Key, "Key", _appViewModel, this, isreadonly));
                }
                else
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(kvp.Value, "Value", _appViewModel, this, isreadonly));
                }
            }
        }
        else if (obj is inkWidgetReference iwr)
        {
            // need to add XPath somewhere in the data structure
            Properties.Add(_chunkViewmodelFactory.ChunkViewModel((CString)"TODO", nameof(inkWidgetReference), _appViewModel, this));
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
                ArgumentNullException.ThrowIfNull(name);

                var t = redClass.GetProperty(name);

                if (t is null)
                {
                    //_loggerService.Warning($"Property is null: {name}");
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(new RedDummy(), propertyInfo.RedName.NotNull(), _appViewModel, this, isreadonly));
                }
                else
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(t, propertyInfo.RedName.NotNull(), _appViewModel, this, isreadonly));
                }
            }

            foreach (var dp in dps)
            {
                ArgumentNullException.ThrowIfNull(dp);
                Properties.Add(_chunkViewmodelFactory.ChunkViewModel(redClass.GetProperty(dp).NotNull(), dp, _appViewModel, this, isreadonly));
            }
        }
        else if (obj is SerializationDeferredDataBuffer sddb)
        {
            if (sddb.Data is RedPackage p4)
            {
                for (var i = 0; i < PropertyCount; i++)
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(p4.Chunks[i], nameof(RedPackage), _appViewModel, this, isreadonly));
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
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(irt, pi.Name, _appViewModel, this, isreadonly));
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
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(p42.Chunks[i], p42.Chunks[i].GetType().Name, _appViewModel, this, isreadonly));
                }
            }
            if (sdb.Data is IParseableBuffer ipb)
            {
                Properties.Add(_chunkViewmodelFactory.ChunkViewModel(ipb.Data.NotNull(), ipb.Data.GetType().Name, _appViewModel, this, isreadonly));
            }
        }
        else if (obj is DataBuffer db)
        {
            if (db.Data is RedPackage p43)
            {
                for (var i = 0; i < PropertyCount; i++)
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(p43.Chunks[i], p43.Chunks[i].GetType().Name, _appViewModel, this, isreadonly));
                }
            }
            else if (db.Data is CR2WList cl)
            {
                for (var i = 0; i < PropertyCount; i++)
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(cl.Files[i].RootChunk, cl.Files[i].RootChunk.GetType().Name, _appViewModel, this, isreadonly));
                }
            }
            else if (db.Data is IList list)
            {
                foreach (var thing in list)
                {
                    if (thing is IRedType redType)
                    {
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(redType, redType.GetType().Name, _appViewModel, this, isreadonly));
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
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(irt, pi.Name, _appViewModel, this, isreadonly));
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
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(t, name, _appViewModel, this, isreadonly));
                    }
                }
            }
            else if (Data is IList list)
            {
                foreach (var thing in list)
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel((IRedType)thing, "Element", _appViewModel, this, isreadonly));
                }
            }
            else if (Data is Dictionary<string, object> dict)
            {
                foreach (var (name, thing) in dict)
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel((IRedType)thing, name, _appViewModel, this, isreadonly));
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
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(irt, pi.Name, _appViewModel, this, isreadonly));
                    }
                }

                if (Data is worldNodeData sst && Tab is RDTDataViewModel dvm && dvm.Chunks[0].Data is worldStreamingSector wss)
                {
                    try
                    {
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(wss.Nodes[sst.NodeIndex].NotNull(), "Node", _appViewModel, this, isreadonly));
                    }
                    catch (Exception ex) { _loggerService.Error(ex); }
                }
            }
        }
        OnPropertyChanged(nameof(TVProperties));
    }

    private void CalculateIsDefault()
    {
        IsDefault = Data is RedDummy;

        if (Parent is not null && Data is not RedDummy)
        {
            var epi = GetPropertyByRedName(Parent.ResolvedPropertyType, PropertyName);
            if (epi is not null)
            {
                //IsDefault = IsDefault(Parent.ResolvedPropertyType, epi, Data);
                IsDefault = epi.IsDefault(ResolvedData);
            }
        }
    }

    // TODO: This is obsolete with NodeIdxInParent - isn't it?
    public int GetIndexOf(ChunkViewModel child)
    {
        if (child.NodeIdxInParent > -1)
        {
            return child.NodeIdxInParent;
        }

        // It should never come to this now, should it?
        for (var i = 0; i < Properties.Count; i++)
        {
            if (ReferenceEquals(Properties[i], child))
            {
                child.NodeIdxInParent = i;
                return i;
            }
        }

        return -1;
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
                if (thing.GetHashCode() == item.Data.GetHashCode())
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
                Tab?.Parent.SetIsDirty(true);
                //RecalculateProperties();
                if (sourceList.GetHashCode() != destList.GetHashCode())
                {
                    oldParent.RecalculateProperties();
                    if (oldParent.Tab is not null && Tab is not null)
                    {
                        if (oldParent.Tab.Parent.GetHashCode() != Tab.Parent.GetHashCode())
                        {
                            oldParent.Tab.Parent.SetIsDirty(true);
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
            if (arrayType == typeof(CArray<>) || arrayType == typeof(CStatic<>) && ira.Count < ira.MaxSize)
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

    private TypeCompability CheckTypeCompatibility(Type destType, Type srcType)
    {
        if (destType.IsAssignableFrom(srcType))
        {
            return TypeCompability.Assignable;
        }

        if (destType.IsAssignableTo(typeof(IRedBaseHandle)) &&
            destType.GetGenericArguments()[0].IsAssignableFrom(srcType))
        {
            return TypeCompability.ClassToHandle;
        }

        if (srcType.IsAssignableTo(typeof(IRedBaseHandle)) &&
            srcType.GetGenericArguments()[0].IsAssignableTo(destType))
        {
            return TypeCompability.HandleToClass;
        }

        return TypeCompability.None;
    }

    private bool CreateArray()
    {
        ArgumentNullException.ThrowIfNull(Parent);

        if (PropertyType.IsAssignableTo(typeof(IRedArray)) || PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)))
        {
            if (Data is RedDummy)
            {
                if (_flags == null || _flags.Equals(Flags.Empty))
                {
                    if (System.Activator.CreateInstance(PropertyType) is IRedType o)
                    {
                        Data = o;
                        return true;
                    }
                }
                else
                {
                    var flags = Flags.NotNull();
                    if (System.Activator.CreateInstance(PropertyType, flags.MoveNext() ? flags.Current : 0) is IRedType o)
                    {
                        Data = o;
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }
        }

        return false;
    }

    public bool InsertChild(int index, IRedType item)
    {
        try
        {
            if (ResolvedData is IRedArray ira)
            {
                var comp = CheckTypeCompatibility(ira.InnerType, item.GetType());
                switch (comp)
                {
                    case TypeCompability.None:
                        return false;
                    case TypeCompability.Assignable:
                        InsertArrayItem(ira, index, item);
                        break;
                    case TypeCompability.HandleToClass:
                    {
                        InsertArrayItem(ira, index, ((IRedBaseHandle)item).GetValue().NotNull());
                        break;
                    }
                    case TypeCompability.ClassToHandle:
                    {
                        var handle = (IRedBaseHandle)System.Activator.CreateInstance(ira.InnerType)!;
                        handle.SetValue((RedBaseClass?)item);
                        InsertArrayItem(ira, index, handle);
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else if (Data is IRedArray ira2) // Not sure why, but seems to be important^^
            {
                var comp = CheckTypeCompatibility(ira2.InnerType, item.GetType());
                switch (comp)
                {
                    case TypeCompability.None:
                        return false;
                    case TypeCompability.Assignable:
                        InsertArrayItem(ira2, index, item);
                        break;
                    case TypeCompability.HandleToClass:
                    {
                        InsertArrayItem(ira2, index, ((IRedBaseHandle)item).GetValue().NotNull());
                        break;
                    }
                    case TypeCompability.ClassToHandle:
                    {
                        var handle = (IRedBaseHandle)System.Activator.CreateInstance(ira2.InnerType)!;
                        handle.SetValue((RedBaseClass?)item);
                        InsertArrayItem(ira2, index, handle);
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
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

            Tab?.Parent.SetIsDirty(true);
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

        OnPropertyChanged("Data");

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


    // Shift: recursively fold/unfold child nodes
    public static bool IsShiftBeingHeld => Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);

    // Shift+Control: recursively fold/unfold nodes all the way
    public static bool IsControlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);


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
        OnPropertyChanged(property);
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
        _appViewModel.CloseDialogCommand.Execute(null);
        if (sender is CreateClassDialogViewModel vm && vm.SelectedClass is not null )
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
                OnPropertyChanged(nameof(Data));
                Tab?.Parent.SetIsDirty(true);
            }
        }
    }

    public void HandleCKeyValuePair(DialogViewModel? sender)
    {
        _appViewModel.CloseDialogCommand.Execute(null);
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
        _appViewModel.CloseDialogCommand.Execute(null);
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
        _appViewModel.CloseDialogCommand.Execute(null);
        if (sender is CreateClassDialogViewModel vm && Data is IRedArray arr && vm.SelectedClass is not null)
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
        Tab?.Parent.SetIsDirty(true);
        RecalculateProperties();

        DeleteAllCommand.NotifyCanExecuteChanged();
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
            Tab?.Parent.SetIsDirty(true);
            RecalculateProperties(irtt);
        }

        ArgumentNullException.ThrowIfNull(Tab);
        var currentfile = FileModel.Create(Tab.Parent.FilePath, _appViewModel.ActiveProject.NotNull());

        _appViewModel.SaveFileCommand.SafeExecute(currentfile);

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

    private void DeleteFullSelection(List<int> l, IRedArray a)
    {
        var sortedList = l.OrderByDescending(x => x).ToList();

        foreach (var i in sortedList)
        {
            try
            {
                a.RemoveAt(i);
            }
            catch (Exception ex)
            {
                _loggerService.Error(ex);
            }
        }

        Tab?.Parent.SetIsDirty(true);
        Parent?.RecalculateProperties();
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

        Tab?.Parent.SetIsDirty(true);
        Parent?.RecalculateProperties();
    }

    private void AddToCopiedChunks(IRedType elem)
    {
        try
        {
            if (elem.GetType().IsValueType)
            {
                RedDocumentTabViewModel.CopiedChunks.Add(elem);
            }
            else if (elem is IRedCloneable irc)
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
        var document = _appViewModel.ActiveDocument;

        if (document is RedDocumentViewModel vm && Tab is not null)
        {
            Tab.Parent.TabItemViewModels.Clear();
            await Task.Delay(1);

            vm.PopulateItems();
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
            var am = _archiveManager;
            var sm = _settingsManager;
            am.LoadModsArchives(new FileInfo(sm.CP77ExecutablePath.NotNull()), sm.AnalyzeModArchives);
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
                        var cr2wFile = _parserService.ReadRed4File(reader);

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
                                    template_path = mesh.Mesh.DepotPath.GetResolvedText().NotNull(),
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
        ArgumentNullException.ThrowIfNull(_projectManager.ActiveProject);

        foreach (var o in json)
        {
            var line = Prop.FromObjectList(o, _projectManager.ActiveProject);

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
        yaw = MathF.Atan2(2.0f * (r.J * r.R + r.I * r.K), 1.0f - 2.0f * (r.I * r.I + r.J * r.J));
        pitch = MathF.Asin(2.0f * (r.I * r.R - r.J * r.K));
        roll = MathF.Atan2(2.0f * (r.I * r.J + r.K * r.R), 1.0f - 2.0f * (r.I * r.I + r.K * r.K));
    }

    #endregion

    private enum TypeCompability
    {
        None,
        Assignable,
        HandleToClass,
        ClassToHandle
    }
}
