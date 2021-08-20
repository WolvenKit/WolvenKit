using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVirtualListController : inkVirtualCompoundController
	{
		private CArray<inkWidgetLibraryReference> _itemTemplates;
		private CBool _cycleNavigation;

		[Ordinal(7)] 
		[RED("itemTemplates")] 
		public CArray<inkWidgetLibraryReference> ItemTemplates
		{
			get => GetProperty(ref _itemTemplates);
			set => SetProperty(ref _itemTemplates, value);
		}

		[Ordinal(8)] 
		[RED("cycleNavigation")] 
		public CBool CycleNavigation
		{
			get => GetProperty(ref _cycleNavigation);
			set => SetProperty(ref _cycleNavigation, value);
		}

		public inkVirtualListController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
