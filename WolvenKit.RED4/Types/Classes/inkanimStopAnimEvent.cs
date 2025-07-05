using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimStopAnimEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkanimStopAnimEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
