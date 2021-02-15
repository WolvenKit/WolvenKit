using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SlotReservationDecorator : AIVehicleTaskAbstract
	{
		[Ordinal(0)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
		[Ordinal(1)] [RED("mountEventData")] public CHandle<gameMountEventData> MountEventData { get; set; }

		public SlotReservationDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
