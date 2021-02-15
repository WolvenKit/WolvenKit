using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimColorInterpolator : inkanimInterpolator
	{
		[Ordinal(7)] [RED("startValue")] public HDRColor StartValue { get; set; }
		[Ordinal(8)] [RED("endValue")] public HDRColor EndValue { get; set; }

		public inkanimColorInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
