using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkMaskEffect : inkIEffect
	{
		[Ordinal(2)] [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(3)] [RED("opacity")] public CFloat Opacity { get; set; }
		[Ordinal(4)] [RED("invert")] public CBool Invert { get; set; }

		public inkMaskEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
