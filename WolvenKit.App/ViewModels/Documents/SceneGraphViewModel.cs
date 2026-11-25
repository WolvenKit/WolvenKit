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
using WolvenKit.App.Interaction.Options;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common.Services;

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

        public readonly RedTypeTemplateService RedTypeTemplateService =
            Locator.Current.GetService<RedTypeTemplateService>() ?? throw new ArgumentNullException(nameof(RedTypeTemplateService));
        private readonly scnSceneResource _sceneData;
        private readonly GraphDocumentSearchState _searchState = new();

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

        /// <summary>
        /// Named in its own right so the Import Dialogue button says what it is bound to, though it
        /// is on the same tab as the two above and so adds nothing to <see cref="IsButtonBarVisible"/>.
        /// </summary>
        public bool IsDialogueImportVisible => SelectedTab?.Header == "Dialogue";

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

        public void OnDocumentSearchChanged(string searchBoxText)
        {
            var match = GraphDocumentSearchHelper.ApplySceneSearch(MainGraph, searchBoxText, _searchState);

            if (match is not null)
            {
                SelectedTab = Tabs.FirstOrDefault(tab => tab.Header == "Node Properties");
            }
        }

        public void OnCurrentSearchResultRequested()
        {
            var match = _searchState.CurrentMatch;
            if (match is null)
            {
                return;
            }

            SelectedTab = Tabs.FirstOrDefault(tab => tab.Header == "Node Properties");
            GraphDocumentSearchHelper.SelectGraphNode(match.Value.Node);
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
            OnPropertyChanged(nameof(IsDialogueImportVisible));
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
                var defaultName = $"new_actor_{_sceneData.Actors.Count + 1}";
                var dialogResult = Interactions.AskForSceneInput(
                    new SceneInputDialogOptions("Add New Actor", "Actor Name:", defaultName));
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

                // Use the built-in AddActor method which handles initialization and performer symbol creation
                _sceneData.AddActor(newActor);

                foreach (var node in MainGraph.Nodes.OfType<IRefreshableDetails>())
                {
                    node.RefreshDetails();
                }

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
                ExpandToNewEntry("actors", "");

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
                var defaultName = $"new_prop_{_sceneData.Props.Count + 1}";
                var dialogResult =
                    Interactions.AskForSceneInput(
                        new SceneInputDialogOptions("Add New Prop", "Prop Name:", defaultName));
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
                ExpandToNewEntry("props", "");

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
                var dialogResult = Interactions.AskForSceneInput(
                    new SceneInputDialogOptions(
                        "Add New Dialogue Line",
                        "LocString ID:",
                        "",
                        showSecondary: true,
                        "Embedded Text:",
                        "Create embedded text? (Optional)"
                ));

                if (dialogResult.primaryInput == null)
                {
                    return;
                }

                var locStringId = dialogResult.primaryInput;
                var createEmbedText = dialogResult.enableSecondary;
                var embeddedText = dialogResult.secondaryInput;

                var itemId = SceneEditingHelper.GetNextDialogLineItemId(_sceneData.ScreenplayStore.Lines);

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
                        Signature = new scnlocSignature { Val = 3 }, // gender mask: 1 = male, 2 = female, 3 = both
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
                ExpandToNewEntry("screenplayStore", "lines");

                // Update total dialogues count in the UI
                OnPropertyChanged(nameof(TotalDialogues));

                _logger?.Info(
                    $"Created new dialogue line with itemId: {itemId}, locStringId: {locStringIdValue}" +
                    (
                        createEmbedText ? $", embedded text: '{embeddedText}'" : ""));
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
                var dialogResult = Interactions.AskForSceneInput(new SceneInputDialogOptions(
                    "Add New Choice Option",
                    "LocString ID:",
                    "",
                    showSecondary: true,
                    "Embedded Text:",
                    "Create embedded text? (Optional)"
                ));

                if (dialogResult.primaryInput == null)
                {
                    return;
                }

                var locStringId = dialogResult.primaryInput;
                var createEmbedText = dialogResult.enableSecondary;
                var embeddedText = dialogResult.secondaryInput;

                var itemId = SceneEditingHelper.GetNextChoiceOptionItemId(_sceneData.ScreenplayStore.Options);

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
                        Signature = new scnlocSignature { Val = 3 }, // gender mask: 1 = male, 2 = female, 3 = both
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
                ExpandToNewEntry("screenplayStore", "options");

                // Update total dialogues count in the UI
                OnPropertyChanged(nameof(TotalDialogues));

                _logger?.Info(
                    $"Created new choice option with itemId: {itemId}, locStringId: {locStringIdValue}" +
                    (
                        createEmbedText ? $", embedded text: '{embeddedText}'" : ""));
            }
            catch (Exception ex)
            {
                _logger?.Error($"Failed to create new choice option: {ex.Message}");
            }
        }

        /// <summary>
        /// Takes a dialogue export written by another tool - the Dialogue Browser CET mod writes
        /// one from its conversation panel - and adds its lines to the screenplay store, with
        /// their embedded text and lipsync animations. Where the user asks for it, the same lines
        /// are also laid out as a section node in the graph.
        /// </summary>
        [RelayCommand]
        private void ImportDialogue()
        {
            try
            {
                var screenplayStore = _sceneData.ScreenplayStore;
                if (screenplayStore == null)
                {
                    _logger?.Warning("Dialogue import: this scene has no screenplay store.");
                    return;
                }

                var screenplayLines = screenplayStore.Lines;
                var screenplayOptions = screenplayStore.Options;

                var existingLineLocStrings = GetLocStringIds(screenplayLines.Select(line => line.LocstringId));
                var existingOptionLocStrings = GetLocStringIds(screenplayOptions.Select(option => option.LocstringId));

                var dialog = Interactions.ShowDialogueImport(new DialogueImportDialogOptions(
                    FileName,
                    screenplayLines,
                    screenplayOptions,
                    GetSceneActorOptions()));

                // Cancelled.
                if (dialog == null)
                {
                    return;
                }

                var importedLines = dialog.GetLinesToImport();
                if (importedLines.Count == 0)
                {
                    return;
                }

                var createEmbeddedText = dialog.CreateEmbeddedText;
                var random = new Random();

                // Item ids run in steps of 256, as the game's own scenes do, and both halves of the
                // screenplay store number themselves independently.
                var nextLineItemId = SceneEditingHelper.GetNextDialogLineItemId(screenplayLines);
                var nextOptionItemId = SceneEditingHelper.GetNextChoiceOptionItemId(screenplayOptions);

                // The locstrings the scene already carries embedded text for, read once rather than
                // per line: an import of any size against a scene of any size would otherwise walk
                // the whole locStore for every line it takes. Grows as text is embedded below.
                var describedLocStrings = GetLocStringIds(_sceneData.LocStore?.VdEntries?.Select(entry => entry.LocstringId));

                var addedLines = 0;
                var addedOptions = 0;
                var addedTexts = 0;
                var addedActors = 0;
                var reusedLines = 0;
                var repairedLines = 0;
                var skipped = 0;

                // The lines as a section plays them, gathered as they are dealt with so each is
                // paired with the item id it actually plays. Empty when no section was asked for.
                var sectionLines = new List<SectionDialogueLine>();

                foreach (var selection in importedLines)
                {
                    var line = selection.Line;

                    // Already in the scene, taken so a section can play the entry that is there.
                    // Nothing is written for it - not the entry, and not its embedded text, which is
                    // not this import's to change. An entry with no item id gets one, since an event
                    // needs a target.
                    if (selection.ExistingLine is { } existingLine)
                    {
                        if (!SceneEditingHelper.HasAssignedItemId(existingLine.ItemId))
                        {
                            existingLine.ItemId = new scnscreenplayItemId { Id = nextLineItemId };
                            nextLineItemId += SceneEditingHelper.ScreenplayItemIdStep;
                            repairedLines++;
                        }

                        if (dialog.CreateSectionNode)
                        {
                            sectionLines.Add(selection.ToSectionLine(existingLine.ItemId));
                        }

                        reusedLines++;
                        continue;
                    }

                    // Checked again rather than trusted from the dialog, whose list was built when
                    // it opened: one locstring must never get two screenplay entries.
                    var known = line.IsChoiceOption ? existingOptionLocStrings : existingLineLocStrings;

                    if (!known.Add(line.LocStringId))
                    {
                        skipped++;
                        continue;
                    }

                    if (line.IsChoiceOption)
                    {
                        screenplayOptions.Add(new scnscreenplayChoiceOption
                        {
                            ItemId = new scnscreenplayItemId { Id = nextOptionItemId },
                            LocstringId = new scnlocLocstringId { Ruid = line.LocStringId },
                            Usage = new scnscreenplayOptionUsage { PlayerGenderMask = new scnGenderMask { Mask = 3 } }
                        });

                        nextOptionItemId += SceneEditingHelper.ScreenplayItemIdStep;
                        addedOptions++;
                    }
                    else
                    {
                        var dialogueLine = new scnscreenplayDialogLine
                        {
                            ItemId = new scnscreenplayItemId { Id = nextLineItemId },
                            LocstringId = new scnlocLocstringId { Ruid = line.LocStringId },
                            Usage = new scnscreenplayLineUsage { PlayerGenderMask = new scnGenderMask { Mask = 3 } }
                        };

                        // Who says the line and who it is said to, as the dialog left them: matched
                        // against the scene's cast by name, then whatever the user picked instead.
                        // A line they left unassigned keeps the default, which is the same "no
                        // actor" a line added by hand starts out with.
                        if (selection.Speaker is { } speaker)
                        {
                            dialogueLine.Speaker = speaker;
                            addedActors++;
                        }

                        if (selection.Addressee is { } addressee)
                        {
                            dialogueLine.Addressee = addressee;
                            addedActors++;
                        }

                        // The index knows a female animation for nearly every line and a male one
                        // for only a few, so an empty name is left as the default rather than
                        // written as one.
                        if (!string.IsNullOrEmpty(line.FemaleLipsyncAnim))
                        {
                            dialogueLine.FemaleLipsyncAnimationName = line.FemaleLipsyncAnim;
                        }

                        if (!string.IsNullOrEmpty(line.MaleLipsyncAnim))
                        {
                            dialogueLine.MaleLipsyncAnimationName = line.MaleLipsyncAnim;
                        }

                        screenplayLines.Add(dialogueLine);

                        if (dialog.CreateSectionNode)
                        {
                            sectionLines.Add(selection.ToSectionLine(dialogueLine.ItemId));
                        }

                        nextLineItemId += SceneEditingHelper.ScreenplayItemIdStep;
                        addedLines++;
                    }

                    if (createEmbeddedText && AddEmbeddedText(line.LocStringId, line.EmbeddedText, random, describedLocStrings))
                    {
                        addedTexts++;
                    }
                }

                // Nothing written, nothing repaired and nothing to lay out: the import had no
                // effect at all.
                if (addedLines == 0 && addedOptions == 0 && repairedLines == 0 && sectionLines.Count == 0)
                {
                    _logger?.Warning("Dialogue import: every line was already in the scene.");
                    return;
                }

                // Mark document as dirty
                Parent?.SetIsDirty(true);

                // Force recalculation of the root chunk properties to pick up the imported lines
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

                // Auto-expand to show what came in - both halves, where a payload held both. A run
                // that only reused what was there reveals neither.
                if (addedLines > 0)
                {
                    ExpandToNewEntry("screenplayStore", "lines");
                }

                if (addedOptions > 0)
                {
                    ExpandToNewEntry("screenplayStore", "options");
                }

                // Update dialogue and choice counts in the UI
                OnPropertyChanged(nameof(TotalDialogues));
                OnPropertyChanged(nameof(TotalChoices));

                var section = CreateSectionForImport(dialog, sectionLines);

                // A run that wrote nothing to the store should not lead with "Imported 0 dialogue
                // line(s)".
                var wroteToStore = addedLines > 0 || addedOptions > 0;

                _logger?.Success(
                    (wroteToStore
                        ? $"Imported {addedLines} dialogue line(s)" +
                          (addedOptions > 0 ? $", {addedOptions} choice option(s)" : "") +
                          (createEmbeddedText ? $", {addedTexts} with embedded text" : "") +
                          (addedActors > 0 ? $", and {addedActors} speaker/addressee assignment(s)" : "") +
                          (reusedLines > 0 ? $".\n Reused {reusedLines} line(s)" : "")
                        : $"Reused {reusedLines} line(s), no new lines added") +
                    (repairedLines > 0
                        ? $".\n Gave an item id to {repairedLines} existing screenplay entr" +
                          (repairedLines == 1 ? "y" : "ies")
                        : "") +
                    (section is not null
                        ? $".\n Section node created, running {section.DurationMs}ms" +
                          $" over {section.ActorCount} actor(s)"
                        : "") +
                    (skipped > 0 ? $".\n Skipped {skipped} already in the scene" : ""));
            }
            catch (Exception ex)
            {
                _logger?.Error($"Failed to import dialogue: {ex.Message}");
            }
        }

        /// <summary>
        /// Lays an import out as a section node in the graph, where the user asked for one.
        /// </summary>
        /// <param name="dialog">
        /// Dialog state used to name the section node.
        /// </param>
        /// <param name="lines">
        /// The lines, each already carrying the item id it plays. Empty for an import of nothing but
        /// choice options, since an option is picked rather than played.
        /// </param>
        /// <returns>What was built, or null where nothing was.</returns>
        private BuiltDialogueSection? CreateSectionForImport(
            DialogueImportDialogViewModel dialog,
            List<SectionDialogueLine> lines)
        {
            if (!dialog.CreateSectionNode)
            {
                return null;
            }

            if (lines.Count == 0)
            {
                _logger?.Warning(
                    "Dialogue import: nothing to lay out as a section - a choice option is picked, not played.");
                return null;
            }

            try
            {
                var section = SceneSectionBuilder.Build(lines);

                MainGraph.AddSceneNode(
                    section.Node,
                    MainGraph.GetFreeCanvasPoint(),
                    SceneSectionBuilder.SanitizeNotablePointName(dialog.ConversationName));

                OnPropertyChanged(nameof(TotalNodes));

                if (section.EstimatedDurationCount > 0)
                {
                    _logger?.Info(
                        $"Dialogue import: the export gave no length for {section.EstimatedDurationCount} " +
                        "line(s), so the section estimated them from their text. Check them on the timeline.");
                }

                // An export with no start times loses the original conversation's pacing, which is
                // worth saying before the user wonders where it went.
                if (section.PlacedByExportCount < lines.Count)
                {
                    _logger?.Info(
                        $"Dialogue import: the export placed {section.PlacedByExportCount} of {lines.Count} " +
                        "line(s) on its own timeline; the rest were laid end to end. A newer Dialogue " +
                        "Browser exports the conversation's own timings.");
                }

                return section;
            }
            catch (Exception ex)
            {
                // The lines are in the store either way; only the section is lost.
                _logger?.Error($"Imported the lines, but could not lay them out as a section: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// The scene's cast, as the import dialog offers it: what speaker and addressee names are
        /// matched against, and what the user picks from. Player actors are listed too, flagged as
        /// such, because the first of them is what an export's "V" always means.
        /// </summary>
        private List<SceneActorOption> GetSceneActorOptions()
        {
            var actors = new List<SceneActorOption>();

            foreach (var actor in _sceneData.Actors)
            {
                if (actor.ActorId is null)
                {
                    continue;
                }

                string actorName = actor.ActorName;
                actors.Add(new SceneActorOption((uint)actor.ActorId.Id, actorName));
            }

            foreach (var playerActor in _sceneData.PlayerActors)
            {
                if (playerActor.ActorId is null)
                {
                    continue;
                }

                string playerName = playerActor.PlayerName;
                actors.Add(new SceneActorOption((uint)playerActor.ActorId.Id, playerName, isPlayer: true));
            }

            return actors;
        }

        /// <summary>
        /// Locstring ids of a screenplay collection, as something an import can be checked against.
        /// </summary>
        private static HashSet<CRUID> GetLocStringIds(IEnumerable<scnlocLocstringId?>? locStringIds) =>
            locStringIds?
                .Where(locStringId => locStringId != null)
                .Select(locStringId => locStringId!.Ruid)
                .ToHashSet() ?? [];

        /// <summary>
        /// Embeds a line's text into the scene's locStore, as a payload entry plus the descriptor
        /// that points a locstring at it.
        /// </summary>
        /// <param name="locStringId">Locstring id to describe.</param>
        /// <param name="text">Text to embed.</param>
        /// <param name="random">Random source for variant ids.</param>
        /// <param name="describedLocStrings">
        /// The locstrings the locStore already describes, which this adds to. Handed in rather than
        /// read from the store so that importing n lines does not walk it n times.
        /// </param>
        /// <returns>False when there was nothing to embed, or the locStore already describes this locstring.</returns>
        private bool AddEmbeddedText(
            CRUID locStringId, string text, Random random, HashSet<CRUID> describedLocStrings)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            // A locstring the scene already carries text for keeps the text it has: two descriptors
            // for one locstring and locale is what the game reads as a broken locStore.
            if (!describedLocStrings.Add(locStringId))
            {
                return false;
            }

            var variantCruid = (CRUID)random.NextCRUID();

            // Create VpEntry (payload entry) with the embedded text
            _sceneData.LocStore.VpEntries.Add(new scnlocLocStoreEmbeddedVariantPayloadEntry
            {
                Content = text,
                VariantId = new scnlocVariantId { Ruid = variantCruid }
            });

            // Create VdEntry (descriptor entry) linking locStringId to the payload with en_us locale
            _sceneData.LocStore.VdEntries.Add(new scnlocLocStoreEmbeddedVariantDescriptorEntry
            {
                LocstringId = new scnlocLocstringId { Ruid = locStringId },
                VariantId = new scnlocVariantId { Ruid = variantCruid },
                VpeIndex = (uint)(_sceneData.LocStore.VpEntries.Count - 1),
                Signature = new scnlocSignature { Val = 3 }, // gender mask: 1 = male, 2 = female, 3 = both
                LocaleId = Enums.scnlocLocaleId.en_us
            });

            return true;
        }

        [RelayCommand]
        private void CreateNewWorkspot()
        {
            try
            {
                // Show scene input dialog for workspot file path
                var dialogResult = Interactions.AskForSceneInput(new SceneInputDialogOptions(
                    "Add New Workspot",
                    "Workspot File Path (.workspot):"
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

                // Generate new dataId
                var random = new Random();
                var maxDataId = (uint)0;

                if (_sceneData.Workspots.Count > 0)
                {
                    var existingDataIds = _sceneData.Workspots
                        .Where(w => w.GetValue() is scnWorkspotData)
                        .Select(w => w.GetValue() as scnWorkspotData)
                        .Where(data => data != null)
                        .Select(data => data!.DataId.Id);

                    if (existingDataIds.Any())
                    {
                        maxDataId = existingDataIds.Max();
                    }
                }

                uint dataId;
                if (maxDataId == 0)
                {
                    dataId = (uint)(100_000_000 + random.Next(0, 10_000_000));
                }
                else
                {
                    var increment = random.Next(1_000, 10_000_000);
                    var newDataId = (ulong)maxDataId + (ulong)increment;

                    dataId = newDataId > uint.MaxValue
                        ? (uint)random.Next(100_000_000, int.MaxValue)
                        : (uint)newDataId;
                }

                // Ensure uniqueness
                while (_sceneData.Workspots.Any(w => w.GetValue() is scnWorkspotData data && data.DataId.Id == dataId))
                {
                    dataId += (uint)random.Next(1_000, 100_000);
                }

                // Create workspot definition with external resource reference
                var workspotData = new scnWorkspotData_ExternalWorkspotResource
                {
                    DataId = new scnSceneWorkspotDataId { Id = dataId },
                    WorkspotResource = new CResourceReference<workWorkspotResource>(workspotPath)
                };

                // Add to workspots collection in sorted order (by dataId)
                var insertIndex = 0;
                for (int i = 0; i < _sceneData.Workspots.Count; i++)
                {
                    if (_sceneData.Workspots[i].GetValue() is scnWorkspotData existingData &&
                        existingData.DataId.Id > dataId)
                    {
                        insertIndex = i;
                        break;
                    }
                    insertIndex = i + 1;
                }
                _sceneData.Workspots.Insert(insertIndex, workspotData);

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
                        Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F }
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
                ExpandToNewEntry("workspotInstances", "");

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
                var dialogResult = Interactions.AskForSceneInput(new SceneInputDialogOptions(
                    "Add New Effect",
                    "Effect File Path (.effect):"
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

                // Generate unique effect instance ID (starting from 0)
                var instanceId = (uint)0;
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
                ExpandToNewEntry("effectInstances", "");

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
                var dialogResult = Interactions.AskForSceneInput(new SceneInputDialogOptions(
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
                        ExpandToNewEntry("resouresReferences", "cinematicAnimNames");
                        break;
                    case "gameplay":
                        ExpandToNewEntry("resouresReferences", "gameplayAnimNames");
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
        private void ExpandToNewEntry(string parentPath, string childPath)
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

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                MainGraph.Dispose();
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
