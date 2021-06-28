using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugNpcNameplateGameController : gameuiProjectedHUDGameController
	{
		private CBool _isToggledOn;
		private CHandle<gameIBlackboard> _uiBlackboard;
		private CUInt32 _bbNPCStatsInfo;
		private CHandle<inkScreenProjection> _nameplateProjection;
		private wCHandle<gameObject> _bufferedNPC;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkTextWidget> _debugText1;
		private wCHandle<inkTextWidget> _debugText2;

		[Ordinal(9)] 
		[RED("isToggledOn")] 
		public CBool IsToggledOn
		{
			get => GetProperty(ref _isToggledOn);
			set => SetProperty(ref _isToggledOn, value);
		}

		[Ordinal(10)] 
		[RED("uiBlackboard")] 
		public CHandle<gameIBlackboard> UiBlackboard
		{
			get => GetProperty(ref _uiBlackboard);
			set => SetProperty(ref _uiBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("bbNPCStatsInfo")] 
		public CUInt32 BbNPCStatsInfo
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
		public wCHandle<gameObject> BufferedNPC
		{
			get => GetProperty(ref _bufferedNPC);
			set => SetProperty(ref _bufferedNPC, value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(15)] 
		[RED("debugText1")] 
		public wCHandle<inkTextWidget> DebugText1
		{
			get => GetProperty(ref _debugText1);
			set => SetProperty(ref _debugText1, value);
		}

		[Ordinal(16)] 
		[RED("debugText2")] 
		public wCHandle<inkTextWidget> DebugText2
		{
			get => GetProperty(ref _debugText2);
			set => SetProperty(ref _debugText2, value);
		}

		public DebugNpcNameplateGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
