using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkVirtualUniformListController : inkVirtualCompoundController
	{
		private inkWidgetLibraryReference _itemTemplate;

		[Ordinal(7)] 
		[RED("itemTemplate")] 
		public inkWidgetLibraryReference ItemTemplate
		{
			get => GetProperty(ref _itemTemplate);
			set => SetProperty(ref _itemTemplate, value);
		}
	}
}
