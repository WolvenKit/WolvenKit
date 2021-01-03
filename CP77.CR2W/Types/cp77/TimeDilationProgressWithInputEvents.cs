using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TimeDilationProgressWithInputEvents : TimeDilationEventsTransitions
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("easeInCurve")] public CName EaseInCurve { get; set; }
		[Ordinal(2)]  [RED("easeOutCurve")] public CName EaseOutCurve { get; set; }
		[Ordinal(3)]  [RED("lerpMultiplier")] public CFloat LerpMultiplier { get; set; }
		[Ordinal(4)]  [RED("previousTimeStamp")] public CFloat PreviousTimeStamp { get; set; }
		[Ordinal(5)]  [RED("targetTimeScale")] public CFloat TargetTimeScale { get; set; }

		public TimeDilationProgressWithInputEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
