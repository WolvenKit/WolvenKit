using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleWindowOpen : ActionBool
	{
		[Ordinal(0)]  [RED("slotID")] public CName SlotID { get; set; }
		[Ordinal(1)]  [RED("speed")] public CName Speed { get; set; }

		public VehicleWindowOpen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
