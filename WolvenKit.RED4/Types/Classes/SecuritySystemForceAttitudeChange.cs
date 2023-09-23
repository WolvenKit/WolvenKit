using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySystemForceAttitudeChange : ScriptableDeviceAction
	{
		[Ordinal(38)] 
		[RED("newAttitude")] 
		public CName NewAttitude
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SecuritySystemForceAttitudeChange()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
