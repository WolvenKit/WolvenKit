using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemLabelContainerController : inkWidgetLogicController
	{
		private CArray<CWeakHandle<ItemLabelController>> _items;

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<CWeakHandle<ItemLabelController>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
