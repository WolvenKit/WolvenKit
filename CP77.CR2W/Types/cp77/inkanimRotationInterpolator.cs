using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimRotationInterpolator : inkanimInterpolator
	{
		[Ordinal(0)]  [RED("endValue")] public CFloat EndValue { get; set; }
		[Ordinal(1)]  [RED("goShortPath")] public CBool GoShortPath { get; set; }
		[Ordinal(2)]  [RED("startValue")] public CFloat StartValue { get; set; }

		public inkanimRotationInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
