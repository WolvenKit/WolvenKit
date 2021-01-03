using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Movement_CustomCurve : gameTransformAnimation_Movement
	{
		[Ordinal(0)]  [RED("curve")] public curveData<CFloat> Curve { get; set; }

		public gameTransformAnimation_Movement_CustomCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
