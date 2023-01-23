using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DebugNpcNameplateGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] 
		[RED("isToggledOn")] 
		public CBool IsToggledOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("uiBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("bbNPCStatsInfo")] 
		public CHandle<redCallbackObject> BbNPCStatsInfo
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("nameplateProjection")] 
		public CHandle<inkScreenProjection> NameplateProjection
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		[Ordinal(13)] 
		[RED("bufferedNPC")] 
		public CWeakHandle<gameObject> BufferedNPC
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("debugText1")] 
		public CWeakHandle<inkTextWidget> DebugText1
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(16)] 
		[RED("debugText2")] 
		public CWeakHandle<inkTextWidget> DebugText2
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		public DebugNpcNameplateGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
