using System;
using System.Collections.ObjectModel;
using System.Linq;
using WolvenKit.App.Controllers;
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using Splat;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using WolvenKit.Core.Extensions;
using System.IO;

namespace WolvenKit.App.ViewModels.Documents
{
    public class SceneTabDefinition
    {
        public string Header { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public Func<ChunkViewModel, bool> Filter { get; set; } = _ => false;
    }

    public partial class SceneGraphViewModel : RedDocumentTabViewModel, IDisposable
    {
        private bool _disposed = false;
        private readonly ILoggerService? _logger = Locator.Current.GetService<ILoggerService>();
        private readonly scnSceneResource _sceneData;

        public RDTDataViewModel RDTViewModel { get; }
        public RedGraph MainGraph { get; }
        public ObservableCollection<SceneTabDefinition> Tabs { get; } = new();

        [ObservableProperty]
        private SceneTabDefinition? _selectedTab;

        private object? _selectedTabContent;
        
        public object? SelectedTabContent
        {
            get => _selectedTabContent;
            set => SetProperty(ref _selectedTabContent, value);
        }

        [ObservableProperty]
        private bool _isGraphLoading = true;

        // Button visibility for tab-specific actions
        public bool IsActorCreationVisible => SelectedTab?.Header == "Actors & Props";
        
        public bool IsPropCreationVisible => SelectedTab?.Header == "Actors & Props";
        
        public bool IsDialogueCreationVisible => SelectedTab?.Header == "Dialogue";
        
        public bool IsOptionCreationVisible => SelectedTab?.Header == "Dialogue";
        
        public bool IsWorkspotCreationVisible => SelectedTab?.Header == "Asset Library";
        
        public bool IsEffectCreationVisible => SelectedTab?.Header == "Asset Library";
        
        public bool IsAnimationCreationVisible => SelectedTab?.Header == "Asset Library";
        
        public bool IsButtonBarVisible => IsActorCreationVisible || IsPropCreationVisible || IsDialogueCreationVisible || IsOptionCreationVisible || IsWorkspotCreationVisible || IsEffectCreationVisible || IsAnimationCreationVisible;

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

        // Scene statistics properties
        public string FileName => Path.GetFileNameWithoutExtension(Parent?.Header ?? "Unknown");
        
        public string SceneCategory
        {
            get
            {
                var category = _sceneData.SceneCategoryTag.ToEnumString();
                return category != "other" ? category : string.Empty;
            }
        }

        public string SceneTitleWithCategory
        {
            get
            {
                var category = SceneCategory;
                return string.IsNullOrEmpty(category) ? FileName : $"{FileName} ({category})";
            }
        }

        public int TotalNodes => _sceneData.SceneGraph?.Chunk?.Graph?.Count ?? 0;
        
        public int TotalActors => (_sceneData.Actors?.Count ?? 0) + (_sceneData.PlayerActors?.Count ?? 0);
        
        public int TotalProps => _sceneData.Props?.Count ?? 0;
        
        public int TotalChoices => _sceneData.ScreenplayStore?.Options?.Count ?? 0;
        
        public int TotalDialogues => _sceneData.ScreenplayStore?.Lines?.Count ?? 0;

        public SceneGraphViewModel(scnSceneResource data, RedDocumentViewModel parent, IChunkViewmodelFactory chunkViewmodelFactory, INodeWrapperFactory nodeWrapperFactory)
            : base(parent, "Scene Editor")
        {
            _sceneData = data;
            
            var appViewModel = Locator.Current.GetService<AppViewModel>() ?? throw new ArgumentNullException(nameof(AppViewModel));
            var settingsManager = Locator.Current.GetService<ISettingsManager>() ?? throw new ArgumentNullException(nameof(ISettingsManager));
            var gameController = Locator.Current.GetService<IGameControllerFactory>() ?? throw new ArgumentNullException(nameof(IGameControllerFactory));

            RDTViewModel = new RDTDataViewModel(data, parent, appViewModel, chunkViewmodelFactory, settingsManager, gameController);
            MainGraph = RedGraph.GenerateSceneGraph(parent.Header, data, parent);
            
            // Set document reference for property change syncing
            MainGraph.DocumentViewModel = parent;

            // Ensure all nodes have DocumentViewModel reference for dirty tracking
            foreach (var node in MainGraph.Nodes)
            {
                node.DocumentViewModel = parent;
            }

            CreateTabs();
            
            // Set the first tab as selected
            SelectedTab = Tabs.FirstOrDefault();

            if (SelectedTab != null)
            {
                UpdateTabContent(SelectedTab);
            }
        }

