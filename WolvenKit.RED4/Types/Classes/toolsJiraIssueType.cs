using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraIssueType : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public toolsJiraIssueType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
