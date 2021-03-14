using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSLoadout : CVariable
	{
		private CArray<gameSEquipArea> _equipAreas;
		private CArray<gameSEquipmentSet> _equipmentSets;

		[Ordinal(0)] 
		[RED("equipAreas")] 
		public CArray<gameSEquipArea> EquipAreas
		{
			get
			{
				if (_equipAreas == null)
				{
					_equipAreas = (CArray<gameSEquipArea>) CR2WTypeManager.Create("array:gameSEquipArea", "equipAreas", cr2w, this);
				}
				return _equipAreas;
			}
			set
			{
				if (_equipAreas == value)
				{
					return;
				}
				_equipAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("equipmentSets")] 
		public CArray<gameSEquipmentSet> EquipmentSets
		{
			get
			{
				if (_equipmentSets == null)
				{
					_equipmentSets = (CArray<gameSEquipmentSet>) CR2WTypeManager.Create("array:gameSEquipmentSet", "equipmentSets", cr2w, this);
				}
				return _equipmentSets;
			}
			set
			{
				if (_equipmentSets == value)
				{
					return;
				}
				_equipmentSets = value;
				PropertySet(this);
			}
		}

		public gameSLoadout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
