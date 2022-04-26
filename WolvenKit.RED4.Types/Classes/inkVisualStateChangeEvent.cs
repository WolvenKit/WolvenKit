using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkVisualStateChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("visualState")] 
		public CName VisualState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkVisualStateChangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
