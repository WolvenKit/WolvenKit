using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questShowCustomTooltip_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("holdIndicationType")] public CEnum<inkInputHintHoldIndicationType> HoldIndicationType { get; set; }
		[Ordinal(1)]  [RED("inputAction")] public CString InputAction { get; set; }
		[Ordinal(2)]  [RED("setTooltip")] public CBool SetTooltip { get; set; }
		[Ordinal(3)]  [RED("text")] public LocalizationString Text { get; set; }

		public questShowCustomTooltip_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
