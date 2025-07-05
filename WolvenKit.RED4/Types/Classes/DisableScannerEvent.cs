using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisableScannerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isDisabled")] 
		public CBool IsDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DisableScannerEvent()
		{
			IsDisabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
