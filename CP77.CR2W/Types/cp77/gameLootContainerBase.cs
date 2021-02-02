using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameLootContainerBase : gameObject
	{
		[Ordinal(0)]  [RED("lootTables")] public CArray<TweakDBID> LootTables { get; set; }
		[Ordinal(1)]  [RED("useAreaLoot")] public CBool UseAreaLoot { get; set; }
		[Ordinal(2)]  [RED("contentAssignment")] public TweakDBID ContentAssignment { get; set; }
		[Ordinal(3)]  [RED("isIllegal")] public CBool IsIllegal { get; set; }

		public gameLootContainerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
