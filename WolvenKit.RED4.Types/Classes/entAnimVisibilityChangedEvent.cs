using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimVisibilityChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entAnimVisibilityChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
