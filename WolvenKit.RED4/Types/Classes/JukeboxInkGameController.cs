using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JukeboxInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("ActionsPanel")] 
		public inkHorizontalPanelWidgetReference ActionsPanel
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("PriceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("playButton")] 
		public CWeakHandle<PlayPauseActionWidgetController> PlayButton
		{
			get => GetPropertyValue<CWeakHandle<PlayPauseActionWidgetController>>();
			set => SetPropertyValue<CWeakHandle<PlayPauseActionWidgetController>>(value);
		}

		[Ordinal(19)] 
		[RED("nextButton")] 
		public CWeakHandle<NextPreviousActionWidgetController> NextButton
		{
			get => GetPropertyValue<CWeakHandle<NextPreviousActionWidgetController>>();
			set => SetPropertyValue<CWeakHandle<NextPreviousActionWidgetController>>(value);
		}

		[Ordinal(20)] 
		[RED("previousButton")] 
		public CWeakHandle<NextPreviousActionWidgetController> PreviousButton
		{
			get => GetPropertyValue<CWeakHandle<NextPreviousActionWidgetController>>();
			set => SetPropertyValue<CWeakHandle<NextPreviousActionWidgetController>>(value);
		}

		public JukeboxInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
