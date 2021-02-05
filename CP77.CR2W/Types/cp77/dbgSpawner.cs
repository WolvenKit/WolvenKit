using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class dbgSpawner : gameObject
	{
		[Ordinal(31)]  [RED("appearance")] public CName Appearance { get; set; }
		[Ordinal(32)]  [RED("objectRecordId")] public TweakDBID ObjectRecordId { get; set; }
		[Ordinal(33)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(34)]  [RED("alwaysSpawned")] public CEnum<gameAlwaysSpawnedState> AlwaysSpawned { get; set; }

		public dbgSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
