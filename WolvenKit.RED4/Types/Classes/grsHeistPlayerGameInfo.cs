using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class grsHeistPlayerGameInfo : RedBaseClass
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
		[RED("isReady")] 
		public CBool IsReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isRespawning")] 
		public CBool IsRespawning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("spawnTime")] 
		public netTime SpawnTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(6)] 
		[RED("killCount")] 
		public CUInt32 KillCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("deathCount")] 
		public CUInt32 DeathCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("characterRecord")] 
		public CString CharacterRecord
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public grsHeistPlayerGameInfo()
		{
			PeerID = new() { Value = 255 };
			SpawnTime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
