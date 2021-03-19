using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameGenerationRule : IScriptable
	{
		private wCHandle<gameuiHackingMinigameGameController> _minigameController;
		private CHandle<gameBlackboardSystem> _blackboardSystem;
		private wCHandle<entEntity> _entity;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<gamedataMinigame_Def_Record> _minigameRecord;
		private CInt32 _bufferSize;
		private CBool _isItemBreach;

		[Ordinal(0)] 
		[RED("minigameController")] 
		public wCHandle<gameuiHackingMinigameGameController> MinigameController
		{
			get => GetProperty(ref _minigameController);
			set => SetProperty(ref _minigameController, value);
		}

		[Ordinal(1)] 
		[RED("blackboardSystem")] 
		public CHandle<gameBlackboardSystem> BlackboardSystem
		{
			get => GetProperty(ref _blackboardSystem);
			set => SetProperty(ref _blackboardSystem, value);
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(4)] 
		[RED("minigameRecord")] 
		public wCHandle<gamedataMinigame_Def_Record> MinigameRecord
		{
			get => GetProperty(ref _minigameRecord);
			set => SetProperty(ref _minigameRecord, value);
		}

		[Ordinal(5)] 
		[RED("bufferSize")] 
		public CInt32 BufferSize
		{
			get => GetProperty(ref _bufferSize);
			set => SetProperty(ref _bufferSize, value);
		}

		[Ordinal(6)] 
		[RED("isItemBreach")] 
		public CBool IsItemBreach
		{
			get => GetProperty(ref _isItemBreach);
			set => SetProperty(ref _isItemBreach, value);
		}

		public gameuiMinigameGenerationRule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
