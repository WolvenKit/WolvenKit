using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageBrush : CResource
	{
		private CArray<CHandle<worldFoliageBrushItem>> _items;

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<CHandle<worldFoliageBrushItem>> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<CHandle<worldFoliageBrushItem>>) CR2WTypeManager.Create("array:handle:worldFoliageBrushItem", "items", cr2w, this);
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

		public worldFoliageBrush(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
