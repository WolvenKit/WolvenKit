using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntEdgeGreaterFromZeroFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		[Ordinal(0)]  [RED("greaterThenValue")] public CInt32 GreaterThenValue { get; set; }

		public animAnimStateTransitionCondition_IntEdgeGreaterFromZeroFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
