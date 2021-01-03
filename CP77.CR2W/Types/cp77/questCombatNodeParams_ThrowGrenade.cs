using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_ThrowGrenade : questCombatNodeParams
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("immediately")] public CBool Immediately { get; set; }
		[Ordinal(2)]  [RED("once")] public CBool Once { get; set; }
		[Ordinal(3)]  [RED("targetOverrideNode")] public NodeRef TargetOverrideNode { get; set; }
		[Ordinal(4)]  [RED("targetOverridePuppet")] public gameEntityReference TargetOverridePuppet { get; set; }

		public questCombatNodeParams_ThrowGrenade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
