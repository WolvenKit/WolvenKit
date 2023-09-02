using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraCreateIssueBody : ISerializable
	{
		[Ordinal(0)] 
		[RED("fields")] 
		public toolsJiraIssueFields Fields
		{
			get => GetPropertyValue<toolsJiraIssueFields>();
			set => SetPropertyValue<toolsJiraIssueFields>(value);
		}

		public toolsJiraCreateIssueBody()
		{
			Fields = new toolsJiraIssueFields { Project = new toolsJiraProject(), Status = new toolsJiraStatus(), Resolution = new toolsJiraResolution(), Issuetype = new toolsJiraIssueType(), Priority = new toolsJiraPriority(), Labels = new(), Assignee = new toolsJiraCustomFieldName(), Customfield_10505 = new toolsJiraCustomFieldValue(), Customfield_29900 = new toolsJiraCustomFieldValue(), FixVersions = new(), Customfield_15306 = new(), Attachment = new(), Customfield_25500 = new toolsJiraCustomFieldValue { Value = "NONE" }, Versions = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
