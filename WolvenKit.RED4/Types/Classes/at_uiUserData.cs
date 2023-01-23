using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class at_uiUserData : inkUserData
	{
		[Ordinal(0)] 
		[RED("atid")] 
		public CString Atid
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public at_uiUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
