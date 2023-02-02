using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WantedBarGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("starsWidget")] 
		public CArray<inkWidgetReference> StarsWidget
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(10)] 
		[RED("wantedBlackboard")] 
		public CWeakHandle<gameIBlackboard> WantedBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("wantedBlackboardDef")] 
		public CHandle<UI_WantedBarDef> WantedBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_WantedBarDef>>();
			set => SetPropertyValue<CHandle<UI_WantedBarDef>>(value);
		}

		[Ordinal(12)] 
		[RED("wantedCallbackID")] 
		public CHandle<redCallbackObject> WantedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(14)] 
		[RED("attentionAnimProxy")] 
		public CHandle<inkanimProxy> AttentionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(15)] 
		[RED("bountyStarAnimProxy")] 
		public CArray<CHandle<inkanimProxy>> BountyStarAnimProxy
		{
			get => GetPropertyValue<CArray<CHandle<inkanimProxy>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimProxy>>>(value);
		}

		[Ordinal(16)] 
		[RED("bountyAnimProxy")] 
		public CHandle<inkanimProxy> BountyAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(17)] 
		[RED("animOptionsLoop")] 
		public inkanimPlaybackOptions AnimOptionsLoop
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(18)] 
		[RED("numOfStar")] 
		public CInt32 NumOfStar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("wantedLevel")] 
		public CInt32 WantedLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("WANTED_TIER_1")] 
		public CFloat WANTED_TIER_1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("WANTED_MIN")] 
		public CFloat WANTED_MIN
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public WantedBarGameController()
		{
			StarsWidget = new();
			BountyStarAnimProxy = new();
			AnimOptionsLoop = new();
			WANTED_TIER_1 = 1.000000F;
			WANTED_MIN = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
