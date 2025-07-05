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
			Fields = new toolsJiraIssueFields { Project = new toolsJiraProject(), Status = new toolsJiraStatus(), Resolution = new toolsJiraResolution(), Issuetype = new toolsJiraIssueType(), Priority = new toolsJiraPriority(), Labels = new(), Assignee = new toolsJiraCustomFieldName(), Versions = new(), FixVersions = new(), Components = new(), Attachment = new(), Customfield_17400 = new toolsJiraCustomFieldId(), Customfield_34100 = new toolsJiraCustomFieldValue(), Customfield_15306 = new(), Customfield_34718 = new(), Customfield_36106 = new(), Customfield_10505 = new toolsJiraCustomFieldValue(), Customfield_10603 = new(), Customfield_34706 = new(), Customfield_25500 = new toolsJiraCustomFieldValue { Value = "NONE" }, Customfield_15808 = new(), Customfield_29900 = new toolsJiraCustomFieldValue() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
