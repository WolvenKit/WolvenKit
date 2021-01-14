using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemInSlotCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(0)]  [RED("state")] public wCHandle<ItemInSlotPrereqState> State { get; set; }

		public ItemInSlotCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
