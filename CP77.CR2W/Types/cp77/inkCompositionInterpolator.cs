using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkCompositionInterpolator : CVariable
	{
		[Ordinal(0)]  [RED("parameter")] public CName Parameter { get; set; }
		[Ordinal(1)]  [RED("startDelay")] public CFloat StartDelay { get; set; }
		[Ordinal(2)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)]  [RED("interpolationMode")] public CEnum<inkanimInterpolationMode> InterpolationMode { get; set; }
		[Ordinal(4)]  [RED("interpolationType")] public CEnum<inkanimInterpolationType> InterpolationType { get; set; }

		public inkCompositionInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
