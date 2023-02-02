using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraCurrentUserInfo : ISerializable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public toolsJiraCurrentUserInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
