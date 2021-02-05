using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnRewindableSectionPlaySpeedModifiers : CVariable
	{
		[Ordinal(0)]  [RED("forwardVeryFast")] public CFloat ForwardVeryFast { get; set; }
		[Ordinal(1)]  [RED("forwardFast")] public CFloat ForwardFast { get; set; }
		[Ordinal(2)]  [RED("forwardSlow")] public CFloat ForwardSlow { get; set; }
		[Ordinal(3)]  [RED("backwardVeryFast")] public CFloat BackwardVeryFast { get; set; }
		[Ordinal(4)]  [RED("backwardFast")] public CFloat BackwardFast { get; set; }
		[Ordinal(5)]  [RED("backwardSlow")] public CFloat BackwardSlow { get; set; }

		public scnRewindableSectionPlaySpeedModifiers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
