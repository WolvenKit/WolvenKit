using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimMathExpressionFloatSocket : CVariable
	{
		[Ordinal(0)] [RED("link")] public animFloatLink Link { get; set; }
		[Ordinal(1)] [RED("expressionVarId")] public CUInt16 ExpressionVarId { get; set; }
		[Ordinal(2)] [RED("inputFloatTrack")] public animNamedTrackIndex InputFloatTrack { get; set; }

		public animAnimMathExpressionFloatSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
