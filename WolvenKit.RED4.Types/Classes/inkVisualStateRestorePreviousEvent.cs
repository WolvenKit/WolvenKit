using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkVisualStateRestorePreviousEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("visualState")] 
		public CName VisualState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkVisualStateRestorePreviousEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
