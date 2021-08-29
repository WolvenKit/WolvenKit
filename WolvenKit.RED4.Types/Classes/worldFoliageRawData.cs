using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldFoliageRawData : ISerializable
	{
		private CArray<CHandle<worldFoliageRawItem>> _items;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<CHandle<worldFoliageRawItem>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
