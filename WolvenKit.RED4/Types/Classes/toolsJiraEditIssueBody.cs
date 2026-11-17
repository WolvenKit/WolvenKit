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
			Fields = new toolsJiraIssueFields();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
