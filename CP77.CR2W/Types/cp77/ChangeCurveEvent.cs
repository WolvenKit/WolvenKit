using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ChangeCurveEvent : redEvent
	{
		[Ordinal(0)]  [RED("curve")] public CName Curve { get; set; }
		[Ordinal(1)]  [RED("loop")] public CBool Loop { get; set; }
		[Ordinal(2)]  [RED("time")] public CFloat Time { get; set; }

		public ChangeCurveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
