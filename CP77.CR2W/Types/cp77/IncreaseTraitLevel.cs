using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IncreaseTraitLevel : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("trait")] public CEnum<gamedataTraitType> Trait { get; set; }

		public IncreaseTraitLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
