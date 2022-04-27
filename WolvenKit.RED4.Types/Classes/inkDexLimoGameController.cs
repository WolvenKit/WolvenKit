using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkDexLimoGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("activeVehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(3)] 
		[RED("playerVehStateId")] 
		public CHandle<redCallbackObject> PlayerVehStateId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(4)] 
		[RED("screenVideoWidget")] 
		public CWeakHandle<inkVideoWidget> ScreenVideoWidget
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("screenVideoWidgetPath")] 
		public CName ScreenVideoWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public inkDexLimoGameController()
		{
			VideoPath = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
