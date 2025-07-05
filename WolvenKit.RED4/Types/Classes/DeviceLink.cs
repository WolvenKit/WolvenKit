using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceLink : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("PSID")] 
		public gamePersistentID PSID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(1)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public DeviceLink()
		{
			PSID = new gamePersistentID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
