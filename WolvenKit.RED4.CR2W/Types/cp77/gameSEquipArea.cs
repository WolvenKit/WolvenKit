using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSEquipArea : CVariable
	{
		private CEnum<gamedataEquipmentArea> _areaType;
		private CArray<gameSEquipSlot> _equipSlots;
		private CInt32 _activeIndex;

		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get
			{
				if (_areaType == null)
				{
					_areaType = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "areaType", cr2w, this);
				}
				return _areaType;
			}
			set
			{
				if (_areaType == value)
				{
					return;
				}
				_areaType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("equipSlots")] 
		public CArray<gameSEquipSlot> EquipSlots
		{
			get
			{
				if (_equipSlots == null)
				{
					_equipSlots = (CArray<gameSEquipSlot>) CR2WTypeManager.Create("array:gameSEquipSlot", "equipSlots", cr2w, this);
				}
				return _equipSlots;
			}
			set
			{
				if (_equipSlots == value)
				{
					return;
				}
				_equipSlots = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activeIndex")] 
		public CInt32 ActiveIndex
		{
			get
			{
				if (_activeIndex == null)
				{
					_activeIndex = (CInt32) CR2WTypeManager.Create("Int32", "activeIndex", cr2w, this);
				}
				return _activeIndex;
			}
			set
			{
				if (_activeIndex == value)
				{
					return;
				}
				_activeIndex = value;
				PropertySet(this);
			}
		}

		public gameSEquipArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
