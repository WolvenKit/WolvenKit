using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPoint : BasicDistractionDevice
	{
		[Ordinal(99)] [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(100)] [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }
		[Ordinal(101)] [RED("mappinID")] public gameNewMappinID MappinID { get; set; }
		[Ordinal(102)] [RED("inventory")] public CHandle<gameInventory> Inventory { get; set; }

		public DropPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
