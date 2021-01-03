using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotData : CVariable
	{
		[Ordinal(0)]  [RED("activeItemID")] public gameItemID ActiveItemID { get; set; }
		[Ordinal(1)]  [RED("itemObject")] public CHandle<gameItemObject> ItemObject { get; set; }
		[Ordinal(2)]  [RED("prevItemID")] public gameItemID PrevItemID { get; set; }
		[Ordinal(3)]  [RED("slotID")] public TweakDBID SlotID { get; set; }

		public gameAttachmentSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
