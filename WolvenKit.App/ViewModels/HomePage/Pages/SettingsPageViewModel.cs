using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Syncfusion.Windows.Controls.Layout;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Controls;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.RED3.CR2W.Types;

namespace WolvenKit.ViewModels.HomePage.Pages
{
    public class SettingsPageViewModel : ReactiveObject
    {
        private readonly ISettingsManager _settingsManager;

        //ItemCollection subProperties;
        private List<SfAccordionItem> originalAccordionItems;

        public SettingsPageViewModel(
            ISettingsManager settingsManager,
            ILoggerService loggerService
        )
        {
            _settingsManager = settingsManager;
            originalAccordionItems = new List<SfAccordionItem>();
        }

        #region properties

        public ItemCollection AccordionItems { get; set; }

        public string SearchText { get; set; }

        public GeneralSettingsPGModel generalSettingsPGModel
        {
            get => new GeneralSettingsPGModel(_settingsManager);
            set { }
        }

        public CP77SettingsPGModel cp77SettingsPGModel
        {
            get => new CP77SettingsPGModel(_settingsManager);
            set { }
        }

        //public TW3SettingsPGModel tw3SettingsPGModel
        //{
        //    get { return new TW3SettingsPGModel(_settingsManager); }
        //    set { }
        //}

        //public ToolSettingsPGModel ToolSettingsPGModel
        //{
        //    get { return new ToolSettingsPGModel(_settingsManager); }
        //    set { }
        //}

        //public EditorSettingsPGModel EditorSettingsPGModel
        //{
        //    get { return new EditorSettingsPGModel(_settingsManager); }
        //    set { }
        //}

        #endregion properties

        #region commands

        public ICommand SearchStartedCommand { get; set; }

        #endregion commands

        #region methods

        private bool CanSearchStartedCommand(object arg) => true;

        //private void ExecuteSearchStartedCommand(object arg)
        //{
        //    if (arg is FunctionEventArgs<string> e)
        //    {
        //        var query = e.Info;
        //        //bool subItemContains = false;

        //        if (!string.IsNullOrWhiteSpace(query))
        //        {
        //            if (AccordionItems.Count == 0)
        //            {
        //                AccordionItems.Filter = null;
        //            }
        //            else
        //            {
        //                // filters the itemcollection, if an item's header doesn't match with the query, it gets filtered out.

        //                AccordionItems.Filter = item =>
        //                {
        //                    //SfAccordionItem accordionItem = item as SfAccordionItem;
        //                    if (item == null)
        //                        return false;

        //                    return (item as SfAccordionItem).Header.ToString().ToLower().Contains(query.ToLower());

        //                    //subProperties = GetPropertyViews(accordionItem);

        //                    //// filters the subCategories aswell based on the Category string.
        //                    //subProperties.Filter = subItem =>
        //                    //{
        //                    //    PropertyCategoryViewItemCollection viewItemCollection = subItem as PropertyCategoryViewItemCollection;
        //                    //    subItemContains = viewItemCollection.Category.ToLower().Contains(query.ToLower());
        //                    //    return subItemContains;
        //                    //};

        //                    //// If theres still an element in the collection after the filter,
        //                    //// then we still allow the current accordionItem to be shown.
        //                    //if (subProperties.Count > 0)
        //                    //    return true;

        //                    //return headerContains;
        //                };
        //            }
        //        }   // reseting filter.
        //        else // if the search bar gets emptied out, then all items should be seen again by removing the filter.
        //        {
        //            AccordionItems.Filter = null;
        //        }
        //    }
        //}

        // Starting from the AccordionItem, this method recurseviley goes down the visual tree
        // until it finds the element with the PropertyView type.
        private ItemCollection GetPropertyViews(DependencyObject currentElement)
        {
            int childCount = VisualTreeHelper.GetChildrenCount(currentElement);
            ItemCollection foundCollection = null;

            for (int i = 0; i < childCount; i++)
            {
                var child = VisualTreeHelper.GetChild(currentElement, i);
                PropertyView childType = child as PropertyView;
                if (childType == null)
                {
                    foundCollection = GetPropertyViews(child);
                    if (foundCollection != null)
                        break;
                }
                else
                {
                    foundCollection = (child as PropertyView).Items;
                    break;
                }
            }

            return foundCollection;
        }

        #endregion methods
    }

    #region PropertyGridModels

    [Editor(nameof(CP77ExecutablePath), typeof(SingleFilePathEditor))]
    [Editor(nameof(MaterialRepositoryPath), typeof(SingleFolderPathEditor))]
    public class CP77SettingsPGModel : ReactiveObject
    {
        /// <summary>
        /// Gets or sets the SettingsManager.
        /// </summary>
        private ISettingsManager _settingsManager { get; set; }

        public CP77SettingsPGModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;

            _settingsManager.WhenAnyValue(x => x.CP77ExecutablePath).Subscribe(value =>
            {
                if (CP77ExecutablePath != value)
                {
                    CP77ExecutablePath = value;
                }
            });
            _settingsManager.WhenAnyValue(x => x.MaterialRepositoryPath).Subscribe(value =>
            {
                if (MaterialRepositoryPath != value)
                {
                    MaterialRepositoryPath = value;
                }
            });

            this.WhenAnyValue(x => x.CP77ExecutablePath).Subscribe(value =>
            {
                if (CP77ExecutablePath != value)
                {
                    _settingsManager.CP77ExecutablePath = value;
                    _settingsManager.Save();
                }
            });
            this.WhenAnyValue(x => x.MaterialRepositoryPath).Subscribe(value =>
            {
                if (CP77ExecutablePath != value)
                {
                    _settingsManager.MaterialRepositoryPath = value;
                    _settingsManager.Save();
                }
            });


        }


