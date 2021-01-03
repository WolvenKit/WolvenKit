using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipModAttachmentData : MinimalItemTooltipModData
	{
		[Ordinal(0)]  [RED("abilities")] public CArray<gameInventoryItemAbility> Abilities { get; set; }
		[Ordinal(1)]  [RED("abilitiesSize")] public CInt32 AbilitiesSize { get; set; }
		[Ordinal(2)]  [RED("isEmpty")] public CBool IsEmpty { get; set; }
		[Ordinal(3)]  [RED("qualityName")] public CName QualityName { get; set; }
		[Ordinal(4)]  [RED("slotName")] public CString SlotName { get; set; }

		public MinimalItemTooltipModAttachmentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
