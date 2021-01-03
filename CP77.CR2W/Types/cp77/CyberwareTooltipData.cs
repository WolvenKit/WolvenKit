using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CyberwareTooltipData : ATooltipData
	{
		[Ordinal(0)]  [RED("label")] public CString Label { get; set; }
		[Ordinal(1)]  [RED("slotData")] public CArray<CHandle<CyberwareSlotTooltipData>> SlotData { get; set; }

		public CyberwareTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
