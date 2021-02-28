using System.Collections.Immutable;
using System.Windows.Input;
using Orc.Squirrel;
using InputGesture = Catel.Windows.Input.InputGesture;
using DiscordRPC.Message;


namespace WolvenKit
{
    public static class AppCommands
    {
        public static class Application
        {
            public const string Exit = "Application.Exit";
            public static readonly InputGesture ExitInputGesture = new InputGesture(Key.F4, ModifierKeys.Alt);

            public const string About = "Application.About";
            public static readonly InputGesture AboutInputGesture = new InputGesture(Key.F1);

            public const string Options = "Application.Options";
            public static readonly InputGesture OptionsInputGesture = new InputGesture(Key.F12);


            public const string OpenLink = "Application.OpenLink";

            public const string DelProject = "Application.DeleteProject";
            public const string SaveProject = "Application.SaveProject";
            public const string SaveAsProject = "Application.SaveAsProject";

            public const string OpenProject = "Application.OpenProject";
            public static readonly InputGesture OpenProjectInputGesture = new InputGesture(Key.O, ModifierKeys.Control);
            public const string NewProject = "Application.NewProject";
            public static readonly InputGesture NewProjectInputGesture = new InputGesture(Key.N, ModifierKeys.Control);
            public const string CreateNewProject = "Application.CreateNewProject";

            //public const string SaveAll = "Application.SaveAll";
            //public static readonly InputGesture SaveAllInputGesture = new InputGesture(Key.S, ModifierKeys.Control);

            public const string ShowFeedback = "Application.ShowFeedback";
            public const string ShowAbout = "Application.ShowAbout";
            public const string ShowSettings = "Application.ShowSettings";

            public const string ShowLog = "Application.ShowLog";
            public const string ShowProjectExplorer = "Application.ShowProjectExplorer";
            public const string ShowImportUtility = "Application.ShowImportUtility";
            public const string ShowProperties = "Application.ShowProperties";

            public const string ShowCsvEditor = "Application.ShowCsvEditor";
            public const string ShowBulkEditor = "Application.ShowBulkEditor";
            public const string ShowGameDebuggerTool = "Application.ShowGameDebuggerTool";
            public const string ShowCodeEditor = "Application.ShowCodeEditor";

            public const string ShowHexEditor = "Application.ShowHexEditor";
            public const string ShowJournalEditor = "Application.ShowJournalEditor";
            public const string ShowVisualEditor = "Application.ShowVisualEditor";
            public const string ShowAnimationTool = "Application.ShowAnimationTool";
            public const string ShowMimicsTool = "Application.ShowMimicsTool";
            public const string ShowCR2WEditor = "Application.ShowCR2WEditor";

            public const string ShowAudioTool = "Application.ShowAudioTool";
            public const string ShowImporterTool = "Application.ShowImporterTool";
            public const string ShowCR2WToTextTool = "Application.ShowCR2WToTextTool";
            public const string ShowMenuCreatorTool = "Application.ShowMenuCreatorTool";
            public const string ShowPluginManager = "Application.ShowPluginManager";
            public const string ShowWccTool = "Application.ShowWccTool";
            public const string ShowRadishTool = "Application.ShowRadishTool";
            public const string ShowAssetBrowser = "Application.ShowAssetBrowser";
            public const string ShowModSettings = "Application.ShowModSettings";
            public const string ShowPackageInstaller = "Application.ShowPackageInstaller";

            public const string OpenFile = "Application.OpenFile";
            public const string NewFile = "Application.NewFile";
            public const string BugReport = "Application.BugReport"; 


            public const string PackMod = "Application.PackMod";
            public const string BackupMod = "Application.BackupMod";
            public const string PublishMod = "Application.PublishMod";



            public const string ViewSelected = "Application.ViewSelected";

        }
        public static class ProjectExplorer
        {
            public const string ExpandAll = "ProjectExplorer.ExpandAll";
            public const string CollapseAll = "ProjectExplorer.CollapseAll";
            public const string Expand = "ProjectExplorer.Expand";
            public const string Collapse = "ProjectExplorer.Collapse";

            public const string Refresh = "ProjectExplorer.Refresh";
        }


        public static class Settings
        {

            public const string General = "Settings.General";
            public static readonly InputGesture GeneralInputGesture = new InputGesture(Key.S, ModifierKeys.Alt | ModifierKeys.Control);
        }
    }

    public static class Settings
    {
        public static class Application
        {
            public static class General
            {
                public const string SomeSetting = "General.SomeSetting";
                public const bool SomeSettingDefaultValue = true;
            }

            public static class AutomaticUpdates
            {
                public const bool CheckForUpdatesDefaultValue = true;

                public static readonly ImmutableArray<UpdateChannel> AvailableChannels = ImmutableArray.Create(
                    new UpdateChannel("Stable", "XXX"),     //TODO
                    new UpdateChannel("Beta", "XXX")        //TODO
                );

                public static readonly UpdateChannel DefaultChannel = AvailableChannels[0];
            }
        }
    }




  



}