        public void SetGraphLoaded()
        {
            IsGraphLoading = false;
        }

        private void CreateTabs()
        {
            // Create tab definitions using the CollectionViewHelper filters
            Tabs.Add(new SceneTabDefinition
            {
                Header = "Node Properties",
                Icon = "SitemapOutline",
                Filter = CollectionViewHelper.CreateNodePropertiesFilter()
            });

            Tabs.Add(new SceneTabDefinition
            {
                Header = "Actors & Props",
                Icon = "AccountGroupOutline",
                Filter = CollectionViewHelper.CreateActorsAndPropsFilter()
            });

            Tabs.Add(new SceneTabDefinition
            {
                Header = "Logic & Flow",
                Icon = "ArrowDecisionOutline",
                Filter = CollectionViewHelper.CreateLogicAndFlowFilter()
            });

            Tabs.Add(new SceneTabDefinition
            {
                Header = "Dialogue",
                Icon = "MessageTextOutline",
                Filter = CollectionViewHelper.CreateDialogueFilter()
            });

            Tabs.Add(new SceneTabDefinition
            {
                Header = "Asset Library",
                Icon = "PackageVariantClosed",
                Filter = CollectionViewHelper.CreateAssetLibraryFilter()
            });

            Tabs.Add(new SceneTabDefinition
            {
                Header = "Markers & Metadata",
                Icon = "TagOutline",
                Filter = CollectionViewHelper.CreateMarkersAndMetadataFilter()
            });
        }

        private void UpdateTabContent(SceneTabDefinition tab)
        {
            var rootChunk = RDTViewModel.GetRootChunk();
            if (rootChunk == null)
            {
                _logger?.Warning($"[PANEL] No root chunk found for tab '{tab.Header}'");
                SelectedTabContent = null;
                return;
            }

            if (!rootChunk.TVProperties.Any())
            {
                rootChunk.CalculateProperties();
            }

            foreach (var cvm in rootChunk.TVProperties)
            {
                if (tab.Filter(cvm))
                {
                    cvm.CalculateProperties();
                }
            }

            var list = new List<ChunkViewModel>(rootChunk.TVProperties.Where(c => tab.Filter(c)));
            SelectedTabContent = list;
        }

        partial void OnSelectedTabChanged(SceneTabDefinition? value)
        {
            if (value == null) return;
            UpdateTabContent(value);
            OnPropertyChanged(nameof(IsActorCreationVisible));
            OnPropertyChanged(nameof(IsPropCreationVisible));
            OnPropertyChanged(nameof(IsDialogueCreationVisible));
            OnPropertyChanged(nameof(IsOptionCreationVisible));
            OnPropertyChanged(nameof(IsWorkspotCreationVisible));
            OnPropertyChanged(nameof(IsEffectCreationVisible));
            OnPropertyChanged(nameof(IsAnimationCreationVisible));
            OnPropertyChanged(nameof(IsButtonBarVisible));
        }

        [RelayCommand]
        private void CreateNewActor()
        {
            try
            {
                // Show scene input dialog for actor name
                var defaultName = $"NewActor_{_sceneData.Actors.Count + 1}";
                var dialogResult = Interactions.AskForSceneInput(("Add New Actor", "Actor Name:", defaultName, false, "", "", false, "", null, null)); 
                var actorName = dialogResult.primaryInput;
                
                // Check if user cancelled the dialog
                if (string.IsNullOrWhiteSpace(actorName))
                {
                    return;
                }

                // Create a new actor definition with user-provided name
                var newActor = new scnActorDef
                {
                    ActorName = actorName.Trim()
                };

                // Use the built-in AddActor method which handles initialization
                _sceneData.AddActor(newActor);

                // Create performer debug symbol for the new actor
                _sceneData.DebugSymbols ??= new scnDebugSymbols();
                var performerSymbol = new scnPerformerSymbol
                {
                    PerformerId = new scnPerformerId { Id = scnSceneResource.CalculatePerformerId(newActor.ActorId.Id) },
                    EntityRef = newActor.FindActorInWorldParams?.ActorRef ?? new gameEntityReference { Names = new CArray<CName>() },
                    EditorPerformerId = new CRUID()
                };
                _sceneData.DebugSymbols.PerformersDebugSymbols.Add(performerSymbol);

                // Mark document as dirty
                Parent?.SetIsDirty(true);

                // Force recalculation of the root chunk properties to pick up new actor
                var rootChunk = RDTViewModel.GetRootChunk();
                if (rootChunk != null)
                {
                    rootChunk.RecalculateProperties();
                }

                // Refresh the current tab content
                if (SelectedTab != null)
                {
                    UpdateTabContent(SelectedTab);
                }

                // Auto-expand to show the newly created actor
                ExpandToNewEntry("actors", "", 0);

                // Update total actors count in the UI
                OnPropertyChanged(nameof(TotalActors));

                _logger?.Info($"Created new actor: {newActor.ActorName}");
            }
            catch (Exception ex)
            {
                _logger?.Error($"Failed to create new actor: {ex.Message}");
            }
        }

