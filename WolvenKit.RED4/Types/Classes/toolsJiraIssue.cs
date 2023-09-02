using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraIssue : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("self")] 
		public CString Self
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("key")] 
		public CString Key
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("fields")] 
		public toolsJiraIssueFields Fields
		{
			get => GetPropertyValue<toolsJiraIssueFields>();
			set => SetPropertyValue<toolsJiraIssueFields>(value);
		}

		public toolsJiraIssue()
		{
			Fields = new toolsJiraIssueFields { Project = new toolsJiraProject(), Status = new toolsJiraStatus(), Resolution = new toolsJiraResolution(), Issuetype = new toolsJiraIssueType(), Priority = new toolsJiraPriority(), Labels = new(), Assignee = new toolsJiraCustomFieldName(), Customfield_10505 = new toolsJiraCustomFieldValue(), Customfield_29900 = new toolsJiraCustomFieldValue(), FixVersions = new(), Customfield_15306 = new(), Attachment = new(), Customfield_25500 = new toolsJiraCustomFieldValue { Value = "NONE" }, Versions = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
