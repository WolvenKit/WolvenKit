using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FastForwardAvailableEvents : ScenesFastForwardTransition
	{
		[Ordinal(0)]  [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(1)]  [RED("forceCloseFX")] public CBool ForceCloseFX { get; set; }

		public FastForwardAvailableEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
