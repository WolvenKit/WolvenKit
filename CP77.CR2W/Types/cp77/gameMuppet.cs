using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppet : gamePuppetBase
	{
		[Ordinal(31)]  [RED("hitRepresantation")] public CHandle<entSlotComponent> HitRepresantation { get; set; }
		[Ordinal(32)]  [RED("slotComponent")] public CHandle<entSlotComponent> SlotComponent { get; set; }
		[Ordinal(33)]  [RED("highDamageThreshold")] public CFloat HighDamageThreshold { get; set; }
		[Ordinal(34)]  [RED("medDamageThreshold")] public CFloat MedDamageThreshold { get; set; }
		[Ordinal(35)]  [RED("lowDamageThreshold")] public CFloat LowDamageThreshold { get; set; }
		[Ordinal(36)]  [RED("effectTimeStamp")] public CFloat EffectTimeStamp { get; set; }

		public gameMuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
