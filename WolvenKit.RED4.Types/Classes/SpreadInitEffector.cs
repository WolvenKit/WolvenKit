using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpreadInitEffector : gameEffector
	{
		private CWeakHandle<gamedataObjectAction_Record> _objectActionRecord;
		private CHandle<gamedataSpreadInitEffector_Record> _effectorRecord;
		private CWeakHandle<PlayerPuppet> _player;

		[Ordinal(0)] 
		[RED("objectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}

		[Ordinal(1)] 
		[RED("effectorRecord")] 
		public CHandle<gamedataSpreadInitEffector_Record> EffectorRecord
		{
			get => GetProperty(ref _effectorRecord);
			set => SetProperty(ref _effectorRecord, value);
		}

		[Ordinal(2)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}
	}
}
