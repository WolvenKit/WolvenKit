using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkColorCorrectionEffect : inkIEffect
	{
		[Ordinal(0)]  [RED("brightness")] public CFloat Brightness { get; set; }
		[Ordinal(1)]  [RED("contrast")] public CFloat Contrast { get; set; }
		[Ordinal(2)]  [RED("saturation")] public CFloat Saturation { get; set; }

		public inkColorCorrectionEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
