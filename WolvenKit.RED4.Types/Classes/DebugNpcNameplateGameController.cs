using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DebugNpcNameplateGameController : gameuiProjectedHUDGameController
	{
		private CBool _isToggledOn;
		private CWeakHandle<gameIBlackboard> _uiBlackboard;
		private CHandle<redCallbackObject> _bbNPCStatsInfo;
		private CHandle<inkScreenProjection> _nameplateProjection;
		private CWeakHandle<gameObject> _bufferedNPC;
		private CWeakHandle<inkWidget> _rootWidget;
		private CWeakHandle<inkTextWidget> _debugText1;
		private CWeakHandle<inkTextWidget> _debugText2;

		[Ordinal(9)] 
		[RED("isToggledOn")] 
		public CBool IsToggledOn
		{
			get => GetProperty(ref _isToggledOn);
			set => SetProperty(ref _isToggledOn, value);
		}

		[Ordinal(10)] 
		[RED("uiBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiBlackboard
		{
			get => GetProperty(ref _uiBlackboard);
			set => SetProperty(ref _uiBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("bbNPCStatsInfo")] 
		public CHandle<redCallbackObject> BbNPCStatsInfo
		{
			get => GetProperty(ref _bbNPCStatsInfo);
			set => SetProperty(ref _bbNPCStatsInfo, value);
		}

		[Ordinal(12)] 
		[RED("nameplateProjection")] 
		public CHandle<inkScreenProjection> NameplateProjection
		{
			get => GetProperty(ref _nameplateProjection);
			set => SetProperty(ref _nameplateProjection, value);
		}

		[Ordinal(13)] 
		[RED("bufferedNPC")] 
		public CWeakHandle<gameObject> BufferedNPC
		{
			get => GetProperty(ref _bufferedNPC);
			set => SetProperty(ref _bufferedNPC, value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(15)] 
		[RED("debugText1")] 
		public CWeakHandle<inkTextWidget> DebugText1
		{
			get => GetProperty(ref _debugText1);
			set => SetProperty(ref _debugText1, value);
		}

		[Ordinal(16)] 
		[RED("debugText2")] 
		public CWeakHandle<inkTextWidget> DebugText2
		{
			get => GetProperty(ref _debugText2);
			set => SetProperty(ref _debugText2, value);
		}
	}
}
