using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAutoFoliageMapping : CResource
	{
		private CArray<worldAutoFoliageMappingItem> _items;

		[Ordinal(1)] 
		[RED("Items")] 
		public CArray<worldAutoFoliageMappingItem> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<worldAutoFoliageMappingItem>) CR2WTypeManager.Create("array:worldAutoFoliageMappingItem", "Items", cr2w, this);
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

		public worldAutoFoliageMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
