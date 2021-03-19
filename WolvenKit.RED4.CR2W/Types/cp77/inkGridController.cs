using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGridController : inkVirtualCompoundController
	{
		private CUInt32 _height;
		private CUInt32 _width;
		private CArray<inkGridItem> _items;
		private Vector2 _slotSize;
		private CArray<inkGridItemTemplate> _itemTemplates;

		[Ordinal(6)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(7)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(8)] 
		[RED("items")] 
		public CArray<inkGridItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		[Ordinal(9)] 
		[RED("slotSize")] 
		public Vector2 SlotSize
		{
			get => GetProperty(ref _slotSize);
			set => SetProperty(ref _slotSize, value);
		}

		[Ordinal(10)] 
		[RED("itemTemplates")] 
		public CArray<inkGridItemTemplate> ItemTemplates
		{
			get => GetProperty(ref _itemTemplates);
			set => SetProperty(ref _itemTemplates, value);
		}

		public inkGridController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
