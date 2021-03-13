using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingMachineFinishedEvent : redEvent
	{
		[Ordinal(0)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)] [RED("isFree")] public CBool IsFree { get; set; }
		[Ordinal(2)] [RED("isReady")] public CBool IsReady { get; set; }

		public VendingMachineFinishedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
