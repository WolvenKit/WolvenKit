using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_Spread : gameEffectExecutor_Scripted
	{
		private CWeakHandle<gamedataObjectAction_Record> _objectActionRecord;
		private CWeakHandle<entEntity> _prevEntity;
		private CWeakHandle<PlayerPuppet> _player;
		private CBool _spreadToAllTargetsInTheArea;

		[Ordinal(1)] 
		[RED("objectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}

		[Ordinal(2)] 
		[RED("prevEntity")] 
		public CWeakHandle<entEntity> PrevEntity
		{
			get => GetProperty(ref _prevEntity);
			set => SetProperty(ref _prevEntity, value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(4)] 
		[RED("spreadToAllTargetsInTheArea")] 
		public CBool SpreadToAllTargetsInTheArea
		{
			get => GetProperty(ref _spreadToAllTargetsInTheArea);
			set => SetProperty(ref _spreadToAllTargetsInTheArea, value);
		}
	}
}
