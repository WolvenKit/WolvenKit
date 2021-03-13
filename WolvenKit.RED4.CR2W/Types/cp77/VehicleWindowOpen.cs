using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleWindowOpen : ActionBool
	{
		[Ordinal(25)] [RED("slotID")] public CName SlotID { get; set; }
		[Ordinal(26)] [RED("speed")] public CName Speed { get; set; }

		public VehicleWindowOpen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
