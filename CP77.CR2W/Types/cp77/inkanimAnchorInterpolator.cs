using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimAnchorInterpolator : inkanimInterpolator
	{
		[Ordinal(0)]  [RED("startValue")] public Vector2 StartValue { get; set; }
		[Ordinal(1)]  [RED("endValue")] public Vector2 EndValue { get; set; }

		public inkanimAnchorInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
