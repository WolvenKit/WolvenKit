using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_RestrictMovementToArea : questCombatNodeParams
	{
		[Ordinal(0)] [RED("area")] public NodeRef Area { get; set; }

		public questCombatNodeParams_RestrictMovementToArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
