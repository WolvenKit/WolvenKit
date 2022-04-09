using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraEditIssueBody : ISerializable
	{
		[Ordinal(0)] 
		[RED("fields")] 
		public toolsJiraIssueFields Fields
		{
			get => GetPropertyValue<toolsJiraIssueFields>();
			set => SetPropertyValue<toolsJiraIssueFields>(value);
		}

		public toolsJiraEditIssueBody()
		{
			Fields = new() { Project = new(), Status = new(), Resolution = new(), Issuetype = new(), Priority = new(), Labels = new(), Assignee = new(), Customfield_10505 = new(), Customfield_29900 = new(), FixVersions = new(), Customfield_15306 = new(), Attachment = new(), Customfield_25500 = new() { Value = "NONE" }, Versions = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
