using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimBreakpointSimple : animIAnimBreakpoint
	{
		[Ordinal(0)]  [RED("hitCount")] public CUInt32 HitCount { get; set; }

		public animAnimBreakpointSimple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
