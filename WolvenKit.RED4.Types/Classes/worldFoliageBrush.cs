using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldFoliageBrush : CResource
	{
		private CArray<CHandle<worldFoliageBrushItem>> _items;

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<CHandle<worldFoliageBrushItem>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
