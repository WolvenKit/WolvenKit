using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimShapeBorderTransparencyInterpolator : inkanimInterpolator
	{
		[Ordinal(0)]  [RED("startValue")] public CFloat StartValue { get; set; }
		[Ordinal(1)]  [RED("endValue")] public CFloat EndValue { get; set; }

		public inkanimShapeBorderTransparencyInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
