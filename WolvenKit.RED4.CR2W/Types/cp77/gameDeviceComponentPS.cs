using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDeviceComponentPS : gameComponentPS
	{
		private CBool _markAsQuest;
		private CBool _autoToggleQuestMark;
		private CName _factToDisableQuestMark;
		private CUInt32 _callbackToDisableQuestMarkID;
		private CHandle<BackDoorObjectiveData> _backdoorObjectiveData;
		private CHandle<ControlPanelObjectiveData> _controlPanelObjectiveData;
		private wCHandle<gameIBlackboard> _blackboard;
		private CBool _isScanned;
		private CBool _isBeingScanned;
		private CBool _exposeQuickHacks;
		private CBool _isAttachedToGame;
		private CBool _isLogicReady;

		[Ordinal(0)] 
		[RED("markAsQuest")] 
		public CBool MarkAsQuest
		{
			get => GetProperty(ref _markAsQuest);
			set => SetProperty(ref _markAsQuest, value);
		}

		[Ordinal(1)] 
		[RED("autoToggleQuestMark")] 
		public CBool AutoToggleQuestMark
		{
			get => GetProperty(ref _autoToggleQuestMark);
			set => SetProperty(ref _autoToggleQuestMark, value);
		}

		[Ordinal(2)] 
		[RED("factToDisableQuestMark")] 
		public CName FactToDisableQuestMark
		{
			get => GetProperty(ref _factToDisableQuestMark);
			set => SetProperty(ref _factToDisableQuestMark, value);
		}

		[Ordinal(3)] 
		[RED("callbackToDisableQuestMarkID")] 
		public CUInt32 CallbackToDisableQuestMarkID
		{
			get => GetProperty(ref _callbackToDisableQuestMarkID);
			set => SetProperty(ref _callbackToDisableQuestMarkID, value);
		}

		[Ordinal(4)] 
		[RED("backdoorObjectiveData")] 
		public CHandle<BackDoorObjectiveData> BackdoorObjectiveData
		{
			get => GetProperty(ref _backdoorObjectiveData);
			set => SetProperty(ref _backdoorObjectiveData, value);
		}

		[Ordinal(5)] 
		[RED("controlPanelObjectiveData")] 
		public CHandle<ControlPanelObjectiveData> ControlPanelObjectiveData
		{
			get => GetProperty(ref _controlPanelObjectiveData);
			set => SetProperty(ref _controlPanelObjectiveData, value);
		}

		[Ordinal(6)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(7)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetProperty(ref _isScanned);
			set => SetProperty(ref _isScanned, value);
		}

		[Ordinal(8)] 
		[RED("isBeingScanned")] 
		public CBool IsBeingScanned
		{
			get => GetProperty(ref _isBeingScanned);
			set => SetProperty(ref _isBeingScanned, value);
		}

		[Ordinal(9)] 
		[RED("exposeQuickHacks")] 
		public CBool ExposeQuickHacks
		{
			get => GetProperty(ref _exposeQuickHacks);
			set => SetProperty(ref _exposeQuickHacks, value);
		}

		[Ordinal(10)] 
		[RED("isAttachedToGame")] 
		public CBool IsAttachedToGame
		{
			get => GetProperty(ref _isAttachedToGame);
			set => SetProperty(ref _isAttachedToGame, value);
		}

		[Ordinal(11)] 
		[RED("isLogicReady")] 
		public CBool IsLogicReady
		{
			get => GetProperty(ref _isLogicReady);
			set => SetProperty(ref _isLogicReady, value);
		}

		public gameDeviceComponentPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
