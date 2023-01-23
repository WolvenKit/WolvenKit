using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMultiplayerChoiceTokenParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("timeout")] 
		public CUInt32 Timeout
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questMultiplayerChoiceTokenParams()
		{
			Timeout = 15;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
