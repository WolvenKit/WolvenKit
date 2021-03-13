using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemAttachments : CVariable
	{
		[Ordinal(0)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)] [RED("attachmentSlotID")] public TweakDBID AttachmentSlotID { get; set; }

		public ItemAttachments(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
