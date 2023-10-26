using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LiftStatus : BaseDeviceStatus
	{
		[Ordinal(40)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public LiftStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
