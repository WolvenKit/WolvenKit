using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InvalidateTooltipHiddenStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public InvalidateTooltipHiddenStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
