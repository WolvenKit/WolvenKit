using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDexLimoGameController : gameuiWidgetGameController
	{
		private CHandle<gameIBlackboard> _activeVehicleBlackboard;
		private CUInt32 _playerVehStateId;
		private wCHandle<inkVideoWidget> _screenVideoWidget;
		private CName _screenVideoWidgetPath;
		private redResourceReferenceScriptToken _videoPath;

		[Ordinal(2)] 
		[RED("activeVehicleBlackboard")] 
		public CHandle<gameIBlackboard> ActiveVehicleBlackboard
		{
			get => GetProperty(ref _activeVehicleBlackboard);
			set => SetProperty(ref _activeVehicleBlackboard, value);
		}

		[Ordinal(3)] 
		[RED("playerVehStateId")] 
		public CUInt32 PlayerVehStateId
		{
			get => GetProperty(ref _playerVehStateId);
			set => SetProperty(ref _playerVehStateId, value);
		}

		[Ordinal(4)] 
		[RED("screenVideoWidget")] 
		public wCHandle<inkVideoWidget> ScreenVideoWidget
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

		public inkDexLimoGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
