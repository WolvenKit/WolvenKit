using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkGridController : inkVirtualCompoundController
	{
		private CUInt32 _height;
		private CUInt32 _width;
		private CArray<inkGridItem> _items;
		private Vector2 _slotSize;
		private CArray<inkGridItemTemplate> _itemTemplates;

		[Ordinal(7)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(8)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(9)] 
		[RED("items")] 
		public CArray<inkGridItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		[Ordinal(10)] 
		[RED("slotSize")] 
		public Vector2 SlotSize
		{
			get => GetProperty(ref _slotSize);
			set => SetProperty(ref _slotSize, value);
		}

		[Ordinal(11)] 
		[RED("itemTemplates")] 
		public CArray<inkGridItemTemplate> ItemTemplates
		{
			get => GetProperty(ref _itemTemplates);
			set => SetProperty(ref _itemTemplates, value);
		}
	}
}
