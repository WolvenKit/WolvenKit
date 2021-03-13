using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowNarrativeEvent_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("eventText")] public CString EventText { get; set; }
		[Ordinal(1)] [RED("textColor")] public CColor TextColor { get; set; }
		[Ordinal(2)] [RED("durationSec")] public CFloat DurationSec { get; set; }

		public questShowNarrativeEvent_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
