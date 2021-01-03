using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkVirtualListController : inkVirtualCompoundController
	{
		[Ordinal(0)]  [RED("cycleNavigation")] public CBool CycleNavigation { get; set; }
		[Ordinal(1)]  [RED("itemTemplates")] public CArray<inkWidgetLibraryReference> ItemTemplates { get; set; }

		public inkVirtualListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
