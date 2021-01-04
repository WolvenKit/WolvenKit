using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePlayerSpawnParams : CVariable
	{
		[Ordinal(0)]  [RED("gender")] public CName Gender { get; set; }
		[Ordinal(1)]  [RED("isSpectator")] public CBool IsSpectator { get; set; }
		[Ordinal(2)]  [RED("nickname")] public CString Nickname { get; set; }
		[Ordinal(3)]  [RED("recordId")] public TweakDBID RecordId { get; set; }
		[Ordinal(4)]  [RED("spawnPoint")] public Transform SpawnPoint { get; set; }
		[Ordinal(5)]  [RED("spawnTags")] public redTagList SpawnTags { get; set; }
		[Ordinal(6)]  [RED("useSpecifiedStartPoint")] public CBool UseSpecifiedStartPoint { get; set; }

		public gamePlayerSpawnParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
