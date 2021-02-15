using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SpecialProperties : CVariable
	{
		[Ordinal(0)] [RED("enemyMarker")] public CBool EnemyMarker { get; set; }
		[Ordinal(1)] [RED("traps")] public CArray<CEnum<ETrap>> Traps { get; set; }

		public SpecialProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
