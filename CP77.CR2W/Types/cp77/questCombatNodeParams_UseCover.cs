using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_UseCover : questCombatNodeParams
	{
		[Ordinal(0)]  [RED("cover")] public NodeRef Cover { get; set; }
		[Ordinal(1)]  [RED("forceStance")] public CArray<CEnum<AICoverExposureMethod>> ForceStance { get; set; }
		[Ordinal(2)]  [RED("forcedEntryAnimation")] public CName ForcedEntryAnimation { get; set; }
		[Ordinal(3)]  [RED("immediately")] public CBool Immediately { get; set; }
		[Ordinal(4)]  [RED("oneTimeSelection")] public CBool OneTimeSelection { get; set; }

		public questCombatNodeParams_UseCover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
