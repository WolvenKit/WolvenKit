using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerBountySystemGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("moneyReward")] 
		public inkTextWidgetReference MoneyReward
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("moneyRewardRow")] 
		public inkWidgetReference MoneyRewardRow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("streetCredReward")] 
		public inkTextWidgetReference StreetCredReward
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("streetCredRewardRow")] 
		public inkWidgetReference StreetCredRewardRow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("transgressions")] 
		public inkTextWidgetReference Transgressions
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("transgressionsWidget")] 
		public inkWidgetReference TransgressionsWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("rewardPanel")] 
		public inkCompoundWidgetReference RewardPanel
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("mugShot")] 
		public inkRectangleWidgetReference MugShot
		{
			get => GetPropertyValue<inkRectangleWidgetReference>();
			set => SetPropertyValue<inkRectangleWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("wanted")] 
		public inkTextWidgetReference Wanted
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("notFound")] 
		public inkTextWidgetReference NotFound
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("deadNotice")] 
		public inkTextWidgetReference DeadNotice
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("crossedOut")] 
		public inkWidgetReference CrossedOut
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("starsWidget")] 
		public CArray<inkWidgetReference> StarsWidget
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(18)] 
		[RED("bountyCallbackID")] 
		public CHandle<redCallbackObject> BountyCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("healthCallbackID")] 
		public CHandle<redCallbackObject> HealthCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("objectCallbackID")] 
		public CHandle<redCallbackObject> ObjectCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("isValidBounty")] 
		public CBool IsValidBounty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("objectType")] 
		public CEnum<ScannerObjectType> ObjectType
		{
			get => GetPropertyValue<CEnum<ScannerObjectType>>();
			set => SetPropertyValue<CEnum<ScannerObjectType>>(value);
		}

		[Ordinal(24)] 
		[RED("showScanBountyAnimProxy")] 
		public CHandle<inkanimProxy> ShowScanBountyAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public ScannerBountySystemGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
