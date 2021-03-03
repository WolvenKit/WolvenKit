using Catel.IoC;
using Catel.MVVM;
using ControlzEx.Theming;
using Orchestra.Services;
using Orchestra.Views;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Orc.Squirrel;
using WolvenKit.ViewModels;
using WolvenKit.MVVM.Views.Components.Wizards;
using WolvenKit.ViewModels.AssetBrowser;
using WolvenKit.ViewModels.AudioTool.Radio;
using WolvenKit.Views.JournalEditor;
using WolvenKit.ViewModels.AudioTool;
using WolvenKit.ViewModels.JournalEditor;
using WolvenKit.ViewModels.Editors.CR2WEditor;
using WolvenKit.Views.CodeEditor;
using WolvenKit.Views.Editors.CR2WEditor;
using WolvenKit.ViewModels.CsvEditor;
using WolvenKit.ViewModels.CR2WToTextTool;
using WolvenKit.ViewModels.AnimationTool;
using WolvenKit.ViewModels.VisualEditor;
using WolvenKit.ViewModels.PluginManager;
using WolvenKit.ViewModels.CodeEditor;
using WolvenKit.Views.BulkEditor;
using WolvenKit.Views.EditorBars;
using WolvenKit.ViewModels.EditorBars;
using WolvenKit.Views.HexEditor;
using WolvenKit.ViewModels.Tools.MenuTool;
using WolvenKit.ViewModels.WccTool;
using WolvenKit.ViewModels.GameDebuggerTool;
using WolvenKit.ViewModels.ImporterTool;
using WolvenKit.ViewModels.HexEditor;
using WolvenKit.ViewModels.RadishTool;
using WolvenKit.Views.Dialogs;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.MVVM.Views.Components.Wizards.WizardPages.FirstSetupWizard;
using WolvenKit.MVVM.Views.Components.Wizards.WizardPages.BugReportWizard;
using WolvenKit.ViewModels.Wizards.WizardPages.BugReportWizard;
using WolvenKit.MVVM.Views.Components.Wizards.WizardPages.FeedbackWizard;
using WolvenKit.ViewModels.Wizards.WizardPages.FeedbackWizard;
using WolvenKit.ViewModels.Wizards.WizardPages.FirstSetupWizard;
using WolvenKit.ViewModels.Wizards.WizardPages.PublishWizard;
using WolvenKit.ViewModels.Wizards.WizardPages.ProjectWizard;
using WolvenKit.MVVM.Views.Components.Wizards.WizardPages.ProjectWizard;
using WolvenKit.MVVM.Views.Components.Wizards.WizardPages.PublishWizard;
using WolvenKit.MVVM.Views.Components.Wizards.WizardPages.UserWizard;
using WolvenKit.ViewModels.Wizards.WizardPages.UserWizard;
using WolvenKit.ViewModels.SettingsPages;
using WolvenKit.ViewModels.SettingsPages.SubPages.Editor;
using WolvenKit.ViewModels.SettingsPages.SubPages.Tool;
using WolvenKit.ViewModels.SettingsPages.SubPages.General;
using WolvenKit.MVVM.Views.Shell.HomePage.Pages.SettingsPages.SubPages.General;
using WolvenKit.MVVM.Views.Shell.HomePage.Pages.SettingsPages.SubPages.Tool;
using WolvenKit.MVVM.Views.Shell.HomePage.Pages.SettingsPages.SubPages.Editor;
using WolvenKit.MVVM.Views.Shell.HomePage.Pages.SettingsPages;
using WolvenKit.MVVM.Views.Shell.HomePage.Pages;
using WolvenKit.ViewModels.HomePage.Pages;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.IntegratedToolsPages.CyberCAT;
using System.Runtime.InteropServices;
using WolvenKit.MVVM.Views.Shell.HomePage;
using WolvenKit.MVVM.Views.Shell.Homepage.Pages.IntegratedToolsPages.CyberCAT;
using WolvenKit.MVVM.Views.Shell.Editor;
using WolvenKit.MVVM.Views.Shell.Backstage;
using WolvenKit.MVVM.Views.Others;
using WolvenKit.MVVM.Views.Components.Tools.AnimationTool;
using WolvenKit.MVVM.Views.Components.Tools.AudioTool;
using WolvenKit.MVVM.Views.Components.Tools.AssetBrowser;
using WolvenKit.MVVM.Views.Components.Tools.AudioTool.Radio;
using WolvenKit.MVVM.Views.Components.Tools.PluginManager;
using WolvenKit.MVVM.Views.Components.Tools.CR2WToTextTool;
using WolvenKit.MVVM.Views.Components.Tools.RadishTool;
using WolvenKit.MVVM.Views.Components.Tools.MenuTool;
using WolvenKit.MVVM.Views.Components.Tools.GameDebuggerTool;
using WolvenKit.MVVM.Views.Components.Tools.WccTool;
using WolvenKit.MVVM.Views.Components.Tools.ImporterTool;
using WolvenKit.MVVM.Views.Components.Editors.VisualEditor;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class InternetHelper
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool IsConnectedToInternet()
        {
            return InternetGetConnectedState(out int Desc, 0);
        }
    }

    public static class AppHelper
    {
       

        public static async Task InitializeMVVM()
        {

            var uri = new Uri("pack://application:,,,/WolvenKit.Resources;component/Resources/Media/Images/git.png");

            await SquirrelHelper.HandleSquirrelAutomaticallyAsync();








            // Register Viewmodels
            var viewModelLocator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels");
            //TODO: rename later to MainViewModel


            // ---- HeadCategory : Extras
            //-- Category : Radio
            viewModelLocator.Register(typeof(RadioPlayerView), typeof(RadioPlayerViewModel));
            // ---- HeadCategory : ProjectView
            viewModelLocator.Register(typeof(MainView), typeof(WorkSpaceViewModel));
            viewModelLocator.Register(typeof(AssetBrowserView), typeof(AssetBrowserViewModel));
            viewModelLocator.Register(typeof(JournalEditorView), typeof(JournalEditorViewModel));
            viewModelLocator.Register(typeof(AudioToolView), typeof(AudioToolViewModel));
            viewModelLocator.Register(typeof(CR2WEditorView), typeof(CR2WEditorViewModel));
            viewModelLocator.Register(typeof(CodeEditorView), typeof(CodeEditorViewModel));
            viewModelLocator.Register(typeof(PluginManagerView), typeof(PluginManagerViewModel));
            viewModelLocator.Register(typeof(VisualEditorView), typeof(VisualEditorViewModel));
            viewModelLocator.Register(typeof(AnimsView), typeof(AnimsViewModel));
            viewModelLocator.Register(typeof(MimicsView), typeof(MimicsViewModel));
            viewModelLocator.Register(typeof(BulkEditorView), typeof(BulkEditorViewModel));
            viewModelLocator.Register(typeof(CR2WToTextToolView), typeof(CR2WToTextToolViewModel));
            viewModelLocator.Register(typeof(CsvEditorViewModel), typeof(CsvEditorViewModel));
            //-- Category : EditorBars
            viewModelLocator.Register(typeof(ArrayEditorView), typeof(ArrayEditorViewModel));
            viewModelLocator.Register(typeof(ByteArrayEditorView), typeof(ByteArrayEditorViewModel));
            viewModelLocator.Register(typeof(IdTagEditorView), typeof(IdTagEditorViewModel));
            viewModelLocator.Register(typeof(PtrEditorView), typeof(PtrEditorViewModel));
            viewModelLocator.Register(typeof(GameDebuggerToolView), typeof(GameDebuggerToolViewModel));
            viewModelLocator.Register(typeof(HexEditorView), typeof(HexEditorViewModel));
            viewModelLocator.Register(typeof(ImporterToolView), typeof(ImporterToolViewModel));
            viewModelLocator.Register(typeof(RadishToolView), typeof(RadishToolViewModel));
            viewModelLocator.Register(typeof(WccToolView), typeof(WccToolViewModel));
            viewModelLocator.Register(typeof(MenuCreatorToolView), typeof(MenuCreatorToolViewModel));


            // ---- HeadCategory : FluentBackstage
            //-- Category : Backstage
            viewModelLocator.Register(typeof(OpenFileView), typeof(OpenFileViewModel));
            viewModelLocator.Register(typeof(RecentlyUsedItemsView), typeof(RecentlyUsedItemsViewModel));
            //-- Category : Homepage 
            viewModelLocator.Register(typeof(HomePageView), typeof(HomePageViewModel));
            viewModelLocator.Register(typeof(TopicView), typeof(TopicViewModel));
            viewModelLocator.Register(typeof(AboutPageView), typeof(AboutPageViewModel));
            viewModelLocator.Register(typeof(GithubPageView), typeof(GithubPageViewModel));
            viewModelLocator.Register(typeof(RecentProjectView), typeof(RecentlyUsedItemsViewModel));
            viewModelLocator.Register(typeof(WikiPageView), typeof(WikiPageViewModel));
            viewModelLocator.Register(typeof(WelcomePageView), typeof(RecentlyUsedItemsViewModel));
            viewModelLocator.Register(typeof(WebsitePageView), typeof(WebsitePageViewModel));
            viewModelLocator.Register(typeof(SettingsPageView), typeof(SettingsPageViewModel));
            viewModelLocator.Register(typeof(UserPageView), typeof(UserPageViewModel));
            viewModelLocator.Register(typeof(DebugPageView), typeof(DebugPageViewModel));
            //-- Category : Integrated Tools
            viewModelLocator.Register(typeof(IntegratedToolsPageView), typeof(IntegratedToolsPageViewModel));
            viewModelLocator.Register(typeof(CyberCATPageView), typeof(CyberCATPageViewModel));
            //-- Category : Settings Pages 
            viewModelLocator.Register(typeof(GeneralSettingsView), typeof(GeneralSettingsViewModel));
            viewModelLocator.Register(typeof(GlobalSubSettingsView), typeof(GlobalSubSettingsViewModel));
            viewModelLocator.Register(typeof(AccountSubSettingsView), typeof(AccountSubSettingsViewModel));
            viewModelLocator.Register(typeof(UpdatesSubSettingsView), typeof(UpdatesSubSettingsViewModel));
            viewModelLocator.Register(typeof(ThemeSubSettingsView), typeof(ThemeSubSettingsViewModel));
            viewModelLocator.Register(typeof(LoggingSubSettingsView), typeof(LoggingSubSettingsViewModel));
            // - Tools
            viewModelLocator.Register(typeof(ToolSettingsView), typeof(ToolSettingsViewModel));
            viewModelLocator.Register(typeof(AssetBrowserSubSettingsView), typeof(AssetBrowserSubSettingsViewModel));
            viewModelLocator.Register(typeof(CodeEditorSubSettingsView), typeof(CodeEditorSubSettingsViewModel));
            viewModelLocator.Register(typeof(PluginManagerSubSettingsView), typeof(PluginManagerSubSettingsViewModel));
            viewModelLocator.Register(typeof(VisualEditorSubSettingsView), typeof(VisualEditorSubSettingsViewModel));
            // - Editor
            viewModelLocator.Register(typeof(EditorSettingsView), typeof(EditorSettingsViewModel));
            viewModelLocator.Register(typeof(GeneralSubSettingsView), typeof(GeneralSubSettingsViewModel));
            viewModelLocator.Register(typeof(CompatibilitySubSettingsView), typeof(CompatibilitySubSettingsViewModel));
            // - Packaging
            viewModelLocator.Register(typeof(PackagingSettingsView), typeof(PackagingSettingsViewModel));
            viewModelLocator.Register(typeof(IntegrationsSettingsView), typeof(IntegrationsSettingsViewModel));

            // ---- HeadCategory : Wizards
            //-- Category : UserWizard
            viewModelLocator.Register(typeof(UserWizardView), typeof(UserWizardViewModel));
            viewModelLocator.Register(typeof(UserWizardPageView), typeof(UserWizardPageViewModel));
            //-- Category : ThemeWizard
   
            //-- Category : ProjectWizard
            viewModelLocator.Register(typeof(ProjectWizardView), typeof(ProjectWizardViewModel));
            viewModelLocator.Register(typeof(SelectProjectTypeView), typeof(SelectProjectTypeViewModel));
            viewModelLocator.Register(typeof(ProjectConfigurationView), typeof(ProjectConfigurationViewModel));
            viewModelLocator.Register(typeof(MVVM.Views.Components.Wizards.WizardPages.ProjectWizard.FinalizeSetupView), typeof(ViewModels.Wizards.WizardPages.ProjectWizard.FinalizeSetupViewModel));
            //-- Category : PublishWizard
            viewModelLocator.Register(typeof(PublishWizardView), typeof(PublishWizardViewModel));
            viewModelLocator.Register(typeof(RequiredSettingsView), typeof(RequiredSettingsViewModel));
            viewModelLocator.Register(typeof(OptionalSettingsView), typeof(OptionalSettingsViewModel));
            viewModelLocator.Register(typeof(MVVM.Views.Components.Wizards.WizardPages.PublishWizard.FinalizeSetupView), typeof(ViewModels.Wizards.WizardPages.PublishWizard.FinalizeSetupViewModel));
            viewModelLocator.Register(typeof(W3PackSettingsView), typeof(W3PackSettingsViewModel));
            //-- Category : FirstSetupWizard 
            viewModelLocator.Register(typeof(FirstSetupWizardView), typeof(FirstSetupWizardViewModel));
            viewModelLocator.Register(typeof(CreateUserView), typeof(CreateUserViewModel));
            viewModelLocator.Register(typeof(SelectThemeView), typeof(SelectThemeViewModel));
            viewModelLocator.Register(typeof(SetInitialPreferencesView), typeof(SetInitialPreferencesViewModel));
            viewModelLocator.Register(typeof(LocateGameDateView), typeof(LocateGameDataViewModel));
            viewModelLocator.Register(typeof(MVVM.Views.Components.Wizards.WizardPages.FirstSetupWizard.FinalizeSetupView), typeof(ViewModels.Wizards.WizardPages.FirstSetupWizard.FinalizeSetupViewModel));
            //-- Category : FeedBackWizard 
            viewModelLocator.Register(typeof(FeedbackWizardView), typeof(FeedbackWizardViewModel));
            viewModelLocator.Register(typeof(RateView), typeof(RateViewModel));
            //-- Category : InstallerWizard 
            viewModelLocator.Register(typeof(InstallerWizardView), typeof(InstallerWizardViewModel));
            //-- Category : BugReportWizard 
            viewModelLocator.Register(typeof(BugReportWizard), typeof(BugReportWizardViewModel));
            viewModelLocator.Register(typeof(SendBugView), typeof(SendBugViewModel));
            var viewLocator = ServiceLocator.Default.ResolveType<IViewLocator>();
            // ---- HeadCategory : Dialogs
            viewModelLocator.Register(typeof(AddChunkDialog), typeof(AddChunkDialogViewModel));
            viewModelLocator.Register(typeof(ExtractAmbigiousDialog), typeof(ExtractAmbigiousDialogViewModel));
            viewModelLocator.Register(typeof(RenameDialog), typeof(RenameDialogViewModel));
            viewModelLocator.Register(typeof(StringsGUIImporterIDDialog), typeof(StringsGUIImporterIDDialogViewModel));
            viewModelLocator.Register(typeof(StringsGuiScriptsPrefixDialog), typeof(StringsGuiScriptsPrefixDialogViewModel));
            viewLocator.Register(typeof(InputDialogViewModel), typeof(InputDialog));
        }

        public static async Task InitializeShell()
        {
            var serviceLocator = ServiceLocator.Default;
            HandyControl.Tools.ConfigHelper.Instance.SetLang("en");
            var shellService = serviceLocator.ResolveType<IShellService>();
            await shellService.CreateAsync<ShellWindow>();
            ShellWindow sh = (ShellWindow)shellService.Shell;
            StaticReferences.GlobalShell = sh;
            sh.MinWidth = 1;
            sh.MinHeight = 1;
            sh.Height = 830;
            sh.Width = 1081;
            sh.WindowState = WindowState.Normal;
            sh.WindowStartupLocation = WindowStartupLocation.CenterScreen;



            StaticReferences.GlobalShell.SetCurrentValue(MahApps.Metro.Controls.MetroWindow.TitleBarHeightProperty, 25);
            StaticReferences.GlobalShell.SetCurrentValue(Window.TitleProperty, "");

            var color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DF2935"));
            ThemeManager.Current.AddTheme(new Theme("CustomLightRed", "CustomLightRed", "Dark", "Red", (Color)ColorConverter.ConvertFromString("#DF2935"), color, true, false));
            ThemeManager.Current.AddTheme(RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", Colors.Red));
            ThemeManager.Current.ChangeTheme(Application.Current, "CustomLightRed");

          //  GlobalShell.SetCurrentValue(FrameworkElement.MinHeightProperty, (double)810);
          //  GlobalShell.SetCurrentValue(FrameworkElement.MinWidthProperty, (double)1060);
        }




        public static void ShowFirstTimeSetup()
        {
            if (Functionality.Services.SettingsManager.FirstTimeSetupForUser)
            {
                Task.Run(() =>
                {
                    //await Task.Delay(5000);
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        FirstSetupWizardView rpv = new FirstSetupWizardView();
                        UserControlHostWindowViewModel zxc = new UserControlHostWindowViewModel(rpv);
                        UserControlHostWindowView uchwv = new UserControlHostWindowView(zxc);
                        rpv.ViewModelChanged += (_s, _e) =>
                        {
                            if (rpv.ViewModel == null)
                                return;
                            rpv.ViewModel.ClosedAsync += async (s, e) =>
                            {
                                await Task.Run(() =>
                                {
                                    Application.Current.Dispatcher.Invoke(() => uchwv.Close());
                                });
                            };
                        };
                        uchwv.Show();
                    });
                });
            }
        }

    }
}