        [RelayCommand]
        private void CreateNewProp()
        {
            try
            {
                // Show scene input dialog for prop name
                var defaultName = $"NewProp_{_sceneData.Props.Count + 1}";
                var dialogResult = Interactions.AskForSceneInput(("Add New Prop", "Prop Name:", defaultName, false, "", "", false, "", null, null));
                var propName = dialogResult.primaryInput;
                
                // Check if user cancelled the dialog
                if (string.IsNullOrWhiteSpace(propName))
                {
                    return;
                }

                // Create a new prop definition with user-provided name
                var newProp = new scnPropDef
                {
                    PropName = propName.Trim()
                };

                // Use the built-in AddProp method which handles initialization
                _sceneData.AddProp(newProp);

                // Mark document as dirty
                Parent?.SetIsDirty(true);

                // Force recalculation of the root chunk properties to pick up new prop
                var rootChunk = RDTViewModel.GetRootChunk();
                if (rootChunk != null)
                {
                    rootChunk.RecalculateProperties();
                }

                // Refresh the current tab content
                if (SelectedTab != null)
                {
                    UpdateTabContent(SelectedTab);
                }

                // Auto-expand to show the newly created prop
                ExpandToNewEntry("props", "", 0);

                // Update total props count in the UI
                OnPropertyChanged(nameof(TotalProps));

                _logger?.Info($"Created new prop: {newProp.PropName}");
            }
            catch (Exception ex)
            {
                _logger?.Error($"Failed to create new prop: {ex.Message}");
            }
        }

        [RelayCommand]
        private void CreateNewDialogue()
        {
            try
            {
                var dialogResult = Interactions.AskForSceneInput((
                    "Add New Dialogue Line", 
                    "LocString ID:", 
                    "", 
                    showSecondary: true, 
                    "Embedded Text:", 
                    "Create embedded text? (Optional)",
                    false, "", null, null
                ));
                
                if (dialogResult.primaryInput == null)
                {
                    return;
                }

                var locStringId = dialogResult.primaryInput;
                var createEmbedText = dialogResult.enableSecondary;
                var embeddedText = dialogResult.secondaryInput;

                var itemId = (uint)2; // First id is always 2
                if (_sceneData.ScreenplayStore.Lines.Count > 0)
                {
                    itemId = _sceneData.ScreenplayStore.Lines[^1].ItemId.Id + 256;
                }

                var random = new Random();
                var cruid = (CRUID)random.NextCRUID();
                
                // Parse locStringId as ulong if it's numeric, otherwise generate a CRUID
                ulong locStringIdValue;
                if (!ulong.TryParse(locStringId.Trim(), out locStringIdValue))
                {
                    locStringIdValue = (ulong)cruid;
                }

                // Create the dialogue line
                var newDialogueLine = new scnscreenplayDialogLine
                {
                    ItemId = new scnscreenplayItemId { Id = itemId },
                    LocstringId = new scnlocLocstringId { Ruid = (CRUID)locStringIdValue },
                    Usage = new scnscreenplayLineUsage { PlayerGenderMask = new scnGenderMask { Mask = 3 } }
                };

                // Add the dialogue line to the screenplay store
                _sceneData.ScreenplayStore.Lines.Add(newDialogueLine);

                // If creating embedded text, add entries to locStore
                if (createEmbedText && embeddedText != null)
                {
                    var variantCruid = (CRUID)random.NextCRUID();

                    // Create VpEntry (payload entry) with the embedded text
                    _sceneData.LocStore.VpEntries.Add(new scnlocLocStoreEmbeddedVariantPayloadEntry
                    {
                        Content = embeddedText,
                        VariantId = new scnlocVariantId { Ruid = variantCruid }
                    });

                    // Create VdEntry (descriptor entry) linking locStringId to the payload with en_us locale
                    _sceneData.LocStore.VdEntries.Add(new scnlocLocStoreEmbeddedVariantDescriptorEntry
                    {
                        LocstringId = new scnlocLocstringId { Ruid = (CRUID)locStringIdValue },
                        VariantId = new scnlocVariantId { Ruid = variantCruid },
                        VpeIndex = (uint)(_sceneData.LocStore.VpEntries.Count - 1),
                        Signature = new scnlocSignature { Val = 3 }, // en_us locale signature
                        LocaleId = Enums.scnlocLocaleId.en_us
                    });
                }

                // Mark document as dirty
                Parent?.SetIsDirty(true);

                // Force recalculation of the root chunk properties to pick up new dialogue
                var rootChunk = RDTViewModel.GetRootChunk();
                if (rootChunk != null)
                {
                    rootChunk.RecalculateProperties();
                }

                // Refresh the current tab content
                if (SelectedTab != null)
                {
                    UpdateTabContent(SelectedTab);
                }

                // Auto-expand to show the newly created dialogue line
                ExpandToNewEntry("screenplayStore", "lines", itemId);

                // Update total dialogues count in the UI
                OnPropertyChanged(nameof(TotalDialogues));

                _logger?.Info($"Created new dialogue line with itemId: {itemId}, locStringId: {locStringIdValue}" + 
                             (createEmbedText ? $", embedded text: '{embeddedText}'" : ""));
            }
            catch (Exception ex)
            {
                _logger?.Error($"Failed to create new dialogue: {ex.Message}");
            }
        }

