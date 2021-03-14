using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSEquipmentSet : CVariable
	{
		private CArray<gameSItemInfo> _setItems;
		private CName _setName;
		private CEnum<gameEquipmentSetType> _setType;

		[Ordinal(0)] 
		[RED("setItems")] 
		public CArray<gameSItemInfo> SetItems
		{
			get
			{
				if (_setItems == null)
				{
					_setItems = (CArray<gameSItemInfo>) CR2WTypeManager.Create("array:gameSItemInfo", "setItems", cr2w, this);
				}
				return _setItems;
			}
			set
			{
				if (_setItems == value)
				{
					return;
				}
				_setItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("setName")] 
		public CName SetName
		{
			get
			{
				if (_setName == null)
				{
					_setName = (CName) CR2WTypeManager.Create("CName", "setName", cr2w, this);
				}
				return _setName;
			}
			set
			{
				if (_setName == value)
				{
					return;
				}
				_setName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("setType")] 
		public CEnum<gameEquipmentSetType> SetType
		{
			get
			{
				if (_setType == null)
				{
					_setType = (CEnum<gameEquipmentSetType>) CR2WTypeManager.Create("gameEquipmentSetType", "setType", cr2w, this);
				}
				return _setType;
			}
			set
			{
				if (_setType == value)
				{
					return;
				}
				_setType = value;
				PropertySet(this);
			}
		}

		public gameSEquipmentSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
