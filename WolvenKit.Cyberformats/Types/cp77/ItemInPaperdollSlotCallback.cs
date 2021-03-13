using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemInPaperdollSlotCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] [RED("paperdollPuppet")] public wCHandle<gamePuppet> PaperdollPuppet { get; set; }

		public ItemInPaperdollSlotCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
