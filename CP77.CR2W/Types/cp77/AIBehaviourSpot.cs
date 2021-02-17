using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIBehaviourSpot : AISmartSpot
	{
		[Ordinal(0)] [RED("behaviour")] public CHandle<AIResourceReference> Behaviour { get; set; }

		public AIBehaviourSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
