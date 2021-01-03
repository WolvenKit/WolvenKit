using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VirtualQuestItemController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("data")] public CHandle<VirutalNestedListData> Data { get; set; }
		[Ordinal(1)]  [RED("questItem")] public inkWidgetReference QuestItem { get; set; }

		public VirtualQuestItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
