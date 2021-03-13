using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIHostileThreatDetected : AIAIEvent
	{
		[Ordinal(2)] [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(3)] [RED("threat")] public wCHandle<entEntity> Threat { get; set; }
		[Ordinal(4)] [RED("status")] public CBool Status { get; set; }

		public AIHostileThreatDetected(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
