using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VirtualQuestItemController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("data")] public CHandle<VirutalNestedListData> Data { get; set; }
		[Ordinal(1)]  [RED("questItem")] public inkWidgetReference QuestItem { get; set; }

		public VirtualQuestItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
