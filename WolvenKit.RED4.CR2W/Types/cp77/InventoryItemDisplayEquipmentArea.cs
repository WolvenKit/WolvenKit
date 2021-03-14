using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemDisplayEquipmentArea : inkWidgetLogicController
	{
		private CArray<CEnum<gamedataEquipmentArea>> _equipmentAreas;
		private CInt32 _numberOfSlots;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("numberOfSlots")] 
		public CInt32 NumberOfSlots
		{
			get
			{
				if (_numberOfSlots == null)
				{
					_numberOfSlots = (CInt32) CR2WTypeManager.Create("Int32", "numberOfSlots", cr2w, this);
				}
				return _numberOfSlots;
			}
			set
			{
				if (_numberOfSlots == value)
				{
					return;
				}
				_numberOfSlots = value;
				PropertySet(this);
			}
		}

		public InventoryItemDisplayEquipmentArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
