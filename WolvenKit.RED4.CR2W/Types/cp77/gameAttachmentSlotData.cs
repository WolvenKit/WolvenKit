using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotData : CVariable
	{
		[Ordinal(0)] [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(1)] [RED("itemObject")] public CHandle<gameItemObject> ItemObject { get; set; }
		[Ordinal(2)] [RED("activeItemID")] public gameItemID ActiveItemID { get; set; }
		[Ordinal(3)] [RED("prevItemID")] public gameItemID PrevItemID { get; set; }

		public gameAttachmentSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
