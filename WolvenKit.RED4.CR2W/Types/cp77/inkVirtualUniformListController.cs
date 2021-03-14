using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVirtualUniformListController : inkVirtualCompoundController
	{
		[Ordinal(6)] [RED("itemTemplate")] public inkWidgetLibraryReference ItemTemplate { get; set; }

		public inkVirtualUniformListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
