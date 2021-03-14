using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeSpeedChangeSection : CVariable
	{
		[Ordinal(0)] [RED("start")] public CFloat Start { get; set; }
		[Ordinal(1)] [RED("end")] public CFloat End { get; set; }
		[Ordinal(2)] [RED("targetSpeed_M_P_S")] public CFloat TargetSpeed_M_P_S { get; set; }

		public worldSpeedSplineNodeSpeedChangeSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
