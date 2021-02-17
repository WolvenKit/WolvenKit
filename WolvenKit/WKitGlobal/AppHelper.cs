using Catel.IoC;
using Catel.MVVM;
using ControlzEx.Theming;
using Orchestra.Services;
using Orchestra.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WolvenKit.Views;
using Orc.Squirrel;


namespace WolvenKit.WKitGlobal
{
    public class AppHelper
    {
        public static RibbonView RibbonViewInstance;
        public static ShellWindow GlobalShell;


        public async Task InitializeMVVM()
        {

            var uri = new Uri("pack://application:,,,/WolvenKit.Resources;component/Resources/Images/git.png");

            await SquirrelHelper.HandleSquirrelAutomaticallyAsync();

            // Register Viewmodels
            var viewModelLocator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels");

            //TODO: rename later to MainViewModel

            // ---- HeadCategory : Extras
            //-- Category : Radio
            viewModelLocator.Register(typeof(Views.AudioTool.Radio.RadioPlayerView), typeof(ViewModels.AudioTool.Radio.RadioPlayerViewModel));


            // ---- HeadCategory : ProjectView
            //-- Category : ProjectView
            viewModelLocator.Register(typeof(Views.MainView), typeof(ViewModels.WorkSpaceViewModel));

            //-- Category : AssetBrowser
            viewModelLocator.Register(typeof(Views.AssetBrowser.AssetBrowserView), typeof(ViewModels.AssetBrowser.AssetBrowserViewModel));

            //-- Category : JournalEditor
            viewModelLocator.Register(typeof(Views.JournalEditor.JournalEditorView), typeof(ViewModels.JournalEditor.JournalEditorViewModel));

            //-- Category : AudioTool
            viewModelLocator.Register(typeof(Views.AudioTool.AudioToolView), typeof(ViewModels.AudioTool.AudioToolViewModel));

            //-- Category : CodeEditor
            viewModelLocator.Register(typeof(Views.CodeEditor.CodeEditorView), typeof(ViewModels.CodeEditor.CodeEditorViewModel));

            //-- Category : PluginManager
            viewModelLocator.Register(typeof(Views.PluginManager.PluginManagerView), typeof(ViewModels.PluginManager.PluginManagerViewModel));

            //-- Category : VisualEditor
            viewModelLocator.Register(typeof(Views.VisualEditor.VisualEditorView), typeof(ViewModels.VisualEditor.VisualEditorViewModel));

            //-- Category : AnimationTool
            viewModelLocator.Register(typeof(Views.AnimationTool.AnimsView), typeof(ViewModels.AnimationTool.AnimsViewModel));
            viewModelLocator.Register(typeof(Views.AnimationTool.MimicsView), typeof(ViewModels.AnimationTool.MimicsViewModel));

            //-- Category : BulkEditor
            viewModelLocator.Register(typeof(Views.BulkEditor.BulkEditorView), typeof(ViewModels.BulkEditor.BulkEditorViewModel));

            //-- Category : CR2WToTextTool
            viewModelLocator.Register(typeof(Views.CR2WToTextTool.CR2WToTextToolView), typeof(ViewModels.CR2WToTextTool.CR2WToTextToolViewModel));

            //-- Category : CsvEditor
            viewModelLocator.Register(typeof(Views.CsvEditor.CsvEditorView), typeof(ViewModels.CsvEditor.CsvEditorViewModel));

            //-- Category : EditorBars
            viewModelLocator.Register(typeof(Views.EditorBars.ArrayEditorView), typeof(ViewModels.EditorBars.ArrayEditorViewModel));
            viewModelLocator.Register(typeof(Views.EditorBars.ByteArrayEditorView), typeof(ViewModels.EditorBars.ByteArrayEditorViewModel));
            viewModelLocator.Register(typeof(Views.EditorBars.IdTagEditorView), typeof(ViewModels.EditorBars.IdTagEditorViewModel));
            viewModelLocator.Register(typeof(Views.EditorBars.PtrEditorView), typeof(ViewModels.EditorBars.PtrEditorViewModel));

            //-- Category : GameDebuggerTool
            viewModelLocator.Register(typeof(Views.GameDebuggerTool.GameDebuggerToolView), typeof(ViewModels.GameDebuggerTool.GameDebuggerToolViewModel));

            //-- Category : HexEditor
            viewModelLocator.Register(typeof(Views.HexEditor.HexEditorView), typeof(ViewModels.HexEditor.HexEditorViewModel));

            //-- Category : ImporterTool
            viewModelLocator.Register(typeof(Views.ImporterTool.ImporterToolView), typeof(ViewModels.ImporterTool.ImporterToolViewModel));

            //-- Category : RadishTool
            viewModelLocator.Register(typeof(Views.RadishTool.RadishToolView), typeof(ViewModels.RadishTool.RadishToolViewModel));

            //-- Category : WccTool
            viewModelLocator.Register(typeof(Views.WccTool.WccToolView), typeof(ViewModels.WccTool.WccToolViewModel));





            // ---- HeadCategory : FluentBackstage
            //-- Category : Backstage
            viewModelLocator.Register(typeof(Views.OpenFileView), typeof(ViewModels.OpenFileViewModel));
            viewModelLocator.Register(typeof(Views.RecentlyUsedItemsView), typeof(ViewModels.RecentlyUsedItemsViewModel));

            //-- Category : Homepage 
            viewModelLocator.Register(typeof(Views.HomePage.HomePageView), typeof(ViewModels.HomePage.HomePageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.TopicView), typeof(ViewModels.HomePage.TopicViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.AboutPageView), typeof(ViewModels.HomePage.Pages.AboutPageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.GithubPageView), typeof(ViewModels.HomePage.Pages.GithubPageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.RecentProjectView), typeof(ViewModels.RecentlyUsedItemsViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.WikiPageView), typeof(ViewModels.HomePage.Pages.WikiPageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.WelcomePageView), typeof(ViewModels.RecentlyUsedItemsViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.WebsitePageView), typeof(ViewModels.HomePage.Pages.WebsitePageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.SettingsPageView), typeof(ViewModels.HomePage.Pages.SettingsPageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.UserPageView), typeof(ViewModels.HomePage.Pages.UserPageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.DebugPageView), typeof(ViewModels.HomePage.Pages.DebugPageViewModel));


            //-- Category : Integrated Tools
            viewModelLocator.Register(typeof(Views.HomePage.Pages.IntegratedToolsPageView), typeof(ViewModels.HomePage.Pages.IntegratedToolsPageViewModel));
            viewModelLocator.Register(typeof(Views.IntegratedToolsPages.CyberCAT.CyberCATPageView), typeof(ViewModels.IntegratedToolsPages.CyberCAT.CyberCATPageViewModel));



            //-- Category : Settings Pages 
            viewModelLocator.Register(typeof(Views.SettingsPages.GeneralSettingsView), typeof(ViewModels.SettingsPages.GeneralSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.General.GlobalSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.General.GlobalSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.General.AccountSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.General.AccountSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.General.UpdatesSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.General.UpdatesSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.General.ThemeSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.General.ThemeSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.General.LoggingSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.General.LoggingSubSettingsViewModel));
            // - Tools
            viewModelLocator.Register(typeof(Views.SettingsPages.ToolSettingsView), typeof(ViewModels.SettingsPages.ToolSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Tool.AssetBrowserSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Tool.AssetBrowserSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Tool.CodeEditorSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Tool.CodeEditorSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Tool.PluginManagerSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Tool.PluginManagerSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Tool.VisualEditorSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Tool.VisualEditorSubSettingsViewModel));
            // - Editor
            viewModelLocator.Register(typeof(Views.SettingsPages.EditorSettingsView), typeof(ViewModels.SettingsPages.EditorSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Editor.GeneralSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Editor.GeneralSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Editor.CompatibilitySubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Editor.CompatibilitySubSettingsViewModel));
            // - Packaging
            viewModelLocator.Register(typeof(Views.SettingsPages.PackagingSettingsView), typeof(ViewModels.SettingsPages.PackagingSettingsViewModel));
            // - Integrations
            viewModelLocator.Register(typeof(Views.SettingsPages.IntegrationsSettingsView), typeof(ViewModels.SettingsPages.IntegrationsSettingsViewModel));


            // ---- HeadCategory : Wizards
            //-- Category : UserWizard
            viewModelLocator.Register(typeof(Views.Wizards.UserWizardView), typeof(ViewModels.Wizards.UserWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.UserWizard.UserWizardPageView), typeof(ViewModels.Wizards.WizardPages.UserWizard.UserWizardPageViewModel));

            //-- Category : ThemeWizard
            viewModelLocator.Register(typeof(Views.Wizards.ThemeWizardView), typeof(ViewModels.Wizards.ThemeWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ThemeWizard.ThemeWizardPageView), typeof(ViewModels.Wizards.WizardPages.ThemeWizard.ThemeWizardPageViewModel));

            //-- Category : ProjectWizard
            viewModelLocator.Register(typeof(Views.Wizards.ProjectWizardView), typeof(ViewModels.Wizards.ProjectWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ProjectWizard.SelectProjectTypeView), typeof(ViewModels.Wizards.WizardPages.ProjectWizard.SelectProjectTypeViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ProjectWizard.ProjectConfigurationView), typeof(ViewModels.Wizards.WizardPages.ProjectWizard.ProjectConfigurationViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ProjectWizard.FinalizeSetupView), typeof(ViewModels.Wizards.WizardPages.ProjectWizard.FinalizeSetupViewModel));

            //-- Category : PublishWizard
            viewModelLocator.Register(typeof(Views.Wizards.PublishWizardView), typeof(ViewModels.Wizards.PublishWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.RequiredSettingsView), typeof(ViewModels.Wizards.WizardPages.PublishWizard.RequiredSettingsViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.OptionalSettingsView), typeof(ViewModels.Wizards.WizardPages.PublishWizard.OptionalSettingsViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.FinalizeSetupView), typeof(ViewModels.Wizards.WizardPages.PublishWizard.FinalizeSetupViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.W3PackSettingsView), typeof(ViewModels.Wizards.WizardPages.PublishWizard.W3PackSettingsViewModel));


            //-- Category : FirstSetupWizard 
            viewModelLocator.Register(typeof(Views.Wizards.FirstSetupWizardView), typeof(ViewModels.Wizards.FirstSetupWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FirstSetupWizard.CreateUserView), typeof(ViewModels.Wizards.WizardPages.FirstSetupWizard.CreateUserViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FirstSetupWizard.SelectThemeView), typeof(ViewModels.Wizards.WizardPages.FirstSetupWizard.SelectThemeViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FirstSetupWizard.SetInitialPreferencesView), typeof(ViewModels.Wizards.WizardPages.FirstSetupWizard.SetInitialPreferencesViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FirstSetupWizard.LocateGameDateView), typeof(ViewModels.Wizards.WizardPages.FirstSetupWizard.LocateGameDataViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FirstSetupWizard.FinalizeSetupView), typeof(ViewModels.Wizards.WizardPages.FirstSetupWizard.FinalizeSetupViewModel));

            //-- Category : FeedBackWizard 
            viewModelLocator.Register(typeof(Views.Wizards.FeedbackWizardView), typeof(ViewModels.Wizards.FeedbackWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FeedbackWizard.RateView), typeof(ViewModels.Wizards.WizardPages.FeedbackWizard.RateViewModel));



            //-- Category : InstallerWizard 
            viewModelLocator.Register(typeof(Views.Wizards.InstallerWizardView), typeof(ViewModels.Wizards.InstallerWizardViewModel));

            //-- Category : BugReportWizard 
            viewModelLocator.Register(typeof(Views.Wizards.BugReportWizard), typeof(ViewModels.Wizards.BugReportWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.BugReportWizard.SendBugView), typeof(ViewModels.Wizards.WizardPages.BugReportWizard.SendBugViewModel));


            var viewLocator = ServiceLocator.Default.ResolveType<IViewLocator>();
            viewLocator.Register(typeof(ViewModels.SettingsViewModel), typeof(Views.SettingsWindow));


            // ---- HeadCategory : Dialogs
            viewLocator.Register(typeof(ViewModels.Dialogs.InputDialogViewModel), typeof(Views.Dialogs.InputDialog));
            viewLocator.Register(typeof(ViewModels.Dialogs.AddChunkDialogViewModel), typeof(Views.Dialogs.AddChunkDialog));
            viewLocator.Register(typeof(ViewModels.Dialogs.ExtractAmbigiousDialogViewModel), typeof(Views.Dialogs.ExtractAmbigiousDialog));
            viewLocator.Register(typeof(ViewModels.Dialogs.RenameDialogViewModel), typeof(Views.Dialogs.RenameDialog));
            viewLocator.Register(typeof(ViewModels.Dialogs.StringsGUIImporterIDDialogViewModel), typeof(Views.Dialogs.StringsGUIImporterIDDialog));
            viewLocator.Register(typeof(ViewModels.Dialogs.StringsGuiScriptsPrefixDialogViewModel), typeof(Views.Dialogs.StringsGuiScriptsPrefixDialog));

        }