        [RelayCommand]
        private void CreateNewOption()
        {
            try
            {
                var dialogResult = Interactions.AskForSceneInput((
                    "Add New Choice Option", 
                    "LocString ID:", 
                    "", 
                    showSecondary: true, 
                    "Embedded Text:", 
                    "Create embedded text? (Optional)",
                    false, "", null, null
                ));
                
                if (dialogResult.primaryInput == null)
                {
                    return;
                }

                var locStringId = dialogResult.primaryInput;
                var createEmbedText = dialogResult.enableSecondary;
                var embeddedText = dialogResult.secondaryInput;

                var itemId = (uint)2; // First id is always 2
                if (_sceneData.ScreenplayStore.Options.Count > 0)
                {
                    itemId = _sceneData.ScreenplayStore.Options[^1].ItemId.Id + 256;
                }

                var random = new Random();
                var cruid = (CRUID)random.NextCRUID();
                
                // Parse locStringId as ulong if it's numeric, otherwise generate a CRUID
                ulong locStringIdValue;
                if (!ulong.TryParse(locStringId.Trim(), out locStringIdValue))
                {
                    locStringIdValue = (ulong)cruid;
                }

                // Create the choice option
                var newChoiceOption = new scnscreenplayChoiceOption
                {
                    ItemId = new scnscreenplayItemId { Id = itemId },
                    LocstringId = new scnlocLocstringId { Ruid = (CRUID)locStringIdValue },
                    Usage = new scnscreenplayOptionUsage { PlayerGenderMask = new scnGenderMask { Mask = 3 } }
                };

                // Add the choice option to the screenplay store
                _sceneData.ScreenplayStore.Options.Add(newChoiceOption);

                // If creating embedded text, add entries to locStore
                if (createEmbedText && embeddedText != null)
                {
                    var variantCruid = (CRUID)random.NextCRUID();

                    // Create VpEntry (payload entry) with the embedded text
                    _sceneData.LocStore.VpEntries.Add(new scnlocLocStoreEmbeddedVariantPayloadEntry
                    {
                        Content = embeddedText,
                        VariantId = new scnlocVariantId { Ruid = variantCruid }
                    });

                    // Create VdEntry (descriptor entry) linking locStringId to the payload with en_us locale
                    _sceneData.LocStore.VdEntries.Add(new scnlocLocStoreEmbeddedVariantDescriptorEntry
                    {
                        LocstringId = new scnlocLocstringId { Ruid = (CRUID)locStringIdValue },
                        VariantId = new scnlocVariantId { Ruid = variantCruid },
                        VpeIndex = (uint)(_sceneData.LocStore.VpEntries.Count - 1),
                        Signature = new scnlocSignature { Val = 3 }, // en_us locale signature
                        LocaleId = Enums.scnlocLocaleId.en_us
                    });
                }

                // Mark document as dirty
                Parent?.SetIsDirty(true);

                // Force recalculation of the root chunk properties to pick up new choice option
                var rootChunk = RDTViewModel.GetRootChunk();
                if (rootChunk != null)
                {
                    rootChunk.RecalculateProperties();
                }

                // Refresh the current tab content
                if (SelectedTab != null)
                {
                    UpdateTabContent(SelectedTab);
                }

                // Auto-expand to show the newly created choice option
                ExpandToNewEntry("screenplayStore", "options", itemId);

                // Update total dialogues count in the UI 
                OnPropertyChanged(nameof(TotalDialogues));

                _logger?.Info($"Created new choice option with itemId: {itemId}, locStringId: {locStringIdValue}" + 
                             (createEmbedText ? $", embedded text: '{embeddedText}'" : ""));
            }
            catch (Exception ex)
            {
                _logger?.Error($"Failed to create new choice option: {ex.Message}");
            }
        }

