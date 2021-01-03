using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetTimeDilationEffector : gameEffector
	{
		[Ordinal(0)]  [RED("dilation")] public CFloat Dilation { get; set; }
		[Ordinal(1)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(2)]  [RED("easeInCurve")] public CName EaseInCurve { get; set; }
		[Ordinal(3)]  [RED("easeOutCurve")] public CName EaseOutCurve { get; set; }
		[Ordinal(4)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(5)]  [RED("reason")] public CName Reason { get; set; }

		public SetTimeDilationEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