        [Category("General")]
        [Display(Name = "Game executable path (.exe)")]
        [Reactive]
        public string CP77ExecutablePath { get; set; }

        [Category("General")]
        [Display(Name = "Materialrepository path")]
        [Reactive]
        public string MaterialRepositoryPath { get; set; }


    }

    //public class TW3SettingsPGModel
    //{
    //    private ISettingsManager _settingsManager;

    //    public TW3SettingsPGModel(ISettingsManager settingsManager)
    //    {
    //        _settingsManager = settingsManager;
    //    }

    //    [Category("General")]
    //    [Display(Name = "Game executable path (.exe)")]
    //    public string Game_Executable_Path
    //    {
    //        get => _settingsManager.W3ExecutablePath;
    //        set
    //        {
    //            _settingsManager.W3ExecutablePath = value;
    //            _settingsManager.Save();
    //        }
    //    }

    //    [Display(Name = "Modkit Path")]
    //    public string Modkit_Path { get; set; }

    //    [Display(Name = "Uncooked Depot Path")]
    //    public string Uncooked_Depot_Path { get; set; }
    //}

    public class GeneralSettingsPGModel : ReactiveObject
    {
        private ISettingsManager _settingsManager;

        public GeneralSettingsPGModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;

            _settingsManager.WhenAnyValue(x => x.UpdateChannel).Subscribe(value =>
            {
                if (UpdateChannel != value)
                {
                    UpdateChannel = value;
                }
            });
            _settingsManager.WhenAnyValue(x => x.CatFactAnimal).Subscribe(value =>
            {
                if (CatFactAnimal != value)
                {
                    CatFactAnimal = value;
                }
            });
            _settingsManager.WhenAnyValue(x => x.ThemeAccentString).Subscribe(value =>
            {
                var brush = new SolidColorBrush(_settingsManager.GetThemeAccent());
                if (BrushProperty != brush)
                {
                    BrushProperty = brush;
                }
            });

            this.WhenAnyValue(x => x.UpdateChannel).Subscribe(value =>
                {
                    if (UpdateChannel != value)
                    {
                        _settingsManager.UpdateChannel = value;
                        _settingsManager.Save();
                    }
                });
            this.WhenAnyValue(x => x.CatFactAnimal).Subscribe(value =>
            {
                if (CatFactAnimal != value)
                {
                    _settingsManager.CatFactAnimal = value;
                    _settingsManager.Save();
                }
            });
            this.WhenAnyValue(x => x.BrushProperty).Subscribe(value =>
            {
                var color = ((SolidColorBrush)value).Color;
                if (_settingsManager.GetThemeAccent() != color)
                {
                    _settingsManager.SetThemeAccent(color);
                    _settingsManager.Save();
                }
            });
        }

        //[Category("General")]
        //public ApplicationLanguage Language { get; set; }

        //public bool Desktop_Notifications { get; set; }

        //[Category("Mods")]
        //[Display(Name = "Automatically install mods.")]
        //public bool AutoInstallMods { get; set; }

        //[Category("Mods")]
        //[Display(Name = "Material depot path.")]
        //public string MaterialDepotPath { get; set; }

        [Category("General")]
        [Display(Name = "Update channel")]
        [Reactive]
        public EUpdateChannel UpdateChannel { get; set; }

        [Category("Theme")]
        [Display(Name = "Application theme accent.")]
        [Reactive]
        public Brush BrushProperty { get; set; }

        [Category("Xtras")]
        [Display(Name = "Fact Animal of Choice")]
        [Reactive]
        public EAnimals CatFactAnimal { get; set; }


    }

    //public class ToolSettingsPGModel
    //{
    //    private ISettingsManager _settingsManager;

    //    public ToolSettingsPGModel(ISettingsManager settingsManager)
    //    {
    //        _settingsManager = settingsManager;
    //    }

    //    [Category("Asset Browser")]
    //    [Display(Name = "Choose Asset Browser type.")]
    //    public AssetBrowserType BrowserType { get; set; }

    //    [Category("Code Editor")]
    //    [Display(Name = "Choose Code Editor type.")]
    //    public CodeEditorType CodeEditorType { get; set; }

    //    [Category("Plugin Manager")]
    //    [Display(Name = "Choose Plugin manager type.")]
    //    public PluginManagerType PluginManagerType { get; set; }

    //    [Category("Visual Editor")]
    //    [Display(Name = "Choose Visual editor type.")]
    //    public VisualEditorType VisualEditorType { get; set; }
    //}

    //public class EditorSettingsPGModel
    //{
    //    private ISettingsManager _settingsManager;

    //    public EditorSettingsPGModel(ISettingsManager settingsManager)
    //    {
    //        _settingsManager = settingsManager;
    //    }

    //    [Display(Name = "Auto-install mods upon creation")]
    //    public AutoInstallMods AutoInstallMods { get; set; }

    //    [Display(Name = "Project auto-saving")]
    //    public bool ProjectAutoSaving { get; set; }

    //    public AutoSaveType AutoSaveType { get; set; }

    //    [Display(Name = "Editor path")]
    //    public string EditorPath { get; set; }
    //}

    #endregion PropertyGridModels

    //#region enums

    //public enum ApplicationLanguage
    //{
    //    English,
    //}

    //public enum AssetBrowserType
    //{
    //    None,
    //}

    //public enum CodeEditorType
    //{
    //    None,
    //}

    //public enum PluginManagerType
    //{
    //    None,
    //}

    //public enum VisualEditorType
    //{
    //    None,
    //}

    //public enum AutoInstallMods
    //{
    //    On,
    //    Off,
    //}

    //public enum AutoSaveType
    //{
    //    Interval,
    //}

    //#endregion enums
}
