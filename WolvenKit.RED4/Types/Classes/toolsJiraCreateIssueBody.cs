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
			Fields = new toolsJiraIssueFields();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
