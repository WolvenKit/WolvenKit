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
			get
			{
				if (_height == null)
				{
					_height = (CUInt32) CR2WTypeManager.Create("Uint32", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CUInt32) CR2WTypeManager.Create("Uint32", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("items")] 
		public CArray<inkGridItem> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<inkGridItem>) CR2WTypeManager.Create("array:inkGridItem", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("slotSize")] 
		public Vector2 SlotSize
		{
			get
			{
				if (_slotSize == null)
				{
					_slotSize = (Vector2) CR2WTypeManager.Create("Vector2", "slotSize", cr2w, this);
				}
				return _slotSize;
			}
			set
			{
				if (_slotSize == value)
				{
					return;
				}
				_slotSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("itemTemplates")] 
		public CArray<inkGridItemTemplate> ItemTemplates
		{
			get
			{
				if (_itemTemplates == null)
				{
					_itemTemplates = (CArray<inkGridItemTemplate>) CR2WTypeManager.Create("array:inkGridItemTemplate", "itemTemplates", cr2w, this);
				}
				return _itemTemplates;
			}
			set
			{
				if (_itemTemplates == value)
				{
					return;
				}
				_itemTemplates = value;
				PropertySet(this);
			}
		}

		public inkGridController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
