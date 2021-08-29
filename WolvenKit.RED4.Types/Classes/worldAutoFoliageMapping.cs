using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAutoFoliageMapping : CResource
	{
		private CArray<worldAutoFoliageMappingItem> _items;

		[Ordinal(1)] 
		[RED("Items")] 
		public CArray<worldAutoFoliageMappingItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
