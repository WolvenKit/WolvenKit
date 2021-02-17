using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animIKTargetRequest : CVariable
	{
		[Ordinal(0)] [RED("weightPosition")] public CFloat WeightPosition { get; set; }
		[Ordinal(1)] [RED("weightOrientation")] public CFloat WeightOrientation { get; set; }
		[Ordinal(2)] [RED("transitionIn")] public CFloat TransitionIn { get; set; }
		[Ordinal(3)] [RED("transitionOut")] public CFloat TransitionOut { get; set; }
		[Ordinal(4)] [RED("priority")] public CInt32 Priority { get; set; }

		public animIKTargetRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
