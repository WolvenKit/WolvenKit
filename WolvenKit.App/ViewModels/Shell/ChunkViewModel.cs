using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData.Binding;
using Microsoft.Win32;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Nodify;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using YamlDotNet.Serialization;
using static WolvenKit.App.ViewModels.Dialogs.DialogViewModel;
using static WolvenKit.RED4.Types.RedReflection;
using Activator = System.Activator;
using CKeyValuePair = WolvenKit.RED4.Types.CKeyValuePair;
using IRedArray = WolvenKit.RED4.Types.IRedArray;
using IRedString = WolvenKit.RED4.Types.IRedString;
using Mat4 = System.Numerics.Matrix4x4;
using Point = System.Windows.Point;
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
    private readonly IAppArchiveManager _archiveManager;
    private readonly IHashService _hashService;
    private readonly AppViewModel _appViewModel;
    private readonly ITweakDBService _tweakDbService;
    private readonly ILocKeyService _locKeyService;
    private readonly Red4ParserService _parserService;
    private readonly CRUIDService _cruidService;
    private readonly IModifierViewStateService _modifierViewStateService;

    private static readonly List<string> s_hiddenProperties = new() 
    { 
        "meshMeshMaterialBuffer.rawDataHeaders", 
        "meshMeshMaterialBuffer.rawData", 
        "entEntityTemplate.compiledData", 
        "appearanceAppearanceDefinition.compiledData",
        "inkWidgetLibraryItem.packageData"
    };

    private bool _propertiesLoaded;

    private const BindingFlags s_defaultLookup = BindingFlags.Instance | BindingFlags.Public;

    private readonly RDTDataViewModel? _tab;

    private Flags? _flags;

    private int _propertyCountCache = -1;

    public int NodeIdxInParent = -1;

    private EditorDifficultyLevel _currentEditorDifficultyLevel;

    #region Constructors

    public ChunkViewModel(IRedType data, string name, AppViewModel appViewModel,
        IChunkViewmodelFactory chunkViewmodelFactory,
        IDocumentTabViewmodelFactory tabViewmodelFactory,
        IHashService hashService,
        ILoggerService loggerService,
        IProjectManager projectManager,
        IGameControllerFactory gameController,
        ISettingsManager settingsManager,
        IAppArchiveManager archiveManager,
        ITweakDBService tweakDbService,
        ILocKeyService locKeyService,
        IModifierViewStateService modifierViewStateService,
        Red4ParserService parserService,
        CRUIDService cruidService,
        EditorDifficultyLevel editorLevel,
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
        _cruidService = cruidService;
        _modifierViewStateService = modifierViewStateService;

        _appViewModel = appViewModel;
        _data = data;
        Parent = parent;
        _propertyName = name;
        _displayName = name;
        IsReadOnly = isReadOnly;

        _currentEditorDifficultyLevel = editorLevel;
        DifficultyLevelFieldInformation = EditorDifficultyLevelFieldFactory.GetInstance(editorLevel);
        
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
                chunkViewmodelFactory.ChunkViewModel(new RedDummy(), nameof(RedDummy), _appViewModel, editorLevel, this) 
            });
        }

        CalculateValue();
        CalculateDescriptor();
        CalculateIsDefault();
        CalculateUserInteractionStates();

        CalculateDisplayName();

    }

    public ChunkViewModel(IRedType data, RDTDataViewModel tab, AppViewModel appViewModel,
        IChunkViewmodelFactory chunkViewmodelFactory,
        IDocumentTabViewmodelFactory tabViewmodelFactory,
        IHashService hashService,
        ILoggerService loggerService,
        IProjectManager projectManager,
        IGameControllerFactory gameController,
        ISettingsManager settingsManager,
        IAppArchiveManager archiveManager,
        ITweakDBService tweakDbService,
        ILocKeyService locKeyService,
        IModifierViewStateService modifierViewStateService,
        Red4ParserService parserService,
        CRUIDService cruidService,
        EditorDifficultyLevel editorDifficultyLevel, 
        bool isReadOnly = false
        ) 
        : this(data, nameof(RDTDataViewModel), appViewModel,
            chunkViewmodelFactory, tabViewmodelFactory, hashService, loggerService, projectManager,
            gameController, settingsManager, archiveManager, tweakDbService, locKeyService, modifierViewStateService, parserService,
            cruidService, editorDifficultyLevel, null, isReadOnly)
    {
        _tab = tab;
        RelativePath = _tab.Parent.RelativePath;
        IsExpanded = true;
        
    }

    public ChunkViewModel(IRedType export, ReferenceSocket socket, AppViewModel appViewModel,
        IChunkViewmodelFactory chunkViewmodelFactory,
        IDocumentTabViewmodelFactory tabViewmodelFactory,
        IHashService hashService,
        ILoggerService loggerService,
        IProjectManager projectManager,
        IGameControllerFactory gameController,
        ISettingsManager settingsManager,
        IAppArchiveManager archiveManager,
        ITweakDBService tweakDbService,
        ILocKeyService locKeyService,
        IModifierViewStateService modifierViewStateService,
        Red4ParserService parserService,
        CRUIDService cruidService,
        EditorDifficultyLevel editorDifficultyLevel, 
        bool isReadOnly = false
        ) 
        : this(export, nameof(ReferenceSocket), appViewModel,
              chunkViewmodelFactory, tabViewmodelFactory, hashService, loggerService, projectManager,
              gameController, settingsManager, archiveManager, tweakDbService, locKeyService, modifierViewStateService, parserService,
              cruidService, editorDifficultyLevel, null, isReadOnly
              )
    {
        Socket = socket;
        socket.Node = this;
        RelativePath = socket.File;
    }

    /// <summary>
    /// Some nodes should have a different display name, for example chunkmaterials. 
    /// </summary>
    private void CalculateDisplayName()
    {
        if (Parent?.DisplayName is not "chunkMaterials" || Parent?.ResolvedData is not CArray<CName> chunkMaterials ||
            GetRootModel().ResolvedData is not CMesh cMesh)
        {
            return;
        }
        
        var (numLodLevels, numSubmeshesPerLod) = MeshTools.GetLodInfo(cMesh);

        var lodSuffix = "";
        var lodIndex = 1;
        if (numLodLevels > 1 && numSubmeshesPerLod != chunkMaterials.Count && int.TryParse(Name, out var index))
        {
            index -= numSubmeshesPerLod;
            while (index >= 0)
            {
                lodIndex += 1;
                index -= numSubmeshesPerLod;
            }

            lodSuffix = $"_LOD{lodIndex}";
        }

        DisplayName = $"submesh_{Name.PadLeft(2, '0')}{lodSuffix}";
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
        
        if (_modifierViewStateService.GetModifierState(ModifierKeys.Shift))
        {
            SetChildExpansionStates(IsExpanded);
            return;
        }

        // expand / collapse nested elements. Why click twice.
        if (!IsArray && (TVProperties.Count == 1 || TVProperties.Count(p => !p.IsHiddenByEditorDifficultyLevel) == 1))
        {
            TVProperties[0].IsExpanded = IsExpanded;
            return;
        }

        // Some special cases should be auto-expanded, e.g. if the parent only has one "interesting" property
        if (!IsExpanded)
        {
            return;
        }

        // expand / collapse "special" children, e.g. if the parent holds no properties we care for
        if (ResolvedData is not meshMeshAppearance || TVProperties.FirstOrDefault() is not { Name: "chunkMaterials" } tvPropChild)
        {
            return;
        }

        if (tvPropChild.TVProperties.Count == 1 && tvPropChild.TVProperties.FirstOrDefault()?.ResolvedData is RedDummy)
        {
            tvPropChild.RecalculateProperties();
            foreach (var chunkViewModel in tvPropChild.TVProperties)
            {
                chunkViewModel.RecalculateProperties();
            }
        }

        tvPropChild.IsExpanded = IsExpanded;
    }

    partial void OnDataChanged(IRedType value)
    {
        CalculateValue();
        CalculateDescriptor();
        CalculateIsDefault();

        // Certain properties should not be editable by or visible to the user
        CalculateUserInteractionStates();

        if (Parent is null)
        {
            return;
        }

        Parent.CalculateIsDefault();

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

                Parent.CalculateDescriptor();
                if (Parent.IsValueExtrapolated)
                {
                    Parent.CalculateValue();
                }

                if (Data is CName && Parent.Parent?.ResolvedData is meshMeshAppearance or redTagList or entVisualTagsSchema)
                {
                    Parent.Parent?.CalculateValue();
                }

                return;
            }

            var parentData = Parent.Data switch
            {
                IRedBaseHandle handle => handle.GetValue(),
                CVariant cVariant => cVariant.Value,
                _ => Parent.Data
            };

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
                if (GetRootModel().GetModelFromPath(key) is not ChunkViewModel list || list.Properties.Count <= idx)
                {
                    continue;
                }

                list.Properties[idx].CalculateDescriptor();
                list.Properties[idx].CalculateValue();
            }
        }
        // if we were an external material instance without a descriptor because we haven't been unique, update all
        else if (Data is CResourceAsyncReference<IMaterial> or CResourceAsyncReference<CMesh>)
        {
            CalculateDescriptor();
        }

        // Recalculate parent descriptor?
        if (Parent is null)
        {
            return;
        }

        if ((s_descriptorPropNames.Contains(Name))
            || ResolvedData is IRedResourceAsyncReference
            || ResolvedData is IRedResourceReference
            || (ResolvedData is WorldPosition && Parent.ResolvedData is WorldTransform)
            || Parent.ResolvedData is IRedResourceAsyncReference
            || Parent.ResolvedData is CKeyValuePair
            || Parent.ResolvedData is Multilayer_Layer
            || Parent.ResolvedData is CMeshMaterialEntry
            || Parent.ResolvedData is localizationPersistenceOnScreenEntry
            || Parent.ResolvedData is IRedArray
           )
        {
            Parent.CalculateDescriptor();
            Parent.CalculateIsDefault();
        }

        if (Parent.IsValueExtrapolated)
        {
            Parent.CalculateValue();
        }

        if (Parent.Parent?.IsValueExtrapolated is true)
        {
            Parent.Parent.CalculateValue();
        }
    }

    

    #endregion Constructors

    #region Properties

    public ObservableCollectionExtended<ChunkViewModel> SelfList { get; set; } = new();

    public ObservableCollectionExtended<ChunkViewModel> TempList { get; set; } = new();

    // Full list of properties
    public ObservableCollectionExtended<ChunkViewModel> Properties { get; } = new();

    // Tree view properties (for the panel on the left)
    public ObservableCollectionExtended<ChunkViewModel> TVProperties => _propertiesLoaded ? Properties : TempList;

    // DisplayProperties (for the panel on the right)
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

    [ObservableProperty] private string _displayName;

    [ObservableProperty] private ReferenceSocket? _socket;

    [ObservableProperty] private IList<ReferenceSocket> _outputs = new ObservableCollection<ReferenceSocket>();

    [ObservableProperty] private Point _location;

    public bool ShouldShowWorldNodeDataImport => Data is worldNodeData;

    public bool ShouldShowExportNodeData => Parent is not null && Parent.Data is DataBuffer { Data: worldNodeDataBuffer };

    public bool ShouldShowTweakXLMenu => Data is gamedataTweakDBRecord || Data is TweakDBID || Parent?.Data is gamedataTweakDBRecord || Parent?.Data is TweakDBID;

    public bool ShouldShowHandleOperations => PropertyType.IsAssignableTo(typeof(IRedBaseHandle)) && !IsArray;

    public bool ShouldShowDynamicClassOperations => ResolvedData is IDynamicClass;

    public bool ShouldShowDynamicPropertyOperations => Parent is not null && Parent.ResolvedData is IDynamicClass;

    public bool ShouldShowArrayOps => IsInArray || IsArray;

    // Iterate over _all_ properties
    public int[] SelectedNodeIndices =>
        Properties.Where(x => x.IsSelected).Select(x => x.NodeIdxInParent).Where(x => x > -1).ToArray();

    // For arrays of indexables, allow renumbering index properties (e.g. for materialDefinitions)
    // to get rid of duplicates and have all the ducks in a row
    public bool ShouldShowRenumberArrayIndexProperties =>
        IsArray && ResolvedData is CArray<CMeshMaterialEntry> or CArray<worldCompiledEffectPlacementInfo>;

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
            else if (Data is DataBuffer { Buffer.Data: IRedType irt })
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
            if (Parent is null || GetPropertyByRedName(Parent.ResolvedPropertyType, PropertyName) is not ExtendedPropertyInfo propInfo)
            {
                return Data.GetType();
            }

            var type = Data.GetType();

            if (type != typeof(RedDummy) && type != propInfo.Type)
            {
                return type;
            }

            _flags = propInfo.Flags;
            return propInfo.Type;
        }
    }

    public Type? ResolvedPropertyType =>
        Data switch
        {
            IRedBaseHandle handle => handle.GetValue()?.GetType() ?? handle.InnerType,
            CVariant v => v.Value?.GetType() ?? null,
            TweakDBID tdb when TweakDBService.TryGetType(tdb, out var type) => type,
            ITweakXLItem iti when TweakDBService.TryGetType(iti.ID, out var type) => type,
            IRedString str when str.GetString() is string s && s.StartsWith("LocKey#") && ulong.TryParse(s[7..], out var _) =>
                typeof(localizationPersistenceOnScreenEntry),
            DataBuffer { Data: not null } db => db.Data.GetType(),
            SharedDataBuffer { Data: not null } sdb => sdb.Data.GetType(),
            SerializationDeferredDataBuffer { Data: not null } sddb => sddb.Data.GetType(),
            gamedataLocKeyWrapper => typeof(localizationPersistenceOnScreenEntry),
            _ => PropertyType
        };

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

    // Controls if value text is being displayed or not
    public bool TypesDiffer => PropertyType != ResolvedPropertyType;

    public bool IsInArray => Parent is not null && Parent.IsArray;

    // Used in view for conditional colouring
    public bool DisplayAsArrayItem => IsInArray && Name != DisplayName;

    // Used in view
    public bool ShowScrollToMaterial => ResolvedData is CMeshMaterialEntry || (ResolvedData is CName && Parent?.Name == "chunkMaterials");

    // Used in view
    public bool HasValue => !IsValueExtrapolated && Value is not null && Value != "" && Value.ToLower() != "none";

    public bool IsArray => PropertyType.IsAssignableTo(typeof(IRedArray))
                           || IsResolvedPropertyType(typeof(IList), typeof(CR2WList), typeof(RedPackage));
    
    
    public int PropertyCount
    {
        get
        {
            if (ResolvedData is RedDummy or IRedRef || Data is LocalizationString)
            {
                return 0;
            }

            if (_propertyCountCache != -1)
            {
                return _propertyCountCache;
            }

            switch (ResolvedData)
            {
                case IRedArray ary:
                    _propertyCountCache = ary.Count;
                    return _propertyCountCache;
                case CKeyValuePair:
                    _propertyCountCache = 2;
                    return _propertyCountCache;
                case IRedType when Data is TweakDBID tdb && TweakDBService.Exists(tdb):
                    _propertyCountCache = 1;
                    return _propertyCountCache;
                case SharedDataBuffer { Data: RedPackage p42 }:
                    _propertyCountCache = p42.Chunks.Count;
                    return _propertyCountCache;
                case DataBuffer { Data: RedPackage p43 }:
                    _propertyCountCache = p43.Chunks.Count;
                    return _propertyCountCache;
                case DataBuffer { Data: CR2WList cl }:
                    _propertyCountCache = cl.Files.Count;
                    return _propertyCountCache;
                case DataBuffer { Data: IList list }:
                    _propertyCountCache = list.Count;
                    return _propertyCountCache;
                case IRedString str when str.GetString() is string s && s.StartsWith("LocKey#") && ulong.TryParse(s[7..], out var _):
                case gamedataLocKeyWrapper:
                case SharedDataBuffer { Data: not null }:
                case DataBuffer { Data: not null }:
                    _propertyCountCache = 1;
                    return _propertyCountCache;
                case RedBaseClass redClass:
                    _propertyCountCache = GetTypeInfo(redClass).PropertyInfos.Count;
                    _propertyCountCache += redClass.GetDynamicPropertyNames().Count;
                    return _propertyCountCache;
                case SerializationDeferredDataBuffer { Data: RedPackage p4 }:
                    _propertyCountCache = p4.Chunks.Count;
                    return _propertyCountCache;
                case SerializationDeferredDataBuffer { Data: not null } sddb:
                    _propertyCountCache = sddb.Data.GetType().GetProperties(s_defaultLookup).Count();
                    return _propertyCountCache;
                default:
                    break;
            }

            switch (Data)
            {
                case IBrowsableDictionary ibd:
                    _propertyCountCache = ibd.GetPropertyNames().Count();
                    return _propertyCountCache;
                case IList list:
                    _propertyCountCache = list.Count;
                    return _propertyCountCache;
                case Dictionary<string, object> dict:
                    _propertyCountCache = dict.Count;
                    return _propertyCountCache;
                case worldNodeData:
                    _propertyCountCache = 1;
                    return _propertyCountCache;
                default:
                    _propertyCountCache = Data.GetType().GetProperties(s_defaultLookup).Length;
            return _propertyCountCache;
            }
        }
        set
        {
            _propertyCountCache = -1;
            OnPropertyChanged(nameof(PropertyCount));
        }
    }



    /// <summary>
    /// Used for view display
    /// </summary>
    public int ArrayIndexWidth
    {
        get
        {
            var width = IsInArray ? UIHelper.GetTextWidth(DisplayName) : DisplayName.Length;

            if (Parent is null)
            {
                return width;
            }

            return Math.Max(width, UIHelper.GetTextWidth(new string('0', Parent.PropertyCount.ToString().Length + 1)));
        }
    }

    public string XPath
    {
        get
        {
            if (Parent is null)
            {
                return "root";
            }

            if (IsInArray)
            {
                return $"{Parent.XPath}[{Name}]";
            }

            if (Name != "")
            {
                return $"{Parent.XPath}.{Name}";
            }

            return Parent.XPath;
           
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

    public IRedType? ParentData => Parent?.Data switch
        {
            IRedBaseHandle handle => handle.GetValue(),
            CVariant cVariant => cVariant.Value,
            _ => Parent?.Data
        };

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
        if (GetTXLString(GetTXL()) is string yaml && !string.IsNullOrEmpty(yaml))
        {
            Clipboard.SetDataObject(yaml);
        }
    }

    [RelayCommand]
    private void CopyTXLOverrideName()
    {
        if (GetTXL().ID.GetResolvedText() is string str && str != "")
        {
            Clipboard.SetDataObject(str);
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
        if (RedTypeManager.CreateRedType(PropertyType) is not IRedBaseHandle handle)
        {
            return;
        }

        var types = GetAssemblyTypes()
            .Where(p => handle.InnerType.IsAssignableFrom(p) && p is { IsClass: true, IsAbstract: false })
                .Select(x => new TypeEntry(x.Name, "", x))
                .ToList();
        var allowCreating = handle.InnerType.IsAssignableTo(typeof(inkWidgetLogicController)) ||
                            handle.InnerType.IsAssignableTo(typeof(inkIWidgetController));

        await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(types, allowCreating) { DialogHandler = HandlePointer });
    }

    // Those won't change at runtime
    private static IEnumerable<Type>? s_AssemblyTypes;

    private static IEnumerable<Type> GetAssemblyTypes() => s_AssemblyTypes ??= AppDomain.CurrentDomain.GetAssemblies()
        .SelectMany(s => s.GetTypes());

    private bool CanAddItemToArray() => Parent is not null && !IsReadOnly && (PropertyType.IsAssignableTo(typeof(IRedArray)) || PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)));   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanAddItemToArray))]
    private async Task AddItemToArray()
    {
        ArgumentNullException.ThrowIfNull(Parent);

        if (!IsPropertyType(typeof(IRedLegacySingleChannelCurve), typeof(IRedArray)))
        {
            return;
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
            return;
        }
        
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

                var types = GetAssemblyTypes()
                    .Where(p => innerType.IsAssignableFrom(p) && p is { IsClass: true, IsAbstract: false })
                    .Select(x => new TypeEntry(x.Name, "", x))
                    .ToList();

                // no inheritable
                if (types.Count == 1)
                {
                    var type = arr.InnerType;
                    if (type == typeof(CKeyValuePair))
                    {
                        types = TypeHelper.GetCKeyValueEntryTypes();
                        await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(types)
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
                    await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(types)
                    {
                        DialogHandler = handler
                    });
                }
            }
        }
    }

    private bool IsPropertyType(params Type[] args) => args.Any(type => PropertyType.IsAssignableTo(type));

    private bool IsResolvedPropertyType(params Type[] args) =>
        args.Any(type => ResolvedPropertyType is not null && ResolvedPropertyType.IsAssignableTo(type));

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
        var dlg = new OpenFileDialog
        {
            FileName = "buffer.bin",
            Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*"
        };
        if (dlg.ShowDialog() != true)
        {
            return;
        }

        if (Data is RedDummy)
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
            if (component is entMeshComponent mesh &&
                mesh.LODMode == Enums.entMeshComponentLODMode.Appearance &&
                mesh.Mesh.DepotPath != ResourcePath.Empty)
            {
                list.Add(new entVisualControllerDependency
                {
                    AppearanceName = mesh.MeshAppearance,
                    ComponentName = mesh.Name,
                    Mesh = mesh.Mesh
                });
            }

            if (component is entSkinnedMeshComponent skinnedMesh &&
                skinnedMesh.LODMode == Enums.entMeshComponentLODMode.Appearance &&
                skinnedMesh.Mesh.DepotPath != ResourcePath.Empty)
            {
                list.Add(new entVisualControllerDependency
                {
                    AppearanceName = skinnedMesh.MeshAppearance,
                    ComponentName = skinnedMesh.Name,
                    Mesh = skinnedMesh.Mesh
                });
            }

            if (component is entSkinnedClothComponent skinnedCloth &&
                skinnedCloth.LODMode == Enums.entMeshComponentLODMode.Appearance)
            {
                list.Add(new entVisualControllerDependency
                {
                    AppearanceName = skinnedCloth.MeshAppearance,
                    ComponentName = skinnedCloth.Name,
                    Mesh = skinnedCloth.GraphicsMesh
                });

                list.Add(new entVisualControllerDependency
                {
                    AppearanceName = "default",
                    ComponentName = skinnedCloth.Name,
                    Mesh = skinnedCloth.PhysicalMesh
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

    private bool CanDeleteEmptySubmeshes() => ResolvedData is CMesh;

    [RelayCommand(CanExecute = nameof(CanDeleteEmptySubmeshes))]
    private void DeleteEmptySubmeshes()
    {
        if (ResolvedData is not CMesh mesh || mesh.Appearances.Count == 0 ||
            mesh.RenderResourceBlob.GetValue() is not rendRenderMeshBlob blob)
        {
            return;
        }

        List<rendChunk> filteredRenderChunkInfos = new();
        List<CUInt8> filteredRenderChunks = new();

        for (var i = 0; i < blob.Header.RenderChunkInfos.Count; i++)
        {
            var renderChunkInfo = blob.Header.RenderChunkInfos[i];
            // <4 vertices: an "invisible" mesh that we want to get rid of
            if (renderChunkInfo.NumVertices <= 3)
            {
                continue;
            }

            filteredRenderChunkInfos.Add(renderChunkInfo);
            if (blob.Header.RenderChunks.Count > i)
            {
                filteredRenderChunks.Add(blob.Header.RenderChunks[i]);
            }
        }

        blob.Header.RenderChunkInfos = [];
        blob.Header.RenderChunks = [];

        foreach (var renderChunkInfo in filteredRenderChunkInfos)
        {
            blob.Header.RenderChunkInfos.Add(renderChunkInfo);
        }

        foreach (var renderChunkInfo in filteredRenderChunks)
        {
            blob.Header.RenderChunks.Add(renderChunkInfo);
        }
        // Find out how many chunk meshes we have 
        var numSubmeshes = blob.Header.RenderChunkInfos.Count;
        var wasDeleted = false;
        foreach (var meshAppearance in mesh.Appearances)
        {
            if (meshAppearance.GetValue() is not meshMeshAppearance appearance || appearance.ChunkMaterials.Count <= numSubmeshes)
            {
                continue;
            }

            var newMaterials = appearance.ChunkMaterials.Where((_, i) => i < numSubmeshes).ToList();
            appearance.ChunkMaterials = new CArray<CName>();
            foreach (var t in newMaterials)
            {
                appearance.ChunkMaterials.Add(t);
            }
            wasDeleted = true;
        }

        if (wasDeleted)
        {
            DeleteUnusedMaterials();
        }
    }


    private bool CanClearMaterials() => ResolvedData is CMesh && IsShiftKeyPressed;

    [RelayCommand(CanExecute = nameof(CanClearMaterials))]
    private void ClearMaterials()
    {
        if (ResolvedData is not CMesh mesh)
        {
            return;
        }

        mesh.Appearances.Clear();
        DeleteUnusedMaterials();
    }

    private static IEnumerable<meshMeshAppearance?> CreateAutoGeneratedChunkMaterials(CArray<CHandle<meshMeshAppearance>> appearanceHandles)
    {
        var appearances = appearanceHandles.Select(handle => handle.GetValue() as meshMeshAppearance).Where(i => i != null).ToList();
        if (appearances.Count == 0)
        {
            return appearances;
        }

        var firstChunkMaterials = appearances[0]!.ChunkMaterials;
        var firstAppearanceName = appearances[0]!.Name.GetResolvedText() ?? "INVALID";
        for (var i = 1; i < appearances.Count; i++)
        {
            var appearance = appearances[i];
            if (appearance is null || appearance.ChunkMaterials.Count > 0)
            {
                continue;
            }

            var appearanceName = appearance.Name.GetResolvedText() ?? "INVALID";
            appearance.ChunkMaterials ??= [];
            for (var j = 0; j < firstChunkMaterials.Count; j++)
            {
                var newChunkMaterial = (firstChunkMaterials[j].GetResolvedText() ?? "").Replace(firstAppearanceName, appearanceName);
                appearance.ChunkMaterials.Insert(j, newChunkMaterial);
            }
        }

        return appearances;
    }

    private bool CanDeleteUnusedMaterials() => ResolvedData is CMesh && !IsShiftKeyPressed;

    [RelayCommand(CanExecute = nameof(CanDeleteUnusedMaterials))]
    private void DeleteUnusedMaterials()
    {
        if (ResolvedData is not CMesh mesh)
        {
            return;
        }

        ConvertPreloadMaterials();

        // Support auto-generated chunk material names (psiberx magic)
        var appearances = CreateAutoGeneratedChunkMaterials(mesh.Appearances);
        

        // Collect material names from appearance chunk materials
        var appearanceNames = appearances
            .SelectMany(mA => mA!.ChunkMaterials.Select(chunkMaterial => chunkMaterial.GetResolvedText()).ToArray())
            .ToList();

        var localMatIdxList = mesh.MaterialEntries.Where(mE =>
            mE.IsLocalInstance && mE.Name.GetResolvedText() is string s && appearanceNames.Contains(s)
        ).Select(me => (int)me.Index).ToList();

        var externalMatIdxList = mesh.MaterialEntries.Where(mE =>
            !mE.IsLocalInstance && mE.Name.GetResolvedText() is string s && appearanceNames.Contains(s)
        ).Select(me => (int)me.Index).ToList();

        var numUnusedMaterials = mesh.MaterialEntries.Count - (localMatIdxList.Count + externalMatIdxList.Count);

        if (numUnusedMaterials == 0)
        {
            _loggerService.Info("No unused materials in current mesh.");
            return;
        }

        IMaterial[] keepLocal = [];
        CHandle<IMaterial>[] keepLocalPreload = [];
        CResourceAsyncReference<IMaterial>[] keepExternal = [];
        CResourceReference<IMaterial>[] keepExternalPreload = [];

        if (mesh.LocalMaterialBuffer?.Materials is not null && mesh.LocalMaterialBuffer.Materials.Count > 0)
        {
            keepLocal = mesh.LocalMaterialBuffer.Materials
                .Where((material, i) => localMatIdxList.Contains(i)).ToArray();
        }

        if (mesh.ExternalMaterials is not null && mesh.ExternalMaterials.Count > 0)
        {
            keepExternal = mesh.ExternalMaterials
                .Where((material, i) => externalMatIdxList.Contains(i)).ToArray();
        }
        
        var usedMaterialDefinitions = mesh.MaterialEntries.Where(me =>
            (me.IsLocalInstance && localMatIdxList.Contains(me.Index)) ||
            (!me.IsLocalInstance && externalMatIdxList.Contains(me.Index))
        ).ToArray();

        if (keepLocal.Length + keepExternal.Length + keepLocalPreload.Length + keepExternalPreload.Length !=
            usedMaterialDefinitions.Length &&
            !_appViewModel.ShowConfirmationDialog("Not all remaining materials match up. Continue? (You need to validate by hand)",
                "Really delete materials?"))
        {
            return;
        }

        if (mesh.LocalMaterialBuffer?.Materials is not null)
        {
            mesh.LocalMaterialBuffer.Materials.Clear();
            foreach (var t in keepLocal)
            {
                mesh.LocalMaterialBuffer.Materials.Add(t);
            }
        }

        if (mesh.ExternalMaterials is not null)
        {
            mesh.ExternalMaterials.Clear();
            foreach (var t in keepExternal)
            {
                mesh.ExternalMaterials.Add(t);
            }    
        }

        mesh.MaterialEntries.Clear();
        var localMaterialIdx = 0;
        var externalMaterialIdx = 0;
        for (var i = 0; i < usedMaterialDefinitions.Length; i++)
        {
            var t = usedMaterialDefinitions[i];
            if (t.IsLocalInstance)
            {
                t.Index = (CUInt16)localMaterialIdx;
                localMaterialIdx += 1;
            }
            else
            {
                t.Index = (CUInt16)externalMaterialIdx;
                externalMaterialIdx += 1;
            }
            t.Index = (CUInt16)i;
            mesh.MaterialEntries.Add(t);
        }

        RecalculateProperties();
        Tab?.Parent.SetIsDirty(true);

        GetPropertyChild("materialEntries")?.RecalculateProperties();

        GetPropertyChild("localMaterialBuffer")?.GetPropertyChild("materials")?.RecalculateProperties();
        GetPropertyChild("localMaterialBuffer")?.RecalculateProperties();

        GetPropertyChild("externalMaterials")?.RecalculateProperties();

        _loggerService.Info($"Deleted {numUnusedMaterials} unused materials.");
    }

    public void GenerateMissingMaterials(string baseMaterial, bool isLocal, bool resolveSubstitutions)
    {
        GenerateMissingMaterialDefinitions(isLocal);
        GenerateMissingMaterialInstances(baseMaterial, isLocal, resolveSubstitutions);
    }

    private void GenerateMissingMaterialDefinitions(bool isLocal)
    {
        if (ResolvedData is not CMesh mesh)
        {
            return;
        }

        var definedMaterialNames = mesh.MaterialEntries.Select(mat => mat.Name).ToList();

        // Collect material names from appearance chunk materials
        var undefinedMaterialNames = CreateAutoGeneratedChunkMaterials(mesh.Appearances)
            .SelectMany(mA => mA!.ChunkMaterials.Select(chunkMaterial => chunkMaterial.GetResolvedText() ?? "").ToArray())
            .Select(materialName => materialName.Contains('@') ? $"@{materialName.Split('@').Last()}" : materialName) // dynamic
            .Where(chunkMaterialName => !definedMaterialNames.Contains(chunkMaterialName))
            .ToHashSet().ToList();

        if (undefinedMaterialNames.Count == 0)
        {
            return;
        }

        var matIdx = mesh.MaterialEntries.LastOrDefault(mat => mat.IsLocalInstance == isLocal)?.Index ?? -1;

        // Create material definitions
        foreach (var materialName in undefinedMaterialNames)
        {
            matIdx += 1;
            var material = new CMeshMaterialEntry { Name = materialName, Index = (CUInt16)matIdx, IsLocalInstance = isLocal };
            mesh.MaterialEntries.Add(material);
        }

        GetPropertyChild("materialEntries")?.RecalculateProperties();
    }

    private ChunkViewModel? GetPropertyChild(string propertyName) => TVProperties.FirstOrDefault(prop => prop.Name == propertyName);

    // Converts PreloadMaterials to regular local materials. We like them better, and this way,
    // we don't have to check all those arrays.


    private bool CanConvertPreloadMaterial() => ResolvedData is CMesh mesh &&
                                                ((mesh.PreloadLocalMaterialInstances?.Count ?? 0) > 0 ||
                                                 (mesh.PreloadExternalMaterials?.Count ?? 0) > 0);


    /// <summary>
    /// Convert to local materials - if preloadLocalMaterialInstances or preloadExternalMaterials have entries, allow converting them
    /// to the corresponding non-preload list
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanConvertPreloadMaterial))]
    private void ConvertPreloadMaterials()
    {
        var resolvedData = ResolvedData is CMesh ? ResolvedData : Parent?.ResolvedData;
        if (resolvedData is not CMesh mesh)
        {
            return;
        }
        

        // Make sure these are initialized
        mesh.LocalMaterialBuffer ??= new meshMeshMaterialBuffer { Materials = [], };
        mesh.LocalMaterialBuffer.Materials ??= [];

        if (mesh.PreloadLocalMaterialInstances.Count > 0)
        {
            foreach (var matRef in mesh.PreloadLocalMaterialInstances)
            {
                if (matRef.GetValue() is not IMaterial mat)
                {
                    continue;
                }

                mesh.LocalMaterialBuffer.Materials.Add(mat);
            }

            mesh.PreloadLocalMaterialInstances.Clear();

            GetPropertyChild("preloadLocalMaterialInstances")?.RecalculateProperties();
            GetPropertyChild("localMaterialBuffer")?.GetPropertyChild("materials")?.RecalculateProperties();
            GetPropertyChild("localMaterialBuffer")?.RecalculateProperties();
            Tab?.Parent.SetIsDirty(true);
        }

        if (mesh.PreloadExternalMaterials.Count == 0)
        {
            return;
        }

        foreach (var mat in mesh.PreloadExternalMaterials)
        {
            mesh.ExternalMaterials.Add(new CResourceAsyncReference<IMaterial>(mat.DepotPath));
        }

        mesh.PreloadExternalMaterials.Clear();

        GetPropertyChild("preloadExternalMaterials")?.RecalculateProperties();
        GetPropertyChild("externalMaterials")?.RecalculateProperties();

        Tab?.Parent.SetIsDirty(true);
    }

    private void GenerateMissingMaterialInstances(string baseMaterial, bool isLocal, bool resolveSubstitutions)
    {
        if (ResolvedData is not CMesh mesh || mesh.MaterialEntries.Count == 0)
        {
            return;
        }

        ConvertPreloadMaterials();

        var numDefinedMaterials = isLocal ? mesh.LocalMaterialBuffer.Materials.Count : mesh.ExternalMaterials.Count;

        foreach (var mat in mesh.MaterialEntries
                     .Where(entry => entry.IsLocalInstance == isLocal && entry.Index >= numDefinedMaterials))
        {
            var baseMaterialPath = resolveSubstitutions
                ? baseMaterial.Replace(@"{material}", mat.Name)
                : baseMaterial;

            if (isLocal)
            {
                mesh.LocalMaterialBuffer?.Materials.Add(new CMaterialInstance
                {
                    BaseMaterial = new CResourceReference<IMaterial>(baseMaterialPath)
                });
            }
            else
            {
                mesh.ExternalMaterials.Add(new CResourceAsyncReference<IMaterial>(baseMaterialPath));
            }
        }

        if (isLocal)
        {
            GetPropertyChild("localMaterialBuffer")?.GetPropertyChild("materials")?.RecalculateProperties();
            GetPropertyChild("localMaterialBuffer")?.RecalculateProperties();
        }
        else
        {
            GetPropertyChild("externalMaterials")?.RecalculateProperties();
        }
    }

    
    // Dynamic Properties

    private bool CanCreateDynamicProperty() => ResolvedData is IDynamicClass;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanCreateDynamicProperty))]
    private async Task CreateDynamicProperty()
    {
        if (ResolvedData is RedBaseClass)
        {
            var types = GetAssemblyTypes()
                .Where(p => typeof(inkWidgetReference).IsAssignableFrom(p) && p is { IsClass: true, IsAbstract: false })
                .Select(x => new TypeEntry(x.Name, "", x))
                .ToList();
            await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(types)
            {
                DialogHandler = HandleNewDynamicProperty
            });
        }
    }

    public void HandleNewDynamicProperty(DialogViewModel? sender)
    {
        _appViewModel.CloseDialogCommand.Execute(null);

        if (sender is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType } && ResolvedData is RedBaseClass rbc)
        {
            var propertyName = Interactions.Rename("");
            var instance = RedTypeManager.CreateRedType(selectedType);
            rbc.AddDynamicProperty(propertyName, selectedType);
            rbc.SetProperty(propertyName, instance);
            //if (Data is IRedBaseHandle handle)
            //{
            //    handle.SetValue(rbc);
            //}
            Tab?.Parent.SetIsDirty(true);
            RecalculateProperties(instance);
        }
    }

    private bool CanRenameDynamicClass() => ResolvedData is IDynamicClass;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanRenameDynamicClass))]
    private void RenameDynamicClass()
    {
        if (ResolvedData is IDynamicClass dbc)
        {
            dbc.ClassName = Interactions.Rename(dbc.ClassName!);
            Tab?.Parent.SetIsDirty(true);
            RecalculateProperties();
        }
    }

    private bool CanAddItemToCompiledData() =>
        ResolvedPropertyType is not null && IsPropertyType(typeof(IRedBufferPointer)); // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanAddItemToCompiledData))]
    private async Task AddItemToCompiledData()
    {
        ArgumentNullException.ThrowIfNull(ResolvedPropertyType);
        if (Data is RedDummy)
        {
            Data = RedTypeManager.CreateRedType(ResolvedPropertyType);
            if (Data is IRedBufferPointer ptr)
            {
                ptr.SetValue(new RedBuffer
                {
                    Data = new RedPackage { Chunks = new List<RedBaseClass>() }
                });
            }

        }
        if (Data is DataBuffer { Data: null } db2)
        {
            if (Parent?.Data is worldStreamingSector)
            {
                db2.Buffer = RedBuffer.CreateBuffer(0, new byte[] { 0 });
                db2.Data = new worldNodeDataBuffer();
            }

            if (Name == "rawData")
            {
                db2.Buffer = RedBuffer.CreateBuffer(0, new byte[] { 0 });
                db2.Data = new CR2WList();
            }
        }


        if (Data is IRedBufferPointer db)
        {
            var types = new List<TypeEntry>();

            if (db.GetValue().Data is worldNodeDataBuffer worldNodeDataBuffer)
            {
                worldNodeDataBuffer.Add(new worldNodeData());
                RecalculateProperties(worldNodeDataBuffer);
                return;
            }

            if (Parent?.ResolvedData is entEntityInstanceData)
            {
                types.AddRange(TypeHelper.GetEntityInstanceDataTypes());
            }
            else if (db.GetValue().Data is RedPackage pkg)
            {
                types = pkg.Chunks
                    .Select(x => new TypeEntry(x.GetType().Name, "", x.GetType()))
                    .DistinctBy(x => x.Name)
                    .ToList();
            }

            if (types.Count == 0)
            {
                throw new WolvenKitException(0x5002,
                    $"You can't create new items for {Data.RedType} yet. Please create a ticket and tell us what you need here.");
            }

            await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(types)
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
        int newSelectionIndex = -1;
        try
        {
            switch (Parent.Data)
            {
                case IRedArray ary:
                {
                    var childIdx = NodeIdxInParent;
                    if (childIdx < ary.Count)
                    {
                        ary.RemoveAt(childIdx);
                        newSelectionIndex = childIdx;
                    }
                    else
                    {
                        _loggerService.Error("Something went wrong here. Please reload the file (Hotkey: Ctrl+R)");
                    }

                    break;
                }
                case IRedLegacySingleChannelCurve curve:
                {
                    curve.Remove((IRedCurvePoint)Data);
                    if (curve.Count == 0)
                    {
                        //Parent.ResolvedData = null;
                        //Parent.Data = null; // TODO ???
                    }

                    break;
                }
                case IRedBufferPointer db when db.GetValue().Data is RedPackage pkg && !pkg.Chunks.Remove((RedBaseClass)Data):
                    _loggerService.Error("Unable to delete chunk");
                    return;
                case IRedBufferPointer db2 when db2.GetValue().Data is CR2WList list:
                    list.Files.RemoveAll(x => x.RootChunk == Data);
                    break;
                case IRedBufferPointer db3 when db3.GetValue().Data is worldNodeDataBuffer dict:
                    dict.Remove((worldNodeData)Data);
                    //dict.RemoveAt(((worldNodeData)Data).NodeIndex);
                    break;
                default:
                    _loggerService.Error("Unknown collection - unable to delete chunk");
                    return;
            }
            
            Parent.RecalculateProperties();
            newSelectionIndex = Math.Min(newSelectionIndex, Parent.TVProperties.Count) - 1;
            newSelectionIndex = Math.Max(0, newSelectionIndex);
            if (Parent.TVProperties.Count > 0 && newSelectionIndex > 0 && newSelectionIndex < Parent.TVProperties.Count)
            {
                Tab.SetSelection(Parent.TVProperties[newSelectionIndex]);
            }
            else
            {
                Tab.SetSelection(Parent.TVProperties.LastOrDefault() ?? Parent);
            }
            Tab.Parent.SetIsDirty(true);
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
        
        var ts = Parent.DisplayProperties
            .Where(m => m.IsSelected)
            .Select(m => m)
            .ToList();

        List<int> indices = ts.Select(m => m.NodeIdxInParent).ToList();
        
        try
        {
            switch (Parent.Data)
            {
                case IRedBufferPointer db3 when db3.GetValue().Data is IRedArray dict:
                {
                    if (indices.Count == 0)
                    {
                        _loggerService.Warning("Please select something first");
                    }
                    else
                    {
                        DeleteFullSelection(indices, dict);
                    }

                    break;
                }
                case IRedArray db4:
                    DeleteFullSelection(indices, db4);
                    break;
                case IRedLegacySingleChannelCurve curve:
                {
                    foreach (var index in indices.OrderByDescending(x => x))
                    {
                        curve.RemoveAt(index);
                    }

                    break;
                }
                case null:
                    _loggerService.Warning("Parent.Data is null");
                    return;
                default:
                    _loggerService.Warning($"Unsupported type : {Parent.Data.NotNull().GetType().Name}");
                    return;
            }
        }
        catch (Exception ex)
        {
            _loggerService.Warning($"Something went wrong while trying to delete the selection : {ex}");
        }

        Parent.RecalculateProperties();
        var newSelectionIndex = Math.Min(indices.First(), Parent.TVProperties.Count) - 1;
        newSelectionIndex = Math.Max(0, newSelectionIndex);
        if (Parent.TVProperties.Count > 0 && newSelectionIndex > 0 && newSelectionIndex < Parent.TVProperties.Count)
        {
            Tab.SetSelection(Parent.TVProperties[newSelectionIndex]);
        }
        else
        {
            Tab.SetSelection(Parent.TVProperties.LastOrDefault() ?? Parent);
        }
        Tab.Parent.SetIsDirty(true);
    }

    private bool CanExportNodeData() =>
        IsInArray && Parent is
            { Data: DataBuffer { Data: worldNodeDataBuffer }, Parent.Data: worldStreamingSector }; // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanExportNodeData))]
    private void ExportNodeData()
    {
        try
        {
            if (Parent is { Data: DataBuffer { Data: worldNodeDataBuffer wndb }, Parent.Data: worldStreamingSector })
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
        if (Data is not RedBaseClass cls)
        {
            return;
        }

        var redDocumentTabViewModel = _tabViewmodelFactory.RDTDataViewModel(cls, Tab.Parent, _appViewModel, _chunkViewmodelFactory);
        Tab.Parent.TabItemViewModels.Add(redDocumentTabViewModel);
    }

    private bool CanRenameProperty() => Parent is not null && Parent.ResolvedData is IDynamicClass;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanRenameProperty))]
    private void RenameProperty()
    {
        try
        {
            if (Parent is not null && Parent.ResolvedData is RedBaseClass rbc)
            {
                var newName = Interactions.Rename(PropertyName);
                rbc.RenameDynamicProperty(PropertyName, newName);
                Tab?.Parent.SetIsDirty(true);
                Parent.RecalculateProperties();
            }
        }
        catch (Exception ex) { _loggerService.Error(ex); }

    }

    private bool CanDeleteProperty() => Parent is not null && Parent.ResolvedData is IDynamicClass;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanDeleteProperty))]
    private void DeleteProperty()
    {
        try
        {
            if (Parent is not null && Parent.ResolvedData is RedBaseClass rbc)
            {
                rbc.RemoveDynamicProperty(PropertyName);
                Tab?.Parent.SetIsDirty(true);
                Parent.RecalculateProperties();
            }
        }
        catch (Exception ex) { _loggerService.Error(ex); }
    }

    public Task<bool> SearchAndReplaceAsync(string searchText, string replaceText) =>
        Task.FromResult(SearchAndReplaceInternal(searchText, replaceText));
    public bool SearchAndReplace(string searchText, string replaceText) => SearchAndReplaceInternal(searchText, replaceText);

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

    private bool CanPasteHandle() => RedDocumentTabViewModel.CopiedChunk is IRedBaseHandle &&
                                     Parent is not { Data: worldNodeData }
                                     && IsPropertyType(typeof(IRedBaseHandle));
    
    [RelayCommand(CanExecute = nameof(CanPasteHandle))]
    private void PasteHandle()
    {
        if (RedDocumentTabViewModel.CopiedChunk is null)
        {
            return;
        }

        if (RedDocumentTabViewModel.CopiedChunk is not IRedBaseHandle sourceHandle)
        {
            return;
        }

        switch (Data)
        {
            case IRedBaseHandle destinationHandle:
            {
                if (destinationHandle.InnerType.IsAssignableFrom(sourceHandle.GetValue().NotNull().GetType()))
                {
                    destinationHandle.SetValue(sourceHandle.GetValue());
                    RecalculateProperties(destinationHandle);
                    RedDocumentTabViewModel.CopiedChunk = null;
                }

                break;
            }
            case RedDummy:
            case null:
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

                break;
            }
            default:
                break;
        }
    }

    private bool CanResetObject() => Parent != null;
    [RelayCommand(CanExecute = nameof(CanResetObject))]
    private void ResetObject()
    {
        if (Parent is null)
        {
            return;
        }

        if (ParentData is RedBaseClass redBaseClass && redBaseClass.GetPropertyDefaultValue(PropertyName) is IRedType defaultValue)
        {
            Data = defaultValue;
        }
        else
        {
            Data = new RedDummy();
        }

        RecalculateProperties(Data);
    }

    private bool CanCopyChunk() => IsInArray;   // TODO RelayCommand check notify
    [RelayCommand(CanExecute = nameof(CanCopyChunk))]
    private void CopyChunk()
    {
        try
        {
            RedDocumentTabViewModel.CopiedChunk = Data is IRedCloneable irc ? (IRedType)irc.DeepCopy() : Data;
            RefreshContextMenuFlags();
        }
        catch (Exception ex) { _loggerService.Error(ex); }
    }

    private bool CanPasteChunks()
    {
        if (RedDocumentTabViewModel.CopiedChunk is null)
        {
            return false;
        }

        if (ResolvedData is IRedArray { InnerType: Type innerType })
        {
            return CheckTypeCompatibility(innerType, RedDocumentTabViewModel.CopiedChunk.GetType()) != TypeCompability.None;
        }

        if (Parent is { ResolvedData: IRedArray { InnerType: Type type } })
        {
            return CheckTypeCompatibility(type, RedDocumentTabViewModel.CopiedChunk.GetType()) != TypeCompability.None;
        }

        return false;
    } 


    // Visibility check: ShouldShowRenumberArrayIndexProperties
    private bool CanReindexChildDataIndexProperties() =>
        IsArray && Properties.Count > 0 &&
        ResolvedData is CArray<CMeshMaterialEntry> or CArray<worldCompiledEffectPlacementInfo>;

    // Renumber index property of children - this is useful for e.g. material definitions after paste
    [RelayCommand(CanExecute = nameof(CanReindexChildDataIndexProperties))]
    private void ReindexChildDataIndexProperties()
    {
        if (!IsArray)
        {
            return;
        }

        // For materials, we need to hold two different kinds of index counter
        var numExternalMaterials = 0;
        var numLocalMaterials = 0;

        for (var i = 0; i < Properties.Count; i++)
        {
            var prop = Properties[i];
            if (prop.ResolvedData is not CMeshMaterialEntry materialDefinition)
            {
                prop.SetDataIndexProperty(i);
                continue;
            }

            // Check if material is a local or an external instance; renumber index
            if (materialDefinition.IsLocalInstance)
            {
                prop.SetDataIndexProperty(numLocalMaterials);
                numLocalMaterials += 1;
            }
            else
            {
                prop.SetDataIndexProperty(numExternalMaterials);
                numExternalMaterials += 1;
            }
        }

        RecalculateProperties();
        CalculateDescriptor();
        CalculateValue();
    }

    [RelayCommand(CanExecute = nameof(CanPasteChunks))]
    private void ClearAndPasteChunk()
    {
        var isExpanded = IsExpanded;
        DeleteAll();
        PasteChunk();
        if (!IsCtrlKeyPressed)
        {
            SetChildExpansionStates(false);
        }

        IsExpanded = isExpanded;
    }
    
    [RelayCommand(CanExecute = nameof(CanPasteChunks))]
    private void PasteChunk()
    {
        try
        {
            if (RedDocumentTabViewModel.CopiedChunk is null)
            {
                return;
            }

            Tab?.ClearSelection();

            object copy;
            if (RedDocumentTabViewModel.CopiedChunk is IRedCloneable irc)
            {
                copy = irc.DeepCopy();
            }
            else if (RedDocumentTabViewModel.CopiedChunk.GetType().IsValueType)
            {
                copy = RedDocumentTabViewModel.CopiedChunk;
            }
            else
            {
                return;
            }

            switch (ResolvedData)
            {
                case IRedArray when !CreateArray():
                    throw new Exception("Error while accessing or creating the array!");
                case IRedArray:
                {
                    var clone = copy;
                    if (clone is IRedType redtype)
                    {
                        InsertChild(-1, redtype);
                        RecalculateProperties();
                    }

                    break;
                }
                default:
                {
                    if (Parent is { ResolvedData: IRedArray })
                    {
                        var clone = copy;
                        if (clone is IRedType redtype)
                        {
                            Parent.InsertChild(Parent.GetIndexOf(this) + 1, redtype);
                            Parent?.RecalculateProperties();
                        }
                    }

                    break;
                }
            }

            Tab?.Parent.SetIsDirty(true);
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

    private void DuplicateInParent(int index = -1)
    {
        if (Parent is null)
        {
            return;
        }

        IsSelected = false;

        if (index == -1)
        {
            index = NodeIdxInParent + 1;
        }
        
        if (Data is IRedCloneable irc)
        {
            Parent.InsertChild(index, (IRedType)irc.DeepCopy());
        }
        else
        {
            Parent.InsertChild(index, Data);
        }
    }

    private bool CanDuplicateChunk() => IsInArray && Parent is not null; // TODO RelayCommand check notify

    [RelayCommand(CanExecute = nameof(CanDuplicateChunk))]
    private void DuplicateChunk()
    {
        if (Parent is null || Tab is not { SelectedChunks: IList lst })
        {
            return;
        }

        // get selected nodes and order them by node index
        var fullSelection = Parent.TVProperties
            .Where(lst.Contains)
            .OrderBy(x => x.NodeIdxInParent)
            .ToList();

        Tab.ClearSelection();
        
        if (fullSelection.Count > 0)
        {
            var index = fullSelection[^1].NodeIdxInParent + 1;
            foreach (var i in fullSelection)
            {
                i.DuplicateInParent(index++);
            }
        }
        else
        {
            // Duplicates the item which is clicked on, even if its not selected
            DuplicateInParent();
        }

        Parent.CalculateDescriptor();
        Parent.CalculateValue();
        Parent.ReindexChildren();
    }

    [RelayCommand(CanExecute = nameof(CanDuplicateChunk))]
    private void DuplicateAsNewChunk()
    {
        if (Parent is null) return;

        DuplicateChunk();

        try
        {
            // Recalculate properties for all selected nodes 
            if (Tab is not { SelectedChunks: IList lst })
            {
                Parent.GetChildNode(NodeIdxInParent + 1)?.AdjustPropertiesAfterPasteAsNewItem();
                return;
            }

            Parent.RecalculateProperties();

            var selectedChunks = lst.OfType<ChunkViewModel>()
                .OrderBy(g => g.NodeIdxInParent)
                .GroupBy(x => x.NodeIdxInParent)
                .Select(g => g.First())
                .ToList();

            foreach (var i in selectedChunks)
            {
                i.AdjustPropertiesAfterPasteAsNewItem();
                i.IsSelected = true;
                Parent.RecalculateProperties();
            }
        }
        catch (Exception ex)
        {
            _loggerService.Error($"Failed to recalculate properties after duplicating entries: {ex}");
        }
    }

    private void ReindexChildren()
    {
        if (!IsArray)
        {
            return;
        }

        for (var i = 0; i < Properties.Count; i++)
        {
            Properties[i].NodeIdxInParent = i;
            Properties[i].CalculateDisplayName();
        }

        Parent?.GetPropertyChild("localMaterialBuffer")?.GetPropertyChild("materials")?.RecalculateProperties();
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

            var indices = ts.Select(m => int.Parse(m.Name)).ToList();

            var fullselection = Parent.DisplayProperties
                .Where(m => indices.Contains(int.Parse(m.Name)))
                .Select(m => m.Data.NotNull())
                .ToList();

            // can't be merged with next block; will cause compiler errors
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
                _loggerService.Warning("Parent.Data is null");
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

    private bool CanCopyArrayContents()
    {
        return Properties.Count > 0 && !Properties[0].IsArray;
    }
    
    private bool CanPasteSelection()
    {
        if (RedDocumentTabViewModel.CopiedChunks.Count == 0)
        {
            return false;
        }

        Type? innerType = null;
        if (ResolvedData is IRedArray arr)
        {
            innerType = arr.InnerType;
        }
        else if (Parent is { ResolvedData: IRedArray pArr })
        {
            innerType = pArr.InnerType;
        }

        return innerType != null &&
               RedDocumentTabViewModel.CopiedChunks.All(c => CheckTypeCompatibility(innerType, c.GetType()) != TypeCompability.None);
    } // TODO RelayCommand check notify


    [RelayCommand(CanExecute = nameof(CanCopyArrayContents))]
    private void CopyArrayContents()
    {
        var fullselection = DisplayProperties
            .Select(m => m.Data.NotNull())
            .ToList();

        RedDocumentTabViewModel.CopiedChunks.Clear();
        foreach (var i in fullselection)
        {
            AddToCopiedChunks(i);
        }
    }

    [RelayCommand(CanExecute = nameof(CanPasteSelection))]
    private void ClearAndPasteSelection()
    {
        DeleteAll();
        PasteSelection();
    }

    [RelayCommand(CanExecute = nameof(CanPasteSelection))]
    private void OverwriteSelectionWithPaste()
    {
        var insertAtIndex = -1;
        if (Tab?.SelectedChunks is IList lst)
        {
            insertAtIndex = lst.OfType<ChunkViewModel>().Where(chunk => chunk.IsSelected).FirstOrDefault()?.NodeIdxInParent ?? -1;
            DeleteSelection();
        }

        PasteSelection(insertAtIndex);
    }
    
    [RelayCommand(CanExecute = nameof(CanPasteSelection))]
    private void PasteSelection(int insertAtIndex = -1)
    {
        ArgumentNullException.ThrowIfNull(Parent);

        if (RedDocumentTabViewModel.CopiedChunks.Count == 0)
        {
            return;
        }

        if (PropertyType.IsAssignableTo(typeof(IRedArray)) && ResolvedData is RedDummy && !CreateArray())
        {
            throw new Exception("Error while accessing or creating the array!");
        }

        try
        {
            var index = insertAtIndex >= 0 ? insertAtIndex : Parent.GetIndexOf(this) + 1;
            
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
                        list.Files.Insert(index, new CR2WFile
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

    private bool CanGenerateCRUID() => PropertyType == typeof(CRUID);

    [RelayCommand(CanExecute = nameof(CanGenerateCRUID))]
    private void GenerateCRUID()
    {
        if (!CanGenerateCRUID())
        {
            return;
        }
        
        Data = _cruidService.GenerateNewCRUID();
    }

    #endregion

    #region methods
 

    private string? GetNodeName(CWeakHandle<animAnimNode_Base>? linkNode)
    {
        if (linkNode is null)
        {
            return null;
        }

        string? desc = null;
        if (linkNode.GetValue() is not null && linkNode.GetValue()?.GetType() is { Name: not null } t)
        {
            desc = t.Name.Split("_")?.LastOrDefault();
        }
        else if (linkNode.InnerType is { Name: not null })
        {
            desc = linkNode.InnerType.Name?.Split("_")?.LastOrDefault();
        }

        return desc;
    }

    public void CalculateProperties()
    {
        if (_propertiesLoaded)
        {
            return;
        }

        CalculateDisplayName();
        
        _propertiesLoaded = true;
        OnPropertyChanged(nameof(ResolvedData));

        Properties.Clear();
        
        // Let SFTreeView clear its items first else the ScrollBar calculations are of...
        // Can't use NotificationSubscriptionMode.CollectionChanged neither since SF never attaches to the event...
        // TVProperties also doesn't need to be Observable but doesn't matter really...
        OnPropertyChanged(nameof(TVProperties));

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
                Properties.Add(_chunkViewmodelFactory.ChunkViewModel(obj, nameof(TweakDBID), _appViewModel,
                    _settingsManager.DefaultEditorDifficultyLevel, this, true));
                OnPropertyChanged(nameof(TVProperties));
                return;
            }

            obj = TweakDBService.GetRecord(tdb);
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
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(t, i.ToString(), _appViewModel, _currentEditorDifficultyLevel,
                        this,
                        isreadonly));
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
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(kvp.Key, "Key", _appViewModel, _currentEditorDifficultyLevel, this,
                        isreadonly));
                }
                else
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(kvp.Value, "Value", _appViewModel, _currentEditorDifficultyLevel,
                        this, isreadonly));
                }
            }
        }
        else if (obj is RedBaseClass redClass)
        {
            var pis = GetTypeInfo(redClass).PropertyInfos.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal));

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
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(new RedDummy(), propertyInfo.RedName.NotNull(), _appViewModel,
                        _currentEditorDifficultyLevel, this, isreadonly));
                }
                else
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(t, propertyInfo.RedName.NotNull(), _appViewModel,
                        _currentEditorDifficultyLevel, this, isreadonly));
                }
            }

            foreach (var dp in dps)
            {
                ArgumentNullException.ThrowIfNull(dp);
                Properties.Add(_chunkViewmodelFactory.ChunkViewModel(redClass.GetProperty(dp).NotNull(), dp, _appViewModel,
                    _currentEditorDifficultyLevel, this, isreadonly));
            }
        }
        else if (obj is SerializationDeferredDataBuffer sddb)
        {
            if (sddb.Data is RedPackage p4)
            {
                for (var i = 0; i < PropertyCount; i++)
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(p4.Chunks[i], nameof(RedPackage), _appViewModel,
                        _currentEditorDifficultyLevel, this, isreadonly));
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
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(irt, pi.Name, _appViewModel, _currentEditorDifficultyLevel,
                            this, isreadonly));
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
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(p42.Chunks[i], p42.Chunks[i].GetType().Name, _appViewModel,
                        _currentEditorDifficultyLevel, this, isreadonly));
                }
            }
            if (sdb.Data is IParseableBuffer ipb)
            {
                Properties.Add(_chunkViewmodelFactory.ChunkViewModel(ipb.Data.NotNull(), ipb.Data.GetType().Name, _appViewModel,
                    _currentEditorDifficultyLevel, this, isreadonly));
            }
        }
        else if (obj is DataBuffer db)
        {
            if (db.Data is RedPackage p43)
            {
                for (var i = 0; i < PropertyCount; i++)
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(p43.Chunks[i], p43.Chunks[i].GetType().Name, _appViewModel,
                        _currentEditorDifficultyLevel, this, isreadonly));
                }
            }
            else if (db.Data is CR2WList cl)
            {
                for (var i = 0; i < PropertyCount; i++)
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel(cl.Files[i].RootChunk, cl.Files[i].RootChunk.GetType().Name,
                        _appViewModel, _currentEditorDifficultyLevel, this, isreadonly));
                }
            }
            else if (db.Data is IList list)
            {
                foreach (var thing in list)
                {
                    if (thing is IRedType redType)
                    {
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(redType, redType.GetType().Name, _appViewModel,
                            _currentEditorDifficultyLevel, this, isreadonly));
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
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(irt, pi.Name, _appViewModel,
                            _settingsManager.DefaultEditorDifficultyLevel, this, isreadonly));
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
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(t, name, _appViewModel, _currentEditorDifficultyLevel, this,
                            isreadonly));
                    }
                }
            }
            else if (Data is IList list)
            {
                foreach (var thing in list)
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel((IRedType)thing, "Element", _appViewModel,
                        _currentEditorDifficultyLevel, this, isreadonly));
                }
            }
            else if (Data is Dictionary<string, object> dict)
            {
                foreach (var (name, thing) in dict)
                {
                    Properties.Add(_chunkViewmodelFactory.ChunkViewModel((IRedType)thing, name, _appViewModel,
                        _currentEditorDifficultyLevel,
                        this, isreadonly));
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
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(irt, pi.Name, _appViewModel, _currentEditorDifficultyLevel,
                            this, isreadonly));
                    }
                }

                if (Data is worldNodeData sst && Tab is { } dvm && dvm.Chunks[0].Data is worldStreamingSector wss && sst.NodeIndex < wss.Nodes.Count)
                {
                    try
                    {
                        Properties.Add(_chunkViewmodelFactory.ChunkViewModel(wss.Nodes[sst.NodeIndex].NotNull(), "Node", _appViewModel,
                            _currentEditorDifficultyLevel, this, isreadonly));
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

        if (!IsDefault && Parent is not null && Data is not RedDummy &&
            GetPropertyByRedName(Parent.ResolvedPropertyType, PropertyName) is { } epi)
        {
            IsDefault = epi.IsDefault(ResolvedData);
        }

        IsDefault = IsDefault || ResolvedData switch
        {
            entSkinnedMeshComponent skinnedMeshComponent => string.IsNullOrEmpty(skinnedMeshComponent.Mesh.DepotPath.GetResolvedText()),
            entMeshComponent meshComponent => string.IsNullOrEmpty(meshComponent.Mesh.DepotPath.GetResolvedText()),
            Multilayer_Layer layer => ((float)layer.Opacity) == 0.0,
            _ => IsDefault
        };
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
        if (item.Parent == null || Tab == null)
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
                sourceList = pkg.Chunks;
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
                destList = pkg.Chunks;
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

            return false;
        }

        if (Data is IRedBufferPointer db)
        {
            if (index == -1 || index > ira.Count)
            {
                index = ira.Count;
            }
            ira.Insert(index, item);

            return true;
        }

        return false;
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

        if (ResolvedData is not IRedArray && !PropertyType.IsAssignableTo(typeof(IRedArray)) &&
            !PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)))
        {
            return false;
        }

        if (Data is not RedDummy)
        {
            return true;
        }

        if (_flags == null || _flags.Equals(Flags.Empty))
        {
            if (Activator.CreateInstance(PropertyType) is IRedType o)
            {
                Data = o;
                return true;
            }
        }
        else
        {
            var flags = Flags.NotNull();
            if (Activator.CreateInstance(PropertyType, flags.MoveNext() ? flags.Current : 0) is IRedType o)
            {
                Data = o;
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Will return a ChunkViewModel if the node is an array and the index is valid
    /// </summary>
    /// <param name="index">numeric index of target node</param>
    /// <returns>ChunkViewModel or null</returns>
    public ChunkViewModel? GetChildNode(int index)
    {
        if (!IsArray || Properties is not ObservableCollectionExtended<ChunkViewModel> children ||
            index >= children.Count)
        {
            return null;
        }

        return children[index];
    }

    public bool InsertChild(int index, IRedType item)
    {
        try
        {
            if (ResolvedData is IRedArray ira)
            {
                index = Math.Min(index, ira.Count);
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
                        var handle = (IRedBaseHandle)Activator.CreateInstance(ira.InnerType)!;
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
                index = Math.Min(index, ira2.Count - 1);
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
                        var handle = (IRedBaseHandle)Activator.CreateInstance(ira2.InnerType)!;
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
                        list.Files.Insert(index, new CR2WFile
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

            RecalculateProperties(item);

            // re-number children
            ReindexChildren();
            Tab?.Parent.SetIsDirty(true);

            if (Properties.Count > index && Tab is not null)
            {
                var chunkModel = Properties.LastOrDefault(x => x.NodeIdxInParent == index);
                if (chunkModel is not null)
                {
                    Tab.AddToSelection(chunkModel);
                }
            }
            return true;
        }
        catch (Exception ex) { _loggerService.Error(ex); }

        return false;
    }

    private void SetDataIndexProperty(int newIndex)
    {
        if (ResolvedData is RedDummy || !IsInArray)
        {
            return;
        }

        switch (ResolvedData)
        {
            case worldCompiledEffectPlacementInfo info:
                info.PlacementTagIndex = (CUInt8)newIndex;
                break;
            case CMeshMaterialEntry materialDefinition:
                materialDefinition.Index = (CUInt16)newIndex;
                break;
            default:
                return;
        }

        OnPropertyChanged("Data");
        
        RecalculateProperties();
        CalculateValue();
        CalculateDescriptor();
    }
    /*
     * QOL: Increment index property in new child
     */
    private void AdjustPropertiesAfterPasteAsNewItem()
    {
        if (Parent is null || !IsInArray || ResolvedData is RedDummy || IsShiftKeyPressed)
        {
            return;
        }

        switch (Parent.ResolvedData)
        {
            // For placement tags: set PlacementTagIndex to previous sibling's plus one
            case CArray<worldCompiledEffectPlacementInfo> infoArray when
                ResolvedData is worldCompiledEffectPlacementInfo info:

                var effectsIndex = infoArray
                    .OrderBy(mat => Int32.Parse(mat.PlacementTagIndex.ToString()))
                    .Select(mat => mat.PlacementTagIndex)
                    .Last();
                SetDataIndexProperty(effectsIndex + 1);
                break;

            // For material definitions: Find highest index of local/external material and increment by one
            case CArray<CMeshMaterialEntry> materialDefinitionArray when
                ResolvedData is CMeshMaterialEntry materialDefinition:
            {
                var materialIndex = materialDefinitionArray
                    .Where(mat => mat.IsLocalInstance.Equals(materialDefinition.IsLocalInstance))
                    .OrderBy(mat => Int32.Parse(mat.Index.ToString()))
                    .Select(mat => mat.Index)
                    .Last();

                SetDataIndexProperty(materialIndex + 1);
                break;
            }
            default:
                return;
        }
    }

    public void RecalculateProperties(IRedType? selectChild = null, bool expand = true)
    {
        PropertyCount = -1;
        // might not be needed
        _propertiesLoaded = false;
        //_resolvedDataCache = null;
        CalculateProperties();
        CalculateDescriptor();

        if (IsArray)
        {
            ReindexChildren();
        }

        OnPropertyChanged(nameof(Data));

        IsExpanded = expand;

        if (!expand || selectChild is null)
        {
            return;
        }

        if (Properties.FirstOrDefault(p => p.Data is not RedDummy && p.Data.GetHashCode() == selectChild.GetHashCode()) is not
            ChunkViewModel prop)
        {
            return;
        }

        prop.IsExpanded = true;
        prop.SetChildExpansionStates(true);

        if (Tab is RDTDataViewModel dvm)
        {
            dvm.SelectedChunk = prop;
        }
    }

    public IList<ReferenceSocket> Inputs
    {
        get => new List<ReferenceSocket>(new[] { Socket.NotNull() });
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

    public ChunkViewModel? GetModelFromPath(string path)
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

    public IEnumerable<ChunkViewModel> GetAllProperties()
    {
        foreach (var property in Properties)
        {
            yield return property;

            foreach (var childProperty in property.GetAllProperties())
            {
                yield return childProperty;
            }
        }
    }

    public void NotifyChain(string property)
    {
        OnPropertyChanged(property);
        Parent?.NotifyChain(property);
    }

    public bool MightHaveChildren() => HasChildren() || IsArray;

    public bool HasChildren() => PropertyCount > 0;

    public void HandlePointer(DialogViewModel? sender)
    {
        _appViewModel.CloseDialogCommand.Execute(null);
        if (sender is TypeSelectorDialogViewModel { SelectedEntry: TypeEntry { UserData: Type selectedType } selectedEntry })
        {
            var instance = RedTypeManager.Create(selectedType);
            if (instance is DynamicBaseClass dbc)
            {
                dbc.ClassName = selectedEntry.Name;
            }
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
        else
        {
            _loggerService.Error("Could not create handle");
        } 
    }

    public void HandleCKeyValuePair(DialogViewModel? sender)
    {
        _appViewModel.CloseDialogCommand.Execute(null);
        if (sender is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType })
        {
            if (Activator.CreateInstance(selectedType) is IRedType t)
            {
                var instance = new CKeyValuePair(CName.Empty, t);
                InsertChild(-1, instance);
            }
        }
    }

    public void HandleChunk(DialogViewModel? sender)
    {
        _appViewModel.CloseDialogCommand.Execute(null);
        if (sender is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType })
        {
            var instance = RedTypeManager.CreateRedType(selectedType);
            if (!InsertChild(-1, instance))
            {
                _loggerService.Error("Unable to insert child");
            }
        }
    }

    public void HandleChunkPointer(DialogViewModel? sender)
    {
        _appViewModel.CloseDialogCommand.Execute(null);
        if (sender is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType } && Data is IRedArray arr)
        {
            var newItem = RedTypeManager.CreateRedType(arr.InnerType);
            if (newItem is IRedBaseHandle handle)
            {
                var instance = RedTypeManager.Create(selectedType);
                handle.SetValue(instance);
                if (!InsertChild(-1, newItem))
                {
                    _loggerService.Error("Unable to insert child");
                }
            }
        }
    }

    public void ClearChildren()
    {
        if (ResolvedData is IRedArray ary)
        {
            ary.Clear();
        }
        else if (ResolvedData is IRedLegacySingleChannelCurve curve)
        {
            curve.Clear();
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
            if (Parent?.Data is DataBuffer { Buffer.Data: IRedArray ira } && json4.Count == ira.Count)
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

        if (Parent?.Data is DataBuffer { Buffer.Data: IRedType irtt })
        {
            Tab?.Parent.SetIsDirty(true);
            RecalculateProperties(irtt);
        }

        ArgumentNullException.ThrowIfNull(Tab);
        _appViewModel.SaveFileCommand.SafeExecute();

        await Refresh();

        _loggerService.Success("Successfully imported from JSON");
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
        var (minX, maxX) = (poslist.Select(v => v.X).Min(), poslist.Select(v => v.X).Max());
        var cX = (maxX + minX) / 2;

        var (minY, maxY) = (poslist.Select(v => v.Y).Min(), poslist.Select(v => v.Y).Max());
        var cY = (maxY + minY) / 2;

        var (minZ, maxZ) = (poslist.Select(v => v.Z).Min(), poslist.Select(v => v.Z).Max());
        var cZ = (maxZ + minZ) / 2;

        var (minW, maxW) = (poslist.Select(v => v.W).Min(), poslist.Select(v => v.W).Max());
        var cW = (maxW + minW) / 2;

        return new Vec4(cX, cY, cZ, cW);
    }

    private static Vec4 GetCenter(List<List<object>> json)
    {
        var poslist =
            json.Select(j =>
            new Vec3
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
        var (minX, maxX) = (poslist.Select(v => v.X).Min(), poslist.Select(v => v.X).Max());
        var cX = (maxX + minX) / 2;

        var (minY, maxY) = (poslist.Select(v => v.Y).Min(), poslist.Select(v => v.Y).Max());
        var cY = (maxY + minY) / 2;

        var (minZ, maxZ) = (poslist.Select(v => v.Z).Min(), poslist.Select(v => v.Z).Max());
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

            var v = new Vec4
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
        var posAndRot = RedJsonSerializer.Deserialize<Vec7S>(PutQuotes(line.pos)).NotNull();

        ArgumentNullException.ThrowIfNull(posAndRot);
        ArgumentNullException.ThrowIfNull(posAndRot.x);
        ArgumentNullException.ThrowIfNull(posAndRot.y);
        ArgumentNullException.ThrowIfNull(posAndRot.z);
        ArgumentNullException.ThrowIfNull(posAndRot.w);
        ArgumentNullException.ThrowIfNull(posAndRot.yaw);
        ArgumentNullException.ThrowIfNull(posAndRot.pitch);
        ArgumentNullException.ThrowIfNull(posAndRot.roll);

        // it really can't be null anymore
        var v = new Vec4
        {
            X = float.Parse(posAndRot.x), Y = float.Parse(posAndRot.y), Z = float.Parse(posAndRot.z), W = float.Parse(posAndRot.w)
            };

        var euler = new Vec3
        {
            X = (float)(Math.PI / 180) * float.Parse(posAndRot.yaw),
            Y = (float)(Math.PI / 180) * float.Parse(posAndRot.pitch),
            Z = (float)(Math.PI / 180) * float.Parse(posAndRot.roll)
            };

        var q = line.isunreal ? FixRotation2(euler) : FixRotation(euler);

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
            var v = new Vec4
            {
                X = pos.x,
                Y = pos.y,
                Z = pos.z,
                W = pos.w
            };
            poslist.Add(v);

            var euler = new Vec3
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
            wen.DebugName = Path.GetFileNameWithoutExtension(line.template_path) + "_" + index;

            current.QuestPrefabRefHash = Convert.ToUInt64(current.GetHashCode()); // Add hash to make object interactible and persistent

            if (line.isdoor is bool and true)
            {
                var eeid = new entEntityInstanceData();
                var eeidh = new CHandle<entEntityInstanceData>(eeid);

                wen.InstanceData = eeidh;
                eeid.Buffer = new DataBuffer();

                var pk = new RedPackage();
                var dc = new DoorController();
                pk.Chunks = new List<RedBaseClass>();

                dc.PersistentState = new DoorControllerPS
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
        if (Parent?.Parent?.Data is not worldStreamingSector wss ||
            RedJsonSerializer.Deserialize<worldNodeData>(tr) is not worldNodeData current)
        {
            return;
        }

        //var cmesh = new worldStaticMeshNode();
        var cmesh = new worldGenericProxyMeshNode();

        var wenh = new CHandle<worldNode>(cmesh);
        var index = wss.Nodes.Count;

        cmesh.DebugName = Path.GetFileNameWithoutExtension(line.template_path) + "_" + index;
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
        if (Parent?.Data is DataBuffer { Buffer.Data: worldNodeDataBuffer db0 })
        {
            if (!db0.Lookup.ContainsKey(current.NodeIndex))
            {
                db0.Lookup[current.NodeIndex] = new();
            }
            db0.Lookup[current.NodeIndex].Add(current);
        }

        if (Parent?.Data is DataBuffer { Buffer.Data: IRedType irt })
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
                var door = line.isdoor is bool and true;

                if (scale != Vec3.One)
                {
                    var path = line.template_path;
                    var sp = Path.GetFileName(path);
                    var spm = Path.ChangeExtension(sp, ".mesh");

                    //find ent
                    var foundents = entList.Where(x => x.FileName.Contains(sp)).Select(f => f).ToList();

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
                                .Select(x => (entMeshComponent)x).ToList();

                            for (var i1 = 0; i1 < meshes.Count; i1++)
                            {
                                var mesh = meshes[i1];
                                var (p, r) = GetPosRot(line);

                                var t = mesh.LocalTransform.Position;
                                var mp = new Vec4(t.X, t.Y, t.Z, 1);

                                var np = p + mp;
                                var nrq = r * mesh.LocalTransform.Orientation;

                                var newline = new Prop
                                {
                                    name = line.name + "_" + i1,
                                    app = line.app == "" ? "default" : line.app,
                                    template_path = mesh.Mesh.DepotPath.GetResolvedText() ?? "",
                                    scale = line.scale
                                };

                                AddMesh(tr, newline, updatecoords, np, nrq);
                            }
                        }
                        else
                        {
                            var foundmesh = meshList.Where(x => x.FileName.Contains(spm)).Select(f => f.FileName).ToList();
                            if (foundmesh.Count > 0)
                            {
                                line.template_path = foundmesh.Last();
                                AddMesh(tr, line, updatecoords);
                            }
                        }
                    }
                    else
                    {
                        var foundmesh = meshList.Where(x => x.FileName.Contains(spm)).Select(f => f.FileName).ToList();
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
        if (Parent?.Data is DataBuffer { Buffer.Data: IRedArray ira })
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

        ArgumentNullException.ThrowIfNull(scala.x);
        ArgumentNullException.ThrowIfNull(scala.y);
        ArgumentNullException.ThrowIfNull(scala.z);

        return new Vec3(float.Parse(scala.x) * factor, float.Parse(scala.y) * factor, float.Parse(scala.z) * factor);
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
