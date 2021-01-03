using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIBehaviourSpot : AISmartSpot
	{
		[Ordinal(0)]  [RED("behaviour")] public CHandle<AIResourceReference> Behaviour { get; set; }

		public AIBehaviourSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
