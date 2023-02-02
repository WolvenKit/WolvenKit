using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkVisualStateBlackBarsVisibilityChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("blackBarsVisible")] 
		public CBool BlackBarsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkVisualStateBlackBarsVisibilityChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
