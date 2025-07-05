using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMultiplayerGiveChoiceTokenEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("timeout")] 
		public CUInt32 Timeout
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("tokenAlreadyGiven")] 
		public CBool TokenAlreadyGiven
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questMultiplayerGiveChoiceTokenEvent()
		{
			Timeout = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
