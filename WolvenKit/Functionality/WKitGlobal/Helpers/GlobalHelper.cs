using System.Collections.Generic;
using Catel.MVVM;
using Orchestra.Views;
using WolvenKit.MVVM.ViewModels.Shell.Editor;
using WolvenKit.MVVM.Views.Shell.Editor;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public enum ProjectWorkFlowActionStatus
    { Queued, Started, Finished, Failed, }

    public static class StaticReferences
    {
        #region Fields

        public static ShellWindow GlobalShell;
        public static StatusBarViewModel GlobalStatusBar;
        public static MainView MainView;
        public static RibbonView RibbonViewInstance;

        public static PropertiesView GlobalPropertiesView;

        #endregion Fields
    }

    public class GlobalHelper
    {
    } // Template.

    /// <summary>
    /// Below is WIP piece of me (Offline) ,,,, The idea behind it is to create preset workflows (Automated actions in WolvenKit)
    ///
    /// Please do add ideas. But please tell me why or what you did <3
    /// </summary>

    public class ProjectWorkFlow
    {
        #region Constructors

        public ProjectWorkFlow(string name, int id, List<ProjectWorkFlowAction> flowactions)
        {
            Name = name;
            ID = id;
            FlowActions = flowactions;
        }

        #endregion Constructors

        #region Properties

        public List<ProjectWorkFlowAction> FlowActions { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }

        #endregion Properties

        #region Methods

        public ProjectWorkFlow CreateProjectWorkFlow(string name, int id, List<ProjectWorkFlowAction> flowactions)
        {
            var projectWorkFlow = new ProjectWorkFlow(name, id, flowactions);
            return projectWorkFlow;
        }

        #endregion Methods
    }

    public class ProjectWorkFlowAction
    {
        #region Constructors

        public ProjectWorkFlowAction(Command command)
        {
            ProjectWorkFlowActionCommand = command;
            ProjectWorkFlowActionStatus = ProjectWorkFlowActionStatus.Queued;
        }

        #endregion Constructors

        #region Properties

        public Command ProjectWorkFlowActionCommand { get; set; }
        public ProjectWorkFlowActionStatus ProjectWorkFlowActionStatus { get; set; }

        #endregion Properties

        #region Methods

        public ProjectWorkFlowAction CreateProjectWorkFlowAction(Command projectWorkFlowActionCommand)
        {
            var projectWorkFlowAction = new ProjectWorkFlowAction(projectWorkFlowActionCommand);
            return projectWorkFlowAction;
        }

        #endregion Methods
    }
}
