using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
