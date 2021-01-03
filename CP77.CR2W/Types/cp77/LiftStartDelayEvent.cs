using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LiftStartDelayEvent : redEvent
	{
		[Ordinal(0)]  [RED("targetFloor")] public CInt32 TargetFloor { get; set; }

		public LiftStartDelayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
