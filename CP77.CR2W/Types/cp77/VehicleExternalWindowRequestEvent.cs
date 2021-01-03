using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleExternalWindowRequestEvent : redEvent
	{
		[Ordinal(0)]  [RED("shouldOpen")] public CBool ShouldOpen { get; set; }
		[Ordinal(1)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(2)]  [RED("speed")] public CName Speed { get; set; }

		public VehicleExternalWindowRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
