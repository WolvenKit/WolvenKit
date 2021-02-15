using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestUIEffectEvent : redEvent
	{
		[Ordinal(0)] [RED("glitch")] public CBool Glitch { get; set; }
		[Ordinal(1)] [RED("panamVehicleStartup")] public CBool PanamVehicleStartup { get; set; }

		public VehicleQuestUIEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
