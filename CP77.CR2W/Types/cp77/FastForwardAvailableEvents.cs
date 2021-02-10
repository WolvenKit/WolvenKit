using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FastForwardAvailableEvents : ScenesFastForwardTransition
	{
		[Ordinal(0)]  [RED("forceCloseFX")] public CBool ForceCloseFX { get; set; }
		[Ordinal(1)]  [RED("delay")] public CFloat Delay { get; set; }

		public FastForwardAvailableEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
