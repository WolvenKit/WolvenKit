using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RuntimeSwitch : animAnimNode_Base
	{
		[Ordinal(11)] [RED("condition")] public CHandle<animIRuntimeCondition> Condition { get; set; }
		[Ordinal(12)] [RED("True")] public animPoseLink True { get; set; }
		[Ordinal(13)] [RED("False")] public animPoseLink False { get; set; }

		public animAnimNode_RuntimeSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
