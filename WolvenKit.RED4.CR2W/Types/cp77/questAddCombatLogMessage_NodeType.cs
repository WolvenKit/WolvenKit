using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAddCombatLogMessage_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("message")] public CString Message { get; set; }
		[Ordinal(1)] [RED("localizedMessage")] public LocalizationString LocalizedMessage { get; set; }

		public questAddCombatLogMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
