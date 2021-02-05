using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemEmissive : effectTrackItem
	{
		[Ordinal(0)]  [RED("override")] public CBool Override { get; set; }
		[Ordinal(1)]  [RED("brigtness")] public effectEffectParameterEvaluatorFloat Brigtness { get; set; }

		public effectTrackItemEmissive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
