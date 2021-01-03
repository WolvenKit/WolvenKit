using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class dbgSpawner : gameObject
	{
		[Ordinal(0)]  [RED("alwaysSpawned")] public CEnum<gameAlwaysSpawnedState> AlwaysSpawned { get; set; }
		[Ordinal(1)]  [RED("appearance")] public CName Appearance { get; set; }
		[Ordinal(2)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(3)]  [RED("objectRecordId")] public TweakDBID ObjectRecordId { get; set; }

		public dbgSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
