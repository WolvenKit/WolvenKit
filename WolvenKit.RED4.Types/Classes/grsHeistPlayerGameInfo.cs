using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class grsHeistPlayerGameInfo : RedBaseClass
	{
		private netPeerID _peerID;
		private CBool _isInGame;
		private CBool _isReady;
		private CBool _isRespawning;
		private CBool _isDead;
		private netTime _spawnTime;
		private CUInt32 _killCount;
		private CUInt32 _deathCount;
		private CString _characterRecord;

		[Ordinal(0)] 
		[RED("peerID")] 
		public netPeerID PeerID
		{
			get => GetProperty(ref _peerID);
			set => SetProperty(ref _peerID, value);
		}

		[Ordinal(1)] 
		[RED("isInGame")] 
		public CBool IsInGame
		{
			get => GetProperty(ref _isInGame);
			set => SetProperty(ref _isInGame, value);
		}

		[Ordinal(2)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get => GetProperty(ref _isReady);
			set => SetProperty(ref _isReady, value);
		}

		[Ordinal(3)] 
		[RED("isRespawning")] 
		public CBool IsRespawning
		{
			get => GetProperty(ref _isRespawning);
			set => SetProperty(ref _isRespawning, value);
		}

		[Ordinal(4)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetProperty(ref _isDead);
			set => SetProperty(ref _isDead, value);
		}

		[Ordinal(5)] 
		[RED("spawnTime")] 
		public netTime SpawnTime
		{
			get => GetProperty(ref _spawnTime);
			set => SetProperty(ref _spawnTime, value);
		}

		[Ordinal(6)] 
		[RED("killCount")] 
		public CUInt32 KillCount
		{
			get => GetProperty(ref _killCount);
			set => SetProperty(ref _killCount, value);
		}

		[Ordinal(7)] 
		[RED("deathCount")] 
		public CUInt32 DeathCount
		{
			get => GetProperty(ref _deathCount);
			set => SetProperty(ref _deathCount, value);
		}

		[Ordinal(8)] 
		[RED("characterRecord")] 
		public CString CharacterRecord
		{
			get => GetProperty(ref _characterRecord);
			set => SetProperty(ref _characterRecord, value);
		}
	}
}
