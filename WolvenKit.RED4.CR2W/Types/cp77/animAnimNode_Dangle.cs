using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Dangle : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("dangleConstraint")] public CHandle<animDangleConstraint_Simulation> DangleConstraint { get; set; }

		public animAnimNode_Dangle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
