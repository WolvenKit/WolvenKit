using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReleaseSlotEvent : redEvent
	{
		[Ordinal(0)] [RED("slotID")] public CInt32 SlotID { get; set; }

		public ReleaseSlotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
