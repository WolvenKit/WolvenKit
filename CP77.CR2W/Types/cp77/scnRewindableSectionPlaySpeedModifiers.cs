using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnRewindableSectionPlaySpeedModifiers : CVariable
	{
		[Ordinal(0)]  [RED("backwardFast")] public CFloat BackwardFast { get; set; }
		[Ordinal(1)]  [RED("backwardSlow")] public CFloat BackwardSlow { get; set; }
		[Ordinal(2)]  [RED("backwardVeryFast")] public CFloat BackwardVeryFast { get; set; }
		[Ordinal(3)]  [RED("forwardFast")] public CFloat ForwardFast { get; set; }
		[Ordinal(4)]  [RED("forwardSlow")] public CFloat ForwardSlow { get; set; }
		[Ordinal(5)]  [RED("forwardVeryFast")] public CFloat ForwardVeryFast { get; set; }

		public scnRewindableSectionPlaySpeedModifiers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
