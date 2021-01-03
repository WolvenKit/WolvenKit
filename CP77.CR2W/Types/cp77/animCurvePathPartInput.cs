using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animCurvePathPartInput : CVariable
	{
		[Ordinal(0)]  [RED("controllerName")] public CName ControllerName { get; set; }
		[Ordinal(1)]  [RED("curveLengthEnd")] public CFloat CurveLengthEnd { get; set; }
		[Ordinal(2)]  [RED("curveLengthStart")] public CFloat CurveLengthStart { get; set; }
		[Ordinal(3)]  [RED("eventNameEnd")] public CName EventNameEnd { get; set; }
		[Ordinal(4)]  [RED("eventNameStart")] public CName EventNameStart { get; set; }
		[Ordinal(5)]  [RED("startBlendTime")] public CFloat StartBlendTime { get; set; }

		public animCurvePathPartInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
