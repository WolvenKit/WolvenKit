using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeLoopCurveEvent : redEvent
	{
		[Ordinal(0)] [RED("loopTime")] public CFloat LoopTime { get; set; }
		[Ordinal(1)] [RED("loopCurve")] public CName LoopCurve { get; set; }

		public ChangeLoopCurveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
