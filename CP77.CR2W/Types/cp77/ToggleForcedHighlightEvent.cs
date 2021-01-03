using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ToggleForcedHighlightEvent : redEvent
	{
		[Ordinal(0)]  [RED("highlightData")] public CHandle<HighlightEditableData> HighlightData { get; set; }
		[Ordinal(1)]  [RED("operation")] public CEnum<EToggleOperationType> Operation { get; set; }
		[Ordinal(2)]  [RED("sourceName")] public CName SourceName { get; set; }

		public ToggleForcedHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
