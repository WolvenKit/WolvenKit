using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMinigameGenerationRule : IScriptable
	{
		private CWeakHandle<gameuiHackingMinigameGameController> _minigameController;
		private CHandle<gameBlackboardSystem> _blackboardSystem;
		private CWeakHandle<entEntity> _entity;
		private CWeakHandle<PlayerPuppet> _player;
		private CWeakHandle<gamedataMinigame_Def_Record> _minigameRecord;
		private CInt32 _bufferSize;
		private CBool _isItemBreach;

		[Ordinal(0)] 
		[RED("minigameController")] 
		public CWeakHandle<gameuiHackingMinigameGameController> MinigameController
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
		public CWeakHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(4)] 
		[RED("minigameRecord")] 
		public CWeakHandle<gamedataMinigame_Def_Record> MinigameRecord
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
	}
}
