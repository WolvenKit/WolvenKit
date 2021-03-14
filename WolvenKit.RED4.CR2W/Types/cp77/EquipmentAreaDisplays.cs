using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentAreaDisplays : IScriptable
	{
		private CArray<CEnum<gamedataEquipmentArea>> _equipmentAreas;
		private wCHandle<inkWidget> _displaysRoot;
		private CArray<CHandle<InventoryItemDisplayController>> _displayControllers;

		[Ordinal(0)] 
		[RED("equipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipmentAreas
		{
			get
			{
				if (_equipmentAreas == null)
				{
					_equipmentAreas = (CArray<CEnum<gamedataEquipmentArea>>) CR2WTypeManager.Create("array:gamedataEquipmentArea", "equipmentAreas", cr2w, this);
				}
				return _equipmentAreas;
			}
			set
			{
				if (_equipmentAreas == value)
				{
					return;
				}
				_equipmentAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("displaysRoot")] 
		public wCHandle<inkWidget> DisplaysRoot
		{
			get
			{
				if (_displaysRoot == null)
				{
					_displaysRoot = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "displaysRoot", cr2w, this);
				}
				return _displaysRoot;
			}
			set
			{
				if (_displaysRoot == value)
				{
					return;
				}
				_displaysRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("displayControllers")] 
		public CArray<CHandle<InventoryItemDisplayController>> DisplayControllers
		{
			get
			{
				if (_displayControllers == null)
				{
					_displayControllers = (CArray<CHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:handle:InventoryItemDisplayController", "displayControllers", cr2w, this);
				}
				return _displayControllers;
			}
			set
			{
				if (_displayControllers == value)
				{
					return;
				}
				_displayControllers = value;
				PropertySet(this);
			}
		}

		public EquipmentAreaDisplays(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
