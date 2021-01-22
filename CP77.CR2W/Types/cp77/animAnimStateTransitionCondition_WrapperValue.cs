using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_WrapperValue : animIAnimStateTransitionCondition
	{
		[Ordinal(0)]  [RED("checkIfWrapperIsSet")] public CBool CheckIfWrapperIsSet { get; set; }
		[Ordinal(1)]  [RED("wrapperName")] public CName WrapperName { get; set; }

		public animAnimStateTransitionCondition_WrapperValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
