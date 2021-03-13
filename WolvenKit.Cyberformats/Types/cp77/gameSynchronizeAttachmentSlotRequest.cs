using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSynchronizeAttachmentSlotRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("slotID")] public TweakDBID SlotID { get; set; }

		public gameSynchronizeAttachmentSlotRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
