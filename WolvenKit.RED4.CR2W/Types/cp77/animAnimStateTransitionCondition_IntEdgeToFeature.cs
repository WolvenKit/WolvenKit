using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntEdgeToFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		[Ordinal(2)] [RED("toValue")] public CInt32 ToValue { get; set; }

		public animAnimStateTransitionCondition_IntEdgeToFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
