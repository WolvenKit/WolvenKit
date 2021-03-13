using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FootPhase : animAnimEvent
	{
		[Ordinal(3)] [RED("phase")] public CEnum<animEFootPhase> Phase { get; set; }

		public animAnimEvent_FootPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
