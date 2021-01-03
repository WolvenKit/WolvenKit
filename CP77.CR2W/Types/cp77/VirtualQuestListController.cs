using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VirtualQuestListController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("questList")] public inkWidgetReference QuestList { get; set; }

		public VirtualQuestListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
