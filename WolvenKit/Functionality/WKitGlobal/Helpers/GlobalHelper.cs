using System.Collections.Generic;
using Catel.MVVM;
using Orchestra.Views;
using WolvenKit.MVVM.ViewModels.Shell.Editor;
using WolvenKit.MVVM.Views.Shell.Editor;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public class GlobalHelper { } // Template.

    public static class StaticReferences
    {
        public static RibbonView RibbonViewInstance;
        public static ShellWindow GlobalShell;
        public static MainView MainView;
        public static StatusBarViewModel GlobalStatusBar;
    }

    /// <summary>
    /// Below is WIP piece of me (Offline) ,,,, The idea behind it is to create preset workflows (Automated actions in WolvenKit)
    ///
    /// Please do add ideas. But please tell me why or what you did <3
    /// </summary>

    public class ProjectWorkFlow
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<ProjectWorkFlowAction> FlowActions { get; set; }

        public ProjectWorkFlow(string name, int id, List<ProjectWorkFlowAction> flowactions)
        {
            Name = name;
            ID = id;
            FlowActions = flowactions;
        }

        public ProjectWorkFlow CreateProjectWorkFlow(string name, int id, List<ProjectWorkFlowAction> flowactions)
        {
            ProjectWorkFlow projectWorkFlow = new ProjectWorkFlow(name, id, flowactions);
            return projectWorkFlow;
        }
    }

    public class ProjectWorkFlowAction
    {
        public Command ProjectWorkFlowActionCommand { get; set; }
        public ProjectWorkFlowActionStatus ProjectWorkFlowActionStatus { get; set; }

        public ProjectWorkFlowAction(Command command)
        {
            ProjectWorkFlowActionCommand = command;
            ProjectWorkFlowActionStatus = ProjectWorkFlowActionStatus.Queued;
        }

        public ProjectWorkFlowAction CreateProjectWorkFlowAction(Command projectWorkFlowActionCommand)
        {
            ProjectWorkFlowAction projectWorkFlowAction = new ProjectWorkFlowAction(projectWorkFlowActionCommand);
            return projectWorkFlowAction;
        }
    }

    public enum ProjectWorkFlowActionStatus
    { Queued, Started, Finished, Failed, }
}
