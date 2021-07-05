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
using Catel.Fody;
using Catel.MVVM;
using Syncfusion.Windows.Controls.Layout;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Controls;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.ViewModels.HomePage.Pages
{
    public class SettingsPageViewModel : ViewModelBase
    {
        private ISettingsManager _settingsManager;
        private ILoggerService _loggerService;

        //ItemCollection subProperties;
        private List<SfAccordionItem> originalAccordionItems;

        public SettingsPageViewModel(
            ISettingsManager settingsManager,
            ILoggerService loggerService
        )
        {
            _settingsManager = settingsManager;
            _loggerService = loggerService;
            //SearchStartedCommand = new DelegateCommand<object>(ExecuteSearchStartedCommand, CanSearchStartedCommand);
            originalAccordionItems = new List<SfAccordionItem>();
        }

        #region properties

        public ItemCollection AccordionItems { get; set; }

        public string SearchText { get; set; }

        public GeneralSettingsPGModel generalSettingsPGModel
        {
            get { return new GeneralSettingsPGModel(_settingsManager); }
            set { }
        }

        public CP77SettingsPGModel cp77SettingsPGModel
        {
            get { return new CP77SettingsPGModel(_settingsManager); }
            set { }
        }

        public TW3SettingsPGModel tw3SettingsPGModel
        {
            get { return new TW3SettingsPGModel(_settingsManager); }
            set { }
        }

        public ToolSettingsPGModel ToolSettingsPGModel
        {
            get { return new ToolSettingsPGModel(_settingsManager); }
            set { }
        }

        public EditorSettingsPGModel EditorSettingsPGModel
        {
            get { return new EditorSettingsPGModel(_settingsManager); }
            set { }
        }

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

    [Editor(nameof(Game_Executable_Path), typeof(SingleFilePathEditor))]
    [Editor(nameof(MaterialRepositoryPath), typeof(SingleFolderPathEditor))]
    public class CP77SettingsPGModel : Catel.Data.ObservableObject
    {
        /// <summary>
        /// Gets or sets the SettingsManager.
        /// </summary>
        private ISettingsManager _settingsManager { get; set; }

        public CP77SettingsPGModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;

            _settingsManager.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(ISettingsManager.CP77ExecutablePath))
                {
                    this.Game_Executable_Path = _settingsManager.CP77ExecutablePath;
                    RaisePropertyChanged(() => Game_Executable_Path);
                }
                if (e.PropertyName == nameof(ISettingsManager.MaterialRepositoryPath))
                {
                    this.MaterialRepositoryPath = _settingsManager.MaterialRepositoryPath;
                    RaisePropertyChanged(() => MaterialRepositoryPath);
                }
                if(e.PropertyName == nameof(ISettingsManager.CatFactAnimal))
                {
                    this.CatFacts_Animal = _settingsManager.CatFactAnimal;
                    RaisePropertyChanged(() => CatFacts_Animal);
                }
                
            };
        }

        [Category("General")]
        [Display(Name = "Game executable path (.exe)")]
        public string Game_Executable_Path
        {
            get => _settingsManager.CP77ExecutablePath;
            set
            {
                if(_settingsManager.CP77ExecutablePath != value)
                {
                    _settingsManager.CP77ExecutablePath = value;
                    _settingsManager.Save();
                    RaisePropertyChanged(() => Game_Executable_Path);
                }
                
            }
        }

        [Category("General")]
        [Display(Name = "Materialrepository path")]
        public string MaterialRepositoryPath
        {
            get => _settingsManager.MaterialRepositoryPath;
            set
            {
                if (_settingsManager.MaterialRepositoryPath != value)
                {
                    _settingsManager.MaterialRepositoryPath = value;
                    _settingsManager.Save();
                    RaisePropertyChanged(() => MaterialRepositoryPath);
                }
            }
        }

        [Category("Xtras")]
        [Display(Name = "Fact Animal of Choice")]
        public EAnimals CatFacts_Animal
        {
            get => _settingsManager.CatFactAnimal;
            set
            {
                if (_settingsManager.CatFactAnimal != value)
                {
                    _settingsManager.CatFactAnimal = value;
                    _settingsManager.Save();
                    RaisePropertyChanged(() => CatFacts_Animal);
                }
            }
        }
    }

    public class TW3SettingsPGModel
    {
        private ISettingsManager _settingsManager;

        public TW3SettingsPGModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;
        }

        [Category("General")]
        [Display(Name = "Game executable path (.exe)")]
        public string Game_Executable_Path
        {
            get => _settingsManager.W3ExecutablePath;
            set
            {
                _settingsManager.W3ExecutablePath = value;
                _settingsManager.Save();
            }
        }

        [Display(Name = "Modkit Path")]
        public string Modkit_Path { get; set; }

        [Display(Name = "Uncooked Depot Path")]
        public string Uncooked_Depot_Path { get; set; }
    }

    public class GeneralSettingsPGModel : Catel.Data.ObservableObject
    {
        private ISettingsManager _settingsManager;

        public GeneralSettingsPGModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;
            _settingsManager.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(ISettingsManager.ThemeAccentString))
                {
                    this.BrushProperty = new SolidColorBrush(_settingsManager.GetThemeAccent());
                    RaisePropertyChanged(() => BrushProperty);
                }
            };
        }

        //[Category("General")]
        //public ApplicationLanguage Language { get; set; }

        //public bool Desktop_Notifications { get; set; }  // Doesn't work yet I think?

        //[Category("Updates")]
        //[Display(Name = "Receive Auto updates?")]
        //public bool ReceiveAutoUpdates { get; set; }

        //[Category("Updates")]
        //[Display(Name = "Set auto update channel.")]
        //public AutoUpdateChannel UpdateChannel { get; set; }

        //[Category("Mods")]
        //[Display(Name = "Automatically install mods.")]
        //public bool AutoInstallMods { get; set; }

        //[Category("Mods")]
        //[Display(Name = "Material depot path.")]
        //public string MaterialDepotPath { get; set; }

        [Category("Theme")]
        [Display(Name = "Application theme accent.")]
        public Brush BrushProperty
        {
            get => new SolidColorBrush(_settingsManager.GetThemeAccent());
            set
            {
                var color = ((SolidColorBrush)value).Color;
                if (_settingsManager.GetThemeAccent() != color)
                {
                    _settingsManager.SetThemeAccent(color);
                    _settingsManager.Save();
                    RaisePropertyChanged(() => BrushProperty);
                }
            }
        }
    }

    public class ToolSettingsPGModel
    {
        private ISettingsManager _settingsManager;

        public ToolSettingsPGModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;
        }

        [Category("Asset Browser")]
        [Display(Name = "Choose Asset Browser type.")]
        public AssetBrowserType BrowserType { get; set; }

        [Category("Code Editor")]
        [Display(Name = "Choose Code Editor type.")]
        public CodeEditorType CodeEditorType { get; set; }

        [Category("Plugin Manager")]
        [Display(Name = "Choose Plugin manager type.")]
        public PluginManagerType PluginManagerType { get; set; }

        [Category("Visual Editor")]
        [Display(Name = "Choose Visual editor type.")]
        public VisualEditorType VisualEditorType { get; set; }
    }

    public class EditorSettingsPGModel
    {
        private ISettingsManager _settingsManager;

        public EditorSettingsPGModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;
        }

        [Display(Name = "Auto-install mods upon creation")]
        public AutoInstallMods AutoInstallMods { get; set; }

        [Display(Name = "Project auto-saving")]
        public bool ProjectAutoSaving { get; set; }

        public AutoSaveType AutoSaveType { get; set; }

        [Display(Name = "Editor path")]
        public string EditorPath { get; set; }
    }

    #endregion PropertyGridModels

    #region enums

    public enum AutoUpdateChannel
    {
        Global,
    }

    public enum ApplicationLanguage
    {
        English,
    }

    public enum AssetBrowserType
    {
        None,
    }

    public enum CodeEditorType
    {
        None,
    }

    public enum PluginManagerType
    {
        None,
    }

    public enum VisualEditorType
    {
        None,
    }

    public enum AutoInstallMods
    {
        On,
        Off,
    }

    public enum AutoSaveType
    {
        Interval,
    }

    #endregion enums
}
