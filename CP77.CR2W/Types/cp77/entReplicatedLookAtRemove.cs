using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entReplicatedLookAtRemove : entReplicatedLookAtData
	{
		[Ordinal(0)]  [RED("hasOutTransition")] public CFloat HasOutTransition { get; set; }
		[Ordinal(1)]  [RED("outTransitionSpeed")] public CFloat OutTransitionSpeed { get; set; }
		[Ordinal(2)]  [RED("ref")] public animLookAtRef Ref { get; set; }

		public entReplicatedLookAtRemove(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
