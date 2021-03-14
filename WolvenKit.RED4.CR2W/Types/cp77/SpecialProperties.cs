using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpecialProperties : CVariable
	{
		[Ordinal(0)] [RED("enemyMarker")] public CBool EnemyMarker { get; set; }
		[Ordinal(1)] [RED("traps")] public CArray<CEnum<ETrap>> Traps { get; set; }

		public SpecialProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
