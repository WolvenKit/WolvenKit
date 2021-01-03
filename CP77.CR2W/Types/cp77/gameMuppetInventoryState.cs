using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInventoryState : CVariable
	{
		[Ordinal(0)]  [RED("activeSlot")] public CInt32 ActiveSlot { get; set; }
		[Ordinal(1)]  [RED("slots")] public CArray<gameMuppetInventorySlotInfo> Slots { get; set; }

		public gameMuppetInventoryState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
