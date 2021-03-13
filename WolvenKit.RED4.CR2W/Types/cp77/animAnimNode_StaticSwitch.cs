using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StaticSwitch : animAnimNode_MotionTableSwitch
	{
		[Ordinal(11)] [RED("condition")] public CHandle<animIStaticCondition> Condition { get; set; }
		[Ordinal(12)] [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }
		[Ordinal(13)] [RED("True")] public animPoseLink True { get; set; }
		[Ordinal(14)] [RED("False")] public animPoseLink False { get; set; }

		public animAnimNode_StaticSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
