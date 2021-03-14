using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class grsHeistPlayerGameInfo : CVariable
	{
		[Ordinal(0)] [RED("peerID")] public netPeerID PeerID { get; set; }
		[Ordinal(1)] [RED("isInGame")] public CBool IsInGame { get; set; }
		[Ordinal(2)] [RED("isReady")] public CBool IsReady { get; set; }
		[Ordinal(3)] [RED("isRespawning")] public CBool IsRespawning { get; set; }
		[Ordinal(4)] [RED("isDead")] public CBool IsDead { get; set; }
		[Ordinal(5)] [RED("spawnTime")] public netTime SpawnTime { get; set; }
		[Ordinal(6)] [RED("killCount")] public CUInt32 KillCount { get; set; }
		[Ordinal(7)] [RED("deathCount")] public CUInt32 DeathCount { get; set; }
		[Ordinal(8)] [RED("characterRecord")] public CString CharacterRecord { get; set; }

		public grsHeistPlayerGameInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
