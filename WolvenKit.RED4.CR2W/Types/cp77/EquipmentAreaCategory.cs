using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentAreaCategory : IScriptable
	{
		private CHandle<InventoryItemDisplayCategoryArea> _parentCategory;
		private CArray<CHandle<EquipmentAreaDisplays>> _areaDisplays;

		[Ordinal(0)] 
		[RED("parentCategory")] 
		public CHandle<InventoryItemDisplayCategoryArea> ParentCategory
		{
			get
			{
				if (_parentCategory == null)
				{
					_parentCategory = (CHandle<InventoryItemDisplayCategoryArea>) CR2WTypeManager.Create("handle:InventoryItemDisplayCategoryArea", "parentCategory", cr2w, this);
				}
				return _parentCategory;
			}
			set
			{
				if (_parentCategory == value)
				{
					return;
				}
				_parentCategory = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("areaDisplays")] 
		public CArray<CHandle<EquipmentAreaDisplays>> AreaDisplays
		{
			get
			{
				if (_areaDisplays == null)
				{
					_areaDisplays = (CArray<CHandle<EquipmentAreaDisplays>>) CR2WTypeManager.Create("array:handle:EquipmentAreaDisplays", "areaDisplays", cr2w, this);
				}
				return _areaDisplays;
			}
			set
			{
				if (_areaDisplays == value)
				{
					return;
				}
				_areaDisplays = value;
				PropertySet(this);
			}
		}

		public EquipmentAreaCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
