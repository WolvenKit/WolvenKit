using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionNotification : GenericNotificationController
	{
		[Ordinal(12)] 
		[RED("bounty_data")] 
		public CHandle<PreventionBountyViewData> Bounty_data
		{
			get => GetPropertyValue<CHandle<PreventionBountyViewData>>();
			set => SetPropertyValue<CHandle<PreventionBountyViewData>>(value);
		}

		[Ordinal(13)] 
		[RED("bountyTitleText")] 
		public inkTextWidgetReference BountyTitleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("bountyAmountText")] 
		public inkTextWidgetReference BountyAmountText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public PreventionNotification()
		{
			BountyTitleText = new inkTextWidgetReference();
			BountyAmountText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