        [RelayCommand]
        private void CreateNewWorkspot()
        {
            try
            {
                // Show scene input dialog for workspot file path
                var dialogResult = Interactions.AskForSceneInput((
                    "Add New Workspot", 
                    "Workspot File Path (.workspot):", 
                    "", 
                    showSecondary: false, 
                    "", 
                    "",
                    false, "", null, null
                ));
                
                // Check if user cancelled the dialog
                if (string.IsNullOrWhiteSpace(dialogResult.primaryInput))
                {
                    return;
                }

                var workspotPath = dialogResult.primaryInput.Trim();
                
                // Validate file extension
                if (!workspotPath.EndsWith(".workspot", StringComparison.OrdinalIgnoreCase))
                {
                    _logger?.Error($"Invalid workspot file path: '{workspotPath}'. Workspot files must end with '.workspot'");
                    return;
                }
                
                // Generate random dataId for the workspot definition
                var random = new Random();
                var dataId = (uint)random.Next(1, int.MaxValue);
                
                // Ensure unique dataId
                while (_sceneData.Workspots.Any(w => w.GetValue() is scnWorkspotData data && data.DataId.Id == dataId))
                {
                    dataId = (uint)random.Next(1, int.MaxValue);
                }

                // Create workspot definition with external resource reference
                var workspotData = new scnWorkspotData_ExternalWorkspotResource
                {
                    DataId = new scnSceneWorkspotDataId { Id = dataId },
                    WorkspotResource = new CResourceReference<workWorkspotResource>(workspotPath)
                };

                // Add to workspots collection
                _sceneData.Workspots.Add(workspotData);

                // Generate unique workspot instance ID (smaller numbers, typically 1-based)
                var instanceId = (uint)1;
                if (_sceneData.WorkspotInstances.Count > 0)
                {
                    instanceId = _sceneData.WorkspotInstances.Max(wi => wi.WorkspotInstanceId.Id) + 1;
                }

                // Create workspot instance
                var workspotInstance = new scnWorkspotInstance
                {
                    WorkspotInstanceId = new scnSceneWorkspotInstanceId { Id = instanceId },
                    DataId = new scnSceneWorkspotDataId { Id = dataId }, // Link to the definition
                    LocalTransform = new Transform 
                    { 
                        Position = new Vector4(), 
                        Orientation = new Quaternion { R = 1.000000F } 
                    },
                    PlayAtActorLocation = false,
                    OriginMarker = new scnMarker 
                    { 
                        Type = Enums.scnMarkerType.Global, 
                        EntityRef = new gameEntityReference { Names = new() }, 
                        IsMounted = true 
                    }
                };

                // Add to workspot instances collection
                _sceneData.WorkspotInstances.Add(workspotInstance);

                // Mark document as dirty
                Parent?.SetIsDirty(true);

                // Force recalculation of the root chunk properties
                var rootChunk = RDTViewModel.GetRootChunk();
                if (rootChunk != null)
                {
                    rootChunk.RecalculateProperties();
                }

                // Refresh the current tab content
                if (SelectedTab != null)
                {
                    UpdateTabContent(SelectedTab);
                }

                // Auto-expand to show the newly created workspot instance
                ExpandToNewEntry("workspotInstances", "", 0);

                _logger?.Info($"Created new workspot: path='{workspotPath}', dataId={dataId}, instanceId={instanceId}");
            }
            catch (Exception ex)
            {
                _logger?.Error($"Failed to create new workspot: {ex.Message}");
            }
        }

