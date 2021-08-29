using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkVirtualListController : inkVirtualCompoundController
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
	}
}
