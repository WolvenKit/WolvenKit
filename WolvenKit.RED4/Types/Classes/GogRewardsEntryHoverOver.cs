using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GogRewardsEntryHoverOver : redEvent
	{
		[Ordinal(0)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public CWeakHandle<GogRewardEntryController> Controller
		{
			get => GetPropertyValue<CWeakHandle<GogRewardEntryController>>();
			set => SetPropertyValue<CWeakHandle<GogRewardEntryController>>(value);
		}

		public GogRewardsEntryHoverOver()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
