using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsJiraTransitionIssueBody : ISerializable
	{
		[Ordinal(0)] 
		[RED("transition")] 
		public toolsJiraIssueTransition Transition
		{
			get => GetPropertyValue<toolsJiraIssueTransition>();
			set => SetPropertyValue<toolsJiraIssueTransition>(value);
		}

		public toolsJiraTransitionIssueBody()
		{
			Transition = new();
		}
	}
}
