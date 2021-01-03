using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_RestrictMovementToArea : questCombatNodeParams
	{
		[Ordinal(0)]  [RED("area")] public NodeRef Area { get; set; }

		public questCombatNodeParams_RestrictMovementToArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
