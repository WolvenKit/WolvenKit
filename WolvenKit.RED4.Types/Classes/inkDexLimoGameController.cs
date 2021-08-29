using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkDexLimoGameController : gameuiWidgetGameController
	{
		private CWeakHandle<gameIBlackboard> _activeVehicleBlackboard;
		private CHandle<redCallbackObject> _playerVehStateId;
		private CWeakHandle<inkVideoWidget> _screenVideoWidget;
		private CName _screenVideoWidgetPath;
		private redResourceReferenceScriptToken _videoPath;

		[Ordinal(2)] 
		[RED("activeVehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleBlackboard
		{
			get => GetProperty(ref _activeVehicleBlackboard);
			set => SetProperty(ref _activeVehicleBlackboard, value);
		}

		[Ordinal(3)] 
		[RED("playerVehStateId")] 
		public CHandle<redCallbackObject> PlayerVehStateId
		{
			get => GetProperty(ref _playerVehStateId);
			set => SetProperty(ref _playerVehStateId, value);
		}

		[Ordinal(4)] 
		[RED("screenVideoWidget")] 
		public CWeakHandle<inkVideoWidget> ScreenVideoWidget
		{
			get => GetProperty(ref _screenVideoWidget);
			set => SetProperty(ref _screenVideoWidget, value);
		}

		[Ordinal(5)] 
		[RED("screenVideoWidgetPath")] 
		public CName ScreenVideoWidgetPath
		{
			get => GetProperty(ref _screenVideoWidgetPath);
			set => SetProperty(ref _screenVideoWidgetPath, value);
		}

		[Ordinal(6)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get => GetProperty(ref _videoPath);
			set => SetProperty(ref _videoPath, value);
		}
	}
}
