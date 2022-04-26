using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class grsDeathmatchPlayerGameInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("peerID")] 
		public netPeerID PeerID
		{
			get => GetPropertyValue<netPeerID>();
			set => SetPropertyValue<netPeerID>(value);
		}

		[Ordinal(1)] 
		[RED("isInGame")] 
		public CBool IsInGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("spawnTime")] 
		public netTime SpawnTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(4)] 
		[RED("killCount")] 
		public CUInt32 KillCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("deathCount")] 
		public CUInt32 DeathCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("lastShooter")] 
		public netPeerID LastShooter
		{
			get => GetPropertyValue<netPeerID>();
			set => SetPropertyValue<netPeerID>(value);
		}

		public grsDeathmatchPlayerGameInfo()
		{
			PeerID = new() { Value = 255 };
			SpawnTime = new();
			LastShooter = new() { Value = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
