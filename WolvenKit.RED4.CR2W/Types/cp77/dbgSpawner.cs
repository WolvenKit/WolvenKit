using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class dbgSpawner : gameObject
	{
		[Ordinal(40)] [RED("objectRecordId")] public TweakDBID ObjectRecordId { get; set; }
		[Ordinal(41)] [RED("appearance")] public CName Appearance { get; set; }
		[Ordinal(42)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(43)] [RED("alwaysSpawned")] public CEnum<gameAlwaysSpawnedState> AlwaysSpawned { get; set; }

		public dbgSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
