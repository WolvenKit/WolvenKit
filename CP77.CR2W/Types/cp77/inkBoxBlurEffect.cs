using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkBoxBlurEffect : inkIEffect
	{
		[Ordinal(2)] [RED("samples")] public CUInt8 Samples { get; set; }
		[Ordinal(3)] [RED("intensity")] public CFloat Intensity { get; set; }
		[Ordinal(4)] [RED("blurDimension")] public CEnum<inkEBlurDimension> BlurDimension { get; set; }

		public inkBoxBlurEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
