using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipModAttachmentData : MinimalItemTooltipModData
	{
		[Ordinal(0)]  [RED("isEmpty")] public CBool IsEmpty { get; set; }
		[Ordinal(1)]  [RED("slotName")] public CString SlotName { get; set; }
		[Ordinal(2)]  [RED("qualityName")] public CName QualityName { get; set; }
		[Ordinal(3)]  [RED("abilitiesSize")] public CInt32 AbilitiesSize { get; set; }
		[Ordinal(4)]  [RED("abilities")] public CArray<gameInventoryItemAbility> Abilities { get; set; }

		public MinimalItemTooltipModAttachmentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
