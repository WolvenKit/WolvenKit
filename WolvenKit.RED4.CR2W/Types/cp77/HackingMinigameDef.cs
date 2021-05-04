using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HackingMinigameDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _minigameDefaults;
		private gamebbScriptID_Variant _nextMinigameData;
		private gamebbScriptID_Bool _skipSummaryScreen;
		private gamebbScriptID_Variant _playerPrograms;
		private gamebbScriptID_Variant _activePrograms;
		private gamebbScriptID_Variant _activeTraps;
		private gamebbScriptID_Int32 _state;
		private gamebbScriptID_Variant _entity;
		private gamebbScriptID_Bool _isJournalTarget;

		[Ordinal(0)] 
		[RED("MinigameDefaults")] 
		public gamebbScriptID_Variant MinigameDefaults
		{
			get => GetProperty(ref _minigameDefaults);
			set => SetProperty(ref _minigameDefaults, value);
		}

		[Ordinal(1)] 
		[RED("NextMinigameData")] 
		public gamebbScriptID_Variant NextMinigameData
		{
			get => GetProperty(ref _nextMinigameData);
			set => SetProperty(ref _nextMinigameData, value);
		}

		[Ordinal(2)] 
		[RED("SkipSummaryScreen")] 
		public gamebbScriptID_Bool SkipSummaryScreen
		{
			get => GetProperty(ref _skipSummaryScreen);
			set => SetProperty(ref _skipSummaryScreen, value);
		}

		[Ordinal(3)] 
		[RED("PlayerPrograms")] 
		public gamebbScriptID_Variant PlayerPrograms
		{
			get => GetProperty(ref _playerPrograms);
			set => SetProperty(ref _playerPrograms, value);
		}

		[Ordinal(4)] 
		[RED("ActivePrograms")] 
		public gamebbScriptID_Variant ActivePrograms
		{
			get => GetProperty(ref _activePrograms);
			set => SetProperty(ref _activePrograms, value);
		}

		[Ordinal(5)] 
		[RED("ActiveTraps")] 
		public gamebbScriptID_Variant ActiveTraps
		{
			get => GetProperty(ref _activeTraps);
			set => SetProperty(ref _activeTraps, value);
		}

		[Ordinal(6)] 
		[RED("State")] 
		public gamebbScriptID_Int32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(7)] 
		[RED("Entity")] 
		public gamebbScriptID_Variant Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(8)] 
		[RED("IsJournalTarget")] 
		public gamebbScriptID_Bool IsJournalTarget
		{
			get => GetProperty(ref _isJournalTarget);
			set => SetProperty(ref _isJournalTarget, value);
		}

		public HackingMinigameDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
