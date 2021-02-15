using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAnyStateTransitionEntry : CVariable
	{
		[Ordinal(0)] [RED("isDisabled")] public CBool IsDisabled { get; set; }
		[Ordinal(1)] [RED("sourceStateId")] public CUInt8 SourceStateId { get; set; }
		[Ordinal(2)] [RED("targetStateId")] public CUInt8 TargetStateId { get; set; }
		[Ordinal(3)] [RED("transitionTime")] public CFloat TransitionTime { get; set; }

		public audioAnyStateTransitionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
