using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DelayedCrowdReactionEvent : redEvent
	{
		[Ordinal(0)]  [RED("stimEvent")] public CHandle<senseStimuliEvent> StimEvent { get; set; }
		[Ordinal(1)]  [RED("vehicleFearPhase")] public CInt32 VehicleFearPhase { get; set; }

		public DelayedCrowdReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
