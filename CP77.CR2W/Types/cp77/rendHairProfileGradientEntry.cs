using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendHairProfileGradientEntry : ISerializable
	{
		[Ordinal(0)] [RED("value")] public CFloat Value { get; set; }
		[Ordinal(1)] [RED("color")] public CColor Color { get; set; }

		public rendHairProfileGradientEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
