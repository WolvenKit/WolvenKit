using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnequipRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataEquipmentArea> _areaType;
		private CInt32 _slotIndex;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get
			{
				if (_slotIndex == null)
				{
					_slotIndex = (CInt32) CR2WTypeManager.Create("Int32", "slotIndex", cr2w, this);
				}
				return _slotIndex;
			}
			set
			{
				if (_slotIndex == value)
				{
					return;
				}
				_slotIndex = value;
				PropertySet(this);
			}
		}

		public UnequipRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