        [RelayCommand]
        private void CreateNewEffect()
        {
            try
            {
                // Show scene input dialog for effect file path
                var dialogResult = Interactions.AskForSceneInput((
                    "Add New Effect", 
                    "Effect File Path (.effect):", 
                    "", 
                    showSecondary: false, 
                    "", 
                    "",
                    false, "", null, null
                ));
                
                // Check if user cancelled the dialog
                if (string.IsNullOrWhiteSpace(dialogResult.primaryInput))
                {
                    return;
                }

                var effectPath = dialogResult.primaryInput.Trim();
                
                // Validate file extension
                if (!effectPath.EndsWith(".effect", StringComparison.OrdinalIgnoreCase))
                {
                    _logger?.Error($"Invalid effect file path: '{effectPath}'. Effect files must end with '.effect'");
                    return;
                }
                
                // Generate random effect ID
                var random = new Random();
                var effectId = (uint)random.Next(1, int.MaxValue);
                
                // Ensure unique effect ID
                while (_sceneData.EffectDefinitions.Any(e => e.Id.Id == effectId))
                {
                    effectId = (uint)random.Next(1, int.MaxValue);
                }

                // Create effect definition with external resource reference
                var effectDef = new scnEffectDef
                {
                    Id = new scnEffectId { Id = effectId },
                    Effect = new CResourceAsyncReference<worldEffect>(effectPath)
                };

                // Add to effect definitions collection
                _sceneData.EffectDefinitions.Add(effectDef);

                // Generate unique effect instance ID (smaller numbers, typically 1-based)
                var instanceId = (uint)1;
                if (_sceneData.EffectInstances.Count > 0)
                {
                    instanceId = _sceneData.EffectInstances.Max(ei => ei.EffectInstanceId.Id) + 1;
                }

                // Load the effect file and populate compiledEffect
                var compiledEventInfos = new CArray<worldCompiledEffectEventInfo>();
                
                try 
                {
                    // Load the effect file using Parent's resource loading
                    var effectFile = Parent?.GetFileFromDepotPathOrCache(effectPath);
                    if (effectFile?.RootChunk is worldEffect worldEffectResource)
                    {
                        // Extract RUIDs from each event in the effect file
                        foreach (var eventHandle in worldEffectResource.Events)
                        {
                            if (eventHandle.GetValue() is effectTrackItem eventItem)
                            {
                                var compiledEventInfo = new worldCompiledEffectEventInfo
                                {
                                    EventRUID = eventItem.Ruid,
                                    PlacementIndexMask = 1,
                                    ComponentIndexMask = 0,
                                    Flags = 1
                                };
                                
                                compiledEventInfos.Add(compiledEventInfo);
                            }
                        }
                        
                        _logger?.Info($"Loaded {compiledEventInfos.Count} events from effect file: {effectPath}");
                    }
                    else
                    {
                        _logger?.Warning($"Could not load effect file or invalid format: {effectPath}");
                    }
                }
                catch (Exception resourceEx)
                {
                    _logger?.Error($"Failed to load effect resource '{effectPath}': {resourceEx.Message}");
                }

                // Create default placement info
                var placementInfos = new CArray<worldCompiledEffectPlacementInfo>();
                placementInfos.Add(new worldCompiledEffectPlacementInfo
                {
                    Flags = 9,
                    RelativePositionIndex = 0,
                    RelativeRotationIndex = 1,
                    PlacementTagIndex = 255 // Default from constructor
                });

                // Create default relative positions and rotations
                var relativePositions = new CArray<Vector3>();
                relativePositions.Add(new Vector3 { X = 0.0f, Y = 0.0f, Z = 0.0f });

                var relativeRotations = new CArray<Quaternion>();
                relativeRotations.Add(new Quaternion { I = 0.0f, J = 0.0f, K = 0.0f, R = 1.0f });

                // Create effect instance with populated compiledEffect
                var effectInstance = new scnEffectInstance
                {
                    EffectInstanceId = new scnEffectInstanceId 
                    { 
                        EffectId = new scnEffectId { Id = effectId }, // Link to definition
                        Id = instanceId 
                    },
                    CompiledEffect = new worldCompiledEffectInfo 
                    { 
                        PlacementTags = new(), 
                        ComponentNames = new(), 
                        RelativePositions = relativePositions, // Default empty vec3 (0,0,0)
                        RelativeRotations = relativeRotations, // Default empty quaternion (0,0,0,1)
                        PlacementInfos = placementInfos, // Default placement info with flags=9
                        EventsSortedByRUID = compiledEventInfos // Use populated events
                    }
                };

                // Add to effect instances collection
                _sceneData.EffectInstances.Add(effectInstance);

                // Mark document as dirty
                Parent?.SetIsDirty(true);

                // Force recalculation of the root chunk properties
                var rootChunk = RDTViewModel.GetRootChunk();
                if (rootChunk != null)
                {
                    rootChunk.RecalculateProperties();
                }

                // Refresh the current tab content
                if (SelectedTab != null)
                {
                    UpdateTabContent(SelectedTab);
                }

                // Auto-expand to show the newly created effect instance
                ExpandToNewEntry("effectInstances", "", 0);

                _logger?.Info($"Created new effect: path='{effectPath}', effectId={effectId}, instanceId={instanceId}, compiledEvents={compiledEventInfos.Count}");
            }
            catch (Exception ex)
            {
                _logger?.Error($"Failed to create new effect: {ex.Message}");
            }
        }

