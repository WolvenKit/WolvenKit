using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotReplicatedState : CVariable
	{
		[Ordinal(0)]  [RED("activeItemID")] public gameItemID ActiveItemID { get; set; }
		[Ordinal(1)]  [RED("hasItemObject")] public CBool HasItemObject { get; set; }
		[Ordinal(2)]  [RED("slotID")] public TweakDBID SlotID { get; set; }

		public gameAttachmentSlotReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
