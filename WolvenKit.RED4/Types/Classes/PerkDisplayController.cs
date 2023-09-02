using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkDisplayController : inkButtonController
	{
		[Ordinal(10)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("fluffText")] 
		public inkTextWidgetReference FluffText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("requiredTrainerIcon")] 
		public inkWidgetReference RequiredTrainerIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("requiredPointsText")] 
		public inkTextWidgetReference RequiredPointsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("displayData")] 
		public CHandle<BasePerkDisplayData> DisplayData
		{
			get => GetPropertyValue<CHandle<BasePerkDisplayData>>();
			set => SetPropertyValue<CHandle<BasePerkDisplayData>>(value);
		}

		[Ordinal(16)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentDataManager>>(value);
		}

		[Ordinal(17)] 
		[RED("playerDevelopmentData")] 
		public CWeakHandle<PlayerDevelopmentData> PlayerDevelopmentData
		{
			get => GetPropertyValue<CWeakHandle<PlayerDevelopmentData>>();
			set => SetPropertyValue<CWeakHandle<PlayerDevelopmentData>>(value);
		}

		[Ordinal(18)] 
		[RED("recentlyPurchased")] 
		public CBool RecentlyPurchased
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("holdStarted")] 
		public CBool HoldStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("isTrait")] 
		public CBool IsTrait
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("wasLocked")] 
		public CBool WasLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("cool_in_proxy")] 
		public CHandle<inkanimProxy> Cool_in_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(24)] 
		[RED("cool_out_proxy")] 
		public CHandle<inkanimProxy> Cool_out_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public PerkDisplayController()
		{
			LevelText = new inkTextWidgetReference();
			Icon = new inkImageWidgetReference();
			FluffText = new inkTextWidgetReference();
			RequiredTrainerIcon = new inkWidgetReference();
			RequiredPointsText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