        [RelayCommand]
        private void CreateNewAnimation()
        {
            try
            {
                // Available animation types
                var animationTypes = new[] { "Cinematic", "Gameplay" };
                
                // Show enhanced scene input dialog with dropdown for animation type
                var dialogResult = Interactions.AskForSceneInput((
                    "Add New Animation", 
                    "Animation File Path (.anims):", 
                    "", 
                    showSecondary: false, 
                    "", 
                    "",
                    showDropdown: true,
                    "Animation Type:",
                    animationTypes,
                    "Cinematic"
                ));
                
                // Check if user cancelled the dialog
                if (string.IsNullOrWhiteSpace(dialogResult.primaryInput))
                {
                    return;
                }

                var animsPath = dialogResult.primaryInput.Trim();
                var animationType = dialogResult.dropdownValue ?? "Cinematic";
                
                // Validate file extension
                if (!animsPath.EndsWith(".anims", StringComparison.OrdinalIgnoreCase))
                {
                    _logger?.Error($"Invalid animation file path: '{animsPath}'. Animation files must end with '.anims'");
                    return;
                }
                
                // Load the .anims file and extract animation names
                var animationNames = new List<string>();
                
                try 
                {
                    // Load the anims file using Parent's resource loading
                    var animsFile = Parent?.GetFileFromDepotPathOrCache(animsPath);
                    if (animsFile?.RootChunk is animAnimSet animSet)
                    {
                        // Extract animation names from each animation entry
                        foreach (var animHandle in animSet.Animations)
                        {
                            if (animHandle.GetValue() is animAnimSetEntry animEntry)
                            {
                                if (animEntry.Animation.GetValue() is animAnimation animation && !string.IsNullOrEmpty(animation.Name))
                                {
                                    animationNames.Add(animation.Name!);
                                }
                            }
                        }
                        
                        _logger?.Info($"Loaded {animationNames.Count} animations from anims file: {animsPath}");
                        _logger?.Info($"Animation names: [{string.Join(", ", animationNames)}]");
                        _logger?.Info($"Animation type: {animationType}");
                    }
                    else
                    {
                        _logger?.Warning($"Could not load anims file or invalid format: {animsPath}");
                        return;
                    }
                }
                catch (Exception resourceEx)
                {
                    _logger?.Error($"Failed to load anims resource '{animsPath}': {resourceEx.Message}");
                    return;
                }

                // Create animation set reference and names collection based on type
                switch (animationType.ToLower())
                {
                    case "cinematic":
                        var cinematicAnimSet = new scnCinematicAnimSetSRRef
                        {
                            AsyncAnimSet = new CResourceAsyncReference<animAnimSet>((ResourcePath)animsPath),
                            Priority = 128, // Default from constructor
                            IsOverride = false
                        };

                        var cinematicAnimNames = new scnAnimSetAnimNames
                        {
                            AnimationNames = new CArray<CName>(animationNames.Select(name => (CName)name).ToList())
                        };

                        _sceneData.ResouresReferences.CinematicAnimSets.Add(cinematicAnimSet);
                        _sceneData.ResouresReferences.CinematicAnimNames.Add(cinematicAnimNames);
                        break;

                    case "gameplay":
                        var gameplayAnimSet = new scnGameplayAnimSetSRRef
                        {
                            AsyncAnimSet = new CResourceAsyncReference<animAnimSet>((ResourcePath)animsPath)
                        };

                        var gameplayAnimNames = new scnAnimSetAnimNames
                        {
                            AnimationNames = new CArray<CName>(animationNames.Select(name => (CName)name).ToList())
                        };

                        _sceneData.ResouresReferences.GameplayAnimSets.Add(gameplayAnimSet);
                        _sceneData.ResouresReferences.GameplayAnimNames.Add(gameplayAnimNames);
                        break;


                    default:
                        _logger?.Warning($"Unknown animation type: {animationType}. Defaulting to Cinematic.");
                        // Create cinematic animation as fallback
                        var fallbackCinematicAnimSet = new scnCinematicAnimSetSRRef
                        {
                            AsyncAnimSet = new CResourceAsyncReference<animAnimSet>((ResourcePath)animsPath),
                            Priority = 128,
                            IsOverride = false
                        };

                        var fallbackCinematicAnimNames = new scnAnimSetAnimNames
                        {
                            AnimationNames = new CArray<CName>(animationNames.Select(name => (CName)name).ToList())
                        };

                        _sceneData.ResouresReferences.CinematicAnimSets.Add(fallbackCinematicAnimSet);
                        _sceneData.ResouresReferences.CinematicAnimNames.Add(fallbackCinematicAnimNames);
                        break;
                }

                // Mark document as dirty
                Parent?.SetIsDirty(true);

                // Force recalculation of the root chunk properties
                var rootChunk = RDTViewModel.GetRootChunk();
                if (rootChunk != null)
                {
                    rootChunk.RecalculateProperties();
                }

                // Refresh the current tab content
                if (SelectedTab != null)
                {
                    UpdateTabContent(SelectedTab);
                }

                // Auto-expand to show the newly created animation entries
                switch (animationType.ToLower())
                {
                    case "cinematic":
                        ExpandToNewEntry("resouresReferences", "cinematicAnimNames", 0);
                        break;
                    case "gameplay":
                        ExpandToNewEntry("resouresReferences", "gameplayAnimNames", 0);
                        break;
                }

                _logger?.Info($"Created new {animationType.ToLower()} animation: path='{animsPath}', animCount={animationNames.Count}");
            }
            catch (Exception ex)
            {
                _logger?.Error($"Failed to create new animation: {ex.Message}");
            }
        }

