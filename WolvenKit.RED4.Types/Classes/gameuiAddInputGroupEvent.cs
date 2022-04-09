using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiAddInputGroupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("groupId")] 
		public CName GroupId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public gameuiInputHintGroupData Data
		{
			get => GetPropertyValue<gameuiInputHintGroupData>();
			set => SetPropertyValue<gameuiInputHintGroupData>(value);
		}

		[Ordinal(2)] 
		[RED("targetHintContainer")] 
		public CName TargetHintContainer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiAddInputGroupEvent()
		{
			Data = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
