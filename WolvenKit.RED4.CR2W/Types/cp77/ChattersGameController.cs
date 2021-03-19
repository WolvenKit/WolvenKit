using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChattersGameController : BaseSubtitlesGameController
	{
		private CFloat _c_DisplayRange;
		private CFloat _c_CloseDisplayRange;
		private CFloat _c_TimeToUnblockSec;
		private wCHandle<inkCompoundWidget> _rootWidget;
		private CArray<ChatterKeyValuePair> _allControllers;
		private CHandle<gametargetingTargetingSystem> _targetingSystem;
		private CArray<CRUID> _broadcastBlockingLines;
		private CBool _playerInDialogChoice;
		private EngineTime _lastBroadcastBlockingLineTime;
		private EngineTime _lastChoiceTime;
		private CUInt32 _bbPSceneTierEventId;
		private CInt32 _sceneTier;

		[Ordinal(28)] 
		[RED("c_DisplayRange")] 
		public CFloat C_DisplayRange
		{
			get => GetProperty(ref _c_DisplayRange);
			set => SetProperty(ref _c_DisplayRange, value);
		}

		[Ordinal(29)] 
		[RED("c_CloseDisplayRange")] 
		public CFloat C_CloseDisplayRange
		{
			get => GetProperty(ref _c_CloseDisplayRange);
			set => SetProperty(ref _c_CloseDisplayRange, value);
		}

		[Ordinal(30)] 
		[RED("c_TimeToUnblockSec")] 
		public CFloat C_TimeToUnblockSec
		{
			get => GetProperty(ref _c_TimeToUnblockSec);
			set => SetProperty(ref _c_TimeToUnblockSec, value);
		}

		[Ordinal(31)] 
		[RED("rootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(32)] 
		[RED("AllControllers")] 
		public CArray<ChatterKeyValuePair> AllControllers
		{
			get => GetProperty(ref _allControllers);
			set => SetProperty(ref _allControllers, value);
		}

		[Ordinal(33)] 
		[RED("targetingSystem")] 
		public CHandle<gametargetingTargetingSystem> TargetingSystem
		{
			get => GetProperty(ref _targetingSystem);
			set => SetProperty(ref _targetingSystem, value);
		}

		[Ordinal(34)] 
		[RED("broadcastBlockingLines")] 
		public CArray<CRUID> BroadcastBlockingLines
		{
			get => GetProperty(ref _broadcastBlockingLines);
			set => SetProperty(ref _broadcastBlockingLines, value);
		}

		[Ordinal(35)] 
		[RED("playerInDialogChoice")] 
		public CBool PlayerInDialogChoice
		{
			get => GetProperty(ref _playerInDialogChoice);
			set => SetProperty(ref _playerInDialogChoice, value);
		}

		[Ordinal(36)] 
		[RED("lastBroadcastBlockingLineTime")] 
		public EngineTime LastBroadcastBlockingLineTime
		{
			get => GetProperty(ref _lastBroadcastBlockingLineTime);
			set => SetProperty(ref _lastBroadcastBlockingLineTime, value);
		}

		[Ordinal(37)] 
		[RED("lastChoiceTime")] 
		public EngineTime LastChoiceTime
		{
			get => GetProperty(ref _lastChoiceTime);
			set => SetProperty(ref _lastChoiceTime, value);
		}

		[Ordinal(38)] 
		[RED("bbPSceneTierEventId")] 
		public CUInt32 BbPSceneTierEventId
		{
			get => GetProperty(ref _bbPSceneTierEventId);
			set => SetProperty(ref _bbPSceneTierEventId, value);
		}

		[Ordinal(39)] 
		[RED("sceneTier")] 
		public CInt32 SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		public ChattersGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