        /// <summary>
        /// Auto-expand tree view to show a newly created entry
        /// </summary>
        /// <param name="parentPath">Parent path like "screenplayStore", "actors", or "props"</param>
        /// <param name="childPath">Child collection like "lines" or "options", or empty for direct arrays</param>
        /// <param name="itemId">The itemId of the newly created entry</param>
        private void ExpandToNewEntry(string parentPath, string childPath, uint itemId)
        {
            try
            {
                var rootChunk = RDTViewModel.GetRootChunk();
                if (rootChunk == null) return;

                // Find the parent collection in the root chunk's properties
                var parentCollection = rootChunk.Properties
                    .FirstOrDefault(p => p.Name.Equals(parentPath, StringComparison.OrdinalIgnoreCase));
                
                if (parentCollection != null)
                {
                    // Expand the parent collection
                    parentCollection.IsExpanded = true;

                    // If there's a child path (like screenplayStore -> lines/options)
                    if (!string.IsNullOrEmpty(childPath))
                    {
                        // Find the child collection
                        var childCollection = parentCollection.Properties
                            .FirstOrDefault(p => p.Name.Equals(childPath, StringComparison.OrdinalIgnoreCase));
                        
                        if (childCollection != null)
                        {
                            // Expand the child collection (lines/options array)
                            childCollection.IsExpanded = true;

                            // Expand the last item (newly created entry)
                            if (childCollection.Properties.Count > 0)
                            {
                                var lastEntry = childCollection.Properties.Last();
                                lastEntry.IsExpanded = true;
                            }
                        }
                    }
                    else
                    {
                        // Direct collection like actors or props - expand the last entry
                        if (parentCollection.Properties.Count > 0)
                        {
                            var lastEntry = parentCollection.Properties.Last();
                            lastEntry.IsExpanded = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger?.Info($"Note: Could not auto-expand new entry - {ex.Message}");
            }
        }

        // Override Unload to ensure disposal when tab is closed
        public override void Unload()
        {
            Dispose();
            base.Unload();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~SceneGraphViewModel()
        {
            Dispose(false);
        }
    }
} 