        public async Task InitializeShell()
        {
            var serviceLocator = ServiceLocator.Default;
            HandyControl.Tools.ConfigHelper.Instance.SetLang("en");
            var shellService = serviceLocator.ResolveType<IShellService>();
            await shellService.CreateAsync<ShellWindow>();
            ShellWindow sh = (ShellWindow)shellService.Shell;
            WKitGlobal.AppHelper.GlobalShell = sh;
            sh.MinWidth = 1590;
            sh.MinHeight = 810;
            sh.Height = 810;
            sh.Width = 1590;
            sh.WindowState = WindowState.Normal;
            sh.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            sh.IsVisibleChanged += Sh_IsVisibleChanged;


            GlobalShell.SetCurrentValue(MahApps.Metro.Controls.MetroWindow.TitleBarHeightProperty, 25);
            GlobalShell.SetCurrentValue(System.Windows.Window.TitleProperty, "");

            var color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DF2935"));
            ThemeManager.Current.AddTheme(new Theme("CustomLightRed", "CustomLightRed", "Dark", "Red", (Color)ColorConverter.ConvertFromString("#DF2935"), color, true, false));
            ThemeManager.Current.AddTheme(RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", Colors.Red));
            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current, "CustomLightRed");

            GlobalShell.SetCurrentValue(FrameworkElement.MinHeightProperty, (double)810);
            GlobalShell.SetCurrentValue(FrameworkElement.MinWidthProperty, (double)1060);
        }




        public void ShowFirstTimeSetup()
        {
            if (Services.SettingsManager.FirstTimeSetupForUser)
            {
                Task.Run(() =>
                {
                    //await Task.Delay(5000);
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        Views.Wizards.FirstSetupWizardView rpv = new Views.Wizards.FirstSetupWizardView();
                        var vm = ServiceLocator.Default.ResolveType<ViewModels.Wizards.FirstSetupWizardViewModel>();
                        ViewModels.UserControlHostWindowViewModel zxc = new ViewModels.UserControlHostWindowViewModel(rpv);
                        UserControlHostWindowView uchwv = new UserControlHostWindowView(zxc);
                        vm.ClosedAsync += async (s, e) =>
                        {
                            await Task.Run(() =>
                            {
                                Application.Current.Dispatcher.Invoke(() => uchwv.Close());
                            });
                        };
                        uchwv.Show();
                    });
                });
            }
        }

        private void Sh_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var a = (ShellWindow)sender;
            if (a.IsVisible && a.IsLoaded)
            {
                DiscordRPCHelper.WhatAmIDoing("Project Editor");
            }
        }
    }
}
