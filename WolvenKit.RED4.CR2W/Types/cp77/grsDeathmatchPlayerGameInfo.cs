using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class grsDeathmatchPlayerGameInfo : CVariable
	{
		private netPeerID _peerID;
		private CBool _isInGame;
		private CBool _isDead;
		private netTime _spawnTime;
		private CUInt32 _killCount;
		private CUInt32 _deathCount;
		private netPeerID _lastShooter;

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
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetProperty(ref _isDead);
			set => SetProperty(ref _isDead, value);
		}

		[Ordinal(3)] 
		[RED("spawnTime")] 
		public netTime SpawnTime
		{
			get => GetProperty(ref _spawnTime);
			set => SetProperty(ref _spawnTime, value);
		}

		[Ordinal(4)] 
		[RED("killCount")] 
		public CUInt32 KillCount
		{
			get => GetProperty(ref _killCount);
			set => SetProperty(ref _killCount, value);
		}

		[Ordinal(5)] 
		[RED("deathCount")] 
		public CUInt32 DeathCount
		{
			get => GetProperty(ref _deathCount);
			set => SetProperty(ref _deathCount, value);
		}

		[Ordinal(6)] 
		[RED("lastShooter")] 
		public netPeerID LastShooter
		{
			get => GetProperty(ref _lastShooter);
			set => SetProperty(ref _lastShooter, value);
		}

		public grsDeathmatchPlayerGameInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
