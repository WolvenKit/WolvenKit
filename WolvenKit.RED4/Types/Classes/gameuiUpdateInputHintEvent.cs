using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiUpdateInputHintEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public gameuiInputHintData Data
		{
			get => GetPropertyValue<gameuiInputHintData>();
			set => SetPropertyValue<gameuiInputHintData>(value);
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("targetHintContainer")] 
		public CName TargetHintContainer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiUpdateInputHintEvent()
		{
			Data = new gameuiInputHintData { HoldIndicationType = Enums.inkInputHintHoldIndicationType.Press };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
