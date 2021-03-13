using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTimeDilationEffector : gameEffector
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)] [RED("reason")] public CName Reason { get; set; }
		[Ordinal(2)] [RED("easeInCurve")] public CName EaseInCurve { get; set; }
		[Ordinal(3)] [RED("easeOutCurve")] public CName EaseOutCurve { get; set; }
		[Ordinal(4)] [RED("dilation")] public CFloat Dilation { get; set; }
		[Ordinal(5)] [RED("duration")] public CFloat Duration { get; set; }

		public SetTimeDilationEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
