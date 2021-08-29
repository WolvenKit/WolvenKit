using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpreadEffector : gameEffector
	{
		private CWeakHandle<gamedataObjectAction_Record> _objectActionRecord;
		private CWeakHandle<PlayerPuppet> _player;
		private CHandle<gamedataSpreadEffector_Record> _effectorRecord;
		private CBool _spreadToAllTargetsInTheArea;

		[Ordinal(0)] 
		[RED("objectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}

		[Ordinal(1)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(2)] 
		[RED("effectorRecord")] 
		public CHandle<gamedataSpreadEffector_Record> EffectorRecord
		{
			get => GetProperty(ref _effectorRecord);
			set => SetProperty(ref _effectorRecord, value);
		}

		[Ordinal(3)] 
		[RED("spreadToAllTargetsInTheArea")] 
		public CBool SpreadToAllTargetsInTheArea
		{
			get => GetProperty(ref _spreadToAllTargetsInTheArea);
			set => SetProperty(ref _spreadToAllTargetsInTheArea, value);
		}
	}
}
