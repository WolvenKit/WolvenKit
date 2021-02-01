using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class grsHeistPlayerGameInfo : CVariable
	{
		[Ordinal(0)]  [RED("characterRecord")] public CString CharacterRecord { get; set; }
		[Ordinal(1)]  [RED("deathCount")] public CUInt32 DeathCount { get; set; }
		[Ordinal(2)]  [RED("isDead")] public CBool IsDead { get; set; }
		[Ordinal(3)]  [RED("isInGame")] public CBool IsInGame { get; set; }
		[Ordinal(4)]  [RED("isReady")] public CBool IsReady { get; set; }
		[Ordinal(5)]  [RED("isRespawning")] public CBool IsRespawning { get; set; }
		[Ordinal(6)]  [RED("killCount")] public CUInt32 KillCount { get; set; }
		[Ordinal(7)]  [RED("peerID")] public netPeerID PeerID { get; set; }
		[Ordinal(8)]  [RED("spawnTime")] public netTime SpawnTime { get; set; }

		public grsHeistPlayerGameInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
