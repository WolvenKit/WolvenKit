using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraCommentIssueBody : ISerializable
	{
		[Ordinal(0)] 
		[RED("body")] 
		public CString Body
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public toolsJiraCommentIssueBody()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
