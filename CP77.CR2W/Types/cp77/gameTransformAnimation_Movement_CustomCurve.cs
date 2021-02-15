using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Movement_CustomCurve : gameTransformAnimation_Movement
	{
		[Ordinal(0)] [RED("curve")] public curveData<CFloat> Curve { get; set; }

		public gameTransformAnimation_Movement_CustomCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
