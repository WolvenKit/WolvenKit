using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCloseMessage_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] [RED("msg")] public CHandle<gameJournalPath> Msg { get; set; }

		public questCloseMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
