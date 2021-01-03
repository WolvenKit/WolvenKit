using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MoveToScavengeTarget : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("lastTime")] public CFloat LastTime { get; set; }
		[Ordinal(1)]  [RED("timeout")] public CFloat Timeout { get; set; }
		[Ordinal(2)]  [RED("timeoutDuration")] public CFloat TimeoutDuration { get; set; }

		public MoveToScavengeTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
