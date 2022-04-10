using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInputHintInitializedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetHintContainer")] 
		public CName TargetHintContainer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiInputHintInitializedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
