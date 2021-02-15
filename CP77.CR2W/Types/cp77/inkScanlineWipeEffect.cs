using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkScanlineWipeEffect : inkIEffect
	{
		[Ordinal(2)] [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(3)] [RED("transition")] public CFloat Transition { get; set; }
		[Ordinal(4)] [RED("width")] public CFloat Width { get; set; }

		public inkScanlineWipeEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
