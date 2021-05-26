// Template.

/// <summary>
/// Below is WIP piece of me (Offline) ,,,, The idea behind it is to create preset workflows (Automated actions in WolvenKit)
///
/// Please do add ideas. But please tell me why or what you did <3
/// </summary>
public enum ProjectWorkFlowActionStatus
{ Queued, Started, Finished, Failed, }
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
