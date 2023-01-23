using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiUpdateInputHintMultipleEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CArray<gameuiInputHintData> Data
		{
			get => GetPropertyValue<CArray<gameuiInputHintData>>();
			set => SetPropertyValue<CArray<gameuiInputHintData>>(value);
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CArray<CBool> Show
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(2)] 
		[RED("targetHintContainer")] 
		public CName TargetHintContainer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiUpdateInputHintMultipleEvent()
		{
			Data = new();
			Show = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
