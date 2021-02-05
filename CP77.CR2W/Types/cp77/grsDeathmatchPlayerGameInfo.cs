using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class grsDeathmatchPlayerGameInfo : CVariable
	{
		[Ordinal(0)]  [RED("peerID")] public netPeerID PeerID { get; set; }
		[Ordinal(1)]  [RED("isInGame")] public CBool IsInGame { get; set; }
		[Ordinal(2)]  [RED("isDead")] public CBool IsDead { get; set; }
		[Ordinal(3)]  [RED("spawnTime")] public netTime SpawnTime { get; set; }
		[Ordinal(4)]  [RED("killCount")] public CUInt32 KillCount { get; set; }
		[Ordinal(5)]  [RED("deathCount")] public CUInt32 DeathCount { get; set; }
		[Ordinal(6)]  [RED("lastShooter")] public netPeerID LastShooter { get; set; }

		public grsDeathmatchPlayerGameInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
