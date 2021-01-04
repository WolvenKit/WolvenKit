using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StaticSwitch : animAnimNode_MotionTableSwitch
	{
		[Ordinal(0)]  [RED("False")] public animPoseLink False { get; set; }
		[Ordinal(1)]  [RED("True")] public animPoseLink True { get; set; }
		[Ordinal(2)]  [RED("condition")] public CHandle<animIStaticCondition> Condition { get; set; }
		[Ordinal(3)]  [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }

		public animAnimNode_StaticSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
